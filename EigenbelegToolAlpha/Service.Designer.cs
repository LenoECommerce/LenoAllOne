namespace EigenbelegToolAlpha
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_RemoveFindMyPhoneLock = new System.Windows.Forms.Button();
            this.btn_PayPalMessageConfigurator = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fensterwechselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_B2CAnkauf = new System.Windows.Forms.Button();
            this.Btn_CustomerSupport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_RepairChat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Trustpilot = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Anrede";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hallo",
            "Guten Tag",
            "Guten Morgen",
            "Guten Abend"});
            this.comboBox1.Location = new System.Drawing.Point(220, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_RemoveFindMyPhoneLock
            // 
            this.btn_RemoveFindMyPhoneLock.Location = new System.Drawing.Point(99, 328);
            this.btn_RemoveFindMyPhoneLock.Name = "btn_RemoveFindMyPhoneLock";
            this.btn_RemoveFindMyPhoneLock.Size = new System.Drawing.Size(221, 41);
            this.btn_RemoveFindMyPhoneLock.TabIndex = 47;
            this.btn_RemoveFindMyPhoneLock.Text = "Find My iPhone entfernen";
            this.btn_RemoveFindMyPhoneLock.UseVisualStyleBackColor = true;
            this.btn_RemoveFindMyPhoneLock.Click += new System.EventHandler(this.btn_RemoveFindMyPhoneLock_Click);
            // 
            // btn_PayPalMessageConfigurator
            // 
            this.btn_PayPalMessageConfigurator.Location = new System.Drawing.Point(99, 529);
            this.btn_PayPalMessageConfigurator.Name = "btn_PayPalMessageConfigurator";
            this.btn_PayPalMessageConfigurator.Size = new System.Drawing.Size(261, 41);
            this.btn_PayPalMessageConfigurator.TabIndex = 48;
            this.btn_PayPalMessageConfigurator.Text = "PayPal Nachricht Konfigurator";
            this.btn_PayPalMessageConfigurator.UseVisualStyleBackColor = true;
            this.btn_PayPalMessageConfigurator.Click += new System.EventHandler(this.btn_PayPalMessageConfigurator_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fensterwechselToolStripMenuItem,
            this.auswertungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fensterwechselToolStripMenuItem
            // 
            this.fensterwechselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceToolStripMenuItem,
            this.eigenbelegeToolStripMenuItem,
            this.protokollierungToolStripMenuItem,
            this.proofingToolStripMenuItem});
            this.fensterwechselToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.windowsvg;
            this.fensterwechselToolStripMenuItem.Name = "fensterwechselToolStripMenuItem";
            this.fensterwechselToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.fensterwechselToolStripMenuItem.Text = "Fensterwechsel";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceToolStripMenuItem.Text = "Eigenbelege";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
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
            this.protokollierungToolStripMenuItem.Text = "Protokollierung";
            this.protokollierungToolStripMenuItem.Click += new System.EventHandler(this.protokollierungToolStripMenuItem_Click);
            // 
            // proofingToolStripMenuItem
            // 
            this.proofingToolStripMenuItem.Name = "proofingToolStripMenuItem";
            this.proofingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proofingToolStripMenuItem.Text = "Proofing";
            this.proofingToolStripMenuItem.Click += new System.EventHandler(this.proofingToolStripMenuItem_Click);
            // 
            // auswertungenToolStripMenuItem
            // 
            this.auswertungenToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.evaluations;
            this.auswertungenToolStripMenuItem.Name = "auswertungenToolStripMenuItem";
            this.auswertungenToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.auswertungenToolStripMenuItem.Text = "Auswertungen";
            // 
            // Btn_B2CAnkauf
            // 
            this.Btn_B2CAnkauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_B2CAnkauf.Location = new System.Drawing.Point(99, 156);
            this.Btn_B2CAnkauf.Name = "Btn_B2CAnkauf";
            this.Btn_B2CAnkauf.Size = new System.Drawing.Size(188, 48);
            this.Btn_B2CAnkauf.TabIndex = 50;
            this.Btn_B2CAnkauf.Text = "B2C Ankauf";
            this.Btn_B2CAnkauf.UseVisualStyleBackColor = true;
            // 
            // Btn_CustomerSupport
            // 
            this.Btn_CustomerSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CustomerSupport.Location = new System.Drawing.Point(312, 156);
            this.Btn_CustomerSupport.Name = "Btn_CustomerSupport";
            this.Btn_CustomerSupport.Size = new System.Drawing.Size(244, 48);
            this.Btn_CustomerSupport.TabIndex = 51;
            this.Btn_CustomerSupport.Text = "Kundensupport";
            this.Btn_CustomerSupport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Weitere wichtige Templates";
            // 
            // Btn_RepairChat
            // 
            this.Btn_RepairChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RepairChat.Location = new System.Drawing.Point(583, 156);
            this.Btn_RepairChat.Name = "Btn_RepairChat";
            this.Btn_RepairChat.Size = new System.Drawing.Size(261, 48);
            this.Btn_RepairChat.TabIndex = 53;
            this.Btn_RepairChat.Text = "Reparatur Chat";
            this.Btn_RepairChat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 54;
            this.label3.Text = "Hauptbereiche";
            // 
            // Btn_Trustpilot
            // 
            this.Btn_Trustpilot.Location = new System.Drawing.Point(359, 328);
            this.Btn_Trustpilot.Name = "Btn_Trustpilot";
            this.Btn_Trustpilot.Size = new System.Drawing.Size(207, 41);
            this.Btn_Trustpilot.TabIndex = 55;
            this.Btn_Trustpilot.Text = "Trustpilot ";
            this.Btn_Trustpilot.UseVisualStyleBackColor = true;
            this.Btn_Trustpilot.Click += new System.EventHandler(this.Btn_Trustpilot_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.Btn_Trustpilot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_RepairChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_CustomerSupport);
            this.Controls.Add(this.Btn_B2CAnkauf);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_PayPalMessageConfigurator);
            this.Controls.Add(this.btn_RemoveFindMyPhoneLock);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_RemoveFindMyPhoneLock;
        private System.Windows.Forms.Button btn_PayPalMessageConfigurator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fensterwechselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenbelegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protokollierungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proofingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswertungenToolStripMenuItem;
        private System.Windows.Forms.Button Btn_B2CAnkauf;
        private System.Windows.Forms.Button Btn_CustomerSupport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_RepairChat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Trustpilot;
    }
}