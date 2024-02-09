
namespace Control_Industrial_Processes
{
    partial class SMTER
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
            this.txtM = new System.Windows.Forms.TextBox();
            this.LM1 = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDPort = new System.Windows.Forms.TextBox();
            this.txtSPort = new System.Windows.Forms.TextBox();
            this.txtDIP = new System.Windows.Forms.TextBox();
            this.txtSIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.SystemColors.Menu;
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtM.Location = new System.Drawing.Point(49, 365);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(514, 26);
            this.txtM.TabIndex = 41;
            // 
            // LM1
            // 
            this.LM1.BackColor = System.Drawing.SystemColors.Menu;
            this.LM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LM1.FormattingEnabled = true;
            this.LM1.ItemHeight = 20;
            this.LM1.Location = new System.Drawing.Point(52, 126);
            this.LM1.Name = "LM1";
            this.LM1.Size = new System.Drawing.Size(511, 224);
            this.LM1.TabIndex = 40;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSend.Location = new System.Drawing.Point(292, 407);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 40);
            this.btnSend.TabIndex = 39;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(178, 407);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 40);
            this.btnConnect.TabIndex = 38;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDPort
            // 
            this.txtDPort.BackColor = System.Drawing.SystemColors.Info;
            this.txtDPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDPort.Location = new System.Drawing.Point(468, 83);
            this.txtDPort.Name = "txtDPort";
            this.txtDPort.Size = new System.Drawing.Size(92, 26);
            this.txtDPort.TabIndex = 37;
            // 
            // txtSPort
            // 
            this.txtSPort.BackColor = System.Drawing.SystemColors.Info;
            this.txtSPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSPort.Location = new System.Drawing.Point(468, 18);
            this.txtSPort.Name = "txtSPort";
            this.txtSPort.Size = new System.Drawing.Size(92, 26);
            this.txtSPort.TabIndex = 36;
            // 
            // txtDIP
            // 
            this.txtDIP.BackColor = System.Drawing.SystemColors.Info;
            this.txtDIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDIP.Location = new System.Drawing.Point(137, 83);
            this.txtDIP.Name = "txtDIP";
            this.txtDIP.Size = new System.Drawing.Size(227, 26);
            this.txtDIP.TabIndex = 35;
            // 
            // txtSIP
            // 
            this.txtSIP.BackColor = System.Drawing.SystemColors.Info;
            this.txtSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSIP.Location = new System.Drawing.Point(137, 18);
            this.txtSIP.Name = "txtSIP";
            this.txtSIP.Size = new System.Drawing.Size(227, 26);
            this.txtSIP.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(411, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Destination IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(411, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Source IP:";
            // 
            // SMTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.LM1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDPort);
            this.Controls.Add(this.txtSPort);
            this.Controls.Add(this.txtDIP);
            this.Controls.Add(this.txtSIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SMTER";
            this.Text = "SMTER";
            this.Load += new System.EventHandler(this.SMTER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.ListBox LM1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDPort;
        private System.Windows.Forms.TextBox txtSPort;
        private System.Windows.Forms.TextBox txtDIP;
        private System.Windows.Forms.TextBox txtSIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}