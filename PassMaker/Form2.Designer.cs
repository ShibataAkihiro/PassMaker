namespace PassMaker
{
    partial class SettingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._topMostCheckBox = new System.Windows.Forms.CheckBox();
            this._label1 = new System.Windows.Forms.Label();
            this._logFileTextBox = new System.Windows.Forms.TextBox();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this._openFileButton = new System.Windows.Forms.Button();
            this._logEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._linkLabel1 = new System.Windows.Forms.LinkLabel();
            this._groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _topMostCheckBox
            // 
            this._topMostCheckBox.AutoSize = true;
            this._topMostCheckBox.Location = new System.Drawing.Point(14, 12);
            this._topMostCheckBox.Name = "_topMostCheckBox";
            this._topMostCheckBox.Size = new System.Drawing.Size(156, 16);
            this._topMostCheckBox.TabIndex = 0;
            this._topMostCheckBox.Text = "ウインドウを常に前面に表示";
            this.toolTip1.SetToolTip(this._topMostCheckBox, "常に前面に表示し、他のウインドウに隠れなくします。");
            this._topMostCheckBox.UseVisualStyleBackColor = true;
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(6, 37);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(86, 12);
            this._label1.TabIndex = 1;
            this._label1.Text = "ログファイルのパス";
            // 
            // _logFileTextBox
            // 
            this._logFileTextBox.Location = new System.Drawing.Point(6, 52);
            this._logFileTextBox.Name = "_logFileTextBox";
            this._logFileTextBox.Size = new System.Drawing.Size(421, 19);
            this._logFileTextBox.TabIndex = 2;
            // 
            // _groupBox1
            // 
            this._groupBox1.Controls.Add(this._linkLabel1);
            this._groupBox1.Controls.Add(this._openFileButton);
            this._groupBox1.Controls.Add(this._logEnableCheckBox);
            this._groupBox1.Controls.Add(this._logFileTextBox);
            this._groupBox1.Controls.Add(this._label1);
            this._groupBox1.Location = new System.Drawing.Point(12, 34);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(460, 85);
            this._groupBox1.TabIndex = 3;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "ログの設定";
            // 
            // _openFileButton
            // 
            this._openFileButton.AutoSize = true;
            this._openFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._openFileButton.Location = new System.Drawing.Point(432, 50);
            this._openFileButton.Name = "_openFileButton";
            this._openFileButton.Size = new System.Drawing.Size(21, 22);
            this._openFileButton.TabIndex = 4;
            this._openFileButton.Text = "...";
            this.toolTip1.SetToolTip(this._openFileButton, "ファイルダイアログを開き、パスを指定します。");
            this._openFileButton.UseVisualStyleBackColor = true;
            this._openFileButton.Click += new System.EventHandler(this._openFileButton_Click);
            // 
            // _logEnableCheckBox
            // 
            this._logEnableCheckBox.AutoSize = true;
            this._logEnableCheckBox.Location = new System.Drawing.Point(6, 18);
            this._logEnableCheckBox.Name = "_logEnableCheckBox";
            this._logEnableCheckBox.Size = new System.Drawing.Size(229, 16);
            this._logEnableCheckBox.TabIndex = 3;
            this._logEnableCheckBox.Text = "コピーしたパスワードをログファイルに書き込む";
            this.toolTip1.SetToolTip(this._logEnableCheckBox, "パスワードをダブルクリックしてクリップボードにコピーした時、そのパスワードをログファイルに書き込みます。");
            this._logEnableCheckBox.UseVisualStyleBackColor = true;
            this._logEnableCheckBox.CheckedChanged += new System.EventHandler(this._logEnableCheckBox_CheckedChanged);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(316, 125);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "キャンセル";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(397, 125);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 5;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _openFileDialog1
            // 
            this._openFileDialog1.CheckFileExists = false;
            this._openFileDialog1.DefaultExt = "txt";
            this._openFileDialog1.FileName = "passwordlog";
            this._openFileDialog1.RestoreDirectory = true;
            this._openFileDialog1.Title = "ログファイルのパス";
            // 
            // _linkLabel1
            // 
            this._linkLabel1.AutoSize = true;
            this._linkLabel1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._linkLabel1.Location = new System.Drawing.Point(353, 38);
            this._linkLabel1.Name = "_linkLabel1";
            this._linkLabel1.Size = new System.Drawing.Size(60, 11);
            this._linkLabel1.TabIndex = 5;
            this._linkLabel1.TabStop = true;
            this._linkLabel1.Text = "ファイルを開く";
            this.toolTip1.SetToolTip(this._linkLabel1, "ファイルをメモ帳で開きます。");
            this._linkLabel1.Click += new System.EventHandler(this._linkLabel1_Click);
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 160);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._groupBox1);
            this.Controls.Add(this._topMostCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "設定ダイアログ";
            this._groupBox1.ResumeLayout(false);
            this._groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _topMostCheckBox;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.TextBox _logFileTextBox;
        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.CheckBox _logEnableCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button _openFileButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.OpenFileDialog _openFileDialog1;
        private System.Windows.Forms.LinkLabel _linkLabel1;
    }
}