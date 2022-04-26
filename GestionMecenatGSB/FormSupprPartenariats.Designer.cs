
namespace GestionMecenatGSB
{
    partial class FormSupprPartenariats
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
            this.dtgPartenariats = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblPartenariatSelectionne = new System.Windows.Forms.Label();
            this.dtgPartenariatSelectione = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariatSelectione)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPartenariats
            // 
            this.dtgPartenariats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartenariats.Location = new System.Drawing.Point(12, 12);
            this.dtgPartenariats.Name = "dtgPartenariats";
            this.dtgPartenariats.Size = new System.Drawing.Size(779, 255);
            this.dtgPartenariats.TabIndex = 0;
            this.dtgPartenariats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartenariats_CellContentClick);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(476, 376);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(312, 62);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer le Partenariat";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblPartenariatSelectionne
            // 
            this.lblPartenariatSelectionne.AutoSize = true;
            this.lblPartenariatSelectionne.Location = new System.Drawing.Point(9, 307);
            this.lblPartenariatSelectionne.Name = "lblPartenariatSelectionne";
            this.lblPartenariatSelectionne.Size = new System.Drawing.Size(124, 13);
            this.lblPartenariatSelectionne.TabIndex = 2;
            this.lblPartenariatSelectionne.Text = "Partenariat sélectionné : ";
            // 
            // dtgPartenariatSelectione
            // 
            this.dtgPartenariatSelectione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartenariatSelectione.Location = new System.Drawing.Point(11, 339);
            this.dtgPartenariatSelectione.Name = "dtgPartenariatSelectione";
            this.dtgPartenariatSelectione.Size = new System.Drawing.Size(459, 99);
            this.dtgPartenariatSelectione.TabIndex = 3;
            // 
            // FormSupprPartenariats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgPartenariatSelectione);
            this.Controls.Add(this.lblPartenariatSelectionne);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dtgPartenariats);
            this.Name = "FormSupprPartenariats";
            this.Text = "FormSupprPartenariats";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariatSelectione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPartenariats;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblPartenariatSelectionne;
        private System.Windows.Forms.DataGridView dtgPartenariatSelectione;
    }
}