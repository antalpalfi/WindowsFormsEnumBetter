namespace WindowsFormsEnumHelyes
{
    partial class Form1
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
            this.cmbNaam = new System.Windows.Forms.ComboBox();
            this.labelNaamInfo = new System.Windows.Forms.Label();
            this.lblNettoBrutto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbNaam
            // 
            this.cmbNaam.FormattingEnabled = true;
            this.cmbNaam.Location = new System.Drawing.Point(12, 12);
            this.cmbNaam.Name = "cmbNaam";
            this.cmbNaam.Size = new System.Drawing.Size(121, 21);
            this.cmbNaam.TabIndex = 0;
            this.cmbNaam.SelectedIndexChanged += new System.EventHandler(this.cmbNaam_SelectedIndexChanged);
            // 
            // labelNaamInfo
            // 
            this.labelNaamInfo.AutoSize = true;
            this.labelNaamInfo.Location = new System.Drawing.Point(149, 12);
            this.labelNaamInfo.Name = "labelNaamInfo";
            this.labelNaamInfo.Size = new System.Drawing.Size(0, 13);
            this.labelNaamInfo.TabIndex = 1;
            // 
            // lblNettoBrutto
            // 
            this.lblNettoBrutto.AutoSize = true;
            this.lblNettoBrutto.Location = new System.Drawing.Point(149, 43);
            this.lblNettoBrutto.Name = "lblNettoBrutto";
            this.lblNettoBrutto.Size = new System.Drawing.Size(0, 13);
            this.lblNettoBrutto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 231);
            this.Controls.Add(this.lblNettoBrutto);
            this.Controls.Add(this.labelNaamInfo);
            this.Controls.Add(this.cmbNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNaam;
        private System.Windows.Forms.Label labelNaamInfo;
        private System.Windows.Forms.Label lblNettoBrutto;
    }
}

