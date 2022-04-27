
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtSommeMax = new System.Windows.Forms.TextBox();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.cbxPays = new System.Windows.Forms.ComboBox();
            this.lblPlafondMecenat = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.dtgConsultLimiteMecenat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(33, 365);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(317, 73);
            this.btnModifier.TabIndex = 32;
            this.btnModifier.Text = "Modifier la limite de Mecenat";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(471, 365);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(317, 73);
            this.btnAnnuler.TabIndex = 31;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // txtSommeMax
            // 
            this.txtSommeMax.Location = new System.Drawing.Point(600, 266);
            this.txtSommeMax.Name = "txtSommeMax";
            this.txtSommeMax.Size = new System.Drawing.Size(171, 20);
            this.txtSommeMax.TabIndex = 30;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(600, 180);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(160, 21);
            this.cbxAnnee.TabIndex = 29;
            // 
            // cbxPays
            // 
            this.cbxPays.FormattingEnabled = true;
            this.cbxPays.Location = new System.Drawing.Point(600, 95);
            this.cbxPays.Name = "cbxPays";
            this.cbxPays.Size = new System.Drawing.Size(160, 21);
            this.cbxPays.TabIndex = 27;
            // 
            // lblPlafondMecenat
            // 
            this.lblPlafondMecenat.AutoSize = true;
            this.lblPlafondMecenat.Location = new System.Drawing.Point(597, 230);
            this.lblPlafondMecenat.Name = "lblPlafondMecenat";
            this.lblPlafondMecenat.Size = new System.Drawing.Size(94, 13);
            this.lblPlafondMecenat.TabIndex = 28;
            this.lblPlafondMecenat.Text = "Somme maximum :";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(597, 67);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(79, 13);
            this.lblPays.TabIndex = 25;
            this.lblPays.Text = "Choix du pays :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(597, 143);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(109, 13);
            this.lblAnnee.TabIndex = 26;
            this.lblAnnee.Text = "Sélectionner l\'année :";
            // 
            // dtgConsultLimiteMecenat
            // 
            this.dtgConsultLimiteMecenat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultLimiteMecenat.Location = new System.Drawing.Point(12, 12);
            this.dtgConsultLimiteMecenat.Name = "dtgConsultLimiteMecenat";
            this.dtgConsultLimiteMecenat.Size = new System.Drawing.Size(557, 328);
            this.dtgConsultLimiteMecenat.TabIndex = 24;
            this.dtgConsultLimiteMecenat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultLimiteMecenat_CellContentDoubleClick);
            // 
            // FormModifLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtSommeMax);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.cbxPays);
            this.Controls.Add(this.lblPlafondMecenat);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.dtgConsultLimiteMecenat);
            this.Name = "FormModifLimiteMecenat";
            this.Text = "FormModifLimiteMecenat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtSommeMax;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxPays;
        private System.Windows.Forms.Label lblPlafondMecenat;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.DataGridView dtgConsultLimiteMecenat;
    }
}