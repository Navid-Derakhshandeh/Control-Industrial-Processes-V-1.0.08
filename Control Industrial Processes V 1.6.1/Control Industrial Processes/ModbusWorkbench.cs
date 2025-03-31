using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Control_Industrial_Processes
{
    
    public partial class ModbusWorkbench : Form
    {
        private ModbusClient modbusClient;
    
        private List<(Point start, Point end)> lines = new List<(Point start, Point end)>(); // Store all lines
        private bool isDrawing = false; // Flag to enable drawing
        private Point startPoint; // Start point of the current line
        // List of dynamically created TextBoxes and their register addresses
        private List<(TextBox, int)> dynamicTextBoxes = new List<(TextBox, int)>();
        // Timer for updating register values
        private Timer updateTimer;

        public ModbusWorkbench()
        {
            InitializeComponent();
            
            Controls.Add(generateButton);
            Controls.Add(pictureBox1);
            modbusClient = new ModbusClient("127.0.0.1", 502);

            // Initialize and configure Timer
            updateTimer = new Timer();
            updateTimer.Interval = 1000; // Update every second
            updateTimer.Tick += UpdateTimer_Tick;

        }
        
        private void generateButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Connect to Modbus server if not connected
                if (!modbusClient.Connected)
                {
                    modbusClient.Connect();
                }

                // Dynamically create a movable TextBox
                TextBox newTextBox = new TextBox
                {
                    Width = 50,
                    Location = new Point(10, 10 + dynamicTextBoxes.Count * 30),
                    BorderStyle = BorderStyle.FixedSingle
                };
                newTextBox.MouseDown += (s, ev) =>
                {
                    if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                    {
                        //Controls.Remove(movableTextBox); // Remove the specific text box
                        pictureBox1.Controls.Remove(newTextBox);
                    }
                };
                // Add Mouse Down, Move and Up events for dragging the TextBox
                newTextBox.MouseDown += (s, ev) => OnMouseDown(s, ev);
                newTextBox.MouseMove += (s, ev) => OnMouseMove(s, ev);
                newTextBox.MouseUp += (s, ev) => OnMouseUp(s, ev);

                // Add the TextBox to the PictureBox
                pictureBox1.Controls.Add(newTextBox);

                // Assign a Modbus register address for the TextBox
                int registerAddress = 0 + dynamicTextBoxes.Count;

                // Store the TextBox and its register address in the list
                dynamicTextBoxes.Add((newTextBox, registerAddress));

                // Start the update timer if not already running
                if (!updateTimer.Enabled)
                {
                    updateTimer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                try
                {
                    // Update all TextBoxes with Modbus register values
                    if (comboBox1.SelectedItem.ToString() == "0")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[0].ToString();
                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "1")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[1].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "2")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[2].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "3")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[3].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "4")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[4].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "5")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[5].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "6")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[6].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "7")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[7].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "8")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[8].ToString();
                        }

                    }
                    if (comboBox1.SelectedItem.ToString() == "9")
                    {
                        foreach (var (textBox, registerAddress) in dynamicTextBoxes)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(registerAddress, 10);
                            textBox.Text = holdingRegisters[9].ToString();
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while updating Modbus registers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool _isDragging = false;
        private System.Drawing.Point _dragCursorPoint;
        private System.Drawing.Point _dragTextBoxPoint;
        // Variables to track dragging state
        private Point dragStartPoint;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragStartPoint = e.Location;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    // Update TextBox location based on mouse movement
                    textBox.Left += e.X - dragStartPoint.X;
                    textBox.Top += e.Y - dragStartPoint.Y;
                }
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            dragStartPoint = Point.Empty; // Reset drag point
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("transformer.jpg"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("ACG.jpg"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picTurbine_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("turbine.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picValve_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("valve1.jpeg"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("WT.jpg"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("Bourdon Tube.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("Cooling Tower.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        

        private void picGasTank_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("Gas Tank.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picMnualValve_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("Manual Valve.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picMotor_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("Motor.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picPressureGuage_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("pressure gauge.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("Servo Valve.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picSteam_Click(object sender, EventArgs e)
        {
            var picbox = new PictureBox
            {
                Location = new Point(30, 30),
                Width = 50,
                Height = 50, // You should specify the height as well, otherwise it defaults to 0
                Image = Image.FromFile("steam.png"), // Correct syntax with a comma
                SizeMode = PictureBoxSizeMode.StretchImage // Ensures the image fits within the PictureBox
            };
            picbox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(picbox);
                }
            };
            picbox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = picbox.Location;
            };
            picbox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    picbox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };
            picbox.MouseUp += (s, ev) => { _isDragging = false; };
            pictureBox1.Controls.Add(picbox);
        }

        private void picLine_Click(object sender, EventArgs e)
        {
            isDrawing = !isDrawing; // Toggle drawing mode
            //MessageBox.Show(isDrawing ? "Drawing enabled. Click and drag to draw a line." : "Drawing disabled.");
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Draw all lines
                foreach (var line in lines)
                {
                    e.Graphics.DrawLine(pen, line.start, line.end);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                // Start drawing a line
                startPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Check if the right-click is near any line
                foreach (var line in lines)
                {
                    if (IsPointNearLine(e.Location, line.start, line.end))
                    {
                        lines.Remove(line); // Remove the line
                        pictureBox1.Invalidate(); // Redraw the PictureBox
                        return;
                    }
                }

                //MessageBox.Show("No line found to erase.");
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                // Complete the drawing
                Point endPoint = e.Location;
                lines.Add((startPoint, endPoint)); // Store the line
                pictureBox1.Invalidate(); // Trigger repaint to show the new line
            }
        }
        private bool IsPointNearLine(Point point, Point start, Point end)
        {
            // Calculate the distance from the point to the line
            const int threshold = 5; // Define the proximity threshold
            float distance = Math.Abs((end.Y - start.Y) * point.X - (end.X - start.X) * point.Y + end.X * start.Y - end.Y * start.X) /
                             (float)Math.Sqrt(Math.Pow(end.Y - start.Y, 2) + Math.Pow(end.X - start.X, 2));

            return distance <= threshold;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient("127.0.0.1", 502); // Adjust IP and port
            modbusClient.Connect();
            
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
            modbusClient.Disconnect();
            
        }

        private void ModbusWorkbench_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateTimer.Enabled = false;
            // Disconnect Modbus connection on form close
            if (modbusClient.Connected)
            {
                modbusClient.Disconnect();
            }
        }
    }
}
