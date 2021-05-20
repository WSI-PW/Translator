using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator_Application.Algorithms;
using Translator_Database.DatabaseFactory;
using Translator_Database.DatabaseFactory;

namespace Translator_Application
{
    public partial class Form1 : Form
    {
        private readonly Color OK_COLOR = Color.DarkGreen;
        private readonly Color WARNING_COLOR = Color.DarkRed;
        private const string NO_DATABASE_TEXT = "No data source selected";

        IDatabase bruteForceDatabase = null;
        IDatabase probabilisticDatabase = null;

        IAlgorithm<IDatabase> bruteForceAlgorithm = new BruteForceAlgorithm<IDatabase>();
        IAlgorithm<IDatabase> probabilisticDynamicAlgorithm = new ProbabilisticDynamicAlgorithm<IDatabase>();
        IAlgorithm<IDatabase> probabilisticRecursiveAlgorithm = new ProbabilisticRecursiveAlgorithm<IDatabase>();

        public Form1()
        {
            InitializeComponent();
            UpdateDatabaseStatusLabel(NO_DATABASE_TEXT, WARNING_COLOR);
        }

        private P LoadDatabase<T, P>(string path)
            where T : IDatabaseFactory<P>, new()
            where P : class, IDatabase
        {

            T factory = new T();
            P database = factory.LoadDatabase(path);
            return database;
        }

        private void bruteForceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bruteForceDatabase = LoadDatabase<BruteforceDatabaseFactory<TranslatorDatabase>, TranslatorDatabase>(openFileDialog.FileName);
                    string labelText = Path.GetFileName(openFileDialog.FileName);
                    UpdateDatabaseStatusLabel(labelText, OK_COLOR);
                }
                catch
                {
                    MessageBox.Show("Loading failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void probabilisticButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    probabilisticDatabase = LoadDatabase<ProbabilisticDatabaseFactory<TranslatorDatabase>, TranslatorDatabase>(openFileDialog.FileName);
                    UpdateDatabaseStatusLabel(openFileDialog.FileName, OK_COLOR);
                }
                catch
                {
                    MessageBox.Show("Loading failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string Translate<T, P>(T algorithm, P database, string text)
            where T: IAlgorithm<P>
            where P: IDatabase
        {
            if (database == null) return string.Empty;
            return algorithm.Solve(database, text);
        }
        private void translateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            bruteForceTextBox.Text = Translate(bruteForceAlgorithm, bruteForceDatabase, input);
            if(recursiveButton.Checked)
                probabilisticTextBox.Text = Translate(probabilisticRecursiveAlgorithm, probabilisticDatabase, input);
            else if(dynamicButton.Checked)
                probabilisticTextBox.Text = Translate(probabilisticDynamicAlgorithm, probabilisticDatabase, input);
        }

        private void UpdateDatabaseStatusLabel(string text, Color color)
        {
            DatabaseStatusLabel.Text = text;
            DatabaseStatusLabel.ForeColor = color;
        }

        private void buttonTranslateFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lines = File.ReadAllLines(openFileDialog.FileName);
                    for(int i = 0;i<lines.Length;i++)
                    {
                        string line = lines[i];
                        string translatedLine;
                        translatedLine = Translate(bruteForceAlgorithm, bruteForceDatabase, line);
                        if (recursiveButton.Checked)
                            translatedLine = Translate(probabilisticRecursiveAlgorithm, probabilisticDatabase, line);
                        else if (dynamicButton.Checked)
                            translatedLine = Translate(probabilisticDynamicAlgorithm, probabilisticDatabase, line);

                        lines[i] += (" => " + translatedLine);
                    }

                    string allTranslatedText = string.Join("\n", lines);
                    bruteForceTextBox.Text = allTranslatedText;
                    if (recursiveButton.Checked)
                        bruteForceTextBox.Text = allTranslatedText;
                    else if (dynamicButton.Checked)
                        probabilisticTextBox.Text = allTranslatedText;

                    var targetFileName = Path.ChangeExtension(openFileDialog.FileName, ".translated");
                    File.WriteAllLines(targetFileName, lines);
                    MessageBox.Show("Success! Save translations in " + targetFileName);
                }
                catch
                {
                    MessageBox.Show("Failed to read file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
