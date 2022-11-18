namespace EigenbelegToolAlpha
{
    partial class Proofing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proofing));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fensterwechselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_InternalNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_proofingDeleteAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proofingDelete = new System.Windows.Forms.Button();
            this.btn_proofingEdit = new System.Windows.Forms.Button();
            this.btn_proofingCreate = new System.Windows.Forms.Button();
            this.proofingDGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Video = new System.Windows.Forms.TextBox();
            this.textBox_nsysCertificate = new System.Windows.Forms.TextBox();
            this.textBox_IMEI = new System.Windows.Forms.TextBox();
            this.btn_SyncTableWithNewData = new System.Windows.Forms.Button();
            this.folderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_CreateExcel = new System.Windows.Forms.Button();
            this.btn_certificateSyncing = new System.Windows.Forms.Button();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proofingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterwechselToolStripMenuItem,
            this.sucheToolStripMenuItem,
            this.auswertungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fensterwechselToolStripMenuItem
            // 
            this.fensterwechselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eigenbelegeToolStripMenuItem,
            this.protokollierungToolStripMenuItem,
            this.protokollierungToolStripMenuItem1,
            this.serviceToolStripMenuItem});
            this.fensterwechselToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.windowsvg;
            this.fensterwechselToolStripMenuItem.Name = "fensterwechselToolStripMenuItem";
            this.fensterwechselToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.fensterwechselToolStripMenuItem.Text = "Fensterwechsel";
            // 
            // eigenbelegeToolStripMenuItem
            // 
            this.eigenbelegeToolStripMenuItem.Name = "eigenbelegeToolStripMenuItem";
            this.eigenbelegeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eigenbelegeToolStripMenuItem.Text = "Reparaturen";
            this.eigenbelegeToolStripMenuItem.Click += new System.EventHandler(this.eigenbelegeToolStripMenuItem_Click);
            // 
            // protokollierungToolStripMenuItem
            // 
            this.protokollierungToolStripMenuItem.Name = "protokollierungToolStripMenuItem";
            this.protokollierungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.protokollierungToolStripMenuItem.Text = "Eigenbelege";
            this.protokollierungToolStripMenuItem.Click += new System.EventHandler(this.protokollierungToolStripMenuItem_Click);
            // 
            // protokollierungToolStripMenuItem1
            // 
            this.protokollierungToolStripMenuItem1.Name = "protokollierungToolStripMenuItem1";
            this.protokollierungToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.protokollierungToolStripMenuItem1.Text = "Protokollierung";
            this.protokollierungToolStripMenuItem1.Click += new System.EventHandler(this.protokollierungToolStripMenuItem1_Click);
            // 
            // sucheToolStripMenuItem
            // 
            this.sucheToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.suche;
            this.sucheToolStripMenuItem.Name = "sucheToolStripMenuItem";
            this.sucheToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sucheToolStripMenuItem.Text = "Suche";
            this.sucheToolStripMenuItem.Click += new System.EventHandler(this.sucheToolStripMenuItem_Click);
            // 
            // auswertungenToolStripMenuItem
            // 
            this.auswertungenToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.evaluations;
            this.auswertungenToolStripMenuItem.Name = "auswertungenToolStripMenuItem";
            this.auswertungenToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.auswertungenToolStripMenuItem.Text = "Auswertungen";
            this.auswertungenToolStripMenuItem.Click += new System.EventHandler(this.auswertungenToolStripMenuItem_Click);
            // 
            // textBox_InternalNumber
            // 
            this.textBox_InternalNumber.Location = new System.Drawing.Point(171, 81);
            this.textBox_InternalNumber.Name = "textBox_InternalNumber";
            this.textBox_InternalNumber.Size = new System.Drawing.Size(178, 20);
            this.textBox_InternalNumber.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "IMEI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Intern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 66;
            this.label2.Text = "Felder";
            // 
            // btn_proofingDeleteAll
            // 
            this.btn_proofingDeleteAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_proofingDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proofingDeleteAll.Location = new System.Drawing.Point(539, 197);
            this.btn_proofingDeleteAll.Name = "btn_proofingDeleteAll";
            this.btn_proofingDeleteAll.Size = new System.Drawing.Size(134, 26);
            this.btn_proofingDeleteAll.TabIndex = 76;
            this.btn_proofingDeleteAll.Text = "Alle löschen";
            this.btn_proofingDeleteAll.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 74;
            this.label1.Text = "Hauptfunktionen";
            // 
            // btn_proofingDelete
            // 
            this.btn_proofingDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_proofingDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proofingDelete.Location = new System.Drawing.Point(372, 197);
            this.btn_proofingDelete.Name = "btn_proofingDelete";
            this.btn_proofingDelete.Size = new System.Drawing.Size(134, 26);
            this.btn_proofingDelete.TabIndex = 73;
            this.btn_proofingDelete.Text = "Löschen";
            this.btn_proofingDelete.UseVisualStyleBackColor = false;
            this.btn_proofingDelete.Click += new System.EventHandler(this.btn_proofingDelete_Click);
            // 
            // btn_proofingEdit
            // 
            this.btn_proofingEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_proofingEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proofingEdit.Location = new System.Drawing.Point(215, 197);
            this.btn_proofingEdit.Name = "btn_proofingEdit";
            this.btn_proofingEdit.Size = new System.Drawing.Size(134, 26);
            this.btn_proofingEdit.TabIndex = 72;
            this.btn_proofingEdit.Text = "Bearbeiten";
            this.btn_proofingEdit.UseVisualStyleBackColor = false;
            this.btn_proofingEdit.Click += new System.EventHandler(this.btn_proofingEdit_Click);
            // 
            // btn_proofingCreate
            // 
            this.btn_proofingCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_proofingCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proofingCreate.Location = new System.Drawing.Point(54, 197);
            this.btn_proofingCreate.Name = "btn_proofingCreate";
            this.btn_proofingCreate.Size = new System.Drawing.Size(134, 26);
            this.btn_proofingCreate.TabIndex = 71;
            this.btn_proofingCreate.Text = "Erstellen";
            this.btn_proofingCreate.UseVisualStyleBackColor = false;
            this.btn_proofingCreate.Click += new System.EventHandler(this.btn_proofingCreate_Click);
            // 
            // proofingDGV
            // 
            this.proofingDGV.AllowUserToAddRows = false;
            this.proofingDGV.AllowUserToDeleteRows = false;
            this.proofingDGV.AllowUserToResizeColumns = false;
            this.proofingDGV.AllowUserToResizeRows = false;
            this.proofingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proofingDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.proofingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proofingDGV.Location = new System.Drawing.Point(36, 245);
            this.proofingDGV.Name = "proofingDGV";
            this.proofingDGV.ReadOnly = true;
            this.proofingDGV.RowHeadersVisible = false;
            this.proofingDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.proofingDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.proofingDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.proofingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proofingDGV.Size = new System.Drawing.Size(1153, 540);
            this.proofingDGV.TabIndex = 77;
            this.proofingDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proofingDGV_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(446, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Video";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "NSYS Zertifikat";
            // 
            // textBox_Video
            // 
            this.textBox_Video.Location = new System.Drawing.Point(578, 81);
            this.textBox_Video.Name = "textBox_Video";
            this.textBox_Video.Size = new System.Drawing.Size(178, 20);
            this.textBox_Video.TabIndex = 80;
            // 
            // textBox_nsysCertificate
            // 
            this.textBox_nsysCertificate.Location = new System.Drawing.Point(578, 114);
            this.textBox_nsysCertificate.Name = "textBox_nsysCertificate";
            this.textBox_nsysCertificate.Size = new System.Drawing.Size(178, 20);
            this.textBox_nsysCertificate.TabIndex = 81;
            // 
            // textBox_IMEI
            // 
            this.textBox_IMEI.Location = new System.Drawing.Point(171, 112);
            this.textBox_IMEI.Name = "textBox_IMEI";
            this.textBox_IMEI.Size = new System.Drawing.Size(178, 20);
            this.textBox_IMEI.TabIndex = 82;
            // 
            // btn_SyncTableWithNewData
            // 
            this.btn_SyncTableWithNewData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SyncTableWithNewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SyncTableWithNewData.Location = new System.Drawing.Point(1055, 197);
            this.btn_SyncTableWithNewData.Name = "btn_SyncTableWithNewData";
            this.btn_SyncTableWithNewData.Size = new System.Drawing.Size(134, 26);
            this.btn_SyncTableWithNewData.TabIndex = 83;
            this.btn_SyncTableWithNewData.Text = "Video Sync";
            this.btn_SyncTableWithNewData.UseVisualStyleBackColor = false;
            this.btn_SyncTableWithNewData.Click += new System.EventHandler(this.btn_SyncTableWithNewData_Click);
            // 
            // btn_CreateExcel
            // 
            this.btn_CreateExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CreateExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateExcel.Location = new System.Drawing.Point(898, 197);
            this.btn_CreateExcel.Name = "btn_CreateExcel";
            this.btn_CreateExcel.Size = new System.Drawing.Size(134, 26);
            this.btn_CreateExcel.TabIndex = 84;
            this.btn_CreateExcel.Text = "Excel erstellen";
            this.btn_CreateExcel.UseVisualStyleBackColor = false;
            this.btn_CreateExcel.Click += new System.EventHandler(this.btn_CreateExcel_Click);
            // 
            // btn_certificateSyncing
            // 
            this.btn_certificateSyncing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_certificateSyncing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_certificateSyncing.Location = new System.Drawing.Point(1055, 156);
            this.btn_certificateSyncing.Name = "btn_certificateSyncing";
            this.btn_certificateSyncing.Size = new System.Drawing.Size(134, 26);
            this.btn_certificateSyncing.TabIndex = 85;
            this.btn_certificateSyncing.Text = "Zertifikat Sync";
            this.btn_certificateSyncing.UseVisualStyleBackColor = false;
            this.btn_certificateSyncing.Click += new System.EventHandler(this.btn_certificateSyncing_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // Proofing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EigenbelegToolAlpha.Properties.Resources.office_gfeb180cfc_1280;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.btn_certificateSyncing);
            this.Controls.Add(this.btn_CreateExcel);
            this.Controls.Add(this.btn_SyncTableWithNewData);
            this.Controls.Add(this.textBox_IMEI);
            this.Controls.Add(this.textBox_nsysCertificate);
            this.Controls.Add(this.textBox_Video);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.proofingDGV);
            this.Controls.Add(this.btn_proofingDeleteAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_proofingDelete);
            this.Controls.Add(this.btn_proofingEdit);
            this.Controls.Add(this.btn_proofingCreate);
            this.Controls.Add(this.textBox_InternalNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Proofing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beweise";
            this.Load += new System.EventHandler(this.Proofing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proofingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fensterwechselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_InternalNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_proofingDeleteAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proofingDelete;
        private System.Windows.Forms.Button btn_proofingEdit;
        private System.Windows.Forms.Button btn_proofingCreate;
        public System.Windows.Forms.DataGridView proofingDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Video;
        private System.Windows.Forms.TextBox textBox_nsysCertificate;
        private System.Windows.Forms.TextBox textBox_IMEI;
        private System.Windows.Forms.Button btn_SyncTableWithNewData;
        private System.Windows.Forms.FolderBrowserDialog folderBD;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem1;
        private System.Windows.Forms.Button btn_CreateExcel;
        private System.Windows.Forms.Button btn_certificateSyncing;
        private System.Windows.Forms.ToolStripMenuItem auswertungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
    }
}