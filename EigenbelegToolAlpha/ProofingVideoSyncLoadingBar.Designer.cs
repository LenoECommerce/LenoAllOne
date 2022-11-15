namespace EigenbelegToolAlpha
{
    partial class ProofingVideoSyncLoadingBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProofingVideoSyncLoadingBar));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_foundVideoData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_matchedVideos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 106);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 49);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(31, 20);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(168, 16);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "Videodateien gefunden";
            // 
            // lbl_foundVideoData
            // 
            this.lbl_foundVideoData.AutoSize = true;
            this.lbl_foundVideoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foundVideoData.Location = new System.Drawing.Point(214, 20);
            this.lbl_foundVideoData.Name = "lbl_foundVideoData";
            this.lbl_foundVideoData.Size = new System.Drawing.Size(147, 16);
            this.lbl_foundVideoData.TabIndex = 2;
            this.lbl_foundVideoData.Text = "Videodateien gefunden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gematchtes Video";
            // 
            // lbl_matchedVideos
            // 
            this.lbl_matchedVideos.AutoSize = true;
            this.lbl_matchedVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matchedVideos.Location = new System.Drawing.Point(214, 51);
            this.lbl_matchedVideos.Name = "lbl_matchedVideos";
            this.lbl_matchedVideos.Size = new System.Drawing.Size(147, 16);
            this.lbl_matchedVideos.TabIndex = 4;
            this.lbl_matchedVideos.Text = "Videodateien gefunden";
            // 
            // ProofingVideoSyncLoadingBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 196);
            this.Controls.Add(this.lbl_matchedVideos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_foundVideoData);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ProofingVideoSyncLoadingBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prozess läuft";
            this.Load += new System.EventHandler(this.ProofingVideoSyncLoadingBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_foundVideoData;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_matchedVideos;
    }
}