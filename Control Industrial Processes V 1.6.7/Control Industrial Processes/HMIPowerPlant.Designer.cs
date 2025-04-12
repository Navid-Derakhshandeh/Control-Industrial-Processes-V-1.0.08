
namespace Control_Industrial_Processes
{
    partial class HMIPowerPlant
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
            this.timerBattery = new System.Windows.Forms.Timer(this.components);
            this.timerCooling = new System.Windows.Forms.Timer(this.components);
            this.timerBoiler = new System.Windows.Forms.Timer(this.components);
            this.picFan = new System.Windows.Forms.PictureBox();
            this.picBattery = new System.Windows.Forms.PictureBox();
            this.picCooling = new System.Windows.Forms.PictureBox();
            this.picBoiler = new System.Windows.Forms.PictureBox();
            this.timerTurbine = new System.Windows.Forms.Timer(this.components);
            this.picTurbine = new System.Windows.Forms.PictureBox();
            this.txtFan = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurbine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTower = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurbine)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBattery
            // 
            this.timerBattery.Tick += new System.EventHandler(this.timerBattery_Tick);
            // 
            // timerCooling
            // 
            this.timerCooling.Tick += new System.EventHandler(this.timerCooling_Tick);
            // 
            // timerBoiler
            // 
            this.timerBoiler.Tick += new System.EventHandler(this.timerBoiler_Tick);
            // 
            // picFan
            // 
            this.picFan.BackColor = System.Drawing.SystemColors.Control;
            this.picFan.Location = new System.Drawing.Point(600, 366);
            this.picFan.Name = "picFan";
            this.picFan.Size = new System.Drawing.Size(233, 207);
            this.picFan.TabIndex = 1;
            this.picFan.TabStop = false;
            this.picFan.Paint += new System.Windows.Forms.PaintEventHandler(this.picFan_Paint);
            // 
            // picBattery
            // 
            this.picBattery.Location = new System.Drawing.Point(26, 410);
            this.picBattery.Name = "picBattery";
            this.picBattery.Size = new System.Drawing.Size(214, 131);
            this.picBattery.TabIndex = 2;
            this.picBattery.TabStop = false;
            this.picBattery.Paint += new System.Windows.Forms.PaintEventHandler(this.picBattery_Paint);
            // 
            // picCooling
            // 
            this.picCooling.Location = new System.Drawing.Point(578, 123);
            this.picCooling.Name = "picCooling";
            this.picCooling.Size = new System.Drawing.Size(255, 207);
            this.picCooling.TabIndex = 3;
            this.picCooling.TabStop = false;
            this.picCooling.Paint += new System.Windows.Forms.PaintEventHandler(this.picCooling_Paint);
            // 
            // picBoiler
            // 
            this.picBoiler.Location = new System.Drawing.Point(12, 52);
            this.picBoiler.Name = "picBoiler";
            this.picBoiler.Size = new System.Drawing.Size(252, 329);
            this.picBoiler.TabIndex = 4;
            this.picBoiler.TabStop = false;
            this.picBoiler.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoiler_Paint);
            // 
            // timerTurbine
            // 
            this.timerTurbine.Tick += new System.EventHandler(this.timerTurbine_Tick);
            // 
            // picTurbine
            // 
            this.picTurbine.Location = new System.Drawing.Point(286, 123);
            this.picTurbine.Name = "picTurbine";
            this.picTurbine.Size = new System.Drawing.Size(268, 220);
            this.picTurbine.TabIndex = 5;
            this.picTurbine.TabStop = false;
            this.picTurbine.Paint += new System.Windows.Forms.PaintEventHandler(this.picTurbine_Paint);
            // 
            // txtFan
            // 
            this.txtFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFan.Location = new System.Drawing.Point(732, 580);
            this.txtFan.Name = "txtFan";
            this.txtFan.Size = new System.Drawing.Size(100, 27);
            this.txtFan.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(375, 554);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 45);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Speed of Fan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Temp of Boiler:";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(160, 18);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 27);
            this.txtTemp.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Speed of Turbine:";
            // 
            // txtTurbine
            // 
            this.txtTurbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurbine.Location = new System.Drawing.Point(447, 70);
            this.txtTurbine.Name = "txtTurbine";
            this.txtTurbine.Size = new System.Drawing.Size(100, 27);
            this.txtTurbine.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Temp of Tower:";
            // 
            // txtTower
            // 
            this.txtTower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTower.Location = new System.Drawing.Point(732, 70);
            this.txtTower.Name = "txtTower";
            this.txtTower.Size = new System.Drawing.Size(100, 27);
            this.txtTower.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Battery Level:";
            // 
            // txtBattery
            // 
            this.txtBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBattery.Location = new System.Drawing.Point(151, 566);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(100, 27);
            this.txtBattery.TabIndex = 15;
            // 
            // HMIPowerPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTurbine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtFan);
            this.Controls.Add(this.picTurbine);
            this.Controls.Add(this.picBoiler);
            this.Controls.Add(this.picCooling);
            this.Controls.Add(this.picBattery);
            this.Controls.Add(this.picFan);
            this.Name = "HMIPowerPlant";
            this.Text = "HMI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HMIPowerPlant_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurbine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerBattery;
        private System.Windows.Forms.Timer timerCooling;
        private System.Windows.Forms.Timer timerBoiler;
        private System.Windows.Forms.PictureBox picFan;
        private System.Windows.Forms.PictureBox picBattery;
        private System.Windows.Forms.PictureBox picCooling;
        private System.Windows.Forms.PictureBox picBoiler;
        private System.Windows.Forms.Timer timerTurbine;
        private System.Windows.Forms.PictureBox picTurbine;
        private System.Windows.Forms.TextBox txtFan;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurbine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBattery;
    }
}