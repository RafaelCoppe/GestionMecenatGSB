
namespace GestionMecenatGSB
{
    partial class FormConsultLimiteMecenat
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
            this.btnObtenirInfos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultLimiteMecenat
            // 
            this.dtgConsultLimiteMecenat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultLimiteMecenat.Location = new System.Drawing.Point(127, 30);
            this.dtgConsultLimiteMecenat.Name = "dtgConsultLimiteMecenat";
            this.dtgConsultLimiteMecenat.Size = new System.Drawing.Size(562, 338);
            this.dtgConsultLimiteMecenat.TabIndex = 0;
            // 
            // btnObtenirInfos
            // 
            this.btnObtenirInfos.Location = new System.Drawing.Point(313, 390);
            this.btnObtenirInfos.Name = "btnObtenirInfos";
            this.btnObtenirInfos.Size = new System.Drawing.Size(194, 34);
            this.btnObtenirInfos.TabIndex = 1;
            this.btnObtenirInfos.Text = "Obtenir les informations";
            this.btnObtenirInfos.UseVisualStyleBackColor = true;
            this.btnObtenirInfos.Click += new System.EventHandler(this.btnObtenirInfos_Click);
            // 
            // FormConsultLimiteMecenat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObtenirInfos);
            this.Controls.Add(this.dtgConsultLimiteMecenat);
            this.Name = "FormConsultLimiteMecenat";
            this.Text = "FormConsultLimiteMecenat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultLimiteMecenat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultLimiteMecenat;
        private System.Windows.Forms.Button btnObtenirInfos;
    }
}