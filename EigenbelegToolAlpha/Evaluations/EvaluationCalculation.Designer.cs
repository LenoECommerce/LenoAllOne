namespace EigenbelegToolAlpha
{
    partial class EvaluationCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationCalculation));
            this.label20 = new System.Windows.Forms.Label();
            this.btn_ExecuteAllAlgorithms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(22, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 29);
            this.label20.TabIndex = 130;
            this.label20.Text = "Kalkulationen";
            // 
            // btn_ExecuteAllAlgorithms
            // 
            this.btn_ExecuteAllAlgorithms.Location = new System.Drawing.Point(265, 24);
            this.btn_ExecuteAllAlgorithms.Name = "btn_ExecuteAllAlgorithms";
            this.btn_ExecuteAllAlgorithms.Size = new System.Drawing.Size(175, 29);
            this.btn_ExecuteAllAlgorithms.TabIndex = 194;
            this.btn_ExecuteAllAlgorithms.Text = "Algorithmen ausführen";
            this.btn_ExecuteAllAlgorithms.UseVisualStyleBackColor = true;
            this.btn_ExecuteAllAlgorithms.Click += new System.EventHandler(this.btn_ExecuteAllAlgorithms_Click);
            // 
            // EvaluationCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 606);
            this.Controls.Add(this.btn_ExecuteAllAlgorithms);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvaluationCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswertung: Berechnungen";
            this.Load += new System.EventHandler(this.EvaluationCalculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_ExecuteAllAlgorithms;
    }
}