namespace EigenbelegToolAlpha
{
    partial class B2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B2B));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.btn_SelectAllRows = new System.Windows.Forms.Button();
            this.btn_eigenbelegRemove = new System.Windows.Forms.Button();
            this.btn_eigenbelegEdit = new System.Windows.Forms.Button();
            this.btn_eigenbelegCreate = new System.Windows.Forms.Button();
            this.b2bDGV = new System.Windows.Forms.DataGridView();
            this.Btn_CreateOffer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fensterwechselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.b2bDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Hauptfunktionen";
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteAll.ForeColor = System.Drawing.Color.Black;
            this.btn_DeleteAll.Location = new System.Drawing.Point(1076, 144);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(134, 26);
            this.btn_DeleteAll.TabIndex = 51;
            this.btn_DeleteAll.Text = "Alles löschen";
            this.btn_DeleteAll.UseVisualStyleBackColor = false;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // btn_SelectAllRows
            // 
            this.btn_SelectAllRows.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SelectAllRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAllRows.ForeColor = System.Drawing.Color.Black;
            this.btn_SelectAllRows.Location = new System.Drawing.Point(913, 144);
            this.btn_SelectAllRows.Name = "btn_SelectAllRows";
            this.btn_SelectAllRows.Size = new System.Drawing.Size(134, 26);
            this.btn_SelectAllRows.TabIndex = 50;
            this.btn_SelectAllRows.Text = "Alles auswählen";
            this.btn_SelectAllRows.UseVisualStyleBackColor = false;
            this.btn_SelectAllRows.Click += new System.EventHandler(this.btn_SelectAllRows_Click);
            // 
            // btn_eigenbelegRemove
            // 
            this.btn_eigenbelegRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eigenbelegRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eigenbelegRemove.Location = new System.Drawing.Point(364, 144);
            this.btn_eigenbelegRemove.Name = "btn_eigenbelegRemove";
            this.btn_eigenbelegRemove.Size = new System.Drawing.Size(121, 26);
            this.btn_eigenbelegRemove.TabIndex = 49;
            this.btn_eigenbelegRemove.Text = "Löschen";
            this.btn_eigenbelegRemove.UseVisualStyleBackColor = false;
            this.btn_eigenbelegRemove.Click += new System.EventHandler(this.btn_eigenbelegRemove_Click);
            // 
            // btn_eigenbelegEdit
            // 
            this.btn_eigenbelegEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eigenbelegEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eigenbelegEdit.Location = new System.Drawing.Point(217, 144);
            this.btn_eigenbelegEdit.Name = "btn_eigenbelegEdit";
            this.btn_eigenbelegEdit.Size = new System.Drawing.Size(121, 26);
            this.btn_eigenbelegEdit.TabIndex = 48;
            this.btn_eigenbelegEdit.Text = "Bearbeiten";
            this.btn_eigenbelegEdit.UseVisualStyleBackColor = false;
            this.btn_eigenbelegEdit.Click += new System.EventHandler(this.btn_eigenbelegEdit_Click);
            // 
            // btn_eigenbelegCreate
            // 
            this.btn_eigenbelegCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eigenbelegCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eigenbelegCreate.Location = new System.Drawing.Point(73, 144);
            this.btn_eigenbelegCreate.Name = "btn_eigenbelegCreate";
            this.btn_eigenbelegCreate.Size = new System.Drawing.Size(121, 26);
            this.btn_eigenbelegCreate.TabIndex = 47;
            this.btn_eigenbelegCreate.Text = "Erstellen";
            this.btn_eigenbelegCreate.UseVisualStyleBackColor = false;
            this.btn_eigenbelegCreate.Click += new System.EventHandler(this.btn_eigenbelegCreate_Click);
            // 
            // b2bDGV
            // 
            this.b2bDGV.AllowUserToAddRows = false;
            this.b2bDGV.AllowUserToDeleteRows = false;
            this.b2bDGV.AllowUserToResizeColumns = false;
            this.b2bDGV.AllowUserToResizeRows = false;
            this.b2bDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.b2bDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.b2bDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.b2bDGV.Location = new System.Drawing.Point(55, 190);
            this.b2bDGV.Name = "b2bDGV";
            this.b2bDGV.ReadOnly = true;
            this.b2bDGV.RowHeadersVisible = false;
            this.b2bDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b2bDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.b2bDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.b2bDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.b2bDGV.Size = new System.Drawing.Size(1153, 533);
            this.b2bDGV.TabIndex = 46;
            this.b2bDGV.TabStop = false;
            this.b2bDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.b2bDGV_CellClick);
            // 
            // Btn_CreateOffer
            // 
            this.Btn_CreateOffer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_CreateOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateOffer.Location = new System.Drawing.Point(73, 41);
            this.Btn_CreateOffer.Name = "Btn_CreateOffer";
            this.Btn_CreateOffer.Size = new System.Drawing.Size(186, 37);
            this.Btn_CreateOffer.TabIndex = 53;
            this.Btn_CreateOffer.Text = "Angebot erstellen";
            this.Btn_CreateOffer.UseVisualStyleBackColor = false;
            this.Btn_CreateOffer.Click += new System.EventHandler(this.Btn_CreateOffer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterwechselToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fensterwechselToolStripMenuItem
            // 
            this.fensterwechselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eigenbelegeToolStripMenuItem1,
            this.eigenbelegeToolStripMenuItem,
            this.protokollierungToolStripMenuItem,
            this.proofingToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.fensterwechselToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.windowsvg;
            this.fensterwechselToolStripMenuItem.Name = "fensterwechselToolStripMenuItem";
            this.fensterwechselToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.fensterwechselToolStripMenuItem.Text = "Fensterwechsel";
            // 
            // eigenbelegeToolStripMenuItem1
            // 
            this.eigenbelegeToolStripMenuItem1.Name = "eigenbelegeToolStripMenuItem1";
            this.eigenbelegeToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.eigenbelegeToolStripMenuItem1.Text = "Eigenbelege";
            this.eigenbelegeToolStripMenuItem1.Click += new System.EventHandler(this.eigenbelegeToolStripMenuItem1_Click);
            // 
            // eigenbelegeToolStripMenuItem
            // 
            this.eigenbelegeToolStripMenuItem.Name = "eigenbelegeToolStripMenuItem";
            this.eigenbelegeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eigenbelegeToolStripMenuItem.Text = "Reparaturen";
            this.eigenbelegeToolStripMenuItem.Click += new System.EventHandler(this.eigenbelegeToolStripMenuItem_Click);
            // 
            // protokollierungToolStripMenuItem
            // 
            this.protokollierungToolStripMenuItem.Name = "protokollierungToolStripMenuItem";
            this.protokollierungToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.protokollierungToolStripMenuItem.Text = "Protokollierung";
            this.protokollierungToolStripMenuItem.Click += new System.EventHandler(this.protokollierungToolStripMenuItem_Click);
            // 
            // proofingToolStripMenuItem
            // 
            this.proofingToolStripMenuItem.Name = "proofingToolStripMenuItem";
            this.proofingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.proofingToolStripMenuItem.Text = "Proofing";
            this.proofingToolStripMenuItem.Click += new System.EventHandler(this.proofingToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.Btn_Refresh.Location = new System.Drawing.Point(1076, 101);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(132, 26);
            this.Btn_Refresh.TabIndex = 55;
            this.Btn_Refresh.Text = "Aktualisieren";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // B2B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EigenbelegToolAlpha.Properties.Resources.office_gfeb180cfc_1280;
            this.ClientSize = new System.Drawing.Size(1264, 836);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Btn_CreateOffer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.btn_SelectAllRows);
            this.Controls.Add(this.btn_eigenbelegRemove);
            this.Controls.Add(this.btn_eigenbelegEdit);
            this.Controls.Add(this.btn_eigenbelegCreate);
            this.Controls.Add(this.b2bDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "B2B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B2B";
            this.Load += new System.EventHandler(this.B2B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b2bDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.Button btn_SelectAllRows;
        private System.Windows.Forms.Button btn_eigenbelegRemove;
        private System.Windows.Forms.Button btn_eigenbelegEdit;
        private System.Windows.Forms.Button btn_eigenbelegCreate;
        public System.Windows.Forms.DataGridView b2bDGV;
        private System.Windows.Forms.Button Btn_CreateOffer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fensterwechselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proofingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem1;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}