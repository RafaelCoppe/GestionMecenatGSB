
namespace GestionMecenatGSB
{
    partial class FormSupprLimiteMecenat
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
            this.btnSuppr = new System.Windows.Forms.Button();
            this.lblPartenariatChoisi = new System.Windows.Forms.Label();
            this.dtgLimiteChoisi = new System.Windows.Forms.DataGridView();
            this.dtgConsultLimiteMecenat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLimiteChoisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(619, 374);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(157, 64);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Supprimer la limite de mecenat";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // lblPartenariatChoisi
            // 
            this.lblPartenariatChoisi.AutoSize = true;
            this.lblPartenariatChoisi.Location = new System.Drawing.Point(12, 358);
            this.lblPartenariatChoisi.Name = "lblPartenariatChoisi";
            this.lblPartenariatChoisi.Size = new System.Drawing.Size(129, 13);
            this.lblPartenariatChoisi.TabIndex = 3;
            this.lblPartenariatChoisi.Text = "Limite de mecenat choisi :";
            // 
            // dtgLimiteChoisi
            // 
            this.dtgLimiteChoisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLimiteChoisi.Location = new System.Drawing.Point(12, 374);
            this.dtgLimiteChoisi.Name = "dtgLimiteChoisi";
            this.dtgLimiteChoisi.Size = new System.Drawing.Size(587, 64);
            this.dtgLimiteChoisi.TabIndex = 4;
            // 
            // dtgConsultLimiteMecenat
            // 
            this.dtgConsultLimiteMecenat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultLimiteMecenat.Location = new System.Drawing.Point(12, 12);
            this.dtgConsultLimiteMecenat.Name = "dtgConsultLimiteMecenat";
            this.dtgConsultLimiteMecenat.Size = new System.Drawing.Size(764, 328);
            this.dtgConsultLimiteMecenat.TabIndex = 25;
            this.dtgConsultLimiteMecenat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultLimiteMecenat_CellContentDoubleClick);
            // 
            // FormSupprLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultLimiteMecenat);
            this.Controls.Add(this.dtgLimiteChoisi);
            this.Controls.Add(this.lblPartenariatChoisi);
            this.Controls.Add(this.btnSuppr);
            this.Name = "FormSupprLimiteMecenat";
            this.Text = "FormSupprLimiteMecenat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLimiteChoisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Label lblPartenariatChoisi;
        private System.Windows.Forms.DataGridView dtgLimiteChoisi;
        private System.Windows.Forms.DataGridView dtgConsultLimiteMecenat;
    }
}