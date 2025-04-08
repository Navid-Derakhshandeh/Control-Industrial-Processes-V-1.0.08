
namespace Control_Industrial_Processes
{
    partial class Receiver
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
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDPort = new System.Windows.Forms.TextBox();
            this.txtSPort = new System.Windows.Forms.TextBox();
            this.txtDIP = new System.Windows.Forms.TextBox();
            this.txtSIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.SuspendLayout();
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 3;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(431, 239);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(138, 57);
            this.sevenSegmentArray1.TabIndex = 28;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = null;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(468, 155);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 40);
            this.btnConnect.TabIndex = 27;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDPort
            // 
            this.txtDPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDPort.Location = new System.Drawing.Point(484, 101);
            this.txtDPort.Name = "txtDPort";
            this.txtDPort.Size = new System.Drawing.Size(92, 26);
            this.txtDPort.TabIndex = 26;
            // 
            // txtSPort
            // 
            this.txtSPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSPort.Location = new System.Drawing.Point(484, 36);
            this.txtSPort.Name = "txtSPort";
            this.txtSPort.Size = new System.Drawing.Size(92, 26);
            this.txtSPort.TabIndex = 25;
            // 
            // txtDIP
            // 
            this.txtDIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDIP.Location = new System.Drawing.Point(153, 101);
            this.txtDIP.Name = "txtDIP";
            this.txtDIP.Size = new System.Drawing.Size(227, 26);
            this.txtDIP.TabIndex = 24;
            // 
            // txtSIP
            // 
            this.txtSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSIP.Location = new System.Drawing.Point(153, 36);
            this.txtSIP.Name = "txtSIP";
            this.txtSIP.Size = new System.Drawing.Size(227, 26);
            this.txtSIP.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(427, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(34, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Destination IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(427, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Source IP:";
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
            this.aGauge1.Location = new System.Drawing.Point(168, 155);
            this.aGauge1.MaxValue = 400F;
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
            this.aGauge1.Size = new System.Drawing.Size(212, 191);
            this.aGauge1.TabIndex = 18;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // Receiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 379);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDPort);
            this.Controls.Add(this.txtSPort);
            this.Controls.Add(this.txtDIP);
            this.Controls.Add(this.txtSIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aGauge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Receiver";
            this.Text = "Receiver";
            this.Load += new System.EventHandler(this.Receiver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDPort;
        private System.Windows.Forms.TextBox txtSPort;
        private System.Windows.Forms.TextBox txtDIP;
        private System.Windows.Forms.TextBox txtSIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AGaugeApp.AGauge aGauge1;
    }
}