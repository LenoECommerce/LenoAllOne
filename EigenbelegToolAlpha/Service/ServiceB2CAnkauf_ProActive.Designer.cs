namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_ProActive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_ProActive));
            this.btn_GetBack = new System.Windows.Forms.Button();
            this.Btn_FirstRequest = new System.Windows.Forms.Button();
            this.Btn_Feedback = new System.Windows.Forms.Button();
            this.Btn_CommonQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetBack
            // 
            this.btn_GetBack.Location = new System.Drawing.Point(516, 12);
            this.btn_GetBack.Name = "btn_GetBack";
            this.btn_GetBack.Size = new System.Drawing.Size(108, 28);
            this.btn_GetBack.TabIndex = 0;
            this.btn_GetBack.Text = "Zurück";
            this.btn_GetBack.UseVisualStyleBackColor = true;
            this.btn_GetBack.Click += new System.EventHandler(this.btn_GetBack_Click);
            // 
            // Btn_FirstRequest
            // 
            this.Btn_FirstRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FirstRequest.Location = new System.Drawing.Point(120, 63);
            this.Btn_FirstRequest.Name = "Btn_FirstRequest";
            this.Btn_FirstRequest.Size = new System.Drawing.Size(374, 59);
            this.Btn_FirstRequest.TabIndex = 1;
            this.Btn_FirstRequest.Text = "Erste Anfrage";
            this.Btn_FirstRequest.UseVisualStyleBackColor = true;
            this.Btn_FirstRequest.Click += new System.EventHandler(this.Btn_FirstRequest_Click);
            // 
            // Btn_Feedback
            // 
            this.Btn_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Feedback.Location = new System.Drawing.Point(120, 145);
            this.Btn_Feedback.Name = "Btn_Feedback";
            this.Btn_Feedback.Size = new System.Drawing.Size(374, 59);
            this.Btn_Feedback.TabIndex = 2;
            this.Btn_Feedback.Text = "Rückmeldungen";
            this.Btn_Feedback.UseVisualStyleBackColor = true;
            this.Btn_Feedback.Click += new System.EventHandler(this.Btn_Feedback_Click);
            // 
            // Btn_CommonQuestions
            // 
            this.Btn_CommonQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CommonQuestions.Location = new System.Drawing.Point(120, 232);
            this.Btn_CommonQuestions.Name = "Btn_CommonQuestions";
            this.Btn_CommonQuestions.Size = new System.Drawing.Size(374, 59);
            this.Btn_CommonQuestions.TabIndex = 3;
            this.Btn_CommonQuestions.Text = "Häufige Rückfragen";
            this.Btn_CommonQuestions.UseVisualStyleBackColor = true;
            this.Btn_CommonQuestions.Click += new System.EventHandler(this.Btn_CommonQuestions_Click);
            // 
            // ServiceB2CAnkauf_ProActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 345);
            this.Controls.Add(this.Btn_CommonQuestions);
            this.Controls.Add(this.Btn_Feedback);
            this.Controls.Add(this.Btn_FirstRequest);
            this.Controls.Add(this.btn_GetBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_ProActive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proaktiver Ankauf";
            this.Load += new System.EventHandler(this.ServiceB2CAnkauf_ProActive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetBack;
        private System.Windows.Forms.Button Btn_FirstRequest;
        private System.Windows.Forms.Button Btn_Feedback;
        private System.Windows.Forms.Button Btn_CommonQuestions;
    }
}