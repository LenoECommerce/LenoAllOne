namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback));
            this.Btn_AllinfosThere = new System.Windows.Forms.Button();
            this.Btn_MissingInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_AllinfosThere
            // 
            this.Btn_AllinfosThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AllinfosThere.Location = new System.Drawing.Point(65, 31);
            this.Btn_AllinfosThere.Name = "Btn_AllinfosThere";
            this.Btn_AllinfosThere.Size = new System.Drawing.Size(419, 54);
            this.Btn_AllinfosThere.TabIndex = 0;
            this.Btn_AllinfosThere.Text = "Alle Informationen vorhanden: Zahlung";
            this.Btn_AllinfosThere.UseVisualStyleBackColor = true;
            this.Btn_AllinfosThere.Click += new System.EventHandler(this.Btn_AllinfosThere_Click);
            // 
            // Btn_MissingInformation
            // 
            this.Btn_MissingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MissingInformation.Location = new System.Drawing.Point(65, 109);
            this.Btn_MissingInformation.Name = "Btn_MissingInformation";
            this.Btn_MissingInformation.Size = new System.Drawing.Size(419, 54);
            this.Btn_MissingInformation.TabIndex = 1;
            this.Btn_MissingInformation.Text = "Fehlende Informationen: Nachfrage";
            this.Btn_MissingInformation.UseVisualStyleBackColor = true;
            this.Btn_MissingInformation.Click += new System.EventHandler(this.Btn_MissingInformation_Click);
            // 
            // ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(556, 212);
            this.Controls.Add(this.Btn_MissingInformation);
            this.Controls.Add(this.Btn_AllinfosThere);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erste Rückmeldung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AllinfosThere;
        private System.Windows.Forms.Button Btn_MissingInformation;
    }
}