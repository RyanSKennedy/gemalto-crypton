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
            this.numericUpDownFeatureId.Size = new System.Drawing.Size(103, 20);
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
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 41);
            this.Controls.Add(this.labelFeatureIdForUsing);
            this.Controls.Add(this.numericUpDownFeatureId);
            this.MaximumSize = new System.Drawing.Size(300, 80);
            this.MinimumSize = new System.Drawing.Size(300, 80);
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
    }
}