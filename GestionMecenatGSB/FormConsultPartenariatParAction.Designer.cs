
namespace GestionMecenatGSB
{
    partial class FormConsultPartenariatParAction
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
            this.cbxActionMenee = new System.Windows.Forms.ComboBox();
            this.dtgPartenariats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActionMenee
            // 
            this.cbxActionMenee.FormattingEnabled = true;
            this.cbxActionMenee.Location = new System.Drawing.Point(228, 12);
            this.cbxActionMenee.Name = "cbxActionMenee";
            this.cbxActionMenee.Size = new System.Drawing.Size(297, 21);
            this.cbxActionMenee.TabIndex = 0;
            this.cbxActionMenee.SelectionChangeCommitted += new System.EventHandler(this.cbxActionMenee_SelectionChangeCommitted);
            // 
            // dtgPartenariats
            // 
            this.dtgPartenariats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartenariats.Location = new System.Drawing.Point(12, 58);
            this.dtgPartenariats.Name = "dtgPartenariats";
            this.dtgPartenariats.Size = new System.Drawing.Size(776, 380);
            this.dtgPartenariats.TabIndex = 1;
            // 
            // FormConsultPartenariatParAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgPartenariats);
            this.Controls.Add(this.cbxActionMenee);
            this.Name = "FormConsultPartenariatParAction";
            this.Text = "FormConsultPartenariatParAction";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartenariats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxActionMenee;
        private System.Windows.Forms.DataGridView dtgPartenariats;
    }
}