
namespace GestionMecenatGSB
{
    partial class FormAjoutLimiteMecenat
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
            this.txtSommeMaximum = new System.Windows.Forms.MaskedTextBox();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cbxPays = new System.Windows.Forms.ComboBox();
            this.lblPlafondMecenat = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSommeMaximum
            // 
            this.txtSommeMaximum.Location = new System.Drawing.Point(335, 222);
            this.txtSommeMaximum.Mask = "9999999";
            this.txtSommeMaximum.Name = "txtSommeMaximum";
            this.txtSommeMaximum.Size = new System.Drawing.Size(112, 20);
            this.txtSommeMaximum.TabIndex = 15;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(335, 167);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(112, 21);
            this.cbxAnnee.TabIndex = 14;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(276, 271);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cbxPays
            // 
            this.cbxPays.FormattingEnabled = true;
            this.cbxPays.Location = new System.Drawing.Point(311, 117);
            this.cbxPays.Name = "cbxPays";
            this.cbxPays.Size = new System.Drawing.Size(160, 21);
            this.cbxPays.TabIndex = 11;
            this.cbxPays.SelectedIndexChanged += new System.EventHandler(this.cbxPays_SelectedIndexChanged_1);
            // 
            // lblPlafondMecenat
            // 
            this.lblPlafondMecenat.AutoSize = true;
            this.lblPlafondMecenat.Location = new System.Drawing.Point(190, 222);
            this.lblPlafondMecenat.Name = "lblPlafondMecenat";
            this.lblPlafondMecenat.Size = new System.Drawing.Size(94, 13);
            this.lblPlafondMecenat.TabIndex = 12;
            this.lblPlafondMecenat.Text = "Somme maximum :";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(214, 120);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(79, 13);
            this.lblPays.TabIndex = 9;
            this.lblPays.Text = "Choix du pays :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(184, 170);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(109, 13);
            this.lblAnnee.TabIndex = 10;
            this.lblAnnee.Text = "Sélectionner l\'année :";
            // 
            // FormAjoutLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSommeMaximum);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxPays);
            this.Controls.Add(this.lblPlafondMecenat);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblAnnee);
            this.Name = "FormAjoutLimiteMecenat";
            this.Text = "FormAjoutLimiteMecenat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtSommeMaximum;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cbxPays;
        private System.Windows.Forms.Label lblPlafondMecenat;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblAnnee;
    }
}