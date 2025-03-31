
namespace Control_Industrial_Processes
{
    partial class SD1
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
            this.btnB = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.txtFP = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnB.Location = new System.Drawing.Point(390, 136);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(108, 48);
            this.btnB.TabIndex = 23;
            this.btnB.Text = "Browse";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnS.Location = new System.Drawing.Point(181, 201);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(99, 49);
            this.btnS.TabIndex = 22;
            this.btnS.Text = "Send";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtFP
            // 
            this.txtFP.BackColor = System.Drawing.SystemColors.Info;
            this.txtFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFP.Location = new System.Drawing.Point(105, 147);
            this.txtFP.Name = "txtFP";
            this.txtFP.Size = new System.Drawing.Size(279, 26);
            this.txtFP.TabIndex = 21;
            // 
            // txtP
            // 
            this.txtP.BackColor = System.Drawing.SystemColors.Info;
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtP.Location = new System.Drawing.Point(104, 86);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(176, 26);
            this.txtP.TabIndex = 20;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Info;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIP.Location = new System.Drawing.Point(104, 27);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(176, 26);
            this.txtIP.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP:";
            // 
            // SD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 271);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtFP);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SD1";
            this.Text = "SD1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtFP;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}