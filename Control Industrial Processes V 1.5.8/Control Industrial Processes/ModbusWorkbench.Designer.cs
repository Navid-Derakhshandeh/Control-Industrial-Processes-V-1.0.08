
namespace Control_Industrial_Processes
{
    partial class ModbusWorkbench
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.picACG = new System.Windows.Forms.PictureBox();
            this.picTransformer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picValve = new System.Windows.Forms.PictureBox();
            this.picTurbine = new System.Windows.Forms.PictureBox();
            this.picGasTank = new System.Windows.Forms.PictureBox();
            this.picCoolingTower = new System.Windows.Forms.PictureBox();
            this.picBurdonTube = new System.Windows.Forms.PictureBox();
            this.picWT = new System.Windows.Forms.PictureBox();
            this.picMotor = new System.Windows.Forms.PictureBox();
            this.picMnualValve = new System.Windows.Forms.PictureBox();
            this.picServoValve = new System.Windows.Forms.PictureBox();
            this.picPressureGuage = new System.Windows.Forms.PictureBox();
            this.picSteam = new System.Windows.Forms.PictureBox();
            this.picLine = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picACG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransformer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurbine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGasTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoolingTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurdonTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMnualValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServoValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPressureGuage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(449, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(582, 387);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(99, 39);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // picACG
            // 
            this.picACG.Image = global::Control_Industrial_Processes.Properties.Resources.ACG;
            this.picACG.Location = new System.Drawing.Point(833, 91);
            this.picACG.Name = "picACG";
            this.picACG.Size = new System.Drawing.Size(56, 52);
            this.picACG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picACG.TabIndex = 9;
            this.picACG.TabStop = false;
            this.picACG.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picTransformer
            // 
            this.picTransformer.Image = global::Control_Industrial_Processes.Properties.Resources.transformer;
            this.picTransformer.Location = new System.Drawing.Point(833, 23);
            this.picTransformer.Name = "picTransformer";
            this.picTransformer.Size = new System.Drawing.Size(56, 52);
            this.picTransformer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransformer.TabIndex = 8;
            this.picTransformer.TabStop = false;
            this.picTransformer.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(114, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // picValve
            // 
            this.picValve.Image = global::Control_Industrial_Processes.Properties.Resources.valve1;
            this.picValve.Location = new System.Drawing.Point(756, 91);
            this.picValve.Name = "picValve";
            this.picValve.Size = new System.Drawing.Size(56, 52);
            this.picValve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picValve.TabIndex = 11;
            this.picValve.TabStop = false;
            this.picValve.Click += new System.EventHandler(this.picValve_Click);
            // 
            // picTurbine
            // 
            this.picTurbine.Image = global::Control_Industrial_Processes.Properties.Resources.turbine;
            this.picTurbine.Location = new System.Drawing.Point(756, 23);
            this.picTurbine.Name = "picTurbine";
            this.picTurbine.Size = new System.Drawing.Size(56, 52);
            this.picTurbine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTurbine.TabIndex = 10;
            this.picTurbine.TabStop = false;
            this.picTurbine.Click += new System.EventHandler(this.picTurbine_Click);
            // 
            // picGasTank
            // 
            this.picGasTank.Image = global::Control_Industrial_Processes.Properties.Resources.Gas_Tank;
            this.picGasTank.Location = new System.Drawing.Point(756, 229);
            this.picGasTank.Name = "picGasTank";
            this.picGasTank.Size = new System.Drawing.Size(56, 52);
            this.picGasTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGasTank.TabIndex = 15;
            this.picGasTank.TabStop = false;
            this.picGasTank.Click += new System.EventHandler(this.picGasTank_Click);
            // 
            // picCoolingTower
            // 
            this.picCoolingTower.Image = global::Control_Industrial_Processes.Properties.Resources.Cooling_Tower;
            this.picCoolingTower.Location = new System.Drawing.Point(756, 161);
            this.picCoolingTower.Name = "picCoolingTower";
            this.picCoolingTower.Size = new System.Drawing.Size(56, 52);
            this.picCoolingTower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoolingTower.TabIndex = 14;
            this.picCoolingTower.TabStop = false;
            this.picCoolingTower.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // picBurdonTube
            // 
            this.picBurdonTube.Image = global::Control_Industrial_Processes.Properties.Resources.Bourdon_Tube;
            this.picBurdonTube.Location = new System.Drawing.Point(833, 229);
            this.picBurdonTube.Name = "picBurdonTube";
            this.picBurdonTube.Size = new System.Drawing.Size(56, 52);
            this.picBurdonTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurdonTube.TabIndex = 13;
            this.picBurdonTube.TabStop = false;
            this.picBurdonTube.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picWT
            // 
            this.picWT.Image = global::Control_Industrial_Processes.Properties.Resources.WT;
            this.picWT.Location = new System.Drawing.Point(833, 161);
            this.picWT.Name = "picWT";
            this.picWT.Size = new System.Drawing.Size(56, 52);
            this.picWT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWT.TabIndex = 12;
            this.picWT.TabStop = false;
            this.picWT.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // picMotor
            // 
            this.picMotor.Image = global::Control_Industrial_Processes.Properties.Resources.Motor;
            this.picMotor.Location = new System.Drawing.Point(756, 299);
            this.picMotor.Name = "picMotor";
            this.picMotor.Size = new System.Drawing.Size(56, 52);
            this.picMotor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMotor.TabIndex = 17;
            this.picMotor.TabStop = false;
            this.picMotor.Click += new System.EventHandler(this.picMotor_Click);
            // 
            // picMnualValve
            // 
            this.picMnualValve.Image = global::Control_Industrial_Processes.Properties.Resources.Manual_Valve;
            this.picMnualValve.Location = new System.Drawing.Point(833, 299);
            this.picMnualValve.Name = "picMnualValve";
            this.picMnualValve.Size = new System.Drawing.Size(56, 52);
            this.picMnualValve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMnualValve.TabIndex = 16;
            this.picMnualValve.TabStop = false;
            this.picMnualValve.Click += new System.EventHandler(this.picMnualValve_Click);
            // 
            // picServoValve
            // 
            this.picServoValve.Image = global::Control_Industrial_Processes.Properties.Resources.Servo_Valve;
            this.picServoValve.Location = new System.Drawing.Point(756, 371);
            this.picServoValve.Name = "picServoValve";
            this.picServoValve.Size = new System.Drawing.Size(56, 52);
            this.picServoValve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picServoValve.TabIndex = 19;
            this.picServoValve.TabStop = false;
            this.picServoValve.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // picPressureGuage
            // 
            this.picPressureGuage.Image = global::Control_Industrial_Processes.Properties.Resources.pressure_gauge;
            this.picPressureGuage.Location = new System.Drawing.Point(833, 371);
            this.picPressureGuage.Name = "picPressureGuage";
            this.picPressureGuage.Size = new System.Drawing.Size(56, 52);
            this.picPressureGuage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPressureGuage.TabIndex = 18;
            this.picPressureGuage.TabStop = false;
            this.picPressureGuage.Click += new System.EventHandler(this.picPressureGuage_Click);
            // 
            // picSteam
            // 
            this.picSteam.Image = global::Control_Industrial_Processes.Properties.Resources.steam;
            this.picSteam.Location = new System.Drawing.Point(686, 23);
            this.picSteam.Name = "picSteam";
            this.picSteam.Size = new System.Drawing.Size(56, 52);
            this.picSteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSteam.TabIndex = 20;
            this.picSteam.TabStop = false;
            this.picSteam.Click += new System.EventHandler(this.picSteam_Click);
            // 
            // picLine
            // 
            this.picLine.Image = global::Control_Industrial_Processes.Properties.Resources.line2;
            this.picLine.Location = new System.Drawing.Point(686, 91);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(56, 52);
            this.picLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLine.TabIndex = 21;
            this.picLine.TabStop = false;
            this.picLine.Click += new System.EventHandler(this.picLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choose Register:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(48, 384);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 39);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(146, 384);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 39);
            this.btnDisconnect.TabIndex = 24;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Register 0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Register 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Register 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Register 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Register 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Register 5:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 31;
            this.label8.Text = "Register 6:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Register 7:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 33;
            this.label10.Text = "Register 8:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Register 9:";
            // 
            // ModbusWorkbench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.picSteam);
            this.Controls.Add(this.picServoValve);
            this.Controls.Add(this.picPressureGuage);
            this.Controls.Add(this.picMotor);
            this.Controls.Add(this.picMnualValve);
            this.Controls.Add(this.picGasTank);
            this.Controls.Add(this.picCoolingTower);
            this.Controls.Add(this.picBurdonTube);
            this.Controls.Add(this.picWT);
            this.Controls.Add(this.picValve);
            this.Controls.Add(this.picTurbine);
            this.Controls.Add(this.picACG);
            this.Controls.Add(this.picTransformer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.generateButton);
            this.Name = "ModbusWorkbench";
            this.Text = "ModbusWorkbench";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModbusWorkbench_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picACG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransformer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurbine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGasTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoolingTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurdonTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMnualValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServoValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPressureGuage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picACG;
        private System.Windows.Forms.PictureBox picTransformer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox picValve;
        private System.Windows.Forms.PictureBox picTurbine;
        private System.Windows.Forms.PictureBox picGasTank;
        private System.Windows.Forms.PictureBox picCoolingTower;
        private System.Windows.Forms.PictureBox picBurdonTube;
        private System.Windows.Forms.PictureBox picWT;
        private System.Windows.Forms.PictureBox picMotor;
        private System.Windows.Forms.PictureBox picMnualValve;
        private System.Windows.Forms.PictureBox picServoValve;
        private System.Windows.Forms.PictureBox picPressureGuage;
        private System.Windows.Forms.PictureBox picSteam;
        private System.Windows.Forms.PictureBox picLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}