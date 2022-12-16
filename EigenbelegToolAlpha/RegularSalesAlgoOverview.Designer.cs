namespace EigenbelegToolAlpha
{
    partial class RegularSalesAlgoOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularSalesAlgoOverview));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Analyze = new System.Windows.Forms.Button();
            this.lbl_lastDateUpdated = new System.Windows.Forms.Label();
            this.lbl_FreeAmount = new System.Windows.Forms.Label();
            this.lbl_AmountAtLeast = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_PayPalShare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Freibetrag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mindestbetrag:";
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.Location = new System.Drawing.Point(279, 182);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(121, 34);
            this.btn_Analyze.TabIndex = 3;
            this.btn_Analyze.Text = "Neu berechnen";
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            // 
            // lbl_lastDateUpdated
            // 
            this.lbl_lastDateUpdated.AutoSize = true;
            this.lbl_lastDateUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDateUpdated.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_lastDateUpdated.Location = new System.Drawing.Point(225, 30);
            this.lbl_lastDateUpdated.Name = "lbl_lastDateUpdated";
            this.lbl_lastDateUpdated.Size = new System.Drawing.Size(175, 24);
            this.lbl_lastDateUpdated.TabIndex = 4;
            this.lbl_lastDateUpdated.Text = "26.12.2022 12:09:03";
            // 
            // lbl_FreeAmount
            // 
            this.lbl_FreeAmount.AutoSize = true;
            this.lbl_FreeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FreeAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_FreeAmount.Location = new System.Drawing.Point(325, 74);
            this.lbl_FreeAmount.Name = "lbl_FreeAmount";
            this.lbl_FreeAmount.Size = new System.Drawing.Size(75, 24);
            this.lbl_FreeAmount.TabIndex = 5;
            this.lbl_FreeAmount.Text = "9000,3€";
            // 
            // lbl_AmountAtLeast
            // 
            this.lbl_AmountAtLeast.AutoSize = true;
            this.lbl_AmountAtLeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AmountAtLeast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AmountAtLeast.Location = new System.Drawing.Point(325, 122);
            this.lbl_AmountAtLeast.Name = "lbl_AmountAtLeast";
            this.lbl_AmountAtLeast.Size = new System.Drawing.Size(75, 24);
            this.lbl_AmountAtLeast.TabIndex = 6;
            this.lbl_AmountAtLeast.Text = "9000,3€";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(53, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aktueller PP Anteil:";
            // 
            // lbl_PayPalShare
            // 
            this.lbl_PayPalShare.AutoSize = true;
            this.lbl_PayPalShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PayPalShare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_PayPalShare.Location = new System.Drawing.Point(355, 230);
            this.lbl_PayPalShare.Name = "lbl_PayPalShare";
            this.lbl_PayPalShare.Size = new System.Drawing.Size(45, 24);
            this.lbl_PayPalShare.TabIndex = 8;
            this.lbl_PayPalShare.Text = "22%";
            // 
            // RegularSalesAlgoOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(521, 276);
            this.Controls.Add(this.lbl_PayPalShare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_AmountAtLeast);
            this.Controls.Add(this.lbl_FreeAmount);
            this.Controls.Add(this.lbl_lastDateUpdated);
            this.Controls.Add(this.btn_Analyze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegularSalesAlgoOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regular Sales Overview";
            this.Load += new System.EventHandler(this.RegularSalesAlgoOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Analyze;
        private System.Windows.Forms.Label lbl_lastDateUpdated;
        private System.Windows.Forms.Label lbl_FreeAmount;
        private System.Windows.Forms.Label lbl_AmountAtLeast;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_PayPalShare;
    }
}