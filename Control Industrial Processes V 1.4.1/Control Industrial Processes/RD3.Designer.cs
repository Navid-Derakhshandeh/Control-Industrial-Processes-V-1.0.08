
namespace Control_Industrial_Processes
{
    partial class RD3
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
            this.btnL = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnL.Location = new System.Drawing.Point(30, 87);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(131, 42);
            this.btnL.TabIndex = 8;
            this.btnL.Text = "Listen To Port";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // txtP
            // 
            this.txtP.BackColor = System.Drawing.SystemColors.Info;
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtP.Location = new System.Drawing.Point(61, 18);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 26);
            this.txtP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port:";
            // 
            // RD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(193, 143);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RD3";
            this.Text = "RD3";
            this.Load += new System.EventHandler(this.RD3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
    }
}