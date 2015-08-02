using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMaker
{
    public partial class SettingDialog : Form
    {

        PasswordMaker rootWindow { get; }
        public SettingDialog(PasswordMaker parent)
        {
            InitializeComponent();
            rootWindow = parent;
            if (rootWindow.TopMost)
            {
                _topMostCheckBox.Checked = true;
            }
            _logEnableCheckBox.Checked = rootWindow.logHandler.Enable;
            _logFileTextBox.Text = rootWindow.logHandler.FilePath;
            _logFileTextBox.Enabled = _logEnableCheckBox.Checked;
            _openFileButton.Enabled = _logEnableCheckBox.Checked;
            _linkLabel1.Enabled = _logEnableCheckBox.Checked;

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
            rootWindow.TopMost = _topMostCheckBox.Checked;
            rootWindow.logHandler.Enable = _logEnableCheckBox.Checked;
            rootWindow.logHandler.FilePath = _logFileTextBox.Text;
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
            _logFileTextBox.Enabled = _logEnableCheckBox.Checked;
            _openFileButton.Enabled = _logEnableCheckBox.Checked;
            _linkLabel1.Enabled = _logEnableCheckBox.Checked;
        }

        private void _linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", _logFileTextBox.Text);
        }
    }
}
