
namespace Control_Industrial_Processes
{
    partial class WorkBenchWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WorkBenchWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WorkBenchWidget";
            this.Click += new System.EventHandler(this.WorkBenchWidget_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WorkBenchWidget_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkBenchWidget_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkBenchWidget_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkBenchWidget_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkBenchWidget_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
