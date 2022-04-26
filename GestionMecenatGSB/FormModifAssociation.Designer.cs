
namespace GestionMecenatGSB
{
    partial class FormModifAssociation
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
            this.cbxModifAssoc = new System.Windows.Forms.ComboBox();
            this.lblListeAssocModif = new System.Windows.Forms.Label();
            this.lblNvNomAssoc = new System.Windows.Forms.Label();
            this.txtBoxModifNom = new System.Windows.Forms.TextBox();
            this.cbxModifMission = new System.Windows.Forms.ComboBox();
            this.lblModifMission = new System.Windows.Forms.Label();
            this.lblModifResp = new System.Windows.Forms.Label();
            this.txtModifResp = new System.Windows.Forms.TextBox();
            this.lblModifPays = new System.Windows.Forms.Label();
            this.cbxModifPays = new System.Windows.Forms.ComboBox();
            this.btnModifAssoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxModifAssoc
            // 
            this.cbxModifAssoc.FormattingEnabled = true;
            this.cbxModifAssoc.Location = new System.Drawing.Point(332, 140);
            this.cbxModifAssoc.Name = "cbxModifAssoc";
            this.cbxModifAssoc.Size = new System.Drawing.Size(121, 21);
            this.cbxModifAssoc.TabIndex = 0;
            // 
            // lblListeAssocModif
            // 
            this.lblListeAssocModif.AutoSize = true;
            this.lblListeAssocModif.Location = new System.Drawing.Point(190, 143);
            this.lblListeAssocModif.Name = "lblListeAssocModif";
            this.lblListeAssocModif.Size = new System.Drawing.Size(110, 13);
            this.lblListeAssocModif.TabIndex = 1;
            this.lblListeAssocModif.Text = "Liste des associations";
            // 
            // lblNvNomAssoc
            // 
            this.lblNvNomAssoc.AutoSize = true;
            this.lblNvNomAssoc.Location = new System.Drawing.Point(172, 180);
            this.lblNvNomAssoc.Name = "lblNvNomAssoc";
            this.lblNvNomAssoc.Size = new System.Drawing.Size(138, 13);
            this.lblNvNomAssoc.TabIndex = 2;
            this.lblNvNomAssoc.Text = "Nouveau nom d\'association";
            // 
            // txtBoxModifNom
            // 
            this.txtBoxModifNom.Location = new System.Drawing.Point(332, 177);
            this.txtBoxModifNom.Name = "txtBoxModifNom";
            this.txtBoxModifNom.Size = new System.Drawing.Size(121, 20);
            this.txtBoxModifNom.TabIndex = 3;
            // 
            // cbxModifMission
            // 
            this.cbxModifMission.FormattingEnabled = true;
            this.cbxModifMission.Location = new System.Drawing.Point(332, 218);
            this.cbxModifMission.Name = "cbxModifMission";
            this.cbxModifMission.Size = new System.Drawing.Size(121, 21);
            this.cbxModifMission.TabIndex = 4;
            // 
            // lblModifMission
            // 
            this.lblModifMission.AutoSize = true;
            this.lblModifMission.Location = new System.Drawing.Point(212, 226);
            this.lblModifMission.Name = "lblModifMission";
            this.lblModifMission.Size = new System.Drawing.Size(42, 13);
            this.lblModifMission.TabIndex = 5;
            this.lblModifMission.Text = "Mission";
            // 
            // lblModifResp
            // 
            this.lblModifResp.AutoSize = true;
            this.lblModifResp.Location = new System.Drawing.Point(161, 266);
            this.lblModifResp.Name = "lblModifResp";
            this.lblModifResp.Size = new System.Drawing.Size(149, 13);
            this.lblModifResp.TabIndex = 6;
            this.lblModifResp.Text = "Nouveau nom du responsable";
            // 
            // txtModifResp
            // 
            this.txtModifResp.Location = new System.Drawing.Point(332, 259);
            this.txtModifResp.Name = "txtModifResp";
            this.txtModifResp.Size = new System.Drawing.Size(100, 20);
            this.txtModifResp.TabIndex = 7;
            // 
            // lblModifPays
            // 
            this.lblModifPays.AutoSize = true;
            this.lblModifPays.Location = new System.Drawing.Point(212, 304);
            this.lblModifPays.Name = "lblModifPays";
            this.lblModifPays.Size = new System.Drawing.Size(30, 13);
            this.lblModifPays.TabIndex = 8;
            this.lblModifPays.Text = "Pays";
            // 
            // cbxModifPays
            // 
            this.cbxModifPays.FormattingEnabled = true;
            this.cbxModifPays.Location = new System.Drawing.Point(332, 296);
            this.cbxModifPays.Name = "cbxModifPays";
            this.cbxModifPays.Size = new System.Drawing.Size(121, 21);
            this.cbxModifPays.TabIndex = 9;
            // 
            // btnModifAssoc
            // 
            this.btnModifAssoc.Location = new System.Drawing.Point(332, 361);
            this.btnModifAssoc.Name = "btnModifAssoc";
            this.btnModifAssoc.Size = new System.Drawing.Size(121, 43);
            this.btnModifAssoc.TabIndex = 10;
            this.btnModifAssoc.Text = "Modifier l\'association";
            this.btnModifAssoc.UseVisualStyleBackColor = true;
            this.btnModifAssoc.Click += new System.EventHandler(this.btnModifAssoc_Click);
            // 
            // FormModifAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifAssoc);
            this.Controls.Add(this.cbxModifPays);
            this.Controls.Add(this.lblModifPays);
            this.Controls.Add(this.txtModifResp);
            this.Controls.Add(this.lblModifResp);
            this.Controls.Add(this.lblModifMission);
            this.Controls.Add(this.cbxModifMission);
            this.Controls.Add(this.txtBoxModifNom);
            this.Controls.Add(this.lblNvNomAssoc);
            this.Controls.Add(this.lblListeAssocModif);
            this.Controls.Add(this.cbxModifAssoc);
            this.Name = "FormModifAssociation";
            this.Text = "Modification d\'une association";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxModifAssoc;
        private System.Windows.Forms.Label lblListeAssocModif;
        private System.Windows.Forms.Label lblNvNomAssoc;
        private System.Windows.Forms.TextBox txtBoxModifNom;
        private System.Windows.Forms.ComboBox cbxModifMission;
        private System.Windows.Forms.Label lblModifMission;
        private System.Windows.Forms.Label lblModifResp;
        private System.Windows.Forms.TextBox txtModifResp;
        private System.Windows.Forms.Label lblModifPays;
        private System.Windows.Forms.ComboBox cbxModifPays;
        private System.Windows.Forms.Button btnModifAssoc;
    }
}