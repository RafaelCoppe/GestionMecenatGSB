
namespace GestionMecenatGSB
{
    partial class FormConsultPartenariat
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
            this.btnAfficherPartenariats = new System.Windows.Forms.Button();
            this.dtgAfficherPartenariats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAfficherPartenariats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficherPartenariats
            // 
            this.btnAfficherPartenariats.Location = new System.Drawing.Point(243, 13);
            this.btnAfficherPartenariats.Name = "btnAfficherPartenariats";
            this.btnAfficherPartenariats.Size = new System.Drawing.Size(319, 55);
            this.btnAfficherPartenariats.TabIndex = 3;
            this.btnAfficherPartenariats.Text = "Afficher les données";
            this.btnAfficherPartenariats.UseVisualStyleBackColor = true;
            this.btnAfficherPartenariats.Click += new System.EventHandler(this.btnAfficherPartenariats_Click);
            // 
            // dtgAfficherPartenariats
            // 
            this.dtgAfficherPartenariats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAfficherPartenariats.Location = new System.Drawing.Point(12, 74);
            this.dtgAfficherPartenariats.Name = "dtgAfficherPartenariats";
            this.dtgAfficherPartenariats.Size = new System.Drawing.Size(776, 364);
            this.dtgAfficherPartenariats.TabIndex = 2;
            // 
            // FormConsultPartenariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficherPartenariats);
            this.Controls.Add(this.dtgAfficherPartenariats);
            this.Name = "FormConsultPartenariat";
            this.Text = "FormConsultPartenariat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAfficherPartenariats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherPartenariats;
        private System.Windows.Forms.DataGridView dtgAfficherPartenariats;
    }
}