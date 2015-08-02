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
    public partial class PasswordMaker : Form
    {
        TextBox[] textboxes;
        PasswordGenerater passGen;
        public LogHandler logHandler { get; }

        public PasswordMaker()
        {
            InitializeComponent();
            passGen = new PasswordGenerater();
            logHandler = new LogHandler();
            textboxes = new TextBox[] {
                _textBox01,
                _textBox02,
                _textBox03,
                _textBox04,
                _textBox05,
                _textBox06,
                _textBox07,
                _textBox08,
                _textBox09,
                _textBox10,
            };
            LoadSettings();
        }

        

        private void LoadSettings()
        {
            var CFG = Properties.Settings.Default;
            Location = CFG.windowPos;
            TopMost = CFG.windowTopMost;
            switch (CFG.radioIndex)
            {
                case (1): _radioButton1.Select(); break;
                case (2): _radioButton2.Select(); break;
                case (3): _radioButton3.Select(); break;
                default: throw new IndexOutOfRangeException();
            }
            _numericUpDown1.Value = CFG.passwordLength;
            logHandler.Enable = CFG.logEnable;
            logHandler.FilePath = CFG.logfilePath;

        }



        private void _generateButton_Click(object sender, EventArgs e)
        {
            int length = (int)_numericUpDown1.Value;
            var type = PasswordGenerater.PasswordType.Normal;
            if (_radioButton1.Checked) type = PasswordGenerater.PasswordType.Weak;
            else if (_radioButton2.Checked) type = PasswordGenerater.PasswordType.Normal;
            else if (_radioButton3.Checked) type = PasswordGenerater.PasswordType.Strong;

            foreach (TextBox t in textboxes)
            {
                t.Text = passGen.GeneratePassword(length, type);
            }
        }

        private void _textBox_Click(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.SelectAll();
        }

        private void _colorResetTimer_Tick(object sender, EventArgs e)
        {
            foreach (var t in textboxes)
            {
                colorResetTimer.Stop();
                t.BackColor = SystemColors.Control;
                t.ForeColor = SystemColors.WindowText;
            }
        }

        private void _PasswordMaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            var CFG = Properties.Settings.Default;
            CFG.windowPos = Location;
            CFG.windowTopMost = TopMost;
            CFG.passwordLength = _numericUpDown1.Value;
            if (_radioButton1.Checked) CFG.radioIndex = 1;
            if (_radioButton2.Checked) CFG.radioIndex = 2;
            if (_radioButton3.Checked) CFG.radioIndex = 3;
            CFG.logEnable = logHandler.Enable;
            CFG.logfilePath = logHandler.FilePath;
            CFG.Save();
        }

        private void _settingLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingDialog form = new SettingDialog(this);
            form.Location = new Point(this.Location.X -120, this.Location.Y + 50);
            form.ShowDialog(this);
            form.Dispose();
        }

        private void _textBox_DoubleClick(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb.Text.Length <= 0)
            {
                return;
            }
            Clipboard.SetDataObject(tb.Text, true);
            tb.Select(0, 0);
            tb.BackColor = Color.Red;
            colorResetTimer.Start();
            logHandler.WriteLog(tb.Text);
        }
    }

    class PasswordGenerater
    {
        public enum PasswordType { Weaken, Weak, Normal, Strong };
        Random oRandom;
        const string key1 = "abcdefghijklmnopqrstuvwxyz";
        const string key2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string key3 = "1234567890";
        const string key4 = "$@#!%^*&'*()+?;\"=,]~<>|{}[";
        public PasswordGenerater()
        {
            oRandom = new Random();
        }
        public string GeneratePassword(int length, PasswordType type)
        {
            string keys = "";
            string words = "";
            switch (type)
            {
                case PasswordType.Weaken:
                    keys = key1;
                    break;
                case PasswordType.Weak:
                    keys = key1 + key2;
                    break;
                case PasswordType.Normal:
                    keys = key1 + key2 + key3;
                    break;
                case PasswordType.Strong:
                    keys = key1 + key2 + key3 + key4;
                    break;
                default:
                    throw new NotImplementedException();
            }
            int index;
            for (int i = 0; i < length; i++)
            {
                index = oRandom.Next(keys.Length);
                words += keys[index];
            }
            return words;
        }

    }

    public class LogHandler
    {
        public string FilePath { get; set; } = "";
        public bool Enable { get; set; } = false;
        public void WriteLog(string s)
        {
            if (Enable && FilePath != "")
            {
                string logLine = $"{DateTime.Now}: {s}\r\n";
                System.IO.File.AppendAllText(FilePath, logLine, Encoding.GetEncoding("sjis"));
            }
        }
    }

}
