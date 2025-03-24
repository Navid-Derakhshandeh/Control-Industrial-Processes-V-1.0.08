
namespace Control_Industrial_Processes
{
    partial class Boiler
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
            this.btnSP = new System.Windows.Forms.Button();
            this.btnSTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPS = new System.Windows.Forms.TextBox();
            this.Lbc1 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.lbTemp1 = new System.Windows.Forms.Label();
            this.LbP1 = new System.Windows.Forms.Label();
            this.ledTemp1 = new Bulb.LedBulb();
            this.ledSVGfail = new Bulb.LedBulb();
            this.ledScfail = new Bulb.LedBulb();
            this.ledSVG = new Bulb.LedBulb();
            this.ledSV = new Bulb.LedBulb();
            this.ledfail = new Bulb.LedBulb();
            this.ledM1 = new Bulb.LedBulb();
            this.ledvalve = new Bulb.LedBulb();
            this.ledMotor = new Bulb.LedBulb();
            this.ledP1 = new Bulb.LedBulb();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSP.Location = new System.Drawing.Point(726, 16);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(75, 38);
            this.btnSP.TabIndex = 0;
            this.btnSP.Text = "Start";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnSTP
            // 
            this.btnSTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSTP.Location = new System.Drawing.Point(817, 16);
            this.btnSTP.Name = "btnSTP";
            this.btnSTP.Size = new System.Drawing.Size(75, 38);
            this.btnSTP.TabIndex = 1;
            this.btnSTP.Text = "Stop";
            this.btnSTP.UseVisualStyleBackColor = true;
            this.btnSTP.Click += new System.EventHandler(this.btnSTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter IP of Modbus Server:";
            // 
            // txtIPS
            // 
            this.txtIPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIPS.Location = new System.Drawing.Point(270, 16);
            this.txtIPS.Name = "txtIPS";
            this.txtIPS.Size = new System.Drawing.Size(153, 26);
            this.txtIPS.TabIndex = 3;
            // 
            // Lbc1
            // 
            this.Lbc1.AutoSize = true;
            this.Lbc1.Location = new System.Drawing.Point(16, 55);
            this.Lbc1.Name = "Lbc1";
            this.Lbc1.Size = new System.Drawing.Size(20, 13);
            this.Lbc1.TabIndex = 4;
            this.Lbc1.Text = "C1";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(642, 141);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(63, 20);
            this.txtv1.TabIndex = 6;
            // 
            // lbTemp1
            // 
            this.lbTemp1.AutoSize = true;
            this.lbTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTemp1.Location = new System.Drawing.Point(597, 198);
            this.lbTemp1.Name = "lbTemp1";
            this.lbTemp1.Size = new System.Drawing.Size(29, 20);
            this.lbTemp1.TabIndex = 14;
            this.lbTemp1.Text = "C2";
            // 
            // LbP1
            // 
            this.LbP1.AutoSize = true;
            this.LbP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbP1.Location = new System.Drawing.Point(408, 159);
            this.LbP1.Name = "LbP1";
            this.LbP1.Size = new System.Drawing.Size(29, 20);
            this.LbP1.TabIndex = 15;
            this.LbP1.Text = "C3";
            // 
            // ledTemp1
            // 
            this.ledTemp1.Color = System.Drawing.Color.Yellow;
            this.ledTemp1.Location = new System.Drawing.Point(676, 198);
            this.ledTemp1.Name = "ledTemp1";
            this.ledTemp1.On = true;
            this.ledTemp1.Size = new System.Drawing.Size(29, 36);
            this.ledTemp1.TabIndex = 16;
            this.ledTemp1.Text = "ledBulb1";
            // 
            // ledSVGfail
            // 
            this.ledSVGfail.Color = System.Drawing.Color.Red;
            this.ledSVGfail.Location = new System.Drawing.Point(642, 495);
            this.ledSVGfail.Name = "ledSVGfail";
            this.ledSVGfail.On = true;
            this.ledSVGfail.Size = new System.Drawing.Size(31, 23);
            this.ledSVGfail.TabIndex = 13;
            this.ledSVGfail.Text = "ledBulb1";
            // 
            // ledScfail
            // 
            this.ledScfail.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ledScfail.Location = new System.Drawing.Point(378, 124);
            this.ledScfail.Name = "ledScfail";
            this.ledScfail.On = true;
            this.ledScfail.Size = new System.Drawing.Size(22, 23);
            this.ledScfail.TabIndex = 12;
            this.ledScfail.Text = "ledBulb1";
            // 
            // ledSVG
            // 
            this.ledSVG.Location = new System.Drawing.Point(642, 390);
            this.ledSVG.Name = "ledSVG";
            this.ledSVG.On = true;
            this.ledSVG.Size = new System.Drawing.Size(31, 23);
            this.ledSVG.TabIndex = 11;
            this.ledSVG.Text = "ledBulb1";
            // 
            // ledSV
            // 
            this.ledSV.Location = new System.Drawing.Point(378, 66);
            this.ledSV.Name = "ledSV";
            this.ledSV.On = true;
            this.ledSV.Size = new System.Drawing.Size(26, 31);
            this.ledSV.TabIndex = 10;
            this.ledSV.Text = "ledBulb1";
            // 
            // ledfail
            // 
            this.ledfail.Color = System.Drawing.Color.Red;
            this.ledfail.Location = new System.Drawing.Point(707, 124);
            this.ledfail.Name = "ledfail";
            this.ledfail.On = true;
            this.ledfail.Size = new System.Drawing.Size(24, 21);
            this.ledfail.TabIndex = 9;
            this.ledfail.Text = "ledBulb1";
            // 
            // ledM1
            // 
            this.ledM1.Color = System.Drawing.Color.Red;
            this.ledM1.Location = new System.Drawing.Point(693, 16);
            this.ledM1.Name = "ledM1";
            this.ledM1.On = true;
            this.ledM1.Size = new System.Drawing.Size(27, 23);
            this.ledM1.TabIndex = 8;
            this.ledM1.Text = "ledBulb1";
            // 
            // ledvalve
            // 
            this.ledvalve.Location = new System.Drawing.Point(616, 124);
            this.ledvalve.Name = "ledvalve";
            this.ledvalve.On = true;
            this.ledvalve.Size = new System.Drawing.Size(20, 21);
            this.ledvalve.TabIndex = 7;
            this.ledvalve.Text = "ledBulb1";
            // 
            // ledMotor
            // 
            this.ledMotor.Color = System.Drawing.Color.Lime;
            this.ledMotor.Location = new System.Drawing.Point(629, 16);
            this.ledMotor.Name = "ledMotor";
            this.ledMotor.On = true;
            this.ledMotor.Size = new System.Drawing.Size(23, 24);
            this.ledMotor.TabIndex = 5;
            this.ledMotor.Text = "ledBulb1";
            // 
            // ledP1
            // 
            this.ledP1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ledP1.Location = new System.Drawing.Point(487, 155);
            this.ledP1.Name = "ledP1";
            this.ledP1.On = true;
            this.ledP1.Size = new System.Drawing.Size(28, 24);
            this.ledP1.TabIndex = 17;
            this.ledP1.Text = "ledBulb1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Boiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control_Industrial_Processes.Properties.Resources.Screenshot__72_;
            this.ClientSize = new System.Drawing.Size(970, 530);
            this.Controls.Add(this.ledP1);
            this.Controls.Add(this.ledTemp1);
            this.Controls.Add(this.LbP1);
            this.Controls.Add(this.lbTemp1);
            this.Controls.Add(this.ledSVGfail);
            this.Controls.Add(this.ledScfail);
            this.Controls.Add(this.ledSVG);
            this.Controls.Add(this.ledSV);
            this.Controls.Add(this.ledfail);
            this.Controls.Add(this.ledM1);
            this.Controls.Add(this.ledvalve);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.ledMotor);
            this.Controls.Add(this.Lbc1);
            this.Controls.Add(this.txtIPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSTP);
            this.Controls.Add(this.btnSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Boiler";
            this.Text = "Boiler";
            this.Load += new System.EventHandler(this.Boiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnSTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPS;
        private System.Windows.Forms.Label Lbc1;
        private Bulb.LedBulb ledMotor;
        private System.Windows.Forms.TextBox txtv1;
        private Bulb.LedBulb ledvalve;
        private Bulb.LedBulb ledM1;
        private Bulb.LedBulb ledfail;
        private Bulb.LedBulb ledSV;
        private Bulb.LedBulb ledSVG;
        private Bulb.LedBulb ledScfail;
        private Bulb.LedBulb ledSVGfail;
        private System.Windows.Forms.Label lbTemp1;
        private System.Windows.Forms.Label LbP1;
        private Bulb.LedBulb ledTemp1;
        private Bulb.LedBulb ledP1;
        private System.Windows.Forms.Timer timer1;
    }
}