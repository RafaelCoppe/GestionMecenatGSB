
namespace GestionMecenatGSB
{
    partial class FormConsultAssoc
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
            this.dtgConsultAssoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAssoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultAssoc
            // 
            this.dtgConsultAssoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultAssoc.Location = new System.Drawing.Point(212, 95);
            this.dtgConsultAssoc.Name = "dtgConsultAssoc";
            this.dtgConsultAssoc.Size = new System.Drawing.Size(373, 210);
            this.dtgConsultAssoc.TabIndex = 0;
            // 
            // FormConsultAssoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultAssoc);
            this.Name = "FormConsultAssoc";
            this.Text = "Consultation des associations";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAssoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultAssoc;
    }
}