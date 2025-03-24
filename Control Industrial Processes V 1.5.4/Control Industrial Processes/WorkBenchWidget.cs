using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Control_Industrial_Processes
{
    public partial class WorkBenchWidget : UserControl
    {




        private bool mouseDown;

        private bool _gridlines;

        public bool Gridlines
        {
            get { return _gridlines; }
            set
            {
                _gridlines = value;
                Invalidate();
            }
        }

        private Color _backColor;

        public override Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
                Invalidate();
            }
        }

        private Color _gridColor;
        public Color GridColor
        {
            get
            {
                return _gridColor;
            }
            set
            {
                _gridColor = value;
            }
        }
        private Size _gridCellSize;
        public Size GridCellSize
        {
            get
            {
                return _gridCellSize;
            }
            set
            {
                if (value.Height <= 0 || value.Width <= 0)
                    value = new Size(32, 32);

                _gridCellSize = value;
                Invalidate();
            }
        }



        public bool SnapTopGrid { get; set; }

        public object SelectedObject;
        public WorkBenchWidget()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            

            Gridlines = false;
            GridCellSize = new Size(32, 32);
            GridColor = Color.Gray;
            BackColor = Color.FromArgb(34, 34, 34);
        }

        private void WorkBenchWidget_Paint(object sender, PaintEventArgs e)
        {
            
            if (Gridlines)
            {
                for (var x = 1; x < Width; x++)
                {
                    if (x % GridCellSize.Width == 0)
                        e.Graphics.DrawLine(new Pen(GridColor), new Point(x, 0), new Point(x, Height));
                }
                for (var y = 1; y < Height; y++)
                {
                    if (y % GridCellSize.Height == 0)
                        e.Graphics.DrawLine(new Pen(GridColor), new Point(0, y), new Point(Width, y));
                }
            }
        }

        private void WorkBenchWidget_Click(object sender, EventArgs e)
        {

        }

        private void WorkBenchWidget_MouseClick(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

        private void WorkBenchWidget_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void WorkBenchWidget_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void WorkBenchWidget_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
