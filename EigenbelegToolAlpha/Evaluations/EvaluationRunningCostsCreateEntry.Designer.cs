namespace EigenbelegToolAlpha
{
    partial class EvaluationRunningCostsCreateEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationRunningCostsCreateEntry));
            this.Rechnungssteller = new System.Windows.Forms.Label();
            this.textBox_invoiceProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.comboBox_taxdeduction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Rechnungssteller
            // 
            this.Rechnungssteller.AutoSize = true;
            this.Rechnungssteller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechnungssteller.Location = new System.Drawing.Point(52, 36);
            this.Rechnungssteller.Name = "Rechnungssteller";
            this.Rechnungssteller.Size = new System.Drawing.Size(173, 24);
            this.Rechnungssteller.TabIndex = 0;
            this.Rechnungssteller.Text = "Rechnungssteller";
            // 
            // textBox_invoiceProvider
            // 
            this.textBox_invoiceProvider.Location = new System.Drawing.Point(263, 41);
            this.textBox_invoiceProvider.Name = "textBox_invoiceProvider";
            this.textBox_invoiceProvider.Size = new System.Drawing.Size(169, 20);
            this.textBox_invoiceProvider.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorsteuerabzug?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betrag";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "O. K.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(263, 86);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(169, 20);
            this.textBox_Amount.TabIndex = 5;
            // 
            // comboBox_taxdeduction
            // 
            this.comboBox_taxdeduction.FormattingEnabled = true;
            this.comboBox_taxdeduction.Items.AddRange(new object[] {
            "Ja",
            "Nein"});
            this.comboBox_taxdeduction.Location = new System.Drawing.Point(263, 131);
            this.comboBox_taxdeduction.Name = "comboBox_taxdeduction";
            this.comboBox_taxdeduction.Size = new System.Drawing.Size(169, 21);
            this.comboBox_taxdeduction.TabIndex = 6;
            // 
            // EvaluationRunningCostsCreateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 221);
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
            this.Name = "EvaluationRunningCostsCreateEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eintrag erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rechnungssteller;
        private System.Windows.Forms.TextBox textBox_invoiceProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.ComboBox comboBox_taxdeduction;
    }
}