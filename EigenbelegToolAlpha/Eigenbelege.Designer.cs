namespace EigenbelegToolAlpha
{
    partial class Eigenbelege
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eigenbelege));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_foundPath = new System.Windows.Forms.Label();
            this.eigenbelegeDGV = new System.Windows.Forms.DataGridView();
            this.btn_eigenbelegCreate = new System.Windows.Forms.Button();
            this.btn_eigenbelegEdit = new System.Windows.Forms.Button();
            this.btn_eigenbelegRemove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_PushToRep = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_SwitchToRelatedReparatur = new System.Windows.Forms.Button();
            this.btn_settings2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fensterwechselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b2CAnkaufToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b2BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lieferscheineMergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etikettenMergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMEIErkennungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_folderInstaCreate = new System.Windows.Forms.Button();
            this.btn_buybackPriceAdaptions = new System.Windows.Forms.Button();
            this.lbl_LastPayPalImport = new System.Windows.Forms.Label();
            this.lbl_LastBuyBackSync = new System.Windows.Forms.Label();
            this.btn_PrintLabelForSellOff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eigenbelegeDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 773);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "PayPal Daten Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_foundPath
            // 
            this.lbl_foundPath.AutoSize = true;
            this.lbl_foundPath.Location = new System.Drawing.Point(47, 373);
            this.lbl_foundPath.Name = "lbl_foundPath";
            this.lbl_foundPath.Size = new System.Drawing.Size(0, 13);
            this.lbl_foundPath.TabIndex = 1;
            // 
            // eigenbelegeDGV
            // 
            this.eigenbelegeDGV.AllowUserToAddRows = false;
            this.eigenbelegeDGV.AllowUserToDeleteRows = false;
            this.eigenbelegeDGV.AllowUserToResizeColumns = false;
            this.eigenbelegeDGV.AllowUserToResizeRows = false;
            this.eigenbelegeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eigenbelegeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.eigenbelegeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eigenbelegeDGV.Location = new System.Drawing.Point(61, 225);
            this.eigenbelegeDGV.Name = "eigenbelegeDGV";
            this.eigenbelegeDGV.ReadOnly = true;
            this.eigenbelegeDGV.RowHeadersVisible = false;
            this.eigenbelegeDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eigenbelegeDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.eigenbelegeDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eigenbelegeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eigenbelegeDGV.Size = new System.Drawing.Size(1153, 533);
            this.eigenbelegeDGV.TabIndex = 5;
            this.eigenbelegeDGV.TabStop = false;
            this.eigenbelegeDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eigenbelegeDGV_CellClick);
            this.eigenbelegeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eigenbelegeDGV_CellContentClick);
            // 
            // btn_eigenbelegCreate
            // 
            this.btn_eigenbelegCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eigenbelegCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eigenbelegCreate.Location = new System.Drawing.Point(79, 179);
            this.btn_eigenbelegCreate.Name = "btn_eigenbelegCreate";
            this.btn_eigenbelegCreate.Size = new System.Drawing.Size(121, 26);
            this.btn_eigenbelegCreate.TabIndex = 22;
            this.btn_eigenbelegCreate.Text = "Erstellen";
            this.btn_eigenbelegCreate.UseVisualStyleBackColor = false;
            this.btn_eigenbelegCreate.Click += new System.EventHandler(this.btn_eigenbelegCreate_Click);
            // 
            // btn_eigenbelegEdit
            // 
            this.btn_eigenbelegEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eigenbelegEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eigenbelegEdit.Location = new System.Drawing.Point(223, 179);
            this.btn_eigenbelegEdit.Name = "btn_eigenbelegEdit";
            this.btn_eigenbelegEdit.Size = new System.Drawing.Size(121, 26);
            this.btn_eigenbelegEdit.TabIndex = 23;
            this.btn_eigenbelegEdit.Text = "Bearbeiten";
            this.btn_eigenbelegEdit.UseVisualStyleBackColor = false;
            this.btn_eigenbelegEdit.Click += new System.EventHandler(this.btn_eigenbelegEdit_Click);
            // 
            // btn_eigenbelegRemove
            // 
            this.btn_eigenbelegRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_eigenbelegRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eigenbelegRemove.Location = new System.Drawing.Point(370, 179);
            this.btn_eigenbelegRemove.Name = "btn_eigenbelegRemove";
            this.btn_eigenbelegRemove.Size = new System.Drawing.Size(121, 26);
            this.btn_eigenbelegRemove.TabIndex = 24;
            this.btn_eigenbelegRemove.Text = "Löschen";
            this.btn_eigenbelegRemove.UseVisualStyleBackColor = false;
            this.btn_eigenbelegRemove.Click += new System.EventHandler(this.btn_eigenbelegRemove_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(79, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 26);
            this.button3.TabIndex = 26;
            this.button3.Text = "Eigenbeleg erstellen";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // btn_PushToRep
            // 
            this.btn_PushToRep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_PushToRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PushToRep.ForeColor = System.Drawing.Color.Black;
            this.btn_PushToRep.Location = new System.Drawing.Point(223, 80);
            this.btn_PushToRep.Name = "btn_PushToRep";
            this.btn_PushToRep.Size = new System.Drawing.Size(134, 26);
            this.btn_PushToRep.TabIndex = 35;
            this.btn_PushToRep.Text = "Als Reparatur erfassen";
            this.btn_PushToRep.UseVisualStyleBackColor = false;
            this.btn_PushToRep.Click += new System.EventHandler(this.btn_PushToRep_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1082, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 27);
            this.button5.TabIndex = 37;
            this.button5.Text = "Aktualisieren";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btn_SwitchToRelatedReparatur
            // 
            this.btn_SwitchToRelatedReparatur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SwitchToRelatedReparatur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SwitchToRelatedReparatur.ForeColor = System.Drawing.Color.Black;
            this.btn_SwitchToRelatedReparatur.Location = new System.Drawing.Point(370, 80);
            this.btn_SwitchToRelatedReparatur.Name = "btn_SwitchToRelatedReparatur";
            this.btn_SwitchToRelatedReparatur.Size = new System.Drawing.Size(134, 26);
            this.btn_SwitchToRelatedReparatur.TabIndex = 38;
            this.btn_SwitchToRelatedReparatur.Text = "Zu Reparatur springen";
            this.btn_SwitchToRelatedReparatur.UseVisualStyleBackColor = false;
            this.btn_SwitchToRelatedReparatur.Click += new System.EventHandler(this.btn_SwitchToRelatedReparatur_Click);
            // 
            // btn_settings2
            // 
            this.btn_settings2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings2.ForeColor = System.Drawing.Color.Black;
            this.btn_settings2.Location = new System.Drawing.Point(1082, 80);
            this.btn_settings2.Name = "btn_settings2";
            this.btn_settings2.Size = new System.Drawing.Size(134, 27);
            this.btn_settings2.TabIndex = 41;
            this.btn_settings2.Text = "Einstellungen";
            this.btn_settings2.UseVisualStyleBackColor = false;
            this.btn_settings2.Click += new System.EventHandler(this.btn_settings2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Erweiterte Funktionen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Hauptfunktionen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1071, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 46;
            this.label3.Text = "Einstellungen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterwechselToolStripMenuItem,
            this.sucheToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.auswertungenToolStripMenuItem,
            this.b2CAnkaufToolStripMenuItem,
            this.b2BToolStripMenuItem,
            this.lieferscheineMergeToolStripMenuItem,
            this.etikettenMergeToolStripMenuItem,
            this.regularSalesToolStripMenuItem,
            this.rEGCheckToolStripMenuItem,
            this.iMEIErkennungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 48;
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
            // sucheToolStripMenuItem
            // 
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
            // b2CAnkaufToolStripMenuItem
            // 
            this.b2CAnkaufToolStripMenuItem.Name = "b2CAnkaufToolStripMenuItem";
            this.b2CAnkaufToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.b2CAnkaufToolStripMenuItem.Text = "B2C Ankauf";
            this.b2CAnkaufToolStripMenuItem.Click += new System.EventHandler(this.b2CAnkaufToolStripMenuItem_Click);
            // 
            // b2BToolStripMenuItem
            // 
            this.b2BToolStripMenuItem.Name = "b2BToolStripMenuItem";
            this.b2BToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.b2BToolStripMenuItem.Text = "B2B";
            this.b2BToolStripMenuItem.Click += new System.EventHandler(this.b2BToolStripMenuItem_Click);
            // 
            // lieferscheineMergeToolStripMenuItem
            // 
            this.lieferscheineMergeToolStripMenuItem.Name = "lieferscheineMergeToolStripMenuItem";
            this.lieferscheineMergeToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.lieferscheineMergeToolStripMenuItem.Text = "Lieferscheine Merge";
            this.lieferscheineMergeToolStripMenuItem.Click += new System.EventHandler(this.lieferscheineMergeToolStripMenuItem_Click);
            // 
            // etikettenMergeToolStripMenuItem
            // 
            this.etikettenMergeToolStripMenuItem.Name = "etikettenMergeToolStripMenuItem";
            this.etikettenMergeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.etikettenMergeToolStripMenuItem.Text = "Etiketten Merge";
            this.etikettenMergeToolStripMenuItem.Click += new System.EventHandler(this.etikettenMergeToolStripMenuItem_Click);
            // 
            // regularSalesToolStripMenuItem
            // 
            this.regularSalesToolStripMenuItem.Name = "regularSalesToolStripMenuItem";
            this.regularSalesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.regularSalesToolStripMenuItem.Text = "Regular Sales ";
            this.regularSalesToolStripMenuItem.Click += new System.EventHandler(this.regularSalesToolStripMenuItem_Click);
            // 
            // rEGCheckToolStripMenuItem
            // 
            this.rEGCheckToolStripMenuItem.Name = "rEGCheckToolStripMenuItem";
            this.rEGCheckToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.rEGCheckToolStripMenuItem.Text = "REG Check";
            this.rEGCheckToolStripMenuItem.Click += new System.EventHandler(this.rEGCheckToolStripMenuItem_Click);
            // 
            // iMEIErkennungToolStripMenuItem
            // 
            this.iMEIErkennungToolStripMenuItem.Name = "iMEIErkennungToolStripMenuItem";
            this.iMEIErkennungToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.iMEIErkennungToolStripMenuItem.Text = "IMEI Erkennung";
            this.iMEIErkennungToolStripMenuItem.Click += new System.EventHandler(this.iMEIErkennungToolStripMenuItem_Click);
            // 
            // btn_folderInstaCreate
            // 
            this.btn_folderInstaCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_folderInstaCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_folderInstaCreate.ForeColor = System.Drawing.Color.Black;
            this.btn_folderInstaCreate.Location = new System.Drawing.Point(527, 80);
            this.btn_folderInstaCreate.Name = "btn_folderInstaCreate";
            this.btn_folderInstaCreate.Size = new System.Drawing.Size(134, 26);
            this.btn_folderInstaCreate.TabIndex = 49;
            this.btn_folderInstaCreate.Text = "Ordner Insta Create";
            this.btn_folderInstaCreate.UseVisualStyleBackColor = false;
            this.btn_folderInstaCreate.Click += new System.EventHandler(this.btn_folderInstaCreate_Click);
            // 
            // btn_buybackPriceAdaptions
            // 
            this.btn_buybackPriceAdaptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buybackPriceAdaptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buybackPriceAdaptions.ForeColor = System.Drawing.Color.Black;
            this.btn_buybackPriceAdaptions.Location = new System.Drawing.Point(679, 80);
            this.btn_buybackPriceAdaptions.Name = "btn_buybackPriceAdaptions";
            this.btn_buybackPriceAdaptions.Size = new System.Drawing.Size(134, 26);
            this.btn_buybackPriceAdaptions.TabIndex = 50;
            this.btn_buybackPriceAdaptions.Text = "BuyBack Price Adaption";
            this.btn_buybackPriceAdaptions.UseVisualStyleBackColor = false;
            this.btn_buybackPriceAdaptions.Click += new System.EventHandler(this.btn_buybackPriceAdaptions_Click);
            // 
            // lbl_LastPayPalImport
            // 
            this.lbl_LastPayPalImport.AutoSize = true;
            this.lbl_LastPayPalImport.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LastPayPalImport.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastPayPalImport.ForeColor = System.Drawing.Color.White;
            this.lbl_LastPayPalImport.Location = new System.Drawing.Point(803, 761);
            this.lbl_LastPayPalImport.Name = "lbl_LastPayPalImport";
            this.lbl_LastPayPalImport.Size = new System.Drawing.Size(232, 28);
            this.lbl_LastPayPalImport.TabIndex = 51;
            this.lbl_LastPayPalImport.Text = "Letzter PayPal-Import:";
            // 
            // lbl_LastBuyBackSync
            // 
            this.lbl_LastBuyBackSync.AutoSize = true;
            this.lbl_LastBuyBackSync.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LastBuyBackSync.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastBuyBackSync.ForeColor = System.Drawing.Color.White;
            this.lbl_LastBuyBackSync.Location = new System.Drawing.Point(803, 799);
            this.lbl_LastBuyBackSync.Name = "lbl_LastBuyBackSync";
            this.lbl_LastBuyBackSync.Size = new System.Drawing.Size(225, 28);
            this.lbl_LastBuyBackSync.TabIndex = 52;
            this.lbl_LastBuyBackSync.Text = "Letzter BuyBackSync:";
            // 
            // btn_PrintLabelForSellOff
            // 
            this.btn_PrintLabelForSellOff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_PrintLabelForSellOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintLabelForSellOff.ForeColor = System.Drawing.Color.Black;
            this.btn_PrintLabelForSellOff.Location = new System.Drawing.Point(835, 80);
            this.btn_PrintLabelForSellOff.Name = "btn_PrintLabelForSellOff";
            this.btn_PrintLabelForSellOff.Size = new System.Drawing.Size(134, 26);
            this.btn_PrintLabelForSellOff.TabIndex = 53;
            this.btn_PrintLabelForSellOff.Text = "Etikett Sell Off";
            this.btn_PrintLabelForSellOff.UseVisualStyleBackColor = false;
            this.btn_PrintLabelForSellOff.Click += new System.EventHandler(this.btn_PrintLabelForSellOff_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(617, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 26);
            this.button2.TabIndex = 54;
            this.button2.Text = "BillBee Test";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Eigenbelege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 836);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_PrintLabelForSellOff);
            this.Controls.Add(this.lbl_LastBuyBackSync);
            this.Controls.Add(this.lbl_LastPayPalImport);
            this.Controls.Add(this.btn_buybackPriceAdaptions);
            this.Controls.Add(this.btn_folderInstaCreate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_settings2);
            this.Controls.Add(this.btn_SwitchToRelatedReparatur);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_PushToRep);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_eigenbelegRemove);
            this.Controls.Add(this.btn_eigenbelegEdit);
            this.Controls.Add(this.btn_eigenbelegCreate);
            this.Controls.Add(this.eigenbelegeDGV);
            this.Controls.Add(this.lbl_foundPath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Eigenbelege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eigenbelege";
            this.Load += new System.EventHandler(this.Hauptmenü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eigenbelegeDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_foundPath;
        public System.Windows.Forms.DataGridView eigenbelegeDGV;
        private System.Windows.Forms.Button btn_eigenbelegCreate;
        private System.Windows.Forms.Button btn_eigenbelegEdit;
        private System.Windows.Forms.Button btn_eigenbelegRemove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_PushToRep;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_SwitchToRelatedReparatur;
        private System.Windows.Forms.Button btn_settings2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fensterwechselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem;
        private System.Windows.Forms.Button btn_folderInstaCreate;
        private System.Windows.Forms.Button btn_buybackPriceAdaptions;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proofingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswertungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.Label lbl_LastPayPalImport;
        private System.Windows.Forms.Label lbl_LastBuyBackSync;
        private System.Windows.Forms.ToolStripMenuItem b2CAnkaufToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b2BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lieferscheineMergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etikettenMergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularSalesToolStripMenuItem;
        private System.Windows.Forms.Button btn_PrintLabelForSellOff;
        private System.Windows.Forms.ToolStripMenuItem rEGCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMEIErkennungToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

