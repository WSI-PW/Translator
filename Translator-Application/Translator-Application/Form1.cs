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
                    var linesBF = File.ReadAllLines(openFileDialog.FileName);
                    var linesPD = (string[])linesBF.Clone();
                    var linesPR = (string[])linesBF.Clone();

                    for (int i = 0;i<linesBF.Length;i++)
                    {
                        string line = linesBF[i];
                        string translatedLineBF, translatedLinePD, translatedLinePR;
                        translatedLineBF = Translate(bruteForceAlgorithm, bruteForceDatabase, line);
                        translatedLinePR = Translate(probabilisticRecursiveAlgorithm, probabilisticDatabase, line);
                        translatedLinePD = Translate(probabilisticDynamicAlgorithm, probabilisticDatabase, line);

                        linesBF[i] += (" => " + translatedLineBF);
                        linesPD[i] += (" => " + translatedLinePD);
                        linesPR[i] += (" => " + translatedLinePR);
                    }

                    string allTranslatedTextBF = string.Join("\n", linesBF);
                    string allTranslatedTextPR = string.Join("\n", linesPR);
                    string allTranslatedTextPD = string.Join("\n", linesPD);
                    bruteForceTextBox.Text = allTranslatedTextBF;
                    if (recursiveButton.Checked)
                        bruteForceTextBox.Text = allTranslatedTextPR;
                    else if (dynamicButton.Checked)
                        probabilisticTextBox.Text = allTranslatedTextPD;

                    var targetFileNameBF = Path.ChangeExtension(openFileDialog.FileName, ".BF.translated");
                    var targetFileNamePR = Path.ChangeExtension(openFileDialog.FileName, ".PR.translated");
                    var targetFileNamePD = Path.ChangeExtension(openFileDialog.FileName, ".PD.translated");
                    File.WriteAllLines(targetFileNameBF, linesBF);
                    File.WriteAllLines(targetFileNamePD, linesPD);
                    File.WriteAllLines(targetFileNamePR, linesPR);
                    MessageBox.Show("Success! Save translations in " + openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Failed to read file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
