using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;
using System.IO;

namespace Control_Industrial_Processes
{
    public partial class DesignApp : Form
    {
        OpcClient Opc = new OpcClient("opc.tcp://localhost:62640/");
        Image Open;
        

        public DesignApp()
        {
            InitializeComponent();
            this.Width = 1147;
            this.Height = 550;
            bitm = new Bitmap(Board.Width, Board.Height);
            gra = Graphics.FromImage(bitm);
            gra.Clear(Color.White);
            Board.Image = bitm;
        }
        Bitmap bitm;
        Graphics gra;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;
        ColorDialog cdia = new ColorDialog();
        Color newcolor;

        private void btnfi_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btsa_Click(object sender, EventArgs e)
        {
            var safid = new SaveFileDialog();
            safid.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (safid.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bitm.Clone(new Rectangle(0, 0, Board.Width, Board.Height), bitm.PixelFormat);
                btm.Save(safid.FileName, ImageFormat.Jpeg);
            }
        }

        private void btop_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult Res = opf.ShowDialog();
            if (Res == DialogResult.OK)
            {
                Open = Image.FromFile(opf.FileName);
                Board.Image = Open;
            }
        }

        private void Board_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

        private void Board_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    gra.DrawLine(pen, px, py);
                    py = px;

                }
                if (index == 2)
                {
                    px = e.Location;
                    gra.DrawLine(erase, px, py);
                    py = px;

                }
            }
            Board.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void Board_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;
            if (index == 3)
            {
                gra.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                gra.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                gra.DrawLine(pen, cX, cY, x, y);
            }
            if (index == 8)
            {
                
                Image img1 = Image.FromFile("Screenshot (56).png");
              
                gra.DrawImage(img1, cX, cY, sX, sY);
                
            }
        }

        private void btnpen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btcr_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btco_Click(object sender, EventArgs e)
        {
            cdia.ShowDialog();
            newcolor = cdia.Color;
            btpico.BackColor = cdia.Color;
            pen.Color = cdia.Color;
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            gra.Clear(Color.White);
            Board.Image = bitm;
            index = 0;
        }

        private void btre_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnli_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void DesignApp_Load(object sender, EventArgs e)
        {
            if (Opc != null)
            {
                Opc.Disconnect();
            }
        }

        private void moveButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Opc.Connect();
                timer1.Start();
                lbl1.Text = "Connected";

            }
            catch (Exception ex)
            {
                lbl1.Text = ex.ToString();
                throw;
            }
        }

        private void moveButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Opc != null)
            {
                Opc.Disconnect();
            }
            lbl1.Text = "Disconnected";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var Tag1 = "ns=2;s=Tag1";
            var t1 = Opc.ReadNode(Tag1);
            var Tag2 = "ns=2;s=Tag2";
            var t2 = Opc.ReadNode(Tag2);
            var Tag3 = "ns=2;s=Tag3";
            var t3 = Opc.ReadNode(Tag3);
            txtBox4.Text = t1.ToString();
            txtBox5.Text = t2.ToString();
            txtBox6.Text = t3.ToString();

            
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void Board_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (index == 7)
            {
                Point point = setpoint(Board, e.Location);
                fill(bitm, point.X, point.Y, newcolor);
            }
        }

        

        private void bter_Click(object sender, EventArgs e)
        {
            index = 2;
        }

       

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            
            

            Graphics gra = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    gra.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    gra.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    gra.DrawLine(pen, cX, cY, x, y);
                }
                if(index == 8)
                {
                    
                    Image img1 = Image.FromFile("Screenshot (56).png");
                    
                    gra.DrawImage(img1, cX, cY, sX, sY);
                    
                }
            }
        }
        private void Validate(Bitmap bitm, Stack<Point> sp, int x, int y, Color oldcolor, Color newcolor)
        {
            Color cx = bitm.GetPixel(x, y);
            if (cx == oldcolor)
            {
                sp.Push(new Point(x, y));
                bitm.SetPixel(x, y, newcolor);
            }
        }
        public void fill(Bitmap bitm, int x, int y, Color newcolr)
        {
            Color oldcolor = bitm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitm.SetPixel(x, y, newcolr);
            if (oldcolor == newcolr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bitm.Width - 1 && pt.Y < bitm.Height - 1)
                {
                    Validate(bitm, pixel, pt.X - 1, pt.Y, oldcolor, newcolr);
                    Validate(bitm, pixel, pt.X, pt.Y - 1, oldcolor, newcolr);
                    Validate(bitm, pixel, pt.X + 1, pt.Y, oldcolor, newcolr);
                    Validate(bitm, pixel, pt.X, pt.Y + 1, oldcolor, newcolr);

                }
            }
        }
        static Point setpoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

    }
}
