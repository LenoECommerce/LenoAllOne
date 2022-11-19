namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_ProActive_FirstRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_ProActive_FirstRequest));
            this.Btn_GetBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Anrede = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Make = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ModellApple = new System.Windows.Forms.ComboBox();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Apple = new System.Windows.Forms.ListBox();
            this.listBox_Samsung = new System.Windows.Forms.ListBox();
            this.Btn_AppleAngebot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_AppleDisplay = new System.Windows.Forms.Button();
            this.Btn_AppleRisikokauf = new System.Windows.Forms.Button();
            this.Btn_AppleFaceID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_GetBack
            // 
            this.Btn_GetBack.Location = new System.Drawing.Point(654, 12);
            this.Btn_GetBack.Name = "Btn_GetBack";
            this.Btn_GetBack.Size = new System.Drawing.Size(126, 33);
            this.Btn_GetBack.TabIndex = 0;
            this.Btn_GetBack.Text = "Zurück";
            this.Btn_GetBack.UseVisualStyleBackColor = true;
            this.Btn_GetBack.Click += new System.EventHandler(this.Btn_GetBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Betrag";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(170, 27);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(130, 20);
            this.textBox_Amount.TabIndex = 2;
            this.textBox_Amount.TextChanged += new System.EventHandler(this.textBox_Amount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(381, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anrede";
            // 
            // comboBox_Anrede
            // 
            this.comboBox_Anrede.FormattingEnabled = true;
            this.comboBox_Anrede.Items.AddRange(new object[] {
            "Hallo",
            "Guten Morgen",
            "Guten Tag",
            "Guten Abend"});
            this.comboBox_Anrede.Location = new System.Drawing.Point(481, 27);
            this.comboBox_Anrede.Name = "comboBox_Anrede";
            this.comboBox_Anrede.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Anrede.TabIndex = 4;
            this.comboBox_Anrede.Text = "Hallo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(60, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marke";
            // 
            // comboBox_Make
            // 
            this.comboBox_Make.FormattingEnabled = true;
            this.comboBox_Make.Items.AddRange(new object[] {
            "Apple",
            "Samsung"});
            this.comboBox_Make.Location = new System.Drawing.Point(170, 76);
            this.comboBox_Make.Name = "comboBox_Make";
            this.comboBox_Make.Size = new System.Drawing.Size(130, 21);
            this.comboBox_Make.TabIndex = 6;
            this.comboBox_Make.Text = "Samsung";
            this.comboBox_Make.SelectedIndexChanged += new System.EventHandler(this.comboBox_Make_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(60, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modell";
            this.label4.Visible = false;
            // 
            // comboBox_ModellApple
            // 
            this.comboBox_ModellApple.FormattingEnabled = true;
            this.comboBox_ModellApple.Items.AddRange(new object[] {
            "Bis iPhone XR",
            "Ab iPhone XS"});
            this.comboBox_ModellApple.Location = new System.Drawing.Point(170, 124);
            this.comboBox_ModellApple.Name = "comboBox_ModellApple";
            this.comboBox_ModellApple.Size = new System.Drawing.Size(130, 21);
            this.comboBox_ModellApple.TabIndex = 8;
            this.comboBox_ModellApple.Visible = false;
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Location = new System.Drawing.Point(189, 241);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(111, 28);
            this.Btn_Copy.TabIndex = 9;
            this.Btn_Copy.Text = "Kopieren";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.Color.Red;
            this.Btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Reset.Location = new System.Drawing.Point(64, 241);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(111, 28);
            this.Btn_Reset.TabIndex = 10;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(382, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fragen";
            // 
            // listBox_Apple
            // 
            this.listBox_Apple.FormattingEnabled = true;
            this.listBox_Apple.Items.AddRange(new object[] {
            "Speicher",
            "Rand",
            "iCloud",
            "Display"});
            this.listBox_Apple.Location = new System.Drawing.Point(481, 77);
            this.listBox_Apple.Name = "listBox_Apple";
            this.listBox_Apple.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Apple.Size = new System.Drawing.Size(120, 95);
            this.listBox_Apple.TabIndex = 12;
            this.listBox_Apple.Visible = false;
            // 
            // listBox_Samsung
            // 
            this.listBox_Samsung.FormattingEnabled = true;
            this.listBox_Samsung.Items.AddRange(new object[] {
            "Rand",
            "Speicher"});
            this.listBox_Samsung.Location = new System.Drawing.Point(482, 77);
            this.listBox_Samsung.Name = "listBox_Samsung";
            this.listBox_Samsung.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Samsung.Size = new System.Drawing.Size(120, 95);
            this.listBox_Samsung.TabIndex = 13;
            // 
            // Btn_AppleAngebot
            // 
            this.Btn_AppleAngebot.Location = new System.Drawing.Point(62, 350);
            this.Btn_AppleAngebot.Name = "Btn_AppleAngebot";
            this.Btn_AppleAngebot.Size = new System.Drawing.Size(105, 33);
            this.Btn_AppleAngebot.TabIndex = 14;
            this.Btn_AppleAngebot.Text = "Angebot";
            this.Btn_AppleAngebot.UseVisualStyleBackColor = true;
            this.Btn_AppleAngebot.Click += new System.EventHandler(this.Btn_AppleAngebot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(60, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Related";
            // 
            // Btn_AppleDisplay
            // 
            this.Btn_AppleDisplay.Location = new System.Drawing.Point(187, 350);
            this.Btn_AppleDisplay.Name = "Btn_AppleDisplay";
            this.Btn_AppleDisplay.Size = new System.Drawing.Size(126, 33);
            this.Btn_AppleDisplay.TabIndex = 16;
            this.Btn_AppleDisplay.Text = "Display";
            this.Btn_AppleDisplay.UseVisualStyleBackColor = true;
            this.Btn_AppleDisplay.Click += new System.EventHandler(this.Btn_AppleDisplay_Click);
            // 
            // Btn_AppleRisikokauf
            // 
            this.Btn_AppleRisikokauf.Location = new System.Drawing.Point(331, 350);
            this.Btn_AppleRisikokauf.Name = "Btn_AppleRisikokauf";
            this.Btn_AppleRisikokauf.Size = new System.Drawing.Size(126, 33);
            this.Btn_AppleRisikokauf.TabIndex = 17;
            this.Btn_AppleRisikokauf.Text = "Risikokauf";
            this.Btn_AppleRisikokauf.UseVisualStyleBackColor = true;
            this.Btn_AppleRisikokauf.Click += new System.EventHandler(this.Btn_AppleRisikokauf_Click);
            // 
            // Btn_AppleFaceID
            // 
            this.Btn_AppleFaceID.Location = new System.Drawing.Point(473, 350);
            this.Btn_AppleFaceID.Name = "Btn_AppleFaceID";
            this.Btn_AppleFaceID.Size = new System.Drawing.Size(126, 33);
            this.Btn_AppleFaceID.TabIndex = 18;
            this.Btn_AppleFaceID.Text = "Face-ID";
            this.Btn_AppleFaceID.UseVisualStyleBackColor = true;
            this.Btn_AppleFaceID.Click += new System.EventHandler(this.Btn_AppleFaceID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(33, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(727, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // ServiceB2CAnkauf_ProActive_FirstRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_AppleFaceID);
            this.Controls.Add(this.Btn_AppleRisikokauf);
            this.Controls.Add(this.Btn_AppleDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_AppleAngebot);
            this.Controls.Add(this.listBox_Samsung);
            this.Controls.Add(this.listBox_Apple);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Copy);
            this.Controls.Add(this.comboBox_ModellApple);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Make);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Anrede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_GetBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_ProActive_FirstRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erste Anfrage konfigurieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_GetBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Anrede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Make;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_ModellApple;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Apple;
        private System.Windows.Forms.ListBox listBox_Samsung;
        private System.Windows.Forms.Button Btn_AppleAngebot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_AppleDisplay;
        private System.Windows.Forms.Button Btn_AppleRisikokauf;
        private System.Windows.Forms.Button Btn_AppleFaceID;
        private System.Windows.Forms.Label label7;
    }
}