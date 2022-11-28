namespace EigenbelegToolAlpha
{
    partial class ProtokollierungScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtokollierungScan));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_scanField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_orderID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI Combo";
            // 
            // textBox_scanField
            // 
            this.textBox_scanField.Location = new System.Drawing.Point(110, 36);
            this.textBox_scanField.Name = "textBox_scanField";
            this.textBox_scanField.Size = new System.Drawing.Size(194, 20);
            this.textBox_scanField.TabIndex = 1;
            this.textBox_scanField.TextChanged += new System.EventHandler(this.textBox_scanField_TextChanged);
            this.textBox_scanField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ausführen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bestellnummer";
            // 
            // textBox_orderID
            // 
            this.textBox_orderID.Location = new System.Drawing.Point(110, 70);
            this.textBox_orderID.Name = "textBox_orderID";
            this.textBox_orderID.Size = new System.Drawing.Size(194, 20);
            this.textBox_orderID.TabIndex = 4;
            this.textBox_orderID.TextChanged += new System.EventHandler(this.textBox_orderID_TextChanged);
            this.textBox_orderID.Enter += new System.EventHandler(this.textBox_orderID_Enter);
            this.textBox_orderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandlerAndEnter);
            // 
            // ProtokollierungScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 131);
            this.Controls.Add(this.textBox_orderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_scanField);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProtokollierungScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProtokollierungScan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_scanField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_orderID;
    }
}