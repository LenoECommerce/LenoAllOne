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
            this.eigenbelegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protokollierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proofingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Atlanta", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 48);
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
            this.comboBox1.Location = new System.Drawing.Point(220, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_RemoveFindMyPhoneLock
            // 
            this.btn_RemoveFindMyPhoneLock.Location = new System.Drawing.Point(99, 133);
            this.btn_RemoveFindMyPhoneLock.Name = "btn_RemoveFindMyPhoneLock";
            this.btn_RemoveFindMyPhoneLock.Size = new System.Drawing.Size(261, 41);
            this.btn_RemoveFindMyPhoneLock.TabIndex = 47;
            this.btn_RemoveFindMyPhoneLock.Text = "Find My iPhone entfernen";
            this.btn_RemoveFindMyPhoneLock.UseVisualStyleBackColor = true;
            this.btn_RemoveFindMyPhoneLock.Click += new System.EventHandler(this.btn_RemoveFindMyPhoneLock_Click);
            // 
            // btn_PayPalMessageConfigurator
            // 
            this.btn_PayPalMessageConfigurator.Location = new System.Drawing.Point(436, 133);
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
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceToolStripMenuItem.Text = "Eigenbelege";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // auswertungenToolStripMenuItem
            // 
            this.auswertungenToolStripMenuItem.Image = global::EigenbelegToolAlpha.Properties.Resources.evaluations;
            this.auswertungenToolStripMenuItem.Name = "auswertungenToolStripMenuItem";
            this.auswertungenToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.auswertungenToolStripMenuItem.Text = "Auswertungen";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 814);
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
    }
}