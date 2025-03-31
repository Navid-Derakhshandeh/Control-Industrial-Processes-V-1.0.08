
namespace Control_Industrial_Processes
{
    partial class _3AxisController
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSendGcode = new System.Windows.Forms.Button();
            this.btnFH = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.txtZAxis = new System.Windows.Forms.TextBox();
            this.txtYAxis = new System.Windows.Forms.TextBox();
            this.txtXAxis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnC = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(45, 162);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 38);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "Load G-code";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 124);
            this.listBox1.TabIndex = 24;
            // 
            // btnSendGcode
            // 
            this.btnSendGcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendGcode.Location = new System.Drawing.Point(45, 206);
            this.btnSendGcode.Name = "btnSendGcode";
            this.btnSendGcode.Size = new System.Drawing.Size(140, 38);
            this.btnSendGcode.TabIndex = 23;
            this.btnSendGcode.Text = "Send G-Code";
            this.btnSendGcode.UseVisualStyleBackColor = true;
            this.btnSendGcode.Click += new System.EventHandler(this.btnSendGcode_Click);
            // 
            // btnFH
            // 
            this.btnFH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFH.Location = new System.Drawing.Point(138, 190);
            this.btnFH.Name = "btnFH";
            this.btnFH.Size = new System.Drawing.Size(110, 38);
            this.btnFH.TabIndex = 22;
            this.btnFH.Text = "Feed Hold";
            this.btnFH.UseVisualStyleBackColor = true;
            this.btnFH.Click += new System.EventHandler(this.btnFH_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(254, 190);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(110, 38);
            this.btnS.TabIndex = 21;
            this.btnS.Text = "Cycle Stop";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnCS
            // 
            this.btnCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.Location = new System.Drawing.Point(22, 190);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(110, 38);
            this.btnCS.TabIndex = 20;
            this.btnCS.Text = "Cycle Start";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // txtZAxis
            // 
            this.txtZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAxis.Location = new System.Drawing.Point(173, 125);
            this.txtZAxis.Name = "txtZAxis";
            this.txtZAxis.Size = new System.Drawing.Size(154, 27);
            this.txtZAxis.TabIndex = 19;
            // 
            // txtYAxis
            // 
            this.txtYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAxis.Location = new System.Drawing.Point(173, 77);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.Size = new System.Drawing.Size(154, 27);
            this.txtYAxis.TabIndex = 18;
            // 
            // txtXAxis
            // 
            this.txtXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAxis.Location = new System.Drawing.Point(173, 32);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.Size = new System.Drawing.Size(154, 27);
            this.txtXAxis.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "XAxis value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "ZAxis value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "YAxis value:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtXAxis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYAxis);
            this.groupBox1.Controls.Add(this.txtZAxis);
            this.groupBox1.Controls.Add(this.btnCS);
            this.groupBox1.Controls.Add(this.btnS);
            this.groupBox1.Controls.Add(this.btnFH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 259);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cycle Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnSendGcode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 259);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load G-Code";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(185, 289);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(111, 38);
            this.btnC.TabIndex = 31;
            this.btnC.Text = "Connect";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(320, 289);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(111, 38);
            this.btnDisconnect.TabIndex = 32;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // _3AxisController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 349);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "_3AxisController";
            this.Text = "_3AxisController";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSendGcode;
        private System.Windows.Forms.Button btnFH;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.TextBox txtZAxis;
        private System.Windows.Forms.TextBox txtYAxis;
        private System.Windows.Forms.TextBox txtXAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDisconnect;
    }
}