
namespace Control_Industrial_Processes
{
    partial class Temp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temp));
            this.LbVoltage = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.LbError = new System.Windows.Forms.Label();
            this.cbGas = new System.Windows.Forms.CheckBox();
            this.cbPower = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.LbO = new System.Windows.Forms.Label();
            this.LbS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbWater = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.Lb5 = new System.Windows.Forms.Label();
            this.Lb6 = new System.Windows.Forms.Label();
            this.Lb7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lb10 = new System.Windows.Forms.Label();
            this.LbNoerror = new System.Windows.Forms.Label();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.led1 = new Bulb.LedBulb();
            this.led2 = new Bulb.LedBulb();
            this.led3 = new Bulb.LedBulb();
            this.led6 = new Bulb.LedBulb();
            this.led5 = new Bulb.LedBulb();
            this.led4 = new Bulb.LedBulb();
            this.SuspendLayout();
            // 
            // LbVoltage
            // 
            this.LbVoltage.AutoSize = true;
            this.LbVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbVoltage.Location = new System.Drawing.Point(622, 408);
            this.LbVoltage.Name = "LbVoltage";
            this.LbVoltage.Size = new System.Drawing.Size(29, 20);
            this.LbVoltage.TabIndex = 29;
            this.LbVoltage.Text = "C4";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label4.Location = new System.Drawing.Point(471, 408);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(135, 20);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Voltage Equal By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(41, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Temperature: of Environment";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.SystemColors.Info;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTemp.Location = new System.Drawing.Point(262, 408);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 26);
            this.txtTemp.TabIndex = 26;
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbError.Location = new System.Drawing.Point(37, 356);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(52, 20);
            this.LbError.TabIndex = 25;
            this.LbError.Text = "Issue:";
            // 
            // cbGas
            // 
            this.cbGas.AutoSize = true;
            this.cbGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGas.Location = new System.Drawing.Point(37, 291);
            this.cbGas.Name = "cbGas";
            this.cbGas.Size = new System.Drawing.Size(95, 24);
            this.cbGas.TabIndex = 24;
            this.cbGas.Text = "Gas Flow";
            this.cbGas.UseVisualStyleBackColor = true;
            // 
            // cbPower
            // 
            this.cbPower.AutoSize = true;
            this.cbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPower.Location = new System.Drawing.Point(37, 261);
            this.cbPower.Name = "cbPower";
            this.cbPower.Size = new System.Drawing.Size(97, 24);
            this.cbPower.TabIndex = 23;
            this.cbPower.Text = "Power On";
            this.cbPower.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDisconnect.Location = new System.Drawing.Point(320, 113);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 39);
            this.btnDisconnect.TabIndex = 22;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // LbO
            // 
            this.LbO.AutoSize = true;
            this.LbO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbO.Location = new System.Drawing.Point(494, 192);
            this.LbO.Name = "LbO";
            this.LbO.Size = new System.Drawing.Size(55, 20);
            this.LbO.TabIndex = 21;
            this.LbO.Text = "Offline";
            // 
            // LbS
            // 
            this.LbS.AutoSize = true;
            this.LbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbS.Location = new System.Drawing.Point(314, 192);
            this.LbS.Name = "LbS";
            this.LbS.Size = new System.Drawing.Size(165, 20);
            this.LbS.TabIndex = 20;
            this.LbS.Text = "Connection Situation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(215, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter IP of Modbus Server:";
            // 
            // ServerIp
            // 
            this.ServerIp.BackColor = System.Drawing.SystemColors.Info;
            this.ServerIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ServerIp.Location = new System.Drawing.Point(421, 12);
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.Size = new System.Drawing.Size(128, 26);
            this.ServerIp.TabIndex = 18;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(320, 72);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 35);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbWater
            // 
            this.cbWater.AutoSize = true;
            this.cbWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbWater.Location = new System.Drawing.Point(37, 322);
            this.cbWater.Name = "cbWater";
            this.cbWater.Size = new System.Drawing.Size(108, 24);
            this.cbWater.TabIndex = 30;
            this.cbWater.Text = "Water Flow";
            this.cbWater.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(622, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Date / Time:";
            // 
            // txtDT
            // 
            this.txtDT.BackColor = System.Drawing.SystemColors.Info;
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDT.Location = new System.Drawing.Point(733, 12);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(197, 26);
            this.txtDT.TabIndex = 32;
            // 
            // Lb5
            // 
            this.Lb5.AutoSize = true;
            this.Lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb5.Location = new System.Drawing.Point(622, 265);
            this.Lb5.Name = "Lb5";
            this.Lb5.Size = new System.Drawing.Size(29, 20);
            this.Lb5.TabIndex = 33;
            this.Lb5.Text = "C1";
            // 
            // Lb6
            // 
            this.Lb6.AutoSize = true;
            this.Lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb6.Location = new System.Drawing.Point(622, 295);
            this.Lb6.Name = "Lb6";
            this.Lb6.Size = new System.Drawing.Size(29, 20);
            this.Lb6.TabIndex = 34;
            this.Lb6.Text = "C2";
            // 
            // Lb7
            // 
            this.Lb7.AutoSize = true;
            this.Lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb7.Location = new System.Drawing.Point(622, 326);
            this.Lb7.Name = "Lb7";
            this.Lb7.Size = new System.Drawing.Size(29, 20);
            this.Lb7.TabIndex = 35;
            this.Lb7.Text = "C3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(528, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Power Is :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(563, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Gas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(554, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Water";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(528, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "If During Processes Runing any Problem occurred.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(528, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Please Open Event Program and Register That.";
            // 
            // Lb10
            // 
            this.Lb10.AutoSize = true;
            this.Lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb10.Location = new System.Drawing.Point(368, 411);
            this.Lb10.Name = "Lb10";
            this.Lb10.Size = new System.Drawing.Size(29, 20);
            this.Lb10.TabIndex = 41;
            this.Lb10.Text = "C5";
            // 
            // LbNoerror
            // 
            this.LbNoerror.AutoSize = true;
            this.LbNoerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbNoerror.Location = new System.Drawing.Point(749, 408);
            this.LbNoerror.Name = "LbNoerror";
            this.LbNoerror.Size = new System.Drawing.Size(29, 20);
            this.LbNoerror.TabIndex = 42;
            this.LbNoerror.Text = "C6";
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
            this.aGauge1.Location = new System.Drawing.Point(37, 35);
            this.aGauge1.MaxValue = 800F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
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
            this.aGauge1.Size = new System.Drawing.Size(219, 191);
            this.aGauge1.TabIndex = 15;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge1_ValueInRangeChanged);
            // 
            // led1
            // 
            this.led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.led1.Location = new System.Drawing.Point(687, 261);
            this.led1.Name = "led1";
            this.led1.On = true;
            this.led1.Size = new System.Drawing.Size(45, 24);
            this.led1.TabIndex = 43;
            this.led1.Text = "ledBulb1";
            // 
            // led2
            // 
            this.led2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.led2.Location = new System.Drawing.Point(687, 295);
            this.led2.Name = "led2";
            this.led2.On = true;
            this.led2.Size = new System.Drawing.Size(45, 24);
            this.led2.TabIndex = 44;
            this.led2.Text = "ledBulb2";
            // 
            // led3
            // 
            this.led3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.led3.Location = new System.Drawing.Point(687, 326);
            this.led3.Name = "led3";
            this.led3.On = true;
            this.led3.Size = new System.Drawing.Size(45, 24);
            this.led3.TabIndex = 45;
            this.led3.Text = "ledBulb3";
            // 
            // led6
            // 
            this.led6.Color = System.Drawing.Color.Red;
            this.led6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.led6.Location = new System.Drawing.Point(753, 326);
            this.led6.Name = "led6";
            this.led6.On = true;
            this.led6.Size = new System.Drawing.Size(45, 24);
            this.led6.TabIndex = 48;
            this.led6.Text = "ledBulb4";
            // 
            // led5
            // 
            this.led5.Color = System.Drawing.Color.Red;
            this.led5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.led5.Location = new System.Drawing.Point(753, 295);
            this.led5.Name = "led5";
            this.led5.On = true;
            this.led5.Size = new System.Drawing.Size(45, 24);
            this.led5.TabIndex = 47;
            this.led5.Text = "ledBulb5";
            // 
            // led4
            // 
            this.led4.Color = System.Drawing.Color.Red;
            this.led4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.led4.Location = new System.Drawing.Point(753, 261);
            this.led4.Name = "led4";
            this.led4.On = true;
            this.led4.Size = new System.Drawing.Size(45, 24);
            this.led4.TabIndex = 46;
            this.led4.Text = "ledBulb6";
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.led6);
            this.Controls.Add(this.led5);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.LbNoerror);
            this.Controls.Add(this.Lb10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lb7);
            this.Controls.Add(this.Lb6);
            this.Controls.Add(this.Lb5);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbWater);
            this.Controls.Add(this.LbVoltage);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.cbGas);
            this.Controls.Add(this.cbPower);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.LbO);
            this.Controls.Add(this.LbS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerIp);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.aGauge1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Temp";
            this.Text = "Temp";
            this.Load += new System.EventHandler(this.Temp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbVoltage;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.CheckBox cbGas;
        private System.Windows.Forms.CheckBox cbPower;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label LbO;
        private System.Windows.Forms.Label LbS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerIp;
        private System.Windows.Forms.Button btnConnect;
        private AGaugeApp.AGauge aGauge1;
        private System.Windows.Forms.CheckBox cbWater;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label Lb5;
        private System.Windows.Forms.Label Lb6;
        private System.Windows.Forms.Label Lb7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lb10;
        private System.Windows.Forms.Label LbNoerror;
        private Bulb.LedBulb led1;
        private Bulb.LedBulb led2;
        private Bulb.LedBulb led3;
        private Bulb.LedBulb led6;
        private Bulb.LedBulb led5;
        private Bulb.LedBulb led4;
    }
}