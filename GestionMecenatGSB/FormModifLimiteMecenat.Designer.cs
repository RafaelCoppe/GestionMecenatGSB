
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
            this.dtgConsultLimiteMecenat = new System.Windows.Forms.DataGridView();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.cbxPays = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblPays = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblPlafondMecenat = new System.Windows.Forms.Label();
            this.txtSommeMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultLimiteMecenat
            // 
            this.dtgConsultLimiteMecenat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultLimiteMecenat.Location = new System.Drawing.Point(12, 12);
            this.dtgConsultLimiteMecenat.Name = "dtgConsultLimiteMecenat";
            this.dtgConsultLimiteMecenat.Size = new System.Drawing.Size(554, 333);
            this.dtgConsultLimiteMecenat.TabIndex = 12;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(586, 172);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(202, 21);
            this.cbxAnnee.TabIndex = 25;
            // 
            // cbxPays
            // 
            this.cbxPays.FormattingEnabled = true;
            this.cbxPays.Location = new System.Drawing.Point(586, 261);
            this.cbxPays.Name = "cbxPays";
            this.cbxPays.Size = new System.Drawing.Size(202, 21);
            this.cbxPays.TabIndex = 26;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 365);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(317, 73);
            this.btnModifier.TabIndex = 27;
            this.btnModifier.Text = "Modifier la limite de mecenat";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(455, 365);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(317, 73);
            this.btnAnnuler.TabIndex = 28;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(583, 231);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(79, 13);
            this.lblPays.TabIndex = 29;
            this.lblPays.Text = "Choix du pays :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(583, 139);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(91, 13);
            this.lblAnnee.TabIndex = 30;
            this.lblAnnee.Text = "Choix de l\'année :";
            // 
            // lblPlafondMecenat
            // 
            this.lblPlafondMecenat.AutoSize = true;
            this.lblPlafondMecenat.Location = new System.Drawing.Point(583, 44);
            this.lblPlafondMecenat.Name = "lblPlafondMecenat";
            this.lblPlafondMecenat.Size = new System.Drawing.Size(94, 13);
            this.lblPlafondMecenat.TabIndex = 31;
            this.lblPlafondMecenat.Text = "Somme maximum :";
            // 
            // txtSommeMax
            // 
            this.txtSommeMax.Location = new System.Drawing.Point(586, 81);
            this.txtSommeMax.Name = "txtSommeMax";
            this.txtSommeMax.Size = new System.Drawing.Size(171, 20);
            this.txtSommeMax.TabIndex = 32;
            // 
            // FormModifLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSommeMax);
            this.Controls.Add(this.lblPlafondMecenat);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbxPays);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.dtgConsultLimiteMecenat);
            this.Name = "FormModifLimiteMecenat";
            this.Text = "FormModifLimiteMecenat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultLimiteMecenat;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxPays;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblPlafondMecenat;
        private System.Windows.Forms.TextBox txtSommeMax;
    }
}