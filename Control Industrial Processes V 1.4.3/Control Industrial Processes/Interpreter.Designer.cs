
namespace Control_Industrial_Processes
{
    partial class Interpreter
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
            this.In1btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // In1btn
            // 
            this.In1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.In1btn.Location = new System.Drawing.Point(85, 12);
            this.In1btn.Name = "In1btn";
            this.In1btn.Size = new System.Drawing.Size(130, 54);
            this.In1btn.TabIndex = 0;
            this.In1btn.Text = "Run First DSL";
            this.In1btn.UseVisualStyleBackColor = true;
            this.In1btn.Click += new System.EventHandler(this.In1btn_Click);
            // 
            // Interpreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 189);
            this.Controls.Add(this.In1btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Interpreter";
            this.Text = "Interpreter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button In1btn;
    }
}