namespace EigenbelegToolAlpha
{
    partial class EigenbelegeLabelSellOffInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EigenbelegeLabelSellOffInput));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.textBox_IMEI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_quantity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_condition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(261, 146);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(91, 24);
            this.btn_Execute.TabIndex = 1;
            this.btn_Execute.Text = "O. K.";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // textBox_IMEI
            // 
            this.textBox_IMEI.Location = new System.Drawing.Point(115, 20);
            this.textBox_IMEI.Name = "textBox_IMEI";
            this.textBox_IMEI.Size = new System.Drawing.Size(237, 20);
            this.textBox_IMEI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anzahl";
            // 
            // comboBox_quantity
            // 
            this.comboBox_quantity.FormattingEnabled = true;
            this.comboBox_quantity.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_quantity.Location = new System.Drawing.Point(231, 59);
            this.comboBox_quantity.Name = "comboBox_quantity";
            this.comboBox_quantity.Size = new System.Drawing.Size(121, 21);
            this.comboBox_quantity.TabIndex = 4;
            this.comboBox_quantity.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(38, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zustand";
            // 
            // comboBox_condition
            // 
            this.comboBox_condition.FormattingEnabled = true;
            this.comboBox_condition.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_condition.Location = new System.Drawing.Point(231, 102);
            this.comboBox_condition.Name = "comboBox_condition";
            this.comboBox_condition.Size = new System.Drawing.Size(121, 21);
            this.comboBox_condition.TabIndex = 6;
            this.comboBox_condition.Text = "D";
            // 
            // EigenbelegeLabelSellOffInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(408, 191);
            this.Controls.Add(this.comboBox_condition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_IMEI);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EigenbelegeLabelSellOffInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMEI eintragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.TextBox textBox_IMEI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_condition;
    }
}