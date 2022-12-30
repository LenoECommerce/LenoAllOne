namespace EigenbelegToolAlpha
{
    partial class TaxCheckForeignGrossSales
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_lastDateUpdated = new System.Windows.Forms.Label();
            this.btn_Analyze = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_amount.Location = new System.Drawing.Point(329, 72);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(75, 24);
            this.lbl_amount.TabIndex = 12;
            this.lbl_amount.Text = "9000,3€";
            // 
            // lbl_lastDateUpdated
            // 
            this.lbl_lastDateUpdated.AutoSize = true;
            this.lbl_lastDateUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDateUpdated.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_lastDateUpdated.Location = new System.Drawing.Point(229, 28);
            this.lbl_lastDateUpdated.Name = "lbl_lastDateUpdated";
            this.lbl_lastDateUpdated.Size = new System.Drawing.Size(175, 24);
            this.lbl_lastDateUpdated.TabIndex = 11;
            this.lbl_lastDateUpdated.Text = "26.12.2022 12:09:03";
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.Location = new System.Drawing.Point(283, 130);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(121, 34);
            this.btn_Analyze.TabIndex = 10;
            this.btn_Analyze.Text = "Neu berechnen";
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Betrag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stand:";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // TaxCheckForeignGrossSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(475, 273);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_lastDateUpdated);
            this.Controls.Add(this.btn_Analyze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaxCheckForeignGrossSales";
            this.Text = "Letzter Stand für Foreign Countries Gross Sales";
            this.Load += new System.EventHandler(this.TaxCheckForeignGrossSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_lastDateUpdated;
        private System.Windows.Forms.Button btn_Analyze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}