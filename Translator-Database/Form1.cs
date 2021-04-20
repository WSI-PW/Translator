using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator_Database.DatabaseFactory;
using Translator_Database.DatabaseFactory;

namespace Translator_Database
{
    public partial class Form1 : Form
    {
        List<string> filePaths = new List<string>();
        public Form1()
        {
            InitializeComponent();

            FactoryComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths.Add(openFileDialog.FileName);
                DataGrid.Rows.Add(openFileDialog.FileName);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = folderBrowserDialog.SelectedPath;
                if(FactoryComboBox.SelectedIndex == 0)
                {
                    FactoryRunner<BruteforceDatabaseFactory<TranslatorDatabase>, TranslatorDatabase>.Run(filePaths, savePath);
                }
                else
                {
                    FactoryRunner<ProbabilisticDatabaseFactory<TranslatorDatabase>, TranslatorDatabase>.Run(filePaths, savePath);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            filePaths.Clear();
            DataGrid.Rows.Clear();
        }
    }
}
