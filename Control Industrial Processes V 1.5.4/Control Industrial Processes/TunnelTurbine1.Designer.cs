
namespace Control_Industrial_Processes
{
    partial class TunnelTurbine1
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
            this.aGauge1 = new AGaugeApp.AGauge();
            this.knobControl1 = new KnobControl.KnobControl();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbtn = new System.Windows.Forms.Button();
            this.Dbtn = new System.Windows.Forms.Button();
            this.lblc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Server = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(83, 270);
            this.aGauge1.MaxValue = 500F;
            this.aGauge1.MinValue = -100F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(0));
            this.aGauge1.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 300F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = -100F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(225, 204);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // knobControl1
            // 
            this.knobControl1.EndAngle = 405F;
            this.knobControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobControl1.KnobBackColor = System.Drawing.Color.LimeGreen;
            this.knobControl1.KnobPointerStyle = KnobControl.KnobControl.KnobPointerStyles.line;
            this.knobControl1.LargeChange = 5;
            this.knobControl1.Location = new System.Drawing.Point(382, 31);
            this.knobControl1.Maximum = 500;
            this.knobControl1.Minimum = 0;
            this.knobControl1.Name = "knobControl1";
            this.knobControl1.PointerColor = System.Drawing.Color.Red;
            this.knobControl1.ScaleColor = System.Drawing.Color.Black;
            this.knobControl1.ScaleDivisions = 11;
            this.knobControl1.ScaleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.knobControl1.ScaleSubDivisions = 4;
            this.knobControl1.ShowLargeScale = true;
            this.knobControl1.ShowSmallScale = false;
            this.knobControl1.Size = new System.Drawing.Size(194, 194);
            this.knobControl1.SmallChange = 1;
            this.knobControl1.StartAngle = 135F;
            this.knobControl1.TabIndex = 1;
            this.knobControl1.Value = 0;
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "";
            this.aGauge3.Center = new System.Drawing.Point(100, 100);
            this.aGauge3.Location = new System.Drawing.Point(666, 270);
            this.aGauge3.MaxValue = 500F;
            this.aGauge3.MinValue = -100F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(0));
            this.aGauge3.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 300F;
            this.aGauge3.RangeInnerRadius = 70;
            this.aGauge3.RangeOuterRadius = 80;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = -100F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 50F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 95;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(225, 204);
            this.aGauge3.TabIndex = 3;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDT.Location = new System.Drawing.Point(675, 12);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(276, 26);
            this.txtDT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(573, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date-Time:";
            // 
            // Cbtn
            // 
            this.Cbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cbtn.Location = new System.Drawing.Point(83, 31);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(115, 51);
            this.Cbtn.TabIndex = 8;
            this.Cbtn.Text = "Connect";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // Dbtn
            // 
            this.Dbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dbtn.Location = new System.Drawing.Point(83, 102);
            this.Dbtn.Name = "Dbtn";
            this.Dbtn.Size = new System.Drawing.Size(115, 51);
            this.Dbtn.TabIndex = 9;
            this.Dbtn.Text = "Disconnect";
            this.Dbtn.UseVisualStyleBackColor = true;
            this.Dbtn.Click += new System.EventHandler(this.Dbtn_Click);
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblc.Location = new System.Drawing.Point(79, 184);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(33, 20);
            this.lblc.TabIndex = 10;
            this.lblc.Text = "C1:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Server
            // 
            this.Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Server.Location = new System.Drawing.Point(675, 61);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(276, 26);
            this.Server.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(601, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Server:";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt1.Location = new System.Drawing.Point(134, 469);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(94, 26);
            this.txt1.TabIndex = 13;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            this.aGauge2.Location = new System.Drawing.Point(373, 270);
            this.aGauge2.MaxValue = 500F;
            this.aGauge2.MinValue = -100F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(0));
            this.aGauge2.RangeColor = System.Drawing.Color.LightGreen;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 300F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = -100F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(225, 204);
            this.aGauge2.TabIndex = 2;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt2.Location = new System.Drawing.Point(427, 469);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(94, 26);
            this.txt2.TabIndex = 14;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt3.Location = new System.Drawing.Point(721, 469);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(94, 26);
            this.txt3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(111, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Turbine Number 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(407, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Turbine Number 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(700, 498);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Turbine Number 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(439, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Power/KW";
            // 
            // TunnelTurbine1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 527);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.Dbtn);
            this.Controls.Add(this.Cbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.knobControl1);
            this.Controls.Add(this.aGauge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TunnelTurbine1";
            this.Text = "TunnelTurbine1";
            this.Load += new System.EventHandler(this.TunnelTurbine1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGaugeApp.AGauge aGauge1;
        private KnobControl.KnobControl knobControl1;
        private AGaugeApp.AGauge aGauge3;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button Dbtn;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private AGaugeApp.AGauge aGauge2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}