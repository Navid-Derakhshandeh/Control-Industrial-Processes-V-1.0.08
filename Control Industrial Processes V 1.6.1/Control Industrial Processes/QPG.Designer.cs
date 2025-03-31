
namespace Control_Industrial_Processes
{
    partial class QPG
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
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentArray2 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentArray3 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.ledBulb1 = new Bulb.LedBulb();
            this.ledBulb2 = new Bulb.LedBulb();
            this.ledBulb3 = new Bulb.LedBulb();
            this.ledBulb4 = new Bulb.LedBulb();
            this.ledBulb5 = new Bulb.LedBulb();
            this.ledBulb6 = new Bulb.LedBulb();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Lbc2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 4;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(144, 68);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(117, 47);
            this.sevenSegmentArray1.TabIndex = 0;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = null;
            // 
            // sevenSegmentArray2
            // 
            this.sevenSegmentArray2.ArrayCount = 4;
            this.sevenSegmentArray2.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentArray2.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentArray2.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray2.DecimalShow = true;
            this.sevenSegmentArray2.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray2.ElementWidth = 10;
            this.sevenSegmentArray2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sevenSegmentArray2.ItalicFactor = 0F;
            this.sevenSegmentArray2.Location = new System.Drawing.Point(144, 140);
            this.sevenSegmentArray2.Name = "sevenSegmentArray2";
            this.sevenSegmentArray2.Size = new System.Drawing.Size(117, 47);
            this.sevenSegmentArray2.TabIndex = 1;
            this.sevenSegmentArray2.TabStop = false;
            this.sevenSegmentArray2.Value = null;
            // 
            // sevenSegmentArray3
            // 
            this.sevenSegmentArray3.ArrayCount = 4;
            this.sevenSegmentArray3.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentArray3.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegmentArray3.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray3.DecimalShow = true;
            this.sevenSegmentArray3.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray3.ElementWidth = 10;
            this.sevenSegmentArray3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sevenSegmentArray3.ItalicFactor = 0F;
            this.sevenSegmentArray3.Location = new System.Drawing.Point(144, 208);
            this.sevenSegmentArray3.Name = "sevenSegmentArray3";
            this.sevenSegmentArray3.Size = new System.Drawing.Size(117, 47);
            this.sevenSegmentArray3.TabIndex = 2;
            this.sevenSegmentArray3.TabStop = false;
            this.sevenSegmentArray3.Value = null;
            // 
            // ledBulb1
            // 
            this.ledBulb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ledBulb1.Location = new System.Drawing.Point(288, 77);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(33, 29);
            this.ledBulb1.TabIndex = 3;
            this.ledBulb1.Text = "ledBulb1";
            // 
            // ledBulb2
            // 
            this.ledBulb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ledBulb2.Location = new System.Drawing.Point(288, 149);
            this.ledBulb2.Name = "ledBulb2";
            this.ledBulb2.On = true;
            this.ledBulb2.Size = new System.Drawing.Size(33, 29);
            this.ledBulb2.TabIndex = 4;
            this.ledBulb2.Text = "ledBulb2";
            // 
            // ledBulb3
            // 
            this.ledBulb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ledBulb3.Location = new System.Drawing.Point(288, 217);
            this.ledBulb3.Name = "ledBulb3";
            this.ledBulb3.On = true;
            this.ledBulb3.Size = new System.Drawing.Size(33, 29);
            this.ledBulb3.TabIndex = 5;
            this.ledBulb3.Text = "ledBulb3";
            // 
            // ledBulb4
            // 
            this.ledBulb4.Color = System.Drawing.Color.Red;
            this.ledBulb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ledBulb4.Location = new System.Drawing.Point(363, 77);
            this.ledBulb4.Name = "ledBulb4";
            this.ledBulb4.On = true;
            this.ledBulb4.Size = new System.Drawing.Size(33, 29);
            this.ledBulb4.TabIndex = 6;
            this.ledBulb4.Text = "ledBulb4";
            // 
            // ledBulb5
            // 
            this.ledBulb5.Color = System.Drawing.Color.Red;
            this.ledBulb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ledBulb5.Location = new System.Drawing.Point(363, 149);
            this.ledBulb5.Name = "ledBulb5";
            this.ledBulb5.On = true;
            this.ledBulb5.Size = new System.Drawing.Size(33, 29);
            this.ledBulb5.TabIndex = 7;
            this.ledBulb5.Text = "ledBulb5";
            // 
            // ledBulb6
            // 
            this.ledBulb6.Color = System.Drawing.Color.Red;
            this.ledBulb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ledBulb6.Location = new System.Drawing.Point(363, 217);
            this.ledBulb6.Name = "ledBulb6";
            this.ledBulb6.On = true;
            this.ledBulb6.Size = new System.Drawing.Size(33, 29);
            this.ledBulb6.TabIndex = 8;
            this.ledBulb6.Text = "ledBulb6";
            // 
            // txtDT
            // 
            this.txtDT.BackColor = System.Drawing.SystemColors.Info;
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDT.Location = new System.Drawing.Point(106, 278);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(301, 26);
            this.txtDT.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity of Gas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity of Water:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Power Generated:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter IP of Modbus Server:";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Info;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIP.Location = new System.Drawing.Point(218, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(189, 26);
            this.txtIP.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(14, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date/Time:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDisconnect.Location = new System.Drawing.Point(218, 325);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 39);
            this.btnDisconnect.TabIndex = 24;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnect.Location = new System.Drawing.Point(84, 325);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 39);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Lbc2
            // 
            this.Lbc2.AutoSize = true;
            this.Lbc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbc2.Location = new System.Drawing.Point(352, 334);
            this.Lbc2.Name = "Lbc2";
            this.Lbc2.Size = new System.Drawing.Size(55, 20);
            this.Lbc2.TabIndex = 25;
            this.Lbc2.Text = "Offline";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 369);
            this.Controls.Add(this.Lbc2);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.ledBulb6);
            this.Controls.Add(this.ledBulb5);
            this.Controls.Add(this.ledBulb4);
            this.Controls.Add(this.ledBulb3);
            this.Controls.Add(this.ledBulb2);
            this.Controls.Add(this.ledBulb1);
            this.Controls.Add(this.sevenSegmentArray3);
            this.Controls.Add(this.sevenSegmentArray2);
            this.Controls.Add(this.sevenSegmentArray1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QPG";
            this.Text = "QPG";
            this.Load += new System.EventHandler(this.QPG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray2;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray3;
        private Bulb.LedBulb ledBulb1;
        private Bulb.LedBulb ledBulb2;
        private Bulb.LedBulb ledBulb3;
        private Bulb.LedBulb ledBulb4;
        private Bulb.LedBulb ledBulb5;
        private Bulb.LedBulb ledBulb6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label Lbc2;
        private System.Windows.Forms.Timer timer1;
    }
}