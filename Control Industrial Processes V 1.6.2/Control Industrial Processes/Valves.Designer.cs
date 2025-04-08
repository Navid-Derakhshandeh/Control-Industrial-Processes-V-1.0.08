
namespace Control_Industrial_Processes
{
    partial class Valves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valves));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnV1 = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(70, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Actuator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Open Water Valve:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDate.Location = new System.Drawing.Point(41, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(170, 26);
            this.txtDate.TabIndex = 11;
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.SystemColors.Info;
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnA1.Location = new System.Drawing.Point(391, 108);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(75, 38);
            this.btnA1.TabIndex = 10;
            this.btnA1.Text = "Off";
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.Info;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnA.Location = new System.Drawing.Point(247, 108);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 38);
            this.btnA.TabIndex = 9;
            this.btnA.Text = "On";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnV1
            // 
            this.btnV1.BackColor = System.Drawing.SystemColors.Info;
            this.btnV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnV1.Location = new System.Drawing.Point(391, 178);
            this.btnV1.Name = "btnV1";
            this.btnV1.Size = new System.Drawing.Size(75, 38);
            this.btnV1.TabIndex = 8;
            this.btnV1.Text = "Close";
            this.btnV1.UseVisualStyleBackColor = false;
            this.btnV1.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.SystemColors.Info;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnV.Location = new System.Drawing.Point(247, 178);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 38);
            this.btnV.TabIndex = 7;
            this.btnV.Text = "Open";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // Valves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnV1);
            this.Controls.Add(this.btnV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Valves";
            this.Text = "Valves";
            this.Load += new System.EventHandler(this.Valves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnV1;
        private System.Windows.Forms.Button btnV;
    }
}