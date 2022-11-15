namespace EigenbelegToolAlpha
{
    partial class FolderInstaCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderInstaCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_minimum = new System.Windows.Forms.TextBox();
            this.textBox_maximum = new System.Windows.Forms.TextBox();
            this.btn_folderCreateExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum";
            // 
            // textBox_minimum
            // 
            this.textBox_minimum.Location = new System.Drawing.Point(178, 48);
            this.textBox_minimum.Name = "textBox_minimum";
            this.textBox_minimum.Size = new System.Drawing.Size(100, 20);
            this.textBox_minimum.TabIndex = 2;
            // 
            // textBox_maximum
            // 
            this.textBox_maximum.Location = new System.Drawing.Point(178, 92);
            this.textBox_maximum.Name = "textBox_maximum";
            this.textBox_maximum.Size = new System.Drawing.Size(100, 20);
            this.textBox_maximum.TabIndex = 3;
            // 
            // btn_folderCreateExecute
            // 
            this.btn_folderCreateExecute.Location = new System.Drawing.Point(203, 137);
            this.btn_folderCreateExecute.Name = "btn_folderCreateExecute";
            this.btn_folderCreateExecute.Size = new System.Drawing.Size(75, 23);
            this.btn_folderCreateExecute.TabIndex = 4;
            this.btn_folderCreateExecute.Text = "Ausführen";
            this.btn_folderCreateExecute.UseVisualStyleBackColor = true;
            this.btn_folderCreateExecute.Click += new System.EventHandler(this.btn_folderCreateExecute_Click);
            // 
            // FolderInstaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 219);
            this.Controls.Add(this.btn_folderCreateExecute);
            this.Controls.Add(this.textBox_maximum);
            this.Controls.Add(this.textBox_minimum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FolderInstaCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordner erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_minimum;
        private System.Windows.Forms.TextBox textBox_maximum;
        private System.Windows.Forms.Button btn_folderCreateExecute;
    }
}