namespace EigenbelegToolAlpha
{
    partial class ServiceB2CAnkauf_ProblemContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceB2CAnkauf_ProblemContact));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Execute = new System.Windows.Forms.Button();
            this.comboBox_Anrede = new System.Windows.Forms.ComboBox();
            this.textBox_Defect = new System.Windows.Forms.TextBox();
            this.textBox_ProofLink = new System.Windows.Forms.TextBox();
            this.checkBox_ReimburseProposal = new System.Windows.Forms.CheckBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.textBox_ReimburseAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anrede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(49, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Erstattung?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(49, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Defekt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(49, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Beweislink";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(49, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Betrag";
            this.label5.Visible = false;
            // 
            // Btn_Execute
            // 
            this.Btn_Execute.Location = new System.Drawing.Point(253, 270);
            this.Btn_Execute.Name = "Btn_Execute";
            this.Btn_Execute.Size = new System.Drawing.Size(109, 33);
            this.Btn_Execute.TabIndex = 7;
            this.Btn_Execute.Text = "Kopieren";
            this.Btn_Execute.UseVisualStyleBackColor = true;
            this.Btn_Execute.Click += new System.EventHandler(this.Btn_Execute_Click);
            // 
            // comboBox_Anrede
            // 
            this.comboBox_Anrede.FormattingEnabled = true;
            this.comboBox_Anrede.Items.AddRange(new object[] {
            "Hallo",
            "Guten Morgen",
            "Guten Tag",
            "Guten Abend"});
            this.comboBox_Anrede.Location = new System.Drawing.Point(213, 39);
            this.comboBox_Anrede.Name = "comboBox_Anrede";
            this.comboBox_Anrede.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Anrede.TabIndex = 8;
            this.comboBox_Anrede.Text = "Guten Tag";
            this.comboBox_Anrede.SelectedIndexChanged += new System.EventHandler(this.comboBox_Anrede_SelectedIndexChanged);
            // 
            // textBox_Defect
            // 
            this.textBox_Defect.Location = new System.Drawing.Point(213, 80);
            this.textBox_Defect.Multiline = true;
            this.textBox_Defect.Name = "textBox_Defect";
            this.textBox_Defect.Size = new System.Drawing.Size(149, 59);
            this.textBox_Defect.TabIndex = 9;
            this.textBox_Defect.Text = "leider hat das Gerät ...";
            // 
            // textBox_ProofLink
            // 
            this.textBox_ProofLink.Location = new System.Drawing.Point(213, 154);
            this.textBox_ProofLink.Name = "textBox_ProofLink";
            this.textBox_ProofLink.Size = new System.Drawing.Size(149, 20);
            this.textBox_ProofLink.TabIndex = 10;
            // 
            // checkBox_ReimburseProposal
            // 
            this.checkBox_ReimburseProposal.AutoSize = true;
            this.checkBox_ReimburseProposal.Location = new System.Drawing.Point(213, 195);
            this.checkBox_ReimburseProposal.Name = "checkBox_ReimburseProposal";
            this.checkBox_ReimburseProposal.Size = new System.Drawing.Size(15, 14);
            this.checkBox_ReimburseProposal.TabIndex = 11;
            this.checkBox_ReimburseProposal.UseVisualStyleBackColor = true;
            this.checkBox_ReimburseProposal.CheckedChanged += new System.EventHandler(this.checkBox_ReimburseProposal_CheckedChanged);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // textBox_ReimburseAmount
            // 
            this.textBox_ReimburseAmount.Location = new System.Drawing.Point(213, 230);
            this.textBox_ReimburseAmount.Name = "textBox_ReimburseAmount";
            this.textBox_ReimburseAmount.Size = new System.Drawing.Size(149, 20);
            this.textBox_ReimburseAmount.TabIndex = 12;
            this.textBox_ReimburseAmount.Visible = false;
            // 
            // ServiceB2CAnkauf_ProblemContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(434, 342);
            this.Controls.Add(this.textBox_ReimburseAmount);
            this.Controls.Add(this.checkBox_ReimburseProposal);
            this.Controls.Add(this.textBox_ProofLink);
            this.Controls.Add(this.textBox_Defect);
            this.Controls.Add(this.comboBox_Anrede);
            this.Controls.Add(this.Btn_Execute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceB2CAnkauf_ProblemContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problemkontakt konfigurieren";
            this.Load += new System.EventHandler(this.ServiceB2CAnkauf_ProblemContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Execute;
        private System.Windows.Forms.ComboBox comboBox_Anrede;
        private System.Windows.Forms.TextBox textBox_Defect;
        private System.Windows.Forms.TextBox textBox_ProofLink;
        private System.Windows.Forms.CheckBox checkBox_ReimburseProposal;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox textBox_ReimburseAmount;
    }
}