
namespace Control_Industrial_Processes
{
    partial class WorkBenchToolKit
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
            this.workBenchWidget1 = new Control_Industrial_Processes.WorkBenchWidget();
            this.moveGauge1 = new Control_Industrial_Processes.MoveGauge(this.components);
            this.txtBox6 = new Control_Industrial_Processes.txtBox(this.components);
            this.txtBox5 = new Control_Industrial_Processes.txtBox(this.components);
            this.txtBox4 = new Control_Industrial_Processes.txtBox(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.moveButton2 = new MouseEvent.MoveButton(this.components);
            this.moveButton1 = new MouseEvent.MoveButton(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveGauge2 = new Control_Industrial_Processes.MoveGauge(this.components);
            this.moveGauge3 = new Control_Industrial_Processes.MoveGauge(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // workBenchWidget1
            // 
            this.workBenchWidget1.GridCellSize = new System.Drawing.Size(32, 32);
            this.workBenchWidget1.GridColor = System.Drawing.Color.Gray;
            this.workBenchWidget1.Gridlines = true;
            this.workBenchWidget1.Location = new System.Drawing.Point(1, 277);
            this.workBenchWidget1.Name = "workBenchWidget1";
            this.workBenchWidget1.Size = new System.Drawing.Size(861, 421);
            this.workBenchWidget1.SnapTopGrid = false;
            this.workBenchWidget1.TabIndex = 2;
            // 
            // moveGauge1
            // 
            this.moveGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.moveGauge1.BaseArcRadius = 80;
            this.moveGauge1.BaseArcStart = 135;
            this.moveGauge1.BaseArcSweep = 270;
            this.moveGauge1.BaseArcWidth = 2;
            this.moveGauge1.Cap_Idx = ((byte)(1));
            this.moveGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.moveGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.moveGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.moveGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.moveGauge1.CapText = "";
            this.moveGauge1.Center = new System.Drawing.Point(100, 100);
            this.moveGauge1.Location = new System.Drawing.Point(12, 70);
            this.moveGauge1.MaxValue = 400F;
            this.moveGauge1.MinValue = -100F;
            this.moveGauge1.Name = "moveGauge1";
            this.moveGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.moveGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.moveGauge1.NeedleRadius = 80;
            this.moveGauge1.NeedleType = 0;
            this.moveGauge1.NeedleWidth = 2;
            this.moveGauge1.Range_Idx = ((byte)(0));
            this.moveGauge1.RangeColor = System.Drawing.Color.Yellow;
            this.moveGauge1.RangeEnabled = true;
            this.moveGauge1.RangeEndValue = 300F;
            this.moveGauge1.RangeInnerRadius = 70;
            this.moveGauge1.RangeOuterRadius = 80;
            this.moveGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.moveGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.moveGauge1.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.moveGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.moveGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.moveGauge1.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.moveGauge1.RangeStartValue = -100F;
            this.moveGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.moveGauge1.ScaleLinesInterInnerRadius = 73;
            this.moveGauge1.ScaleLinesInterOuterRadius = 80;
            this.moveGauge1.ScaleLinesInterWidth = 1;
            this.moveGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.moveGauge1.ScaleLinesMajorInnerRadius = 70;
            this.moveGauge1.ScaleLinesMajorOuterRadius = 80;
            this.moveGauge1.ScaleLinesMajorStepValue = 50F;
            this.moveGauge1.ScaleLinesMajorWidth = 2;
            this.moveGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.moveGauge1.ScaleLinesMinorInnerRadius = 75;
            this.moveGauge1.ScaleLinesMinorNumOf = 9;
            this.moveGauge1.ScaleLinesMinorOuterRadius = 80;
            this.moveGauge1.ScaleLinesMinorWidth = 1;
            this.moveGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.moveGauge1.ScaleNumbersFormat = null;
            this.moveGauge1.ScaleNumbersRadius = 95;
            this.moveGauge1.ScaleNumbersRotation = 0;
            this.moveGauge1.ScaleNumbersStartScaleLine = 0;
            this.moveGauge1.ScaleNumbersStepScaleLines = 1;
            this.moveGauge1.Size = new System.Drawing.Size(209, 181);
            this.moveGauge1.TabIndex = 3;
            this.moveGauge1.Text = "moveGauge1";
            this.moveGauge1.Value = 0F;
            // 
            // txtBox6
            // 
            this.txtBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBox6.Location = new System.Drawing.Point(573, 44);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.Size = new System.Drawing.Size(53, 20);
            this.txtBox6.TabIndex = 67;
            // 
            // txtBox5
            // 
            this.txtBox5.BackColor = System.Drawing.Color.Lime;
            this.txtBox5.Location = new System.Drawing.Point(343, 45);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(53, 20);
            this.txtBox5.TabIndex = 66;
            // 
            // txtBox4
            // 
            this.txtBox4.BackColor = System.Drawing.Color.Yellow;
            this.txtBox4.Location = new System.Drawing.Point(82, 40);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(53, 20);
            this.txtBox4.TabIndex = 65;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(792, 107);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 13);
            this.lbl1.TabIndex = 61;
            this.lbl1.Text = "C1";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // moveButton2
            // 
            this.moveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.moveButton2.Location = new System.Drawing.Point(759, 55);
            this.moveButton2.Name = "moveButton2";
            this.moveButton2.Size = new System.Drawing.Size(75, 38);
            this.moveButton2.TabIndex = 60;
            this.moveButton2.Text = "Stop";
            this.moveButton2.UseVisualStyleBackColor = true;
            this.moveButton2.Click += new System.EventHandler(this.moveButton2_Click);
            // 
            // moveButton1
            // 
            this.moveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.moveButton1.Location = new System.Drawing.Point(759, 11);
            this.moveButton1.Name = "moveButton1";
            this.moveButton1.Size = new System.Drawing.Size(75, 38);
            this.moveButton1.TabIndex = 59;
            this.moveButton1.Text = "Start";
            this.moveButton1.UseVisualStyleBackColor = true;
            this.moveButton1.Click += new System.EventHandler(this.moveButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox3.Location = new System.Drawing.Point(556, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 27);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tag3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lime;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox2.Location = new System.Drawing.Point(330, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 27);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tag2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.groupBox1.Location = new System.Drawing.Point(68, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 26);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag1";
            // 
            // moveGauge2
            // 
            this.moveGauge2.BackColor = System.Drawing.SystemColors.Control;
            this.moveGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.moveGauge2.BaseArcRadius = 80;
            this.moveGauge2.BaseArcStart = 135;
            this.moveGauge2.BaseArcSweep = 270;
            this.moveGauge2.BaseArcWidth = 2;
            this.moveGauge2.Cap_Idx = ((byte)(1));
            this.moveGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.moveGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.moveGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.moveGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.moveGauge2.CapText = "";
            this.moveGauge2.Center = new System.Drawing.Point(100, 100);
            this.moveGauge2.Location = new System.Drawing.Point(266, 70);
            this.moveGauge2.MaxValue = 400F;
            this.moveGauge2.MinValue = -100F;
            this.moveGauge2.Name = "moveGauge2";
            this.moveGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.moveGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.moveGauge2.NeedleRadius = 80;
            this.moveGauge2.NeedleType = 0;
            this.moveGauge2.NeedleWidth = 2;
            this.moveGauge2.Range_Idx = ((byte)(0));
            this.moveGauge2.RangeColor = System.Drawing.Color.Lime;
            this.moveGauge2.RangeEnabled = true;
            this.moveGauge2.RangeEndValue = 300F;
            this.moveGauge2.RangeInnerRadius = 70;
            this.moveGauge2.RangeOuterRadius = 80;
            this.moveGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.moveGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.moveGauge2.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.moveGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.moveGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.moveGauge2.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.moveGauge2.RangeStartValue = -100F;
            this.moveGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.moveGauge2.ScaleLinesInterInnerRadius = 73;
            this.moveGauge2.ScaleLinesInterOuterRadius = 80;
            this.moveGauge2.ScaleLinesInterWidth = 1;
            this.moveGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.moveGauge2.ScaleLinesMajorInnerRadius = 70;
            this.moveGauge2.ScaleLinesMajorOuterRadius = 80;
            this.moveGauge2.ScaleLinesMajorStepValue = 50F;
            this.moveGauge2.ScaleLinesMajorWidth = 2;
            this.moveGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.moveGauge2.ScaleLinesMinorInnerRadius = 75;
            this.moveGauge2.ScaleLinesMinorNumOf = 9;
            this.moveGauge2.ScaleLinesMinorOuterRadius = 80;
            this.moveGauge2.ScaleLinesMinorWidth = 1;
            this.moveGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.moveGauge2.ScaleNumbersFormat = null;
            this.moveGauge2.ScaleNumbersRadius = 95;
            this.moveGauge2.ScaleNumbersRotation = 0;
            this.moveGauge2.ScaleNumbersStartScaleLine = 0;
            this.moveGauge2.ScaleNumbersStepScaleLines = 1;
            this.moveGauge2.Size = new System.Drawing.Size(206, 181);
            this.moveGauge2.TabIndex = 68;
            this.moveGauge2.Text = "moveGauge2";
            this.moveGauge2.Value = 0F;
            // 
            // moveGauge3
            // 
            this.moveGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.moveGauge3.BaseArcRadius = 80;
            this.moveGauge3.BaseArcStart = 135;
            this.moveGauge3.BaseArcSweep = 270;
            this.moveGauge3.BaseArcWidth = 2;
            this.moveGauge3.Cap_Idx = ((byte)(1));
            this.moveGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.moveGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.moveGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.moveGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.moveGauge3.CapText = "";
            this.moveGauge3.Center = new System.Drawing.Point(100, 100);
            this.moveGauge3.Location = new System.Drawing.Point(511, 76);
            this.moveGauge3.MaxValue = 400F;
            this.moveGauge3.MinValue = -100F;
            this.moveGauge3.Name = "moveGauge3";
            this.moveGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.moveGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.moveGauge3.NeedleRadius = 80;
            this.moveGauge3.NeedleType = 0;
            this.moveGauge3.NeedleWidth = 2;
            this.moveGauge3.Range_Idx = ((byte)(0));
            this.moveGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.moveGauge3.RangeEnabled = true;
            this.moveGauge3.RangeEndValue = 300F;
            this.moveGauge3.RangeInnerRadius = 70;
            this.moveGauge3.RangeOuterRadius = 80;
            this.moveGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.moveGauge3.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.moveGauge3.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.moveGauge3.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.moveGauge3.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.moveGauge3.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.moveGauge3.RangeStartValue = -100F;
            this.moveGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.moveGauge3.ScaleLinesInterInnerRadius = 73;
            this.moveGauge3.ScaleLinesInterOuterRadius = 80;
            this.moveGauge3.ScaleLinesInterWidth = 1;
            this.moveGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.moveGauge3.ScaleLinesMajorInnerRadius = 70;
            this.moveGauge3.ScaleLinesMajorOuterRadius = 80;
            this.moveGauge3.ScaleLinesMajorStepValue = 50F;
            this.moveGauge3.ScaleLinesMajorWidth = 2;
            this.moveGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.moveGauge3.ScaleLinesMinorInnerRadius = 75;
            this.moveGauge3.ScaleLinesMinorNumOf = 9;
            this.moveGauge3.ScaleLinesMinorOuterRadius = 80;
            this.moveGauge3.ScaleLinesMinorWidth = 1;
            this.moveGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.moveGauge3.ScaleNumbersFormat = null;
            this.moveGauge3.ScaleNumbersRadius = 95;
            this.moveGauge3.ScaleNumbersRotation = 0;
            this.moveGauge3.ScaleNumbersStartScaleLine = 0;
            this.moveGauge3.ScaleNumbersStepScaleLines = 1;
            this.moveGauge3.Size = new System.Drawing.Size(203, 175);
            this.moveGauge3.TabIndex = 69;
            this.moveGauge3.Text = "moveGauge3";
            this.moveGauge3.Value = 0F;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WorkBenchToolKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 689);
            this.Controls.Add(this.moveGauge3);
            this.Controls.Add(this.moveGauge2);
            this.Controls.Add(this.txtBox6);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.moveButton2);
            this.Controls.Add(this.moveButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.moveGauge1);
            this.Controls.Add(this.workBenchWidget1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WorkBenchToolKit";
            this.Text = "WorkBenchToolKit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WorkBenchWidget workBenchWidget1;
        private MoveGauge moveGauge1;
        private txtBox txtBox6;
        private txtBox txtBox5;
        private txtBox txtBox4;
        private System.Windows.Forms.Label lbl1;
        private MouseEvent.MoveButton moveButton2;
        private MouseEvent.MoveButton moveButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MoveGauge moveGauge2;
        private MoveGauge moveGauge3;
        private System.Windows.Forms.Timer timer1;
    }
}