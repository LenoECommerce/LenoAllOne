namespace EigenbelegToolAlpha
{
    partial class EvaluationRunningCosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationRunningCosts));
            this.runningcostsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.runningcostsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // runningcostsDGV
            // 
            this.runningcostsDGV.AllowUserToAddRows = false;
            this.runningcostsDGV.AllowUserToDeleteRows = false;
            this.runningcostsDGV.AllowUserToResizeColumns = false;
            this.runningcostsDGV.AllowUserToResizeRows = false;
            this.runningcostsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.runningcostsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.runningcostsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runningcostsDGV.Location = new System.Drawing.Point(63, 110);
            this.runningcostsDGV.Name = "runningcostsDGV";
            this.runningcostsDGV.ReadOnly = true;
            this.runningcostsDGV.RowHeadersVisible = false;
            this.runningcostsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.runningcostsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.runningcostsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.runningcostsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.runningcostsDGV.Size = new System.Drawing.Size(1160, 524);
            this.runningcostsDGV.TabIndex = 6;
            this.runningcostsDGV.TabStop = false;
            this.runningcostsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.runningcostsDGV_CellClick);
            this.runningcostsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.runningcostsDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hauptfunktionen";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(371, 63);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 26);
            this.btn_delete.TabIndex = 48;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(227, 63);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(121, 26);
            this.btn_Edit.TabIndex = 47;
            this.btn_Edit.Text = "Bearbeiten";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Location = new System.Drawing.Point(80, 63);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(121, 26);
            this.btn_Create.TabIndex = 46;
            this.btn_Create.Text = "Erstellen";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // EvaluationRunningCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1297, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.runningcostsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvaluationRunningCosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laufende Kosten bearbeiten";
            this.Load += new System.EventHandler(this.EvaluationRunningCosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runningcostsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView runningcostsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Create;
    }
}