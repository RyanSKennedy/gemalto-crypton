namespace Crypton
{
    partial class FormMain
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
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.numericUpDownDaysForDetach = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfDaysForDetach = new System.Windows.Forms.Label();
            this.buttonDetach = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSourceText = new System.Windows.Forms.TextBox();
            this.labelSourceText = new System.Windows.Forms.Label();
            this.labelIntro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelLicenseStatus = new System.Windows.Forms.LinkLabel();
            this.buttonClearResults = new System.Windows.Forms.Button();
            this.labelKeyInfo = new System.Windows.Forms.Label();
            this.linkLabelKeyInfo = new System.Windows.Forms.LinkLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaysForDetach)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(11, 19);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(420, 22);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLoginLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonClearResults);
            this.panelMain.Controls.Add(this.numericUpDownDaysForDetach);
            this.panelMain.Controls.Add(this.labelNumberOfDaysForDetach);
            this.panelMain.Controls.Add(this.buttonDetach);
            this.panelMain.Controls.Add(this.buttonEncrypt);
            this.panelMain.Controls.Add(this.buttonDecrypt);
            this.panelMain.Controls.Add(this.labelResults);
            this.panelMain.Controls.Add(this.textBoxResult);
            this.panelMain.Controls.Add(this.textBoxSourceText);
            this.panelMain.Controls.Add(this.labelSourceText);
            this.panelMain.Enabled = false;
            this.panelMain.Location = new System.Drawing.Point(11, 68);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(420, 253);
            this.panelMain.TabIndex = 1;
            // 
            // numericUpDownDaysForDetach
            // 
            this.numericUpDownDaysForDetach.Enabled = false;
            this.numericUpDownDaysForDetach.Location = new System.Drawing.Point(254, 221);
            this.numericUpDownDaysForDetach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownDaysForDetach.Name = "numericUpDownDaysForDetach";
            this.numericUpDownDaysForDetach.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownDaysForDetach.TabIndex = 8;
            // 
            // labelNumberOfDaysForDetach
            // 
            this.labelNumberOfDaysForDetach.AutoSize = true;
            this.labelNumberOfDaysForDetach.Enabled = false;
            this.labelNumberOfDaysForDetach.Location = new System.Drawing.Point(117, 224);
            this.labelNumberOfDaysForDetach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfDaysForDetach.Name = "labelNumberOfDaysForDetach";
            this.labelNumberOfDaysForDetach.Size = new System.Drawing.Size(133, 13);
            this.labelNumberOfDaysForDetach.TabIndex = 7;
            this.labelNumberOfDaysForDetach.Text = "Number of days for Cache:";
            // 
            // buttonDetach
            // 
            this.buttonDetach.Enabled = false;
            this.buttonDetach.Location = new System.Drawing.Point(318, 219);
            this.buttonDetach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDetach.Name = "buttonDetach";
            this.buttonDetach.Size = new System.Drawing.Size(100, 22);
            this.buttonDetach.TabIndex = 6;
            this.buttonDetach.Text = "Cache the license";
            this.buttonDetach.UseVisualStyleBackColor = true;
            this.buttonDetach.Click += new System.EventHandler(this.buttonDetach_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(264, 105);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 22);
            this.buttonEncrypt.TabIndex = 5;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(343, 105);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 22);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(0, 120);
            this.labelResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 3;
            this.labelResults.Text = "Results:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(2, 135);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(416, 80);
            this.textBoxResult.TabIndex = 2;
            // 
            // textBoxSourceText
            // 
            this.textBoxSourceText.Location = new System.Drawing.Point(2, 21);
            this.textBoxSourceText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSourceText.Multiline = true;
            this.textBoxSourceText.Name = "textBoxSourceText";
            this.textBoxSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSourceText.Size = new System.Drawing.Size(416, 80);
            this.textBoxSourceText.TabIndex = 1;
            this.textBoxSourceText.Tag = "";
            this.textBoxSourceText.TextChanged += new System.EventHandler(this.textBoxSourceText_TextChanged);
            // 
            // labelSourceText
            // 
            this.labelSourceText.AutoSize = true;
            this.labelSourceText.Location = new System.Drawing.Point(0, 6);
            this.labelSourceText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSourceText.Name = "labelSourceText";
            this.labelSourceText.Size = new System.Drawing.Size(64, 13);
            this.labelSourceText.TabIndex = 0;
            this.labelSourceText.Text = "Source text:";
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntro.Location = new System.Drawing.Point(165, 4);
            this.labelIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(105, 13);
            this.labelIntro.TabIndex = 2;
            this.labelIntro.Text = "Please login first!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current license:";
            // 
            // linkLabelLicenseStatus
            // 
            this.linkLabelLicenseStatus.AutoSize = true;
            this.linkLabelLicenseStatus.Location = new System.Drawing.Point(96, 43);
            this.linkLabelLicenseStatus.Name = "linkLabelLicenseStatus";
            this.linkLabelLicenseStatus.Size = new System.Drawing.Size(16, 13);
            this.linkLabelLicenseStatus.TabIndex = 8;
            this.linkLabelLicenseStatus.TabStop = true;
            this.linkLabelLicenseStatus.Text = "...";
            this.linkLabelLicenseStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicenseStatus_LinkClicked);
            // 
            // buttonClearResults
            // 
            this.buttonClearResults.Location = new System.Drawing.Point(2, 220);
            this.buttonClearResults.Name = "buttonClearResults";
            this.buttonClearResults.Size = new System.Drawing.Size(80, 22);
            this.buttonClearResults.TabIndex = 9;
            this.buttonClearResults.Text = "Clear Results";
            this.buttonClearResults.UseVisualStyleBackColor = true;
            this.buttonClearResults.Click += new System.EventHandler(this.buttonClearResults_Click);
            // 
            // labelKeyInfo
            // 
            this.labelKeyInfo.AutoSize = true;
            this.labelKeyInfo.Location = new System.Drawing.Point(262, 43);
            this.labelKeyInfo.Name = "labelKeyInfo";
            this.labelKeyInfo.Size = new System.Drawing.Size(51, 13);
            this.labelKeyInfo.TabIndex = 9;
            this.labelKeyInfo.Text = "Key info: ";
            // 
            // linkLabelKeyInfo
            // 
            this.linkLabelKeyInfo.AutoSize = true;
            this.linkLabelKeyInfo.Location = new System.Drawing.Point(319, 43);
            this.linkLabelKeyInfo.Name = "linkLabelKeyInfo";
            this.linkLabelKeyInfo.Size = new System.Drawing.Size(16, 13);
            this.linkLabelKeyInfo.TabIndex = 10;
            this.linkLabelKeyInfo.TabStop = true;
            this.linkLabelKeyInfo.Text = "...";
            this.linkLabelKeyInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKeyInfo_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 321);
            this.Controls.Add(this.linkLabelKeyInfo);
            this.Controls.Add(this.labelKeyInfo);
            this.Controls.Add(this.linkLabelLicenseStatus);
            this.Controls.Add(this.labelIntro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonLoginLogout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(458, 360);
            this.MinimumSize = new System.Drawing.Size(458, 360);
            this.Name = "FormMain";
            this.Text = "Crypton";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaysForDetach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.NumericUpDown numericUpDownDaysForDetach;
        private System.Windows.Forms.Label labelNumberOfDaysForDetach;
        private System.Windows.Forms.Button buttonDetach;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSourceText;
        private System.Windows.Forms.Label labelSourceText;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLicenseStatus;
        private System.Windows.Forms.Button buttonClearResults;
        private System.Windows.Forms.Label labelKeyInfo;
        private System.Windows.Forms.LinkLabel linkLabelKeyInfo;
    }
}

