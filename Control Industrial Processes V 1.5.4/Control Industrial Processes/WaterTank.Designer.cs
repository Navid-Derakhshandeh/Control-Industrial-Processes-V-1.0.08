
namespace Control_Industrial_Processes
{
    partial class WaterTank
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbC = new System.Windows.Forms.Label();
            this.picOR = new System.Windows.Forms.PictureBox();
            this.picOG = new System.Windows.Forms.PictureBox();
            this.picTR = new System.Windows.Forms.PictureBox();
            this.picTG = new System.Windows.Forms.PictureBox();
            this.picPR = new System.Windows.Forms.PictureBox();
            this.picPG = new System.Windows.Forms.PictureBox();
            this.picMR = new System.Windows.Forms.PictureBox();
            this.picMG = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SAP = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.SA1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.SAV = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.SAT = new DmitryBrant.CustomControls.SevenSegmentArray();
            ((System.ComponentModel.ISupportInitialize)(this.picOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date / Time:";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtDT.Location = new System.Drawing.Point(124, 23);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(293, 27);
            this.txtDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(440, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtIP.Location = new System.Drawing.Point(548, 23);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(240, 27);
            this.txtIP.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lbC.Location = new System.Drawing.Point(233, 82);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(28, 22);
            this.lbC.TabIndex = 14;
            this.lbC.Text = "C:";
            // 
            // picOR
            // 
            this.picOR.Image = global::Control_Industrial_Processes.Properties.Resources.Closed_Valve_R6;
            this.picOR.Location = new System.Drawing.Point(566, 291);
            this.picOR.Name = "picOR";
            this.picOR.Size = new System.Drawing.Size(165, 92);
            this.picOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOR.TabIndex = 13;
            this.picOR.TabStop = false;
            // 
            // picOG
            // 
            this.picOG.Image = global::Control_Industrial_Processes.Properties.Resources.Open_Valve_G1;
            this.picOG.Location = new System.Drawing.Point(566, 291);
            this.picOG.Name = "picOG";
            this.picOG.Size = new System.Drawing.Size(165, 92);
            this.picOG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOG.TabIndex = 12;
            this.picOG.TabStop = false;
            // 
            // picTR
            // 
            this.picTR.Image = global::Control_Industrial_Processes.Properties.Resources.Tank_R4_1;
            this.picTR.Location = new System.Drawing.Point(17, 128);
            this.picTR.Name = "picTR";
            this.picTR.Size = new System.Drawing.Size(554, 399);
            this.picTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTR.TabIndex = 11;
            this.picTR.TabStop = false;
            // 
            // picTG
            // 
            this.picTG.Image = global::Control_Industrial_Processes.Properties.Resources.Tank_G4_1;
            this.picTG.Location = new System.Drawing.Point(17, 128);
            this.picTG.Name = "picTG";
            this.picTG.Size = new System.Drawing.Size(554, 399);
            this.picTG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTG.TabIndex = 10;
            this.picTG.TabStop = false;
            // 
            // picPR
            // 
            this.picPR.Image = global::Control_Industrial_Processes.Properties.Resources.Pump_R2;
            this.picPR.Location = new System.Drawing.Point(726, 249);
            this.picPR.Name = "picPR";
            this.picPR.Size = new System.Drawing.Size(152, 178);
            this.picPR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPR.TabIndex = 9;
            this.picPR.TabStop = false;
            // 
            // picPG
            // 
            this.picPG.Image = global::Control_Industrial_Processes.Properties.Resources.Pump_G11;
            this.picPG.Location = new System.Drawing.Point(726, 249);
            this.picPG.Name = "picPG";
            this.picPG.Size = new System.Drawing.Size(152, 178);
            this.picPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPG.TabIndex = 8;
            this.picPG.TabStop = false;
            // 
            // picMR
            // 
            this.picMR.Image = global::Control_Industrial_Processes.Properties.Resources.Motor_R2;
            this.picMR.Location = new System.Drawing.Point(763, 134);
            this.picMR.Name = "picMR";
            this.picMR.Size = new System.Drawing.Size(97, 124);
            this.picMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMR.TabIndex = 7;
            this.picMR.TabStop = false;
            // 
            // picMG
            // 
            this.picMG.Image = global::Control_Industrial_Processes.Properties.Resources.Motor_G3;
            this.picMG.Location = new System.Drawing.Point(763, 134);
            this.picMG.Name = "picMG";
            this.picMG.Size = new System.Drawing.Size(97, 124);
            this.picMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMG.TabIndex = 6;
            this.picMG.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnStop.BackgroundImage = global::Control_Industrial_Processes.Properties.Resources.Stop_Switch;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnStop.Location = new System.Drawing.Point(104, 72);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 50);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::Control_Industrial_Processes.Properties.Resources.Start_Switch;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnStart.Location = new System.Drawing.Point(30, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // SAP
            // 
            this.SAP.ArrayCount = 3;
            this.SAP.ColorBackground = System.Drawing.Color.Black;
            this.SAP.ColorDark = System.Drawing.Color.DimGray;
            this.SAP.ColorLight = System.Drawing.Color.Yellow;
            this.SAP.DecimalShow = true;
            this.SAP.ElementPadding = new System.Windows.Forms.Padding(4);
            this.SAP.ElementWidth = 10;
            this.SAP.ItalicFactor = 0F;
            this.SAP.Location = new System.Drawing.Point(760, 443);
            this.SAP.Name = "SAP";
            this.SAP.Size = new System.Drawing.Size(100, 45);
            this.SAP.TabIndex = 18;
            this.SAP.TabStop = false;
            this.SAP.Value = null;
            // 
            // SA1
            // 
            this.SA1.ArrayCount = 3;
            this.SA1.ColorBackground = System.Drawing.Color.Black;
            this.SA1.ColorDark = System.Drawing.Color.DimGray;
            this.SA1.ColorLight = System.Drawing.Color.Yellow;
            this.SA1.DecimalShow = true;
            this.SA1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.SA1.ElementWidth = 10;
            this.SA1.ItalicFactor = 0F;
            this.SA1.Location = new System.Drawing.Point(760, 72);
            this.SA1.Name = "SA1";
            this.SA1.Size = new System.Drawing.Size(100, 45);
            this.SA1.TabIndex = 17;
            this.SA1.TabStop = false;
            this.SA1.Value = null;
            // 
            // SAV
            // 
            this.SAV.ArrayCount = 3;
            this.SAV.ColorBackground = System.Drawing.Color.Black;
            this.SAV.ColorDark = System.Drawing.Color.DimGray;
            this.SAV.ColorLight = System.Drawing.Color.Yellow;
            this.SAV.DecimalShow = true;
            this.SAV.ElementPadding = new System.Windows.Forms.Padding(4);
            this.SAV.ElementWidth = 10;
            this.SAV.ItalicFactor = 0F;
            this.SAV.Location = new System.Drawing.Point(600, 240);
            this.SAV.Name = "SAV";
            this.SAV.Size = new System.Drawing.Size(100, 45);
            this.SAV.TabIndex = 16;
            this.SAV.TabStop = false;
            this.SAV.Value = null;
            // 
            // SAT
            // 
            this.SAT.ArrayCount = 3;
            this.SAT.ColorBackground = System.Drawing.Color.Black;
            this.SAT.ColorDark = System.Drawing.Color.DimGray;
            this.SAT.ColorLight = System.Drawing.Color.Yellow;
            this.SAT.DecimalShow = true;
            this.SAT.ElementPadding = new System.Windows.Forms.Padding(4);
            this.SAT.ElementWidth = 10;
            this.SAT.ItalicFactor = 0F;
            this.SAT.Location = new System.Drawing.Point(237, 535);
            this.SAT.Name = "SAT";
            this.SAT.Size = new System.Drawing.Size(100, 45);
            this.SAT.TabIndex = 15;
            this.SAT.TabStop = false;
            this.SAT.Value = null;
            // 
            // WaterTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 592);
            this.Controls.Add(this.SAP);
            this.Controls.Add(this.SA1);
            this.Controls.Add(this.SAV);
            this.Controls.Add(this.SAT);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.picOR);
            this.Controls.Add(this.picOG);
            this.Controls.Add(this.picTR);
            this.Controls.Add(this.picTG);
            this.Controls.Add(this.picPR);
            this.Controls.Add(this.picPG);
            this.Controls.Add(this.picMR);
            this.Controls.Add(this.picMG);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WaterTank";
            this.Text = "WaterTank";
            ((System.ComponentModel.ISupportInitialize)(this.picOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox picMG;
        private System.Windows.Forms.PictureBox picMR;
        private System.Windows.Forms.PictureBox picPG;
        private System.Windows.Forms.PictureBox picPR;
        private System.Windows.Forms.PictureBox picTG;
        private System.Windows.Forms.PictureBox picTR;
        private System.Windows.Forms.PictureBox picOG;
        private System.Windows.Forms.PictureBox picOR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbC;
        private DmitryBrant.CustomControls.SevenSegmentArray SAT;
        private DmitryBrant.CustomControls.SevenSegmentArray SAV;
        private DmitryBrant.CustomControls.SevenSegmentArray SA1;
        private DmitryBrant.CustomControls.SevenSegmentArray SAP;
    }
}