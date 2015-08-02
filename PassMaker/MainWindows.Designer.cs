namespace SimplePasswordGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._buttonGenerate = new System.Windows.Forms.Button();
            this._textBox01 = new System.Windows.Forms.TextBox();
            this._textBox02 = new System.Windows.Forms.TextBox();
            this._textBox03 = new System.Windows.Forms.TextBox();
            this._textBox04 = new System.Windows.Forms.TextBox();
            this._textBox05 = new System.Windows.Forms.TextBox();
            this._textBox10 = new System.Windows.Forms.TextBox();
            this._textBox09 = new System.Windows.Forms.TextBox();
            this._textBox08 = new System.Windows.Forms.TextBox();
            this._textBox07 = new System.Windows.Forms.TextBox();
            this._textBox06 = new System.Windows.Forms.TextBox();
            this._radioButton1 = new System.Windows.Forms.RadioButton();
            this._radioButton2 = new System.Windows.Forms.RadioButton();
            this._radioButton3 = new System.Windows.Forms.RadioButton();
            this._numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this._label1 = new System.Windows.Forms.Label();
            this.tooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this._linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.colorResetTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonGenerate
            // 
            this._buttonGenerate.Location = new System.Drawing.Point(147, 176);
            this._buttonGenerate.Name = "_buttonGenerate";
            this._buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this._buttonGenerate.TabIndex = 0;
            this._buttonGenerate.Text = "生成";
            this._buttonGenerate.UseVisualStyleBackColor = true;
            this._buttonGenerate.Click += new System.EventHandler(this._generateButton_Click);
            // 
            // _textBox01
            // 
            this._textBox01.Location = new System.Drawing.Point(12, 12);
            this._textBox01.Name = "_textBox01";
            this._textBox01.ReadOnly = true;
            this._textBox01.Size = new System.Drawing.Size(100, 19);
            this._textBox01.TabIndex = 1;
            this.tooltip1.SetToolTip(this._textBox01, "ダブルクリックでクリップボードにコピー");
            this._textBox01.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox02
            // 
            this._textBox02.Location = new System.Drawing.Point(12, 37);
            this._textBox02.Name = "_textBox02";
            this._textBox02.ReadOnly = true;
            this._textBox02.Size = new System.Drawing.Size(100, 19);
            this._textBox02.TabIndex = 2;
            this.tooltip1.SetToolTip(this._textBox02, "ダブルクリックでクリップボードにコピー");
            this._textBox02.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox03
            // 
            this._textBox03.Location = new System.Drawing.Point(12, 62);
            this._textBox03.Name = "_textBox03";
            this._textBox03.ReadOnly = true;
            this._textBox03.Size = new System.Drawing.Size(100, 19);
            this._textBox03.TabIndex = 3;
            this.tooltip1.SetToolTip(this._textBox03, "ダブルクリックでクリップボードにコピー");
            this._textBox03.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox04
            // 
            this._textBox04.Location = new System.Drawing.Point(12, 87);
            this._textBox04.Name = "_textBox04";
            this._textBox04.ReadOnly = true;
            this._textBox04.Size = new System.Drawing.Size(100, 19);
            this._textBox04.TabIndex = 4;
            this.tooltip1.SetToolTip(this._textBox04, "ダブルクリックでクリップボードにコピー");
            this._textBox04.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox05
            // 
            this._textBox05.Location = new System.Drawing.Point(12, 112);
            this._textBox05.Name = "_textBox05";
            this._textBox05.ReadOnly = true;
            this._textBox05.Size = new System.Drawing.Size(100, 19);
            this._textBox05.TabIndex = 5;
            this.tooltip1.SetToolTip(this._textBox05, "ダブルクリックでクリップボードにコピー");
            this._textBox05.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox10
            // 
            this._textBox10.Location = new System.Drawing.Point(122, 112);
            this._textBox10.Name = "_textBox10";
            this._textBox10.ReadOnly = true;
            this._textBox10.Size = new System.Drawing.Size(100, 19);
            this._textBox10.TabIndex = 10;
            this.tooltip1.SetToolTip(this._textBox10, "ダブルクリックでクリップボードにコピー");
            this._textBox10.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox09
            // 
            this._textBox09.Location = new System.Drawing.Point(122, 87);
            this._textBox09.Name = "_textBox09";
            this._textBox09.ReadOnly = true;
            this._textBox09.Size = new System.Drawing.Size(100, 19);
            this._textBox09.TabIndex = 9;
            this.tooltip1.SetToolTip(this._textBox09, "ダブルクリックでクリップボードにコピー");
            this._textBox09.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox08
            // 
            this._textBox08.Location = new System.Drawing.Point(122, 62);
            this._textBox08.Name = "_textBox08";
            this._textBox08.ReadOnly = true;
            this._textBox08.Size = new System.Drawing.Size(100, 19);
            this._textBox08.TabIndex = 8;
            this.tooltip1.SetToolTip(this._textBox08, "ダブルクリックでクリップボードにコピー");
            this._textBox08.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox07
            // 
            this._textBox07.Location = new System.Drawing.Point(122, 37);
            this._textBox07.Name = "_textBox07";
            this._textBox07.ReadOnly = true;
            this._textBox07.Size = new System.Drawing.Size(100, 19);
            this._textBox07.TabIndex = 7;
            this.tooltip1.SetToolTip(this._textBox07, "ダブルクリックでクリップボードにコピー");
            this._textBox07.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _textBox06
            // 
            this._textBox06.Location = new System.Drawing.Point(122, 12);
            this._textBox06.Name = "_textBox06";
            this._textBox06.ReadOnly = true;
            this._textBox06.Size = new System.Drawing.Size(100, 19);
            this._textBox06.TabIndex = 6;
            this.tooltip1.SetToolTip(this._textBox06, "ダブルクリックでクリップボードにコピー");
            this._textBox06.DoubleClick += new System.EventHandler(this._textBox_DoubleClick);
            // 
            // _radioButton1
            // 
            this._radioButton1.AutoSize = true;
            this._radioButton1.Location = new System.Drawing.Point(12, 139);
            this._radioButton1.Name = "_radioButton1";
            this._radioButton1.Size = new System.Drawing.Size(50, 16);
            this._radioButton1.TabIndex = 12;
            this._radioButton1.TabStop = true;
            this._radioButton1.Text = "Weak";
            this.tooltip1.SetToolTip(this._radioButton1, "アルファベットのみのパスワードを生成します。");
            this._radioButton1.UseVisualStyleBackColor = true;
            // 
            // _radioButton2
            // 
            this._radioButton2.AutoSize = true;
            this._radioButton2.Location = new System.Drawing.Point(12, 161);
            this._radioButton2.Name = "_radioButton2";
            this._radioButton2.Size = new System.Drawing.Size(59, 16);
            this._radioButton2.TabIndex = 13;
            this._radioButton2.TabStop = true;
            this._radioButton2.Text = "Normal";
            this.tooltip1.SetToolTip(this._radioButton2, "アルファベット+数字のパスワードを生成します。");
            this._radioButton2.UseVisualStyleBackColor = true;
            // 
            // _radioButton3
            // 
            this._radioButton3.AutoSize = true;
            this._radioButton3.Location = new System.Drawing.Point(12, 183);
            this._radioButton3.Name = "_radioButton3";
            this._radioButton3.Size = new System.Drawing.Size(56, 16);
            this._radioButton3.TabIndex = 14;
            this._radioButton3.TabStop = true;
            this._radioButton3.Text = "Strong";
            this.tooltip1.SetToolTip(this._radioButton3, "アルファベット+数字+記号のパスワードを生成します。");
            this._radioButton3.UseVisualStyleBackColor = true;
            // 
            // _numericUpDown1
            // 
            this._numericUpDown1.Location = new System.Drawing.Point(176, 139);
            this._numericUpDown1.Name = "_numericUpDown1";
            this._numericUpDown1.Size = new System.Drawing.Size(46, 19);
            this._numericUpDown1.TabIndex = 15;
            this.tooltip1.SetToolTip(this._numericUpDown1, "パスワードの文字数を設定します。");
            this._numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(129, 141);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(41, 12);
            this._label1.TabIndex = 16;
            this._label1.Text = "文字数";
            this.tooltip1.SetToolTip(this._label1, "パスワードの文字数を設定します。");
            // 
            // _linkLabel1
            // 
            this._linkLabel1.AutoSize = true;
            this._linkLabel1.Location = new System.Drawing.Point(83, 185);
            this._linkLabel1.Name = "_linkLabel1";
            this._linkLabel1.Size = new System.Drawing.Size(29, 12);
            this._linkLabel1.TabIndex = 17;
            this._linkLabel1.TabStop = true;
            this._linkLabel1.Text = "設定";
            this.tooltip1.SetToolTip(this._linkLabel1, "アプリケーション設定ダイアログを開きます。");
            this._linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._settingLinkLabel_LinkClicked);
            // 
            // colorResetTimer
            // 
            this.colorResetTimer.Interval = 200;
            this.colorResetTimer.Tick += new System.EventHandler(this._colorResetTimer_Tick);
            // 
            // PasswordMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this._linkLabel1);
            this.Controls.Add(this._label1);
            this.Controls.Add(this._numericUpDown1);
            this.Controls.Add(this._radioButton3);
            this.Controls.Add(this._radioButton2);
            this.Controls.Add(this._radioButton1);
            this.Controls.Add(this._textBox10);
            this.Controls.Add(this._textBox09);
            this.Controls.Add(this._textBox08);
            this.Controls.Add(this._textBox07);
            this.Controls.Add(this._textBox06);
            this.Controls.Add(this._textBox05);
            this.Controls.Add(this._textBox04);
            this.Controls.Add(this._textBox03);
            this.Controls.Add(this._textBox02);
            this.Controls.Add(this._textBox01);
            this.Controls.Add(this._buttonGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PasswordMaker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._PasswordMaker_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonGenerate;
        private System.Windows.Forms.TextBox _textBox01;
        private System.Windows.Forms.TextBox _textBox02;
        private System.Windows.Forms.TextBox _textBox03;
        private System.Windows.Forms.TextBox _textBox04;
        private System.Windows.Forms.TextBox _textBox05;
        private System.Windows.Forms.TextBox _textBox10;
        private System.Windows.Forms.TextBox _textBox09;
        private System.Windows.Forms.TextBox _textBox08;
        private System.Windows.Forms.TextBox _textBox07;
        private System.Windows.Forms.TextBox _textBox06;
        private System.Windows.Forms.RadioButton _radioButton1;
        private System.Windows.Forms.RadioButton _radioButton2;
        private System.Windows.Forms.RadioButton _radioButton3;
        private System.Windows.Forms.NumericUpDown _numericUpDown1;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.ToolTip tooltip1;
        private System.Windows.Forms.Timer colorResetTimer;
        private System.Windows.Forms.LinkLabel _linkLabel1;
    }
}

