namespace EigenbelegToolAlpha
{
    partial class Protokollierung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Protokollierung));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_protokollierungDelete = new System.Windows.Forms.Button();
            this.btn_protokollierungEdit = new System.Windows.Forms.Button();
            this.btn_protokollierungCreate = new System.Windows.Forms.Button();
            this.protokollierungDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fensterwechselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_OrderID = new System.Windows.Forms.TextBox();
            this.textBox_IMEI = new System.Windows.Forms.TextBox();
            this.textBox_InternalNumber = new System.Windows.Forms.TextBox();
            this.textBox_ScanDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Months = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Marketplace = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_BulkEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.protokollierungDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Hauptfunktionen";
            // 
            // btn_protokollierungDelete
            // 
            this.btn_protokollierungDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_protokollierungDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_protokollierungDelete.Location = new System.Drawing.Point(379, 214);
            this.btn_protokollierungDelete.Name = "btn_protokollierungDelete";
            this.btn_protokollierungDelete.Size = new System.Drawing.Size(134, 26);
            this.btn_protokollierungDelete.TabIndex = 45;
            this.btn_protokollierungDelete.Text = "Löschen";
            this.btn_protokollierungDelete.UseVisualStyleBackColor = false;
            this.btn_protokollierungDelete.Click += new System.EventHandler(this.btn_protokollierungDelete_Click);
            // 
            // btn_protokollierungEdit
            // 
            this.btn_protokollierungEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_protokollierungEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_protokollierungEdit.Location = new System.Drawing.Point(222, 214);
            this.btn_protokollierungEdit.Name = "btn_protokollierungEdit";
            this.btn_protokollierungEdit.Size = new System.Drawing.Size(134, 26);
            this.btn_protokollierungEdit.TabIndex = 44;
            this.btn_protokollierungEdit.Text = "Bearbeiten";
            this.btn_protokollierungEdit.UseVisualStyleBackColor = false;
            this.btn_protokollierungEdit.Click += new System.EventHandler(this.btn_protokollierungEdit_Click);
            // 
            // btn_protokollierungCreate
            // 
            this.btn_protokollierungCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_protokollierungCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_protokollierungCreate.Location = new System.Drawing.Point(61, 214);
            this.btn_protokollierungCreate.Name = "btn_protokollierungCreate";
            this.btn_protokollierungCreate.Size = new System.Drawing.Size(134, 26);
            this.btn_protokollierungCreate.TabIndex = 43;
            this.btn_protokollierungCreate.Text = "Erstellen";
            this.btn_protokollierungCreate.UseVisualStyleBackColor = false;
            this.btn_protokollierungCreate.Click += new System.EventHandler(this.btn_reparaturenCreate_Click);
            // 
            // protokollierungDGV
            // 
            this.protokollierungDGV.AllowUserToAddRows = false;
            this.protokollierungDGV.AllowUserToDeleteRows = false;
            this.protokollierungDGV.AllowUserToResizeColumns = false;
            this.protokollierungDGV.AllowUserToResizeRows = false;
            this.protokollierungDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.protokollierungDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.protokollierungDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.protokollierungDGV.Location = new System.Drawing.Point(45, 262);
            this.protokollierungDGV.Name = "protokollierungDGV";
            this.protokollierungDGV.ReadOnly = true;
            this.protokollierungDGV.RowHeadersVisible = false;
            this.protokollierungDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.protokollierungDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.protokollierungDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.protokollierungDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.protokollierungDGV.Size = new System.Drawing.Size(1153, 540);
            this.protokollierungDGV.TabIndex = 47;
            this.protokollierungDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.protokollierungDGV_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterwechselToolStripMenuItem,
            this.sucheToolStripMenuItem,
            this.auswertungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fensterwechselToolStripMenuItem
            // 
            this.fensterwechselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eigenbelegeToolStripMenuItem,
            this.protokollierungToolStripMenuItem,
            this.proofingToolStripMenuItem});
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
            // proofingToolStripMenuItem
            // 
            this.proofingToolStripMenuItem.Name = "proofingToolStripMenuItem";
            this.proofingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proofingToolStripMenuItem.Text = "Proofing";
            this.proofingToolStripMenuItem.Click += new System.EventHandler(this.proofingToolStripMenuItem_Click);
            // 
            // sucheToolStripMenuItem
            // 
            this.sucheToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.suche;
            this.sucheToolStripMenuItem.Name = "sucheToolStripMenuItem";
            this.sucheToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sucheToolStripMenuItem.Text = "Suche";
            this.sucheToolStripMenuItem.Click += new System.EventHandler(this.sucheToolStripMenuItem_Click);
            // 
            // auswertungToolStripMenuItem
            // 
            this.auswertungToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.evaluations;
            this.auswertungToolStripMenuItem.Name = "auswertungToolStripMenuItem";
            this.auswertungToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.auswertungToolStripMenuItem.Text = "Auswertungen";
            this.auswertungToolStripMenuItem.Click += new System.EventHandler(this.auswertungToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "Felder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Bestellnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Marktplatz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(392, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "IMEI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(743, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Intern";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(743, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Scandatum";
            // 
            // textBox_OrderID
            // 
            this.textBox_OrderID.Location = new System.Drawing.Point(178, 92);
            this.textBox_OrderID.Name = "textBox_OrderID";
            this.textBox_OrderID.Size = new System.Drawing.Size(178, 20);
            this.textBox_OrderID.TabIndex = 57;
            this.textBox_OrderID.TextChanged += new System.EventHandler(this.textBox_OrderID_TextChanged);
            // 
            // textBox_IMEI
            // 
            this.textBox_IMEI.Location = new System.Drawing.Point(494, 92);
            this.textBox_IMEI.Name = "textBox_IMEI";
            this.textBox_IMEI.Size = new System.Drawing.Size(178, 20);
            this.textBox_IMEI.TabIndex = 59;
            // 
            // textBox_InternalNumber
            // 
            this.textBox_InternalNumber.Location = new System.Drawing.Point(854, 93);
            this.textBox_InternalNumber.Name = "textBox_InternalNumber";
            this.textBox_InternalNumber.Size = new System.Drawing.Size(178, 20);
            this.textBox_InternalNumber.TabIndex = 61;
            // 
            // textBox_ScanDate
            // 
            this.textBox_ScanDate.Location = new System.Drawing.Point(854, 124);
            this.textBox_ScanDate.Name = "textBox_ScanDate";
            this.textBox_ScanDate.Size = new System.Drawing.Size(178, 20);
            this.textBox_ScanDate.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(684, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 26);
            this.button1.TabIndex = 63;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Months
            // 
            this.comboBox_Months.FormattingEnabled = true;
            this.comboBox_Months.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "März",
            "April",
            "Mai",
            "Juni",
            "Juli",
            "August",
            "September",
            "Oktober",
            "November",
            "Dezember"});
            this.comboBox_Months.Location = new System.Drawing.Point(494, 124);
            this.comboBox_Months.Name = "comboBox_Months";
            this.comboBox_Months.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Months.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(392, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Monat";
            // 
            // comboBox_Marketplace
            // 
            this.comboBox_Marketplace.FormattingEnabled = true;
            this.comboBox_Marketplace.Items.AddRange(new object[] {
            "BackMarket",
            "Ebay"});
            this.comboBox_Marketplace.Location = new System.Drawing.Point(178, 124);
            this.comboBox_Marketplace.Name = "comboBox_Marketplace";
            this.comboBox_Marketplace.Size = new System.Drawing.Size(178, 21);
            this.comboBox_Marketplace.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1064, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 26);
            this.button2.TabIndex = 66;
            this.button2.Text = "Manueller Datenimport";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(535, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 26);
            this.button3.TabIndex = 67;
            this.button3.Text = "Alle löschen";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_BulkEditor
            // 
            this.btn_BulkEditor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_BulkEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BulkEditor.Location = new System.Drawing.Point(924, 214);
            this.btn_BulkEditor.Name = "btn_BulkEditor";
            this.btn_BulkEditor.Size = new System.Drawing.Size(134, 26);
            this.btn_BulkEditor.TabIndex = 69;
            this.btn_BulkEditor.Text = "Bulk Editor";
            this.btn_BulkEditor.UseVisualStyleBackColor = false;
            this.btn_BulkEditor.Click += new System.EventHandler(this.btn_BulkEditor_Click);
            // 
            // Protokollierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.btn_BulkEditor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_Marketplace);
            this.Controls.Add(this.comboBox_Months);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ScanDate);
            this.Controls.Add(this.textBox_InternalNumber);
            this.Controls.Add(this.textBox_IMEI);
            this.Controls.Add(this.textBox_OrderID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.protokollierungDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_protokollierungDelete);
            this.Controls.Add(this.btn_protokollierungEdit);
            this.Controls.Add(this.btn_protokollierungCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Protokollierung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protokollierung";
            this.Load += new System.EventHandler(this.Protokollierung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protokollierungDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_protokollierungDelete;
        private System.Windows.Forms.Button btn_protokollierungEdit;
        private System.Windows.Forms.Button btn_protokollierungCreate;
        public System.Windows.Forms.DataGridView protokollierungDGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fensterwechselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_OrderID;
        private System.Windows.Forms.TextBox textBox_IMEI;
        private System.Windows.Forms.TextBox textBox_InternalNumber;
        private System.Windows.Forms.TextBox textBox_ScanDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Months;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Marketplace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_BulkEditor;
        private System.Windows.Forms.ToolStripMenuItem proofingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswertungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheToolStripMenuItem;
    }
}