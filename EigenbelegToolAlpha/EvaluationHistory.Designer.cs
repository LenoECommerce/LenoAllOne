namespace EigenbelegToolAlpha
{
    partial class EvaluationHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationHistory));
            this.label10 = new System.Windows.Forms.Label();
            this.combobox_SelectedYear = new System.Windows.Forms.ComboBox();
            this.btn_DownloadReport = new System.Windows.Forms.Button();
            this.evaluationsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 110;
            this.label10.Text = "Jahr";
            // 
            // combobox_SelectedYear
            // 
            this.combobox_SelectedYear.FormattingEnabled = true;
            this.combobox_SelectedYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.combobox_SelectedYear.Location = new System.Drawing.Point(140, 22);
            this.combobox_SelectedYear.Name = "combobox_SelectedYear";
            this.combobox_SelectedYear.Size = new System.Drawing.Size(121, 21);
            this.combobox_SelectedYear.TabIndex = 109;
            this.combobox_SelectedYear.Text = "2022";
            this.combobox_SelectedYear.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedYear_SelectedIndexChanged);
            // 
            // btn_DownloadReport
            // 
            this.btn_DownloadReport.Location = new System.Drawing.Point(588, 17);
            this.btn_DownloadReport.Name = "btn_DownloadReport";
            this.btn_DownloadReport.Size = new System.Drawing.Size(132, 31);
            this.btn_DownloadReport.TabIndex = 111;
            this.btn_DownloadReport.Text = "Downloaden";
            this.btn_DownloadReport.UseVisualStyleBackColor = true;
            this.btn_DownloadReport.Click += new System.EventHandler(this.btn_DownloadReport_Click);
            // 
            // evaluationsDGV
            // 
            this.evaluationsDGV.AllowUserToAddRows = false;
            this.evaluationsDGV.AllowUserToDeleteRows = false;
            this.evaluationsDGV.AllowUserToResizeColumns = false;
            this.evaluationsDGV.AllowUserToResizeRows = false;
            this.evaluationsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.evaluationsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.evaluationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evaluationsDGV.Location = new System.Drawing.Point(62, 85);
            this.evaluationsDGV.Name = "evaluationsDGV";
            this.evaluationsDGV.ReadOnly = true;
            this.evaluationsDGV.RowHeadersVisible = false;
            this.evaluationsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.evaluationsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.evaluationsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.evaluationsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evaluationsDGV.Size = new System.Drawing.Size(658, 309);
            this.evaluationsDGV.TabIndex = 112;
            this.evaluationsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evaluationsDGV_CellClick);
            // 
            // EvaluationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 456);
            this.Controls.Add(this.evaluationsDGV);
            this.Controls.Add(this.btn_DownloadReport);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combobox_SelectedYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvaluationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswertungen Übersicht";
            this.Load += new System.EventHandler(this.EvaluationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combobox_SelectedYear;
        private System.Windows.Forms.Button btn_DownloadReport;
        public System.Windows.Forms.DataGridView evaluationsDGV;
    }
}