using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebConfigChecker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WebConfig File(*.config)|*.config";
            openFileDialog.Title = "Select a Web.config File";
            
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    txtFilePath.Text = file;
                }
                catch (IOException)
                {
                }
            }
        }

        private void txtCheck_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFilePath.Text) || String.IsNullOrWhiteSpace(txtRegex.Text) || String.IsNullOrWhiteSpace(txtProjectFolder.Text))
            {
                MessageBox.Show("Required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    List<string> keys = new List<string>();
                    List<string> errorKeys = new List<string>();

                    getKeys(keys, txtProjectFolder.Text);

                    getErrorKeys(keys, errorKeys);

                    txtBoxErrorKeys.Clear();
                    
                    errorKeys.ForEach(k => {
                        txtBoxErrorKeys.AppendText(k);
                        txtBoxErrorKeys.AppendText(Environment.NewLine);
                    });

                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getErrorKeys(List<string> keys, List<string> errorKeys)
        {
            var filePath = txtFilePath.Text;
            var map = new ExeConfigurationFileMap { ExeConfigFilename = filePath };
            var configFile = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

            foreach (var item in keys)
            {
                var key = configFile.AppSettings.Settings[item]?.Value;

                if (key == null)
                {
                    if (!errorKeys.Any(e => e == key))
                    {
                        errorKeys.Add(item);
                    }
                }
            }
        }

        private void getKeys(List<string> keys, string projectFolder)
        {
            Regex r = new Regex(txtRegex.Text, RegexOptions.IgnoreCase);

            foreach (string file in System.IO.Directory.GetFiles(projectFolder, "*.cs", System.IO.SearchOption.AllDirectories))
            {
                string contents = File.ReadAllText(file);

                Match m = r.Match(contents);

                while (m.Success)
                {
                    var keyName = m.Groups[1].Value;

                    if (!keys.Any(k => k == keyName))
                    {
                        keys.Add(keyName);
                    }

                    m = m.NextMatch();
                }
            }
        }
    }
}
