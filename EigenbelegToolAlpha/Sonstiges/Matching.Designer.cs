namespace EigenbelegToolAlpha
{
    partial class Matching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matching));
            this.matchingDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matchingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // matchingDGV
            // 
            this.matchingDGV.AllowUserToAddRows = false;
            this.matchingDGV.AllowUserToDeleteRows = false;
            this.matchingDGV.AllowUserToResizeColumns = false;
            this.matchingDGV.AllowUserToResizeRows = false;
            this.matchingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchingDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matchingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchingDGV.Location = new System.Drawing.Point(33, 92);
            this.matchingDGV.Name = "matchingDGV";
            this.matchingDGV.ReadOnly = true;
            this.matchingDGV.RowHeadersVisible = false;
            this.matchingDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.matchingDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.matchingDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.matchingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.matchingDGV.Size = new System.Drawing.Size(705, 288);
            this.matchingDGV.TabIndex = 6;
            // 
            // Matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matchingDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matching";
            this.Text = "Matching";
            this.Load += new System.EventHandler(this.Matching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchingDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView matchingDGV;
    }
}