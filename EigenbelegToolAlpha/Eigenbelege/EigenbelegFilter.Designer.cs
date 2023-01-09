namespace EigenbelegToolAlpha
{
    partial class EigenbelegFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EigenbelegFilter));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_FilterCreated = new System.Windows.Forms.ComboBox();
            this.comboBox_filterPlatform = new System.Windows.Forms.ComboBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_filterModell = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plattform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Erstellt?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_FilterCreated
            // 
            this.comboBox_FilterCreated.FormattingEnabled = true;
            this.comboBox_FilterCreated.Items.AddRange(new object[] {
            "Alle",
            "Ja",
            "Nein"});
            this.comboBox_FilterCreated.Location = new System.Drawing.Point(207, 147);
            this.comboBox_FilterCreated.Name = "comboBox_FilterCreated";
            this.comboBox_FilterCreated.Size = new System.Drawing.Size(193, 21);
            this.comboBox_FilterCreated.TabIndex = 6;
            this.comboBox_FilterCreated.Text = "Alle";
            // 
            // comboBox_filterPlatform
            // 
            this.comboBox_filterPlatform.FormattingEnabled = true;
            this.comboBox_filterPlatform.Items.AddRange(new object[] {
            "Alle",
            "Ebay Kleinanzeigen",
            "Ebay",
            "BackMarket"});
            this.comboBox_filterPlatform.Location = new System.Drawing.Point(207, 100);
            this.comboBox_filterPlatform.Name = "comboBox_filterPlatform";
            this.comboBox_filterPlatform.Size = new System.Drawing.Size(193, 21);
            this.comboBox_filterPlatform.TabIndex = 7;
            this.comboBox_filterPlatform.Text = "Alle";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(300, 192);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(100, 23);
            this.btn_Execute.TabIndex = 8;
            this.btn_Execute.Text = "Ausführen";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filterung geht nur mit je einer Auswahl";
            // 
            // comboBox_filterModell
            // 
            this.comboBox_filterModell.FormattingEnabled = true;
            this.comboBox_filterModell.Items.AddRange(new object[] {
            "Alle",
            "iPhone SE 1. Gen",
            "iPhone 6S",
            "iPhone 6S Plus",
            "iPhone 7",
            "iPhone 7 Plus",
            "iPhone 8",
            "iPhone 8 Plus",
            "iPhone SE 2020",
            "iPhone X",
            "iPhone XR",
            "iPhone XS",
            "iPhone XS Max",
            "iPhone 11",
            "iPhone 11 Pro",
            "iPhone 11 Pro Max",
            "iPhone 12 Mini",
            "iPhone 12",
            "iPhone 12 Pro",
            "iPhone 12 Pro Max",
            "iPhone 13 Mini",
            "iPhone 13",
            "iPhone 13 Pro",
            "iPhone 13 Pro Max"});
            this.comboBox_filterModell.Location = new System.Drawing.Point(207, 55);
            this.comboBox_filterModell.Name = "comboBox_filterModell";
            this.comboBox_filterModell.Size = new System.Drawing.Size(193, 21);
            this.comboBox_filterModell.TabIndex = 5;
            this.comboBox_filterModell.Text = "Alle";
            // 
            // EigenbelegFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.comboBox_filterPlatform);
            this.Controls.Add(this.comboBox_FilterCreated);
            this.Controls.Add(this.comboBox_filterModell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EigenbelegFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter einstellen";
            this.Load += new System.EventHandler(this.EigenbelegFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public  System.Windows.Forms.ComboBox comboBox_FilterCreated;
        public System.Windows.Forms.ComboBox comboBox_filterPlatform;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label label3;
        public  System.Windows.Forms.ComboBox comboBox_filterModell;
    }
}