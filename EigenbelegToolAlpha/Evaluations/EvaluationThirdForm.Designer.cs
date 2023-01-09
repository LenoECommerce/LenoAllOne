namespace EigenbelegToolAlpha
{
    partial class EvaluationThirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationThirdForm));
            this.textbox_DigitalToolsBillbee = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ContinueWithEvaluation3 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_RestVersandkosten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CostsFromDatabase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_DigitalToolsBillbee
            // 
            this.textbox_DigitalToolsBillbee.Location = new System.Drawing.Point(199, 83);
            this.textbox_DigitalToolsBillbee.Name = "textbox_DigitalToolsBillbee";
            this.textbox_DigitalToolsBillbee.Size = new System.Drawing.Size(224, 20);
            this.textbox_DigitalToolsBillbee.TabIndex = 122;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(29, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(173, 29);
            this.label20.TabIndex = 120;
            this.label20.Text = "Laufende Kosten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 119;
            this.label1.Text = "Billbee";
            // 
            // btn_ContinueWithEvaluation3
            // 
            this.btn_ContinueWithEvaluation3.Location = new System.Drawing.Point(320, 225);
            this.btn_ContinueWithEvaluation3.Name = "btn_ContinueWithEvaluation3";
            this.btn_ContinueWithEvaluation3.Size = new System.Drawing.Size(103, 28);
            this.btn_ContinueWithEvaluation3.TabIndex = 123;
            this.btn_ContinueWithEvaluation3.Text = "Weiter";
            this.btn_ContinueWithEvaluation3.UseVisualStyleBackColor = true;
            this.btn_ContinueWithEvaluation3.Click += new System.EventHandler(this.btn_ContinueWithEvaluation3_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(41, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 18);
            this.label24.TabIndex = 161;
            this.label24.Text = "Versandkosten";
            // 
            // textBox_RestVersandkosten
            // 
            this.textBox_RestVersandkosten.Location = new System.Drawing.Point(199, 120);
            this.textBox_RestVersandkosten.Name = "textBox_RestVersandkosten";
            this.textBox_RestVersandkosten.Size = new System.Drawing.Size(224, 20);
            this.textBox_RestVersandkosten.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 167;
            this.label2.Text = "Rest";
            // 
            // textBox_CostsFromDatabase
            // 
            this.textBox_CostsFromDatabase.Location = new System.Drawing.Point(199, 163);
            this.textBox_CostsFromDatabase.Name = "textBox_CostsFromDatabase";
            this.textBox_CostsFromDatabase.Size = new System.Drawing.Size(224, 20);
            this.textBox_CostsFromDatabase.TabIndex = 168;
            // 
            // EvaluationThirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.textBox_CostsFromDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_RestVersandkosten);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btn_ContinueWithEvaluation3);
            this.Controls.Add(this.textbox_DigitalToolsBillbee);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EvaluationThirdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswertung 3. Seite";
            this.Load += new System.EventHandler(this.EvaluationThirdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_DigitalToolsBillbee;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ContinueWithEvaluation3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_RestVersandkosten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CostsFromDatabase;
    }
}