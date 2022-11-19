namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Was fehlt?";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Speicher",
            "Bilder",
            "Phone Doc Test",
            "iCloud",
            "Originalität"});
            this.listBox1.Location = new System.Drawing.Point(194, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Location = new System.Drawing.Point(194, 161);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(120, 29);
            this.Btn_Copy.TabIndex = 2;
            this.Btn_Copy.Text = "Kopieren";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(473, 236);
            this.Controls.Add(this.Btn_Copy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fehlende Informationen abfragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_Copy;
    }
}