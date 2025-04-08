
namespace Control_Industrial_Processes
{
    partial class MQTTc
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
            this.LM1 = new System.Windows.Forms.ListBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LM1
            // 
            this.LM1.FormattingEnabled = true;
            this.LM1.Location = new System.Drawing.Point(12, 12);
            this.LM1.Name = "LM1";
            this.LM1.Size = new System.Drawing.Size(478, 264);
            this.LM1.TabIndex = 8;
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtM.Location = new System.Drawing.Point(12, 287);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(478, 27);
            this.txtM.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnSend.Location = new System.Drawing.Point(201, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 42);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MQTTc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 400);
            this.Controls.Add(this.LM1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.btnSend);
            this.Name = "MQTTc";
            this.Text = "MQTTc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MQTTc_FormClosing);
            this.Load += new System.EventHandler(this.MQTTc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LM1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btnSend;
    }
}