
namespace GestionMecenatGSB
{
    partial class FormSupprPartenariat
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
            this.btnSuppr = new System.Windows.Forms.Button();
            this.lblPartenariatChoisi = new System.Windows.Forms.Label();
            this.dtgPartenariatChoisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariatChoisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPartenariats
            // 
            this.dtgPartenariats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartenariats.Location = new System.Drawing.Point(12, 12);
            this.dtgPartenariats.Name = "dtgPartenariats";
            this.dtgPartenariats.Size = new System.Drawing.Size(775, 305);
            this.dtgPartenariats.TabIndex = 0;
            this.dtgPartenariats.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartenariats_CellContentDoubleClick);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(551, 387);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(237, 51);
            this.btnSuppr.TabIndex = 1;
            this.btnSuppr.Text = "Supprimer le partenariat";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // lblPartenariatChoisi
            // 
            this.lblPartenariatChoisi.AutoSize = true;
            this.lblPartenariatChoisi.Location = new System.Drawing.Point(9, 355);
            this.lblPartenariatChoisi.Name = "lblPartenariatChoisi";
            this.lblPartenariatChoisi.Size = new System.Drawing.Size(94, 13);
            this.lblPartenariatChoisi.TabIndex = 2;
            this.lblPartenariatChoisi.Text = "Partenariat choisi :";
            // 
            // dtgPartenariatChoisi
            // 
            this.dtgPartenariatChoisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartenariatChoisi.Location = new System.Drawing.Point(12, 387);
            this.dtgPartenariatChoisi.Name = "dtgPartenariatChoisi";
            this.dtgPartenariatChoisi.Size = new System.Drawing.Size(491, 51);
            this.dtgPartenariatChoisi.TabIndex = 3;
            // 
            // FormSupprPartenariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgPartenariatChoisi);
            this.Controls.Add(this.lblPartenariatChoisi);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.dtgPartenariats);
            this.Name = "FormSupprPartenariat";
            this.Text = "FormSupprPartenariat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariatChoisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPartenariats;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Label lblPartenariatChoisi;
        private System.Windows.Forms.DataGridView dtgPartenariatChoisi;
    }
}