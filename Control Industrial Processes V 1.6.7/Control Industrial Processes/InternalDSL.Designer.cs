
namespace Control_Industrial_Processes
{
    partial class InternalDSL
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtExecute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.btnIDSL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(114, 23);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(313, 27);
            this.txtCommand.TabIndex = 0;
            // 
            // txtExecute
            // 
            this.txtExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecute.Location = new System.Drawing.Point(114, 79);
            this.txtExecute.Name = "txtExecute";
            this.txtExecute.Size = new System.Drawing.Size(313, 27);
            this.txtExecute.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command:";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(39, 82);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(69, 22);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output:";
            // 
            // btnIDSL
            // 
            this.btnIDSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDSL.Location = new System.Drawing.Point(176, 135);
            this.btnIDSL.Name = "btnIDSL";
            this.btnIDSL.Size = new System.Drawing.Size(100, 38);
            this.btnIDSL.TabIndex = 4;
            this.btnIDSL.Text = "RUN";
            this.btnIDSL.UseVisualStyleBackColor = true;
            this.btnIDSL.Click += new System.EventHandler(this.btnIDSL_Click);
            // 
            // InternalDSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 185);
            this.Controls.Add(this.btnIDSL);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExecute);
            this.Controls.Add(this.txtCommand);
            this.Name = "InternalDSL";
            this.Text = "InternalDSL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button btnIDSL;
    }
}