namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_Request));
            this.btn_GetBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetBack
            // 
            this.btn_GetBack.Location = new System.Drawing.Point(680, 12);
            this.btn_GetBack.Name = "btn_GetBack";
            this.btn_GetBack.Size = new System.Drawing.Size(108, 28);
            this.btn_GetBack.TabIndex = 1;
            this.btn_GetBack.Text = "Zurück";
            this.btn_GetBack.UseVisualStyleBackColor = true;
            this.btn_GetBack.Click += new System.EventHandler(this.btn_GetBack_Click);
            // 
            // ServiceB2CAnkauf_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GetBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anfrage bearbeiten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetBack;
    }
}