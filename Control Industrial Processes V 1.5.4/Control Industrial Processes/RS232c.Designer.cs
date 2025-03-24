
namespace Control_Industrial_Processes
{
    partial class RS232c
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnC.Location = new System.Drawing.Point(237, 11);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(94, 38);
            this.btnC.TabIndex = 15;
            this.btnC.Text = "Connect";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnS.Location = new System.Drawing.Point(198, 241);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(72, 40);
            this.btnS.TabIndex = 12;
            this.btnS.Text = "Send";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtR.Location = new System.Drawing.Point(53, 69);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(366, 109);
            this.txtR.TabIndex = 11;
            // 
            // txtS
            // 
            this.txtS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtS.Location = new System.Drawing.Point(53, 195);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(366, 27);
            this.txtS.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // cbop
            // 
            this.cbop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.cbop.FormattingEnabled = true;
            this.cbop.Location = new System.Drawing.Point(64, 11);
            this.cbop.Name = "cbop";
            this.cbop.Size = new System.Drawing.Size(121, 28);
            this.cbop.TabIndex = 8;
            // 
            // RS232c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 305);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbop);
            this.Name = "RS232c";
            this.Text = "RS232c";
            this.Load += new System.EventHandler(this.RS232c_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbop;
    }
}