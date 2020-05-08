namespace Cloud_Thales_CAD_CAM
{
    partial class FormSettings
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
            this.numericUpDownFeatureId = new System.Windows.Forms.NumericUpDown();
            this.labelFeatureIdForUsing = new System.Windows.Forms.Label();
            this.checkBoxSpecifyKeyIdEnable = new System.Windows.Forms.CheckBox();
            this.textBoxSpecifyKeyId = new System.Windows.Forms.TextBox();
            this.comboBoxMethodsForDetach = new System.Windows.Forms.ComboBox();
            this.labelSelectMethodForDetach = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxSelectLanguage = new System.Windows.Forms.ComboBox();
            this.labelSelectBatchCode = new System.Windows.Forms.Label();
            this.comboBoxBatchCode = new System.Windows.Forms.ComboBox();
            this.textBoxAddNewBatchCode = new System.Windows.Forms.TextBox();
            this.buttonDeleteBatchCode = new System.Windows.Forms.Button();
            this.labelAddNewBatchCode = new System.Windows.Forms.Label();
            this.buttonAddNewBatchCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeatureId)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownFeatureId
            // 
            this.numericUpDownFeatureId.Location = new System.Drawing.Point(222, 12);
            this.numericUpDownFeatureId.Maximum = new decimal(new int[] {
            65471,
            0,
            0,
            0});
            this.numericUpDownFeatureId.Name = "numericUpDownFeatureId";
            this.numericUpDownFeatureId.Size = new System.Drawing.Size(160, 20);
            this.numericUpDownFeatureId.TabIndex = 0;
            this.numericUpDownFeatureId.ValueChanged += new System.EventHandler(this.numericUpDownFeatureId_ValueChanged);
            // 
            // labelFeatureIdForUsing
            // 
            this.labelFeatureIdForUsing.AutoSize = true;
            this.labelFeatureIdForUsing.Location = new System.Drawing.Point(12, 14);
            this.labelFeatureIdForUsing.Name = "labelFeatureIdForUsing";
            this.labelFeatureIdForUsing.Size = new System.Drawing.Size(152, 13);
            this.labelFeatureIdForUsing.TabIndex = 1;
            this.labelFeatureIdForUsing.Text = "Chouse Feature ID for Sample:";
            // 
            // checkBoxSpecifyKeyIdEnable
            // 
            this.checkBoxSpecifyKeyIdEnable.AutoSize = true;
            this.checkBoxSpecifyKeyIdEnable.Location = new System.Drawing.Point(15, 147);
            this.checkBoxSpecifyKeyIdEnable.Name = "checkBoxSpecifyKeyIdEnable";
            this.checkBoxSpecifyKeyIdEnable.Size = new System.Drawing.Size(152, 17);
            this.checkBoxSpecifyKeyIdEnable.TabIndex = 2;
            this.checkBoxSpecifyKeyIdEnable.Text = "Connect to specify Key ID:";
            this.checkBoxSpecifyKeyIdEnable.UseVisualStyleBackColor = true;
            this.checkBoxSpecifyKeyIdEnable.CheckedChanged += new System.EventHandler(this.checkBoxSpecifyKeyIdEnable_CheckedChanged);
            // 
            // textBoxSpecifyKeyId
            // 
            this.textBoxSpecifyKeyId.Enabled = false;
            this.textBoxSpecifyKeyId.Location = new System.Drawing.Point(222, 145);
            this.textBoxSpecifyKeyId.Name = "textBoxSpecifyKeyId";
            this.textBoxSpecifyKeyId.Size = new System.Drawing.Size(160, 20);
            this.textBoxSpecifyKeyId.TabIndex = 3;
            this.textBoxSpecifyKeyId.TextChanged += new System.EventHandler(this.textBoxSpecifyKeyId_TextChanged);
            // 
            // comboBoxMethodsForDetach
            // 
            this.comboBoxMethodsForDetach.FormattingEnabled = true;
            this.comboBoxMethodsForDetach.Items.AddRange(new object[] {
            "ACC Url (Recommended)",
            "Licesing API "});
            this.comboBoxMethodsForDetach.Location = new System.Drawing.Point(222, 171);
            this.comboBoxMethodsForDetach.Name = "comboBoxMethodsForDetach";
            this.comboBoxMethodsForDetach.Size = new System.Drawing.Size(160, 21);
            this.comboBoxMethodsForDetach.TabIndex = 7;
            this.comboBoxMethodsForDetach.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethodsForDetach_SelectedIndexChanged);
            // 
            // labelSelectMethodForDetach
            // 
            this.labelSelectMethodForDetach.AutoSize = true;
            this.labelSelectMethodForDetach.Location = new System.Drawing.Point(12, 174);
            this.labelSelectMethodForDetach.Name = "labelSelectMethodForDetach";
            this.labelSelectMethodForDetach.Size = new System.Drawing.Size(166, 13);
            this.labelSelectMethodForDetach.TabIndex = 8;
            this.labelSelectMethodForDetach.Text = "Select method for cancel Detach:";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(12, 201);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(116, 13);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Select language for UI:";
            // 
            // comboBoxSelectLanguage
            // 
            this.comboBoxSelectLanguage.FormattingEnabled = true;
            this.comboBoxSelectLanguage.Location = new System.Drawing.Point(222, 198);
            this.comboBoxSelectLanguage.Name = "comboBoxSelectLanguage";
            this.comboBoxSelectLanguage.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSelectLanguage.TabIndex = 9;
            this.comboBoxSelectLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectLanguage_SelectedIndexChanged);
            // 
            // labelSelectBatchCode
            // 
            this.labelSelectBatchCode.AutoSize = true;
            this.labelSelectBatchCode.Location = new System.Drawing.Point(12, 43);
            this.labelSelectBatchCode.Name = "labelSelectBatchCode";
            this.labelSelectBatchCode.Size = new System.Drawing.Size(98, 13);
            this.labelSelectBatchCode.TabIndex = 12;
            this.labelSelectBatchCode.Text = "Select Batch code:";
            // 
            // comboBoxBatchCode
            // 
            this.comboBoxBatchCode.FormattingEnabled = true;
            this.comboBoxBatchCode.Location = new System.Drawing.Point(222, 39);
            this.comboBoxBatchCode.Name = "comboBoxBatchCode";
            this.comboBoxBatchCode.Size = new System.Drawing.Size(79, 21);
            this.comboBoxBatchCode.TabIndex = 11;
            this.comboBoxBatchCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxBatchCode_SelectedIndexChanged);
            // 
            // textBoxAddNewBatchCode
            // 
            this.textBoxAddNewBatchCode.Location = new System.Drawing.Point(15, 84);
            this.textBoxAddNewBatchCode.Multiline = true;
            this.textBoxAddNewBatchCode.Name = "textBoxAddNewBatchCode";
            this.textBoxAddNewBatchCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddNewBatchCode.Size = new System.Drawing.Size(330, 55);
            this.textBoxAddNewBatchCode.TabIndex = 13;
            this.textBoxAddNewBatchCode.TextChanged += new System.EventHandler(this.textBoxAddNewBatchCode_TextChanged);
            // 
            // buttonDeleteBatchCode
            // 
            this.buttonDeleteBatchCode.Enabled = false;
            this.buttonDeleteBatchCode.Location = new System.Drawing.Point(307, 38);
            this.buttonDeleteBatchCode.Name = "buttonDeleteBatchCode";
            this.buttonDeleteBatchCode.Size = new System.Drawing.Size(75, 22);
            this.buttonDeleteBatchCode.TabIndex = 14;
            this.buttonDeleteBatchCode.Text = "Delete";
            this.buttonDeleteBatchCode.UseVisualStyleBackColor = true;
            this.buttonDeleteBatchCode.Click += new System.EventHandler(this.buttonDeleteBatchCode_Click);
            // 
            // labelAddNewBatchCode
            // 
            this.labelAddNewBatchCode.AutoSize = true;
            this.labelAddNewBatchCode.Location = new System.Drawing.Point(12, 68);
            this.labelAddNewBatchCode.Name = "labelAddNewBatchCode";
            this.labelAddNewBatchCode.Size = new System.Drawing.Size(110, 13);
            this.labelAddNewBatchCode.TabIndex = 15;
            this.labelAddNewBatchCode.Text = "Add new Batch code:";
            // 
            // buttonAddNewBatchCode
            // 
            this.buttonAddNewBatchCode.Enabled = false;
            this.buttonAddNewBatchCode.Location = new System.Drawing.Point(351, 84);
            this.buttonAddNewBatchCode.Name = "buttonAddNewBatchCode";
            this.buttonAddNewBatchCode.Size = new System.Drawing.Size(31, 55);
            this.buttonAddNewBatchCode.TabIndex = 16;
            this.buttonAddNewBatchCode.Text = "+";
            this.buttonAddNewBatchCode.UseVisualStyleBackColor = true;
            this.buttonAddNewBatchCode.Click += new System.EventHandler(this.buttonAddNewBatchCode_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.buttonAddNewBatchCode);
            this.Controls.Add(this.labelAddNewBatchCode);
            this.Controls.Add(this.buttonDeleteBatchCode);
            this.Controls.Add(this.textBoxAddNewBatchCode);
            this.Controls.Add(this.labelSelectBatchCode);
            this.Controls.Add(this.comboBoxBatchCode);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxSelectLanguage);
            this.Controls.Add(this.labelSelectMethodForDetach);
            this.Controls.Add(this.comboBoxMethodsForDetach);
            this.Controls.Add(this.textBoxSpecifyKeyId);
            this.Controls.Add(this.checkBoxSpecifyKeyIdEnable);
            this.Controls.Add(this.labelFeatureIdForUsing);
            this.Controls.Add(this.numericUpDownFeatureId);
            this.MaximumSize = new System.Drawing.Size(410, 270);
            this.MinimumSize = new System.Drawing.Size(410, 270);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeatureId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxSpecifyKeyIdEnable;
        private System.Windows.Forms.TextBox textBoxSpecifyKeyId;
        private System.Windows.Forms.ComboBox comboBoxMethodsForDetach;
        private System.Windows.Forms.Label labelSelectMethodForDetach;
        public System.Windows.Forms.Label labelLanguage;
        public System.Windows.Forms.ComboBox comboBoxSelectLanguage;
        public System.Windows.Forms.Label labelSelectBatchCode;
        public System.Windows.Forms.ComboBox comboBoxBatchCode;
        public System.Windows.Forms.TextBox textBoxAddNewBatchCode;
        public System.Windows.Forms.Button buttonDeleteBatchCode;
        public System.Windows.Forms.Label labelAddNewBatchCode;
        public System.Windows.Forms.Button buttonAddNewBatchCode;
        public System.Windows.Forms.NumericUpDown numericUpDownFeatureId;
        public System.Windows.Forms.Label labelFeatureIdForUsing;
    }
}