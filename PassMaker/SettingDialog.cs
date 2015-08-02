using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePasswordGenerator
{
    public partial class SettingDialog : Form
    {

        MainWindow mainWindow { get; }
        public SettingDialog(MainWindow parent)
        {
            InitializeComponent();
            mainWindow = parent;
            if (mainWindow.TopMost)
            {
                _topMostCheckBox.Checked = true;
            }
            _logEnableCheckBox.Checked = mainWindow.logHandler.Enable;
            _logFileTextBox.Text = mainWindow.logHandler.FilePath;
            if (_logEnableCheckBox.Checked)
            {
                _logFileTextBox.Enabled = true;
                _openFileButton.Enabled = true;
                _appSettingLinkLabel1.Enabled = true;
            }
            else
            {
                _logFileTextBox.Enabled = false;
                _openFileButton.Enabled = false;
                _appSettingLinkLabel1.Enabled = false;
            }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            string filePath = _logFileTextBox.Text;
            if (_logEnableCheckBox.Checked)
            {
                if (!System.IO.File.Exists(filePath))
                {
                    try
                    {
                        var fp = System.IO.File.Create(filePath);
                        fp.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "ログファイルを作成できませんでした", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            mainWindow.TopMost = _topMostCheckBox.Checked;
            mainWindow.logHandler.Enable = _logEnableCheckBox.Checked;
            mainWindow.logHandler.FilePath = _logFileTextBox.Text;
            this.Close();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _openFileButton_Click(object sender, EventArgs e)
        {
            _openFileDialog1.FileName = _logFileTextBox.Text;
            _openFileDialog1.ShowDialog(this);
            _logFileTextBox.Text = _openFileDialog1.FileName;
        }

        private void _logEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_logEnableCheckBox.Checked)
            {
                _logFileTextBox.Enabled = true;
                _openFileButton.Enabled = true;
                _appSettingLinkLabel1.Enabled = true;
            }
            else
            {
                _logFileTextBox.Enabled = false;
                _openFileButton.Enabled = false;
                _appSettingLinkLabel1.Enabled = false;
            }
        }

        private void _linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", _logFileTextBox.Text);
        }
    }
}
