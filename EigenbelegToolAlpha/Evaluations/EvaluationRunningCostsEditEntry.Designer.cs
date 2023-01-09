namespace EigenbelegToolAlpha
{
    partial class EvaluationRunningCostsEditEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationRunningCostsEditEntry));
            this.comboBox_taxdeduction = new System.Windows.Forms.ComboBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_invoiceProvider = new System.Windows.Forms.TextBox();
            this.Rechnungssteller = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_taxdeduction
            // 
            this.comboBox_taxdeduction.FormattingEnabled = true;
            this.comboBox_taxdeduction.Items.AddRange(new object[] {
            "Ja",
            "Nein"});
            this.comboBox_taxdeduction.Location = new System.Drawing.Point(254, 133);
            this.comboBox_taxdeduction.Name = "comboBox_taxdeduction";
            this.comboBox_taxdeduction.Size = new System.Drawing.Size(169, 21);
            this.comboBox_taxdeduction.TabIndex = 13;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(254, 88);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(169, 20);
            this.textBox_Amount.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "O. K.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Betrag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vorsteuerabzug?";
            // 
            // textBox_invoiceProvider
            // 
            this.textBox_invoiceProvider.Location = new System.Drawing.Point(254, 43);
            this.textBox_invoiceProvider.Name = "textBox_invoiceProvider";
            this.textBox_invoiceProvider.Size = new System.Drawing.Size(169, 20);
            this.textBox_invoiceProvider.TabIndex = 8;
            // 
            // Rechnungssteller
            // 
            this.Rechnungssteller.AutoSize = true;
            this.Rechnungssteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechnungssteller.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rechnungssteller.Location = new System.Drawing.Point(43, 38);
            this.Rechnungssteller.Name = "Rechnungssteller";
            this.Rechnungssteller.Size = new System.Drawing.Size(173, 24);
            this.Rechnungssteller.TabIndex = 7;
            this.Rechnungssteller.Text = "Rechnungssteller";
            // 
            // EvaluationRunningCostsEditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(470, 253);
            this.Controls.Add(this.comboBox_taxdeduction);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_invoiceProvider);
            this.Controls.Add(this.Rechnungssteller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvaluationRunningCostsEditEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eintrag bearbeiten";
            this.Load += new System.EventHandler(this.EvaluationRunningCostsEditEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_taxdeduction;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_invoiceProvider;
        private System.Windows.Forms.Label Rechnungssteller;
    }
}