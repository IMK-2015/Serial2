namespace Serial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.portNamesComboBox = new System.Windows.Forms.ComboBox();
            this.baudRatesComboBox = new System.Windows.Forms.ComboBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendHereTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readButton = new System.Windows.Forms.Button();
            this.receivedHereTextBox = new System.Windows.Forms.TextBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.closePortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // portNamesComboBox
            // 
            this.portNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNamesComboBox.FormattingEnabled = true;
            this.portNamesComboBox.Location = new System.Drawing.Point(30, 33);
            this.portNamesComboBox.Name = "portNamesComboBox";
            this.portNamesComboBox.Size = new System.Drawing.Size(173, 21);
            this.portNamesComboBox.TabIndex = 0;
            // 
            // baudRatesComboBox
            // 
            this.baudRatesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRatesComboBox.FormattingEnabled = true;
            this.baudRatesComboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.baudRatesComboBox.Location = new System.Drawing.Point(256, 33);
            this.baudRatesComboBox.Name = "baudRatesComboBox";
            this.baudRatesComboBox.Size = new System.Drawing.Size(173, 21);
            this.baudRatesComboBox.TabIndex = 1;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(30, 87);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(399, 23);
            this.statusProgressBar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.sendHereTextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Here";
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(52, 178);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendHereTextBox
            // 
            this.sendHereTextBox.Enabled = false;
            this.sendHereTextBox.Location = new System.Drawing.Point(7, 20);
            this.sendHereTextBox.Multiline = true;
            this.sendHereTextBox.Name = "sendHereTextBox";
            this.sendHereTextBox.Size = new System.Drawing.Size(173, 152);
            this.sendHereTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readButton);
            this.groupBox2.Controls.Add(this.receivedHereTextBox);
            this.groupBox2.Location = new System.Drawing.Point(249, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recieved Here";
            // 
            // readButton
            // 
            this.readButton.Enabled = false;
            this.readButton.Location = new System.Drawing.Point(57, 178);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // receivedHereTextBox
            // 
            this.receivedHereTextBox.Enabled = false;
            this.receivedHereTextBox.Location = new System.Drawing.Point(7, 20);
            this.receivedHereTextBox.Multiline = true;
            this.receivedHereTextBox.Name = "receivedHereTextBox";
            this.receivedHereTextBox.ReadOnly = true;
            this.receivedHereTextBox.Size = new System.Drawing.Size(173, 152);
            this.receivedHereTextBox.TabIndex = 0;
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(128, 359);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(75, 37);
            this.openPortButton.TabIndex = 5;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // closePortButton
            // 
            this.closePortButton.Enabled = false;
            this.closePortButton.Location = new System.Drawing.Point(256, 359);
            this.closePortButton.Name = "closePortButton";
            this.closePortButton.Size = new System.Drawing.Size(75, 37);
            this.closePortButton.TabIndex = 6;
            this.closePortButton.Text = "Close Port";
            this.closePortButton.UseVisualStyleBackColor = true;
            this.closePortButton.Click += new System.EventHandler(this.closePortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closePortButton);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusProgressBar);
            this.Controls.Add(this.baudRatesComboBox);
            this.Controls.Add(this.portNamesComboBox);
            this.Name = "Form1";
            this.Text = "   Serial Communication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portNamesComboBox;
        private System.Windows.Forms.ComboBox baudRatesComboBox;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendHereTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox receivedHereTextBox;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Button closePortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

