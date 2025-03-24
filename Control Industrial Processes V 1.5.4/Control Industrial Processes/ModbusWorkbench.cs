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


        public ModbusWorkbench()
        {
            InitializeComponent();
            modbusClient = new ModbusClient("127.0.0.1", 502); // Adjust IP and port
            modbusClient.Connect();
            Controls.Add(generateButton);
            Controls.Add(pictureBox1);
           
        }
        
        private void generateButton_Click(object sender, EventArgs e)
        {
            var movableTextBox = new TextBox
            {
                Location = new Point(10, 10),
                Width = 50
            };

            // Attach MouseDown event handler to handle right-click deletion
            movableTextBox.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) // Check if right mouse button was clicked
                {
                    //Controls.Remove(movableTextBox); // Remove the specific text box
                    pictureBox1.Controls.Remove(movableTextBox);
                }
            };
            // Attach Mouse event handlers to make the TextBox movable
            movableTextBox.MouseDown += (s, ev) =>
            {
                _isDragging = true;
                _dragCursorPoint = Cursor.Position;
                _dragTextBoxPoint = movableTextBox.Location;
            };


            movableTextBox.MouseMove += (s, ev) =>
            {
                if (_isDragging)
                {

                    var diff = new System.Drawing.Point(Cursor.Position.X - _dragCursorPoint.X, Cursor.Position.Y - _dragCursorPoint.Y);
                    movableTextBox.Location = new System.Drawing.Point(_dragTextBoxPoint.X + diff.X, _dragTextBoxPoint.Y + diff.Y);
                }
            };

            movableTextBox.MouseUp += (s, ev) => { _isDragging = false; };

            // Link the TextBox to a single Modbus register
            int[] registerValues = modbusClient.ReadHoldingRegisters(0, 10); // Read register 0
            try
            {
                if (comboBox1.SelectedItem.ToString() == "0")
                {
                    movableTextBox.Text = registerValues[0].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "1")
                {
                    movableTextBox.Text = registerValues[1].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "2")
                {
                    movableTextBox.Text = registerValues[2].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "3")
                {
                    movableTextBox.Text = registerValues[3].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "4")
                {
                    movableTextBox.Text = registerValues[4].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "5")
                {
                    movableTextBox.Text = registerValues[5].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "6")
                {
                    movableTextBox.Text = registerValues[6].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "7")
                {
                    movableTextBox.Text = registerValues[7].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "8")
                {
                    movableTextBox.Text = registerValues[8].ToString();
                }
                if (comboBox1.SelectedItem.ToString() == "9")
                {
                    movableTextBox.Text = registerValues[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Add the TextBox to the form
            pictureBox1.Controls.Add(movableTextBox);

        }
        private bool _isDragging = false;
        private System.Drawing.Point _dragCursorPoint;
        private System.Drawing.Point _dragTextBoxPoint;

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
    }
}
