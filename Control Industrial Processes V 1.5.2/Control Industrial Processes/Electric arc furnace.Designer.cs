
namespace Control_Industrial_Processes
{
    partial class Electric_arc_furnace
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
            this.knobControl1 = new KnobControl.KnobControl();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnconnect = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.lblsensor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btndisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // knobControl1
            // 
            this.knobControl1.EndAngle = 405F;
            this.knobControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobControl1.KnobBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.knobControl1.KnobPointerStyle = KnobControl.KnobControl.KnobPointerStyles.line;
            this.knobControl1.LargeChange = 5;
            this.knobControl1.Location = new System.Drawing.Point(135, 75);
            this.knobControl1.Maximum = 400;
            this.knobControl1.Minimum = 0;
            this.knobControl1.Name = "knobControl1";
            this.knobControl1.PointerColor = System.Drawing.Color.Red;
            this.knobControl1.ScaleColor = System.Drawing.Color.Black;
            this.knobControl1.ScaleDivisions = 11;
            this.knobControl1.ScaleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.knobControl1.ScaleSubDivisions = 4;
            this.knobControl1.ShowLargeScale = true;
            this.knobControl1.ShowSmallScale = false;
            this.knobControl1.Size = new System.Drawing.Size(150, 150);
            this.knobControl1.SmallChange = 1;
            this.knobControl1.StartAngle = 135F;
            this.knobControl1.TabIndex = 0;
            this.knobControl1.Value = 0;
            this.knobControl1.Load += new System.EventHandler(this.knobControl1_Load);
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
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(149, 29);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(102, 43);
            this.sevenSegmentArray1.TabIndex = 2;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = null;
            // 
            // btnconnect
            // 
            this.btnconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnconnect.Location = new System.Drawing.Point(119, 389);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(96, 48);
            this.btnconnect.TabIndex = 5;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(149, 226);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(125, 38);
            this.txtdata.TabIndex = 7;
            this.txtdata.Text = "0";
            // 
            // lblsensor
            // 
            this.lblsensor.AutoSize = true;
            this.lblsensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsensor.Location = new System.Drawing.Point(17, 44);
            this.lblsensor.Name = "lblsensor";
            this.lblsensor.Size = new System.Drawing.Size(0, 31);
            this.lblsensor.TabIndex = 9;
            this.lblsensor.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btndisconnect
            // 
            this.btndisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btndisconnect.Location = new System.Drawing.Point(230, 389);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(126, 48);
            this.btndisconnect.TabIndex = 10;
            this.btndisconnect.Text = "Disconnect";
            this.btndisconnect.UseVisualStyleBackColor = true;
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.knobControl1);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 270);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblsensor);
            this.groupBox2.Controls.Add(this.sevenSegmentArray1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 78);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temp Sensor";
            // 
            // Electric_arc_furnace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndisconnect);
            this.Controls.Add(this.btnconnect);
            this.Name = "Electric_arc_furnace";
            this.Text = "Electric_arc_furnace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Electric_arc_furnace_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KnobControl.KnobControl knobControl1;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label lblsensor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}