namespace EigenbelegToolAlpha
{
    partial class ReparaturenFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReparaturenFilter));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.comboBox_filterSource = new System.Windows.Forms.ComboBox();
            this.comboBox_filterModell = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_filterRepairState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filterung geht nur mit je einer Auswahl";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(307, 227);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(100, 23);
            this.btn_Execute.TabIndex = 16;
            this.btn_Execute.Text = "Ausführen";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // comboBox_filterSource
            // 
            this.comboBox_filterSource.FormattingEnabled = true;
            this.comboBox_filterSource.Items.AddRange(new object[] {
            "Alle",
            "Ebay Kleinanzeigen",
            "Ebay",
            "BackMarket"});
            this.comboBox_filterSource.Location = new System.Drawing.Point(214, 118);
            this.comboBox_filterSource.Name = "comboBox_filterSource";
            this.comboBox_filterSource.Size = new System.Drawing.Size(193, 21);
            this.comboBox_filterSource.TabIndex = 15;
            this.comboBox_filterSource.Text = "Alle";
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
            this.comboBox_filterModell.Location = new System.Drawing.Point(214, 73);
            this.comboBox_filterModell.Name = "comboBox_filterModell";
            this.comboBox_filterModell.Size = new System.Drawing.Size(193, 21);
            this.comboBox_filterModell.TabIndex = 13;
            this.comboBox_filterModell.Text = "Alle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status";
            // 
            // comboBox_filterRepairState
            // 
            this.comboBox_filterRepairState.FormattingEnabled = true;
            this.comboBox_filterRepairState.Items.AddRange(new object[] {
            "Alle",
            "Entgegengenommen",
            "Getestet",
            "Reparatur",
            "Fertiggestellt",
            "",
            "BackMarket Gegenangebot",
            "Warten auf Teil",
            "Spender",
            "Entnahme"});
            this.comboBox_filterRepairState.Location = new System.Drawing.Point(214, 162);
            this.comboBox_filterRepairState.Name = "comboBox_filterRepairState";
            this.comboBox_filterRepairState.Size = new System.Drawing.Size(193, 21);
            this.comboBox_filterRepairState.TabIndex = 19;
            this.comboBox_filterRepairState.Text = "Alle";
            // 
            // ReparaturenFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 281);
            this.Controls.Add(this.comboBox_filterRepairState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.comboBox_filterSource);
            this.Controls.Add(this.comboBox_filterModell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReparaturenFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReparaturenFilter";
            this.Load += new System.EventHandler(this.ReparaturenFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.ComboBox comboBox_filterSource;
        private System.Windows.Forms.ComboBox comboBox_filterModell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_filterRepairState;
    }
}