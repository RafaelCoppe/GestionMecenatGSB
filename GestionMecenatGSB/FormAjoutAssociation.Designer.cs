
namespace GestionMecenatGSB
{
    partial class FormAjoutAssociation
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPays = new System.Windows.Forms.ComboBox();
            this.btnAjoutAssoc = new System.Windows.Forms.Button();
            this.txtNomResponsable = new System.Windows.Forms.TextBox();
            this.lblNomResponsable = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.cbxMission = new System.Windows.Forms.ComboBox();
            this.lblNomAssociation = new System.Windows.Forms.Label();
            this.txtNomAssoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pays";
            // 
            // cbxPays
            // 
            this.cbxPays.FormattingEnabled = true;
            this.cbxPays.Location = new System.Drawing.Point(318, 239);
            this.cbxPays.Name = "cbxPays";
            this.cbxPays.Size = new System.Drawing.Size(121, 21);
            this.cbxPays.TabIndex = 16;
            // 
            // btnAjoutAssoc
            // 
            this.btnAjoutAssoc.Location = new System.Drawing.Point(281, 303);
            this.btnAjoutAssoc.Name = "btnAjoutAssoc";
            this.btnAjoutAssoc.Size = new System.Drawing.Size(137, 34);
            this.btnAjoutAssoc.TabIndex = 15;
            this.btnAjoutAssoc.Text = "Ajouter l\'association";
            this.btnAjoutAssoc.UseVisualStyleBackColor = true;
            this.btnAjoutAssoc.Click += new System.EventHandler(this.btnAjoutAssoc_Click);
            // 
            // txtNomResponsable
            // 
            this.txtNomResponsable.Location = new System.Drawing.Point(318, 197);
            this.txtNomResponsable.Name = "txtNomResponsable";
            this.txtNomResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtNomResponsable.TabIndex = 14;
            // 
            // lblNomResponsable
            // 
            this.lblNomResponsable.AutoSize = true;
            this.lblNomResponsable.Location = new System.Drawing.Point(195, 204);
            this.lblNomResponsable.Name = "lblNomResponsable";
            this.lblNomResponsable.Size = new System.Drawing.Size(104, 13);
            this.lblNomResponsable.TabIndex = 13;
            this.lblNomResponsable.Text = "Nom du responsable";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(249, 156);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(42, 13);
            this.lblMission.TabIndex = 12;
            this.lblMission.Text = "Mission";
            // 
            // cbxMission
            // 
            this.cbxMission.FormattingEnabled = true;
            this.cbxMission.Location = new System.Drawing.Point(318, 148);
            this.cbxMission.Name = "cbxMission";
            this.cbxMission.Size = new System.Drawing.Size(121, 21);
            this.cbxMission.TabIndex = 11;
            // 
            // lblNomAssociation
            // 
            this.lblNomAssociation.AutoSize = true;
            this.lblNomAssociation.Location = new System.Drawing.Point(195, 109);
            this.lblNomAssociation.Name = "lblNomAssociation";
            this.lblNomAssociation.Size = new System.Drawing.Size(104, 13);
            this.lblNomAssociation.TabIndex = 10;
            this.lblNomAssociation.Text = "Nom de l\'association";
            // 
            // txtNomAssoc
            // 
            this.txtNomAssoc.Location = new System.Drawing.Point(318, 106);
            this.txtNomAssoc.Name = "txtNomAssoc";
            this.txtNomAssoc.Size = new System.Drawing.Size(100, 20);
            this.txtNomAssoc.TabIndex = 9;
            // 
            // FormAjoutAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPays);
            this.Controls.Add(this.btnAjoutAssoc);
            this.Controls.Add(this.txtNomResponsable);
            this.Controls.Add(this.lblNomResponsable);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.cbxMission);
            this.Controls.Add(this.lblNomAssociation);
            this.Controls.Add(this.txtNomAssoc);
            this.Name = "FormAjoutAssociation";
            this.Text = "Ajout d\'une association";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPays;
        private System.Windows.Forms.Button btnAjoutAssoc;
        private System.Windows.Forms.TextBox txtNomResponsable;
        private System.Windows.Forms.Label lblNomResponsable;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.ComboBox cbxMission;
        private System.Windows.Forms.Label lblNomAssociation;
        private System.Windows.Forms.TextBox txtNomAssoc;
    }
}