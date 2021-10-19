
namespace GestionMecenatGSB
{
    partial class FormAjoutPartenariat
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
            this.txtBudgetPrevu = new System.Windows.Forms.MaskedTextBox();
            this.txtCoutPartenariat = new System.Windows.Forms.MaskedTextBox();
            this.lblBudgetPrevu = new System.Windows.Forms.Label();
            this.lblCoutPartenariat = new System.Windows.Forms.Label();
            this.cbxActionMenee = new System.Windows.Forms.ComboBox();
            this.cbxAssoLiee = new System.Windows.Forms.ComboBox();
            this.lblActionMenee = new System.Windows.Forms.Label();
            this.lblAssoLiee = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBudgetPrevu
            // 
            this.txtBudgetPrevu.Location = new System.Drawing.Point(13, 33);
            this.txtBudgetPrevu.Mask = "9999.99";
            this.txtBudgetPrevu.Name = "txtBudgetPrevu";
            this.txtBudgetPrevu.Size = new System.Drawing.Size(100, 20);
            this.txtBudgetPrevu.TabIndex = 0;
            // 
            // txtCoutPartenariat
            // 
            this.txtCoutPartenariat.Location = new System.Drawing.Point(13, 121);
            this.txtCoutPartenariat.Mask = "9999.99";
            this.txtCoutPartenariat.Name = "txtCoutPartenariat";
            this.txtCoutPartenariat.Size = new System.Drawing.Size(100, 20);
            this.txtCoutPartenariat.TabIndex = 1;
            // 
            // lblBudgetPrevu
            // 
            this.lblBudgetPrevu.AutoSize = true;
            this.lblBudgetPrevu.Location = new System.Drawing.Point(13, 14);
            this.lblBudgetPrevu.Name = "lblBudgetPrevu";
            this.lblBudgetPrevu.Size = new System.Drawing.Size(72, 13);
            this.lblBudgetPrevu.TabIndex = 2;
            this.lblBudgetPrevu.Text = "Budget Prévu";
            // 
            // lblCoutPartenariat
            // 
            this.lblCoutPartenariat.AutoSize = true;
            this.lblCoutPartenariat.Location = new System.Drawing.Point(13, 105);
            this.lblCoutPartenariat.Name = "lblCoutPartenariat";
            this.lblCoutPartenariat.Size = new System.Drawing.Size(98, 13);
            this.lblCoutPartenariat.TabIndex = 3;
            this.lblCoutPartenariat.Text = "Cout du Partenariat";
            // 
            // cbxActionMenee
            // 
            this.cbxActionMenee.FormattingEnabled = true;
            this.cbxActionMenee.Location = new System.Drawing.Point(13, 197);
            this.cbxActionMenee.Name = "cbxActionMenee";
            this.cbxActionMenee.Size = new System.Drawing.Size(162, 21);
            this.cbxActionMenee.TabIndex = 4;
            // 
            // cbxAssoLiee
            // 
            this.cbxAssoLiee.FormattingEnabled = true;
            this.cbxAssoLiee.Location = new System.Drawing.Point(13, 286);
            this.cbxAssoLiee.Name = "cbxAssoLiee";
            this.cbxAssoLiee.Size = new System.Drawing.Size(162, 21);
            this.cbxAssoLiee.TabIndex = 5;
            // 
            // lblActionMenee
            // 
            this.lblActionMenee.AutoSize = true;
            this.lblActionMenee.Location = new System.Drawing.Point(13, 181);
            this.lblActionMenee.Name = "lblActionMenee";
            this.lblActionMenee.Size = new System.Drawing.Size(73, 13);
            this.lblActionMenee.TabIndex = 6;
            this.lblActionMenee.Text = "Action Menée";
            // 
            // lblAssoLiee
            // 
            this.lblAssoLiee.AutoSize = true;
            this.lblAssoLiee.Location = new System.Drawing.Point(13, 270);
            this.lblAssoLiee.Name = "lblAssoLiee";
            this.lblAssoLiee.Size = new System.Drawing.Size(84, 13);
            this.lblAssoLiee.TabIndex = 7;
            this.lblAssoLiee.Text = "Association Liée";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(13, 352);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(162, 65);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FormAjoutPartenariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblAssoLiee);
            this.Controls.Add(this.lblActionMenee);
            this.Controls.Add(this.cbxAssoLiee);
            this.Controls.Add(this.cbxActionMenee);
            this.Controls.Add(this.lblCoutPartenariat);
            this.Controls.Add(this.lblBudgetPrevu);
            this.Controls.Add(this.txtCoutPartenariat);
            this.Controls.Add(this.txtBudgetPrevu);
            this.Name = "FormAjoutPartenariat";
            this.Text = "FormAjoutPartenariat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtBudgetPrevu;
        private System.Windows.Forms.MaskedTextBox txtCoutPartenariat;
        private System.Windows.Forms.Label lblBudgetPrevu;
        private System.Windows.Forms.Label lblCoutPartenariat;
        private System.Windows.Forms.ComboBox cbxActionMenee;
        private System.Windows.Forms.ComboBox cbxAssoLiee;
        private System.Windows.Forms.Label lblActionMenee;
        private System.Windows.Forms.Label lblAssoLiee;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}