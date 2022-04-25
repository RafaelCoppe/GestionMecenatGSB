
namespace GestionMecenatGSB
{
    partial class FormModifPartenariats
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblActionMenee = new System.Windows.Forms.Label();
            this.lblAssoLiee = new System.Windows.Forms.Label();
            this.lblCoutReel = new System.Windows.Forms.Label();
            this.lblBudgetPrev = new System.Windows.Forms.Label();
            this.cbxActionMenee = new System.Windows.Forms.ComboBox();
            this.cbxAssoLiee = new System.Windows.Forms.ComboBox();
            this.txtCoutReel = new System.Windows.Forms.TextBox();
            this.txtBudgetPrev = new System.Windows.Forms.TextBox();
            this.dtgPartenariats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(471, 365);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(317, 73);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 365);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(317, 73);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier le Partenariat";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblActionMenee
            // 
            this.lblActionMenee.AutoSize = true;
            this.lblActionMenee.Location = new System.Drawing.Point(583, 280);
            this.lblActionMenee.Name = "lblActionMenee";
            this.lblActionMenee.Size = new System.Drawing.Size(73, 13);
            this.lblActionMenee.TabIndex = 19;
            this.lblActionMenee.Text = "Action Menée";
            // 
            // lblAssoLiee
            // 
            this.lblAssoLiee.AutoSize = true;
            this.lblAssoLiee.Location = new System.Drawing.Point(583, 193);
            this.lblAssoLiee.Name = "lblAssoLiee";
            this.lblAssoLiee.Size = new System.Drawing.Size(84, 13);
            this.lblAssoLiee.TabIndex = 18;
            this.lblAssoLiee.Text = "Association Liée";
            // 
            // lblCoutReel
            // 
            this.lblCoutReel.AutoSize = true;
            this.lblCoutReel.Location = new System.Drawing.Point(583, 114);
            this.lblCoutReel.Name = "lblCoutReel";
            this.lblCoutReel.Size = new System.Drawing.Size(118, 13);
            this.lblCoutReel.TabIndex = 17;
            this.lblCoutReel.Text = "Cout réel du Partenariat";
            // 
            // lblBudgetPrev
            // 
            this.lblBudgetPrev.AutoSize = true;
            this.lblBudgetPrev.Location = new System.Drawing.Point(583, 26);
            this.lblBudgetPrev.Name = "lblBudgetPrev";
            this.lblBudgetPrev.Size = new System.Drawing.Size(101, 13);
            this.lblBudgetPrev.TabIndex = 16;
            this.lblBudgetPrev.Text = "Budget Previsionnel";
            // 
            // cbxActionMenee
            // 
            this.cbxActionMenee.FormattingEnabled = true;
            this.cbxActionMenee.Location = new System.Drawing.Point(586, 296);
            this.cbxActionMenee.Name = "cbxActionMenee";
            this.cbxActionMenee.Size = new System.Drawing.Size(202, 21);
            this.cbxActionMenee.TabIndex = 15;
            // 
            // cbxAssoLiee
            // 
            this.cbxAssoLiee.FormattingEnabled = true;
            this.cbxAssoLiee.Location = new System.Drawing.Point(586, 209);
            this.cbxAssoLiee.Name = "cbxAssoLiee";
            this.cbxAssoLiee.Size = new System.Drawing.Size(202, 21);
            this.cbxAssoLiee.TabIndex = 14;
            // 
            // txtCoutReel
            // 
            this.txtCoutReel.Location = new System.Drawing.Point(586, 130);
            this.txtCoutReel.Name = "txtCoutReel";
            this.txtCoutReel.Size = new System.Drawing.Size(202, 20);
            this.txtCoutReel.TabIndex = 13;
            // 
            // txtBudgetPrev
            // 
            this.txtBudgetPrev.Location = new System.Drawing.Point(586, 42);
            this.txtBudgetPrev.Name = "txtBudgetPrev";
            this.txtBudgetPrev.Size = new System.Drawing.Size(202, 20);
            this.txtBudgetPrev.TabIndex = 12;
            // 
            // dtgPartenariats
            // 
            this.dtgPartenariats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartenariats.Location = new System.Drawing.Point(12, 12);
            this.dtgPartenariats.Name = "dtgPartenariats";
            this.dtgPartenariats.Size = new System.Drawing.Size(554, 333);
            this.dtgPartenariats.TabIndex = 11;
            this.dtgPartenariats.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartenariats_CellContentDoubleClick);
            // 
            // FormModifPartenariats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblActionMenee);
            this.Controls.Add(this.lblAssoLiee);
            this.Controls.Add(this.lblCoutReel);
            this.Controls.Add(this.lblBudgetPrev);
            this.Controls.Add(this.cbxActionMenee);
            this.Controls.Add(this.cbxAssoLiee);
            this.Controls.Add(this.txtCoutReel);
            this.Controls.Add(this.txtBudgetPrev);
            this.Controls.Add(this.dtgPartenariats);
            this.Name = "FormModifPartenariats";
            this.Text = "FormModifPartenariats";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblActionMenee;
        private System.Windows.Forms.Label lblAssoLiee;
        private System.Windows.Forms.Label lblCoutReel;
        private System.Windows.Forms.Label lblBudgetPrev;
        private System.Windows.Forms.ComboBox cbxActionMenee;
        private System.Windows.Forms.ComboBox cbxAssoLiee;
        private System.Windows.Forms.TextBox txtCoutReel;
        private System.Windows.Forms.TextBox txtBudgetPrev;
        private System.Windows.Forms.DataGridView dtgPartenariats;
    }
}