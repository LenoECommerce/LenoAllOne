namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_Selection));
            this.Btn_B2CAnkauf_ProActive = new System.Windows.Forms.Button();
            this.Btn_B2CAnkauf_Request = new System.Windows.Forms.Button();
            this.Btn_ContactProblem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_B2CAnkauf_ProActive
            // 
            this.Btn_B2CAnkauf_ProActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_B2CAnkauf_ProActive.Location = new System.Drawing.Point(62, 35);
            this.Btn_B2CAnkauf_ProActive.Name = "Btn_B2CAnkauf_ProActive";
            this.Btn_B2CAnkauf_ProActive.Size = new System.Drawing.Size(356, 59);
            this.Btn_B2CAnkauf_ProActive.TabIndex = 0;
            this.Btn_B2CAnkauf_ProActive.Text = "Proaktiv";
            this.Btn_B2CAnkauf_ProActive.UseVisualStyleBackColor = true;
            this.Btn_B2CAnkauf_ProActive.Click += new System.EventHandler(this.Btn_B2CAnkauf_ProActive_Click);
            // 
            // Btn_B2CAnkauf_Request
            // 
            this.Btn_B2CAnkauf_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_B2CAnkauf_Request.Location = new System.Drawing.Point(62, 121);
            this.Btn_B2CAnkauf_Request.Name = "Btn_B2CAnkauf_Request";
            this.Btn_B2CAnkauf_Request.Size = new System.Drawing.Size(356, 59);
            this.Btn_B2CAnkauf_Request.TabIndex = 1;
            this.Btn_B2CAnkauf_Request.Text = "Anfrage ";
            this.Btn_B2CAnkauf_Request.UseVisualStyleBackColor = true;
            this.Btn_B2CAnkauf_Request.Click += new System.EventHandler(this.Btn_B2CAnkauf_Request_Click);
            // 
            // Btn_ContactProblem
            // 
            this.Btn_ContactProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ContactProblem.Location = new System.Drawing.Point(62, 206);
            this.Btn_ContactProblem.Name = "Btn_ContactProblem";
            this.Btn_ContactProblem.Size = new System.Drawing.Size(356, 59);
            this.Btn_ContactProblem.TabIndex = 2;
            this.Btn_ContactProblem.Text = "Problemkontakt";
            this.Btn_ContactProblem.UseVisualStyleBackColor = true;
            this.Btn_ContactProblem.Click += new System.EventHandler(this.Btn_ContactProblem_Click);
            // 
            // ServiceB2CAnkauf_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 301);
            this.Controls.Add(this.Btn_ContactProblem);
            this.Controls.Add(this.Btn_B2CAnkauf_Request);
            this.Controls.Add(this.Btn_B2CAnkauf_ProActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswahl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_B2CAnkauf_ProActive;
        private System.Windows.Forms.Button Btn_B2CAnkauf_Request;
        private System.Windows.Forms.Button Btn_ContactProblem;
    }
}