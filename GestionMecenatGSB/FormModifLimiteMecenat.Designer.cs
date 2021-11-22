
namespace GestionMecenatGSB
{
    partial class FormModifLimiteMecenat
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
            this.txtSommeMaximumModif = new System.Windows.Forms.MaskedTextBox();
            this.cbxAnneeModif = new System.Windows.Forms.ComboBox();
            this.lblAnneeModif = new System.Windows.Forms.Label();
            this.btnModifLimiteMecenat = new System.Windows.Forms.Button();
            this.lblPlafondMecenatModif = new System.Windows.Forms.Label();
            this.lblLimiteMecenat = new System.Windows.Forms.Label();
            this.dtgInfosLimiteMecenat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosLimiteMecenat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSommeMaximumModif
            // 
            this.txtSommeMaximumModif.Location = new System.Drawing.Point(398, 350);
            this.txtSommeMaximumModif.Mask = "9999.99";
            this.txtSommeMaximumModif.Name = "txtSommeMaximumModif";
            this.txtSommeMaximumModif.Size = new System.Drawing.Size(112, 20);
            this.txtSommeMaximumModif.TabIndex = 22;
            // 
            // cbxAnneeModif
            // 
            this.cbxAnneeModif.FormattingEnabled = true;
            this.cbxAnneeModif.Location = new System.Drawing.Point(398, 310);
            this.cbxAnneeModif.Name = "cbxAnneeModif";
            this.cbxAnneeModif.Size = new System.Drawing.Size(112, 21);
            this.cbxAnneeModif.TabIndex = 21;
            // 
            // lblAnneeModif
            // 
            this.lblAnneeModif.AutoSize = true;
            this.lblAnneeModif.Location = new System.Drawing.Point(253, 313);
            this.lblAnneeModif.Name = "lblAnneeModif";
            this.lblAnneeModif.Size = new System.Drawing.Size(109, 13);
            this.lblAnneeModif.TabIndex = 17;
            this.lblAnneeModif.Text = "Sélectionner l\'année :";
            // 
            // btnModifLimiteMecenat
            // 
            this.btnModifLimiteMecenat.Location = new System.Drawing.Point(338, 403);
            this.btnModifLimiteMecenat.Name = "btnModifLimiteMecenat";
            this.btnModifLimiteMecenat.Size = new System.Drawing.Size(155, 23);
            this.btnModifLimiteMecenat.TabIndex = 6;
            this.btnModifLimiteMecenat.Text = "Enregistrer la modification";
            this.btnModifLimiteMecenat.UseVisualStyleBackColor = true;
            // 
            // lblPlafondMecenatModif
            // 
            this.lblPlafondMecenatModif.AutoSize = true;
            this.lblPlafondMecenatModif.Location = new System.Drawing.Point(268, 357);
            this.lblPlafondMecenatModif.Name = "lblPlafondMecenatModif";
            this.lblPlafondMecenatModif.Size = new System.Drawing.Size(94, 13);
            this.lblPlafondMecenatModif.TabIndex = 19;
            this.lblPlafondMecenatModif.Text = "Somme maximum :";
            // 
            // lblLimiteMecenat
            // 
            this.lblLimiteMecenat.AutoSize = true;
            this.lblLimiteMecenat.Location = new System.Drawing.Point(23, 30);
            this.lblLimiteMecenat.Name = "lblLimiteMecenat";
            this.lblLimiteMecenat.Size = new System.Drawing.Size(253, 13);
            this.lblLimiteMecenat.TabIndex = 3;
            this.lblLimiteMecenat.Text = "Veuillez sélectionner la limite de mecenat à modifier :";
            // 
            // dtgInfosLimiteMecenat
            // 
            this.dtgInfosLimiteMecenat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfosLimiteMecenat.Location = new System.Drawing.Point(12, 63);
            this.dtgInfosLimiteMecenat.Name = "dtgInfosLimiteMecenat";
            this.dtgInfosLimiteMecenat.Size = new System.Drawing.Size(767, 205);
            this.dtgInfosLimiteMecenat.TabIndex = 15;
            // 
            // FormModifLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSommeMaximumModif);
            this.Controls.Add(this.dtgInfosLimiteMecenat);
            this.Controls.Add(this.btnModifLimiteMecenat);
            this.Controls.Add(this.lblPlafondMecenatModif);
            this.Controls.Add(this.cbxAnneeModif);
            this.Controls.Add(this.lblLimiteMecenat);
            this.Controls.Add(this.lblAnneeModif);
            this.Name = "FormModifLimiteMecenat";
            this.Text = "FormModifLimiteMecenat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfosLimiteMecenat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModifLimiteMecenat;
        private System.Windows.Forms.Label lblLimiteMecenat;
        private System.Windows.Forms.MaskedTextBox txtSommeMaximumModif;
        private System.Windows.Forms.ComboBox cbxAnneeModif;
        private System.Windows.Forms.Label lblAnneeModif;
        private System.Windows.Forms.Label lblPlafondMecenatModif;
        private System.Windows.Forms.DataGridView dtgInfosLimiteMecenat;
    }
}