namespace Crypton
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
            this.checkBoxUseAdminApi = new System.Windows.Forms.CheckBox();
            this.textBoxAdminApiPassword = new System.Windows.Forms.TextBox();
            this.checkBoxUseUrlForDetachLicense = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeatureId)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownFeatureId
            // 
            this.numericUpDownFeatureId.Location = new System.Drawing.Point(170, 12);
            this.numericUpDownFeatureId.Maximum = new decimal(new int[] {
            65471,
            0,
            0,
            0});
            this.numericUpDownFeatureId.Name = "numericUpDownFeatureId";
            this.numericUpDownFeatureId.Size = new System.Drawing.Size(152, 20);
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
            this.checkBoxSpecifyKeyIdEnable.Location = new System.Drawing.Point(15, 40);
            this.checkBoxSpecifyKeyIdEnable.Name = "checkBoxSpecifyKeyIdEnable";
            this.checkBoxSpecifyKeyIdEnable.Size = new System.Drawing.Size(152, 17);
            this.checkBoxSpecifyKeyIdEnable.TabIndex = 2;
            this.checkBoxSpecifyKeyIdEnable.Text = "Connect to specifi Key ID: ";
            this.checkBoxSpecifyKeyIdEnable.UseVisualStyleBackColor = true;
            this.checkBoxSpecifyKeyIdEnable.CheckedChanged += new System.EventHandler(this.checkBoxSpecifyKeyIdEnable_CheckedChanged);
            // 
            // textBoxSpecifyKeyId
            // 
            this.textBoxSpecifyKeyId.Enabled = false;
            this.textBoxSpecifyKeyId.Location = new System.Drawing.Point(170, 38);
            this.textBoxSpecifyKeyId.Name = "textBoxSpecifyKeyId";
            this.textBoxSpecifyKeyId.Size = new System.Drawing.Size(152, 20);
            this.textBoxSpecifyKeyId.TabIndex = 3;
            this.textBoxSpecifyKeyId.TextChanged += new System.EventHandler(this.textBoxSpecifyKeyId_TextChanged);
            // 
            // checkBoxUseAdminApi
            // 
            this.checkBoxUseAdminApi.AutoSize = true;
            this.checkBoxUseAdminApi.Enabled = false;
            this.checkBoxUseAdminApi.Location = new System.Drawing.Point(15, 86);
            this.checkBoxUseAdminApi.Name = "checkBoxUseAdminApi";
            this.checkBoxUseAdminApi.Size = new System.Drawing.Size(309, 17);
            this.checkBoxUseAdminApi.TabIndex = 4;
            this.checkBoxUseAdminApi.Text = "Use Admin API for cancel Detach, password for Admin API: ";
            this.checkBoxUseAdminApi.UseVisualStyleBackColor = true;
            this.checkBoxUseAdminApi.CheckedChanged += new System.EventHandler(this.checkBoxUseAdminApi_CheckedChanged);
            // 
            // textBoxAdminApiPassword
            // 
            this.textBoxAdminApiPassword.Enabled = false;
            this.textBoxAdminApiPassword.Location = new System.Drawing.Point(12, 109);
            this.textBoxAdminApiPassword.Name = "textBoxAdminApiPassword";
            this.textBoxAdminApiPassword.Size = new System.Drawing.Size(310, 20);
            this.textBoxAdminApiPassword.TabIndex = 5;
            this.textBoxAdminApiPassword.TextChanged += new System.EventHandler(this.textBoxAdminApiPassword_TextChanged);
            // 
            // checkBoxUseUrlForDetachLicense
            // 
            this.checkBoxUseUrlForDetachLicense.AutoSize = true;
            this.checkBoxUseUrlForDetachLicense.Checked = true;
            this.checkBoxUseUrlForDetachLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseUrlForDetachLicense.Location = new System.Drawing.Point(15, 63);
            this.checkBoxUseUrlForDetachLicense.Name = "checkBoxUseUrlForDetachLicense";
            this.checkBoxUseUrlForDetachLicense.Size = new System.Drawing.Size(230, 17);
            this.checkBoxUseUrlForDetachLicense.TabIndex = 6;
            this.checkBoxUseUrlForDetachLicense.Text = "Use Url for cancel Detach (Recommended)";
            this.checkBoxUseUrlForDetachLicense.UseVisualStyleBackColor = true;
            this.checkBoxUseUrlForDetachLicense.CheckedChanged += new System.EventHandler(this.checkBoxUseUrlForDetachLicense_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 136);
            this.Controls.Add(this.checkBoxUseUrlForDetachLicense);
            this.Controls.Add(this.textBoxAdminApiPassword);
            this.Controls.Add(this.checkBoxUseAdminApi);
            this.Controls.Add(this.textBoxSpecifyKeyId);
            this.Controls.Add(this.checkBoxSpecifyKeyIdEnable);
            this.Controls.Add(this.labelFeatureIdForUsing);
            this.Controls.Add(this.numericUpDownFeatureId);
            this.MaximumSize = new System.Drawing.Size(350, 175);
            this.MinimumSize = new System.Drawing.Size(350, 175);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeatureId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownFeatureId;
        private System.Windows.Forms.Label labelFeatureIdForUsing;
        private System.Windows.Forms.CheckBox checkBoxSpecifyKeyIdEnable;
        private System.Windows.Forms.TextBox textBoxSpecifyKeyId;
        private System.Windows.Forms.CheckBox checkBoxUseAdminApi;
        private System.Windows.Forms.TextBox textBoxAdminApiPassword;
        private System.Windows.Forms.CheckBox checkBoxUseUrlForDetachLicense;
    }
}