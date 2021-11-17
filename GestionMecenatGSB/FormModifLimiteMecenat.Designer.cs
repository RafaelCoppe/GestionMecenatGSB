
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
            this.pnlProd = new System.Windows.Forms.Panel();
            this.btnAnnulLimiteMecenat = new System.Windows.Forms.Button();
            this.btnModifLimiteMecenat = new System.Windows.Forms.Button();
            this.cbxLimiteMecenat = new System.Windows.Forms.ComboBox();
            this.lblLimiteMecenat = new System.Windows.Forms.Label();
            this.txtSommeMaximumModif = new System.Windows.Forms.MaskedTextBox();
            this.cbxAnneeModif = new System.Windows.Forms.ComboBox();
            this.lblPlafondMecenatModif = new System.Windows.Forms.Label();
            this.lblAnneeModif = new System.Windows.Forms.Label();
            this.pnlProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProd
            // 
            this.pnlProd.Controls.Add(this.txtSommeMaximumModif);
            this.pnlProd.Controls.Add(this.btnAnnulLimiteMecenat);
            this.pnlProd.Controls.Add(this.cbxAnneeModif);
            this.pnlProd.Controls.Add(this.lblAnneeModif);
            this.pnlProd.Controls.Add(this.btnModifLimiteMecenat);
            this.pnlProd.Controls.Add(this.lblPlafondMecenatModif);
            this.pnlProd.Location = new System.Drawing.Point(224, 139);
            this.pnlProd.Name = "pnlProd";
            this.pnlProd.Size = new System.Drawing.Size(446, 258);
            this.pnlProd.TabIndex = 5;
            this.pnlProd.Visible = false;
            // 
            // btnAnnulLimiteMecenat
            // 
            this.btnAnnulLimiteMecenat.Location = new System.Drawing.Point(240, 177);
            this.btnAnnulLimiteMecenat.Name = "btnAnnulLimiteMecenat";
            this.btnAnnulLimiteMecenat.Size = new System.Drawing.Size(156, 23);
            this.btnAnnulLimiteMecenat.TabIndex = 7;
            this.btnAnnulLimiteMecenat.Text = "Annuler la modification";
            this.btnAnnulLimiteMecenat.UseVisualStyleBackColor = true;
            // 
            // btnModifLimiteMecenat
            // 
            this.btnModifLimiteMecenat.Location = new System.Drawing.Point(49, 177);
            this.btnModifLimiteMecenat.Name = "btnModifLimiteMecenat";
            this.btnModifLimiteMecenat.Size = new System.Drawing.Size(155, 23);
            this.btnModifLimiteMecenat.TabIndex = 6;
            this.btnModifLimiteMecenat.Text = "Enregistrer la modification";
            this.btnModifLimiteMecenat.UseVisualStyleBackColor = true;
            // 
            // cbxLimiteMecenat
            // 
            this.cbxLimiteMecenat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLimiteMecenat.FormattingEnabled = true;
            this.cbxLimiteMecenat.Location = new System.Drawing.Point(445, 102);
            this.cbxLimiteMecenat.Name = "cbxLimiteMecenat";
            this.cbxLimiteMecenat.Size = new System.Drawing.Size(121, 21);
            this.cbxLimiteMecenat.TabIndex = 4;
            // 
            // lblLimiteMecenat
            // 
            this.lblLimiteMecenat.AutoSize = true;
            this.lblLimiteMecenat.Location = new System.Drawing.Point(115, 105);
            this.lblLimiteMecenat.Name = "lblLimiteMecenat";
            this.lblLimiteMecenat.Size = new System.Drawing.Size(313, 13);
            this.lblLimiteMecenat.TabIndex = 3;
            this.lblLimiteMecenat.Text = "Veuillez sélectionner la limite de mecenat à modifier pour le pays :";
            // 
            // txtSommeMaximumModif
            // 
            this.txtSommeMaximumModif.Location = new System.Drawing.Point(221, 103);
            this.txtSommeMaximumModif.Mask = "9999.99";
            this.txtSommeMaximumModif.Name = "txtSommeMaximumModif";
            this.txtSommeMaximumModif.Size = new System.Drawing.Size(112, 20);
            this.txtSommeMaximumModif.TabIndex = 22;
            // 
            // cbxAnneeModif
            // 
            this.cbxAnneeModif.FormattingEnabled = true;
            this.cbxAnneeModif.Location = new System.Drawing.Point(221, 47);
            this.cbxAnneeModif.Name = "cbxAnneeModif";
            this.cbxAnneeModif.Size = new System.Drawing.Size(112, 21);
            this.cbxAnneeModif.TabIndex = 21;
            // 
            // lblPlafondMecenatModif
            // 
            this.lblPlafondMecenatModif.AutoSize = true;
            this.lblPlafondMecenatModif.Location = new System.Drawing.Point(69, 106);
            this.lblPlafondMecenatModif.Name = "lblPlafondMecenatModif";
            this.lblPlafondMecenatModif.Size = new System.Drawing.Size(94, 13);
            this.lblPlafondMecenatModif.TabIndex = 19;
            this.lblPlafondMecenatModif.Text = "Somme maximum :";
            // 
            // lblAnneeModif
            // 
            this.lblAnneeModif.AutoSize = true;
            this.lblAnneeModif.Location = new System.Drawing.Point(69, 47);
            this.lblAnneeModif.Name = "lblAnneeModif";
            this.lblAnneeModif.Size = new System.Drawing.Size(109, 13);
            this.lblAnneeModif.TabIndex = 17;
            this.lblAnneeModif.Text = "Sélectionner l\'année :";
            // 
            // FormModifLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlProd);
            this.Controls.Add(this.cbxLimiteMecenat);
            this.Controls.Add(this.lblLimiteMecenat);
            this.Name = "FormModifLimiteMecenat";
            this.Text = "FormModifLimiteMecenat";
            this.pnlProd.ResumeLayout(false);
            this.pnlProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProd;
        private System.Windows.Forms.Button btnAnnulLimiteMecenat;
        private System.Windows.Forms.Button btnModifLimiteMecenat;
        private System.Windows.Forms.ComboBox cbxLimiteMecenat;
        private System.Windows.Forms.Label lblLimiteMecenat;
        private System.Windows.Forms.MaskedTextBox txtSommeMaximumModif;
        private System.Windows.Forms.ComboBox cbxAnneeModif;
        private System.Windows.Forms.Label lblAnneeModif;
        private System.Windows.Forms.Label lblPlafondMecenatModif;
    }
}