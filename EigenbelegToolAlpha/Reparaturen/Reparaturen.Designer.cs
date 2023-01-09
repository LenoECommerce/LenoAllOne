namespace EigenbelegToolAlpha
{
    partial class Reparaturen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reparaturen));
            this.reparaturenDGV = new System.Windows.Forms.DataGridView();
            this.btn_reparaturenEdit = new System.Windows.Forms.Button();
            this.btn_reparaturenCreate = new System.Windows.Forms.Button();
            this.btn_reparaturenDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SwitchToRelatedEigenbeleg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fensterwechselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etikettenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptetikettToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xHauptetikettToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b2BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_WorkWithSpecificReparatur = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.reparaturenDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reparaturenDGV
            // 
            this.reparaturenDGV.AllowUserToAddRows = false;
            this.reparaturenDGV.AllowUserToDeleteRows = false;
            this.reparaturenDGV.AllowUserToResizeColumns = false;
            this.reparaturenDGV.AllowUserToResizeRows = false;
            this.reparaturenDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reparaturenDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reparaturenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reparaturenDGV.Location = new System.Drawing.Point(54, 306);
            this.reparaturenDGV.Name = "reparaturenDGV";
            this.reparaturenDGV.ReadOnly = true;
            this.reparaturenDGV.RowHeadersVisible = false;
            this.reparaturenDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reparaturenDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.reparaturenDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.reparaturenDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reparaturenDGV.Size = new System.Drawing.Size(1153, 432);
            this.reparaturenDGV.TabIndex = 29;
            this.reparaturenDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reparaturenDGV_CellClick);
            this.reparaturenDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reparaturenDGV_CellContentClick);
            // 
            // btn_reparaturenEdit
            // 
            this.btn_reparaturenEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reparaturenEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reparaturenEdit.Location = new System.Drawing.Point(232, 250);
            this.btn_reparaturenEdit.Name = "btn_reparaturenEdit";
            this.btn_reparaturenEdit.Size = new System.Drawing.Size(134, 26);
            this.btn_reparaturenEdit.TabIndex = 34;
            this.btn_reparaturenEdit.Text = "Bearbeiten";
            this.btn_reparaturenEdit.UseVisualStyleBackColor = false;
            this.btn_reparaturenEdit.Click += new System.EventHandler(this.btn_reparaturenEdit_Click);
            // 
            // btn_reparaturenCreate
            // 
            this.btn_reparaturenCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reparaturenCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reparaturenCreate.Location = new System.Drawing.Point(71, 250);
            this.btn_reparaturenCreate.Name = "btn_reparaturenCreate";
            this.btn_reparaturenCreate.Size = new System.Drawing.Size(134, 26);
            this.btn_reparaturenCreate.TabIndex = 32;
            this.btn_reparaturenCreate.Text = "Erstellen";
            this.btn_reparaturenCreate.UseVisualStyleBackColor = false;
            this.btn_reparaturenCreate.Click += new System.EventHandler(this.btn_reparaturenCreate_Click);
            // 
            // btn_reparaturenDelete
            // 
            this.btn_reparaturenDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reparaturenDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reparaturenDelete.Location = new System.Drawing.Point(389, 250);
            this.btn_reparaturenDelete.Name = "btn_reparaturenDelete";
            this.btn_reparaturenDelete.Size = new System.Drawing.Size(134, 26);
            this.btn_reparaturenDelete.TabIndex = 35;
            this.btn_reparaturenDelete.Text = "Löschen";
            this.btn_reparaturenDelete.UseVisualStyleBackColor = false;
            this.btn_reparaturenDelete.Click += new System.EventHandler(this.btn_reparaturenDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1109, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 36;
            this.button1.Text = "Aktualisieren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SwitchToRelatedEigenbeleg
            // 
            this.btn_SwitchToRelatedEigenbeleg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SwitchToRelatedEigenbeleg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SwitchToRelatedEigenbeleg.ForeColor = System.Drawing.Color.Black;
            this.btn_SwitchToRelatedEigenbeleg.Location = new System.Drawing.Point(71, 88);
            this.btn_SwitchToRelatedEigenbeleg.Name = "btn_SwitchToRelatedEigenbeleg";
            this.btn_SwitchToRelatedEigenbeleg.Size = new System.Drawing.Size(180, 26);
            this.btn_SwitchToRelatedEigenbeleg.TabIndex = 39;
            this.btn_SwitchToRelatedEigenbeleg.Text = "Zu Eigenbeleg springen";
            this.btn_SwitchToRelatedEigenbeleg.UseVisualStyleBackColor = false;
            this.btn_SwitchToRelatedEigenbeleg.Click += new System.EventHandler(this.btn_SwitchToRelatedEigenbeleg_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1109, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 40;
            this.button2.Text = "Einstellungen";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterwechselToolStripMenuItem,
            this.etikettenToolStripMenuItem,
            this.sucheToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.auswertungenToolStripMenuItem,
            this.b2BToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fensterwechselToolStripMenuItem
            // 
            this.fensterwechselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eigenbelegeToolStripMenuItem,
            this.protokollierungToolStripMenuItem,
            this.proofingToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.fensterwechselToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.windowsvg;
            this.fensterwechselToolStripMenuItem.Name = "fensterwechselToolStripMenuItem";
            this.fensterwechselToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.fensterwechselToolStripMenuItem.Text = "Fensterwechsel";
            // 
            // eigenbelegeToolStripMenuItem
            // 
            this.eigenbelegeToolStripMenuItem.Name = "eigenbelegeToolStripMenuItem";
            this.eigenbelegeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eigenbelegeToolStripMenuItem.Text = "Eigenbelege";
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
            // etikettenToolStripMenuItem
            // 
            this.etikettenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptetikettToolStripMenuItem,
            this.xHauptetikettToolStripMenuItem});
            this.etikettenToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.etikettenToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.print;
            this.etikettenToolStripMenuItem.Name = "etikettenToolStripMenuItem";
            this.etikettenToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.etikettenToolStripMenuItem.Text = "Etiketten";
            this.etikettenToolStripMenuItem.Click += new System.EventHandler(this.etikettenToolStripMenuItem_Click);
            // 
            // hauptetikettToolStripMenuItem
            // 
            this.hauptetikettToolStripMenuItem.Name = "hauptetikettToolStripMenuItem";
            this.hauptetikettToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.hauptetikettToolStripMenuItem.Text = "Hauptetikett";
            this.hauptetikettToolStripMenuItem.Click += new System.EventHandler(this.hauptetikettToolStripMenuItem_Click);
            // 
            // xHauptetikettToolStripMenuItem
            // 
            this.xHauptetikettToolStripMenuItem.Name = "xHauptetikettToolStripMenuItem";
            this.xHauptetikettToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.xHauptetikettToolStripMenuItem.Text = "2x Hauptetikett";
            this.xHauptetikettToolStripMenuItem.Click += new System.EventHandler(this.xHauptetikettToolStripMenuItem_Click);
            // 
            // sucheToolStripMenuItem
            // 
            this.sucheToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sucheToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.suche;
            this.sucheToolStripMenuItem.Name = "sucheToolStripMenuItem";
            this.sucheToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sucheToolStripMenuItem.Text = "Suche";
            this.sucheToolStripMenuItem.Click += new System.EventHandler(this.sucheToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.filter;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // auswertungenToolStripMenuItem
            // 
            this.auswertungenToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.evaluations;
            this.auswertungenToolStripMenuItem.Name = "auswertungenToolStripMenuItem";
            this.auswertungenToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.auswertungenToolStripMenuItem.Text = "Auswertungen";
            this.auswertungenToolStripMenuItem.Click += new System.EventHandler(this.auswertungenToolStripMenuItem_Click);
            // 
            // b2BToolStripMenuItem
            // 
            this.b2BToolStripMenuItem.Name = "b2BToolStripMenuItem";
            this.b2BToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.b2BToolStripMenuItem.Text = "B2B";
            this.b2BToolStripMenuItem.Click += new System.EventHandler(this.b2BToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Hauptfunktionen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Erweiterte Funktionen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1068, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "Einstellungen";
            // 
            // btn_WorkWithSpecificReparatur
            // 
            this.btn_WorkWithSpecificReparatur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_WorkWithSpecificReparatur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WorkWithSpecificReparatur.ForeColor = System.Drawing.Color.Black;
            this.btn_WorkWithSpecificReparatur.Location = new System.Drawing.Point(271, 88);
            this.btn_WorkWithSpecificReparatur.Name = "btn_WorkWithSpecificReparatur";
            this.btn_WorkWithSpecificReparatur.Size = new System.Drawing.Size(165, 26);
            this.btn_WorkWithSpecificReparatur.TabIndex = 45;
            this.btn_WorkWithSpecificReparatur.Text = "Reparatur Scan";
            this.btn_WorkWithSpecificReparatur.UseVisualStyleBackColor = false;
            this.btn_WorkWithSpecificReparatur.Click += new System.EventHandler(this.btn_WorkWithSpecificReparatur_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Reparaturen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.btn_WorkWithSpecificReparatur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_SwitchToRelatedEigenbeleg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reparaturenDelete);
            this.Controls.Add(this.btn_reparaturenEdit);
            this.Controls.Add(this.btn_reparaturenCreate);
            this.Controls.Add(this.reparaturenDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Reparaturen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparaturen";
            this.Load += new System.EventHandler(this.Reparaturen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reparaturenDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView reparaturenDGV;
        private System.Windows.Forms.Button btn_reparaturenEdit;
        private System.Windows.Forms.Button btn_reparaturenCreate;
        private System.Windows.Forms.Button btn_reparaturenDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SwitchToRelatedEigenbeleg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etikettenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptetikettToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_WorkWithSpecificReparatur;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.ToolStripMenuItem fensterwechselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xHauptetikettToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proofingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswertungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b2BToolStripMenuItem;
    }
}