using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrawShapes
{
    public partial class frmDrawShapes : Form
    {
        int x, y, h, w; // (x,y): tọa độ góc trên trái hình vẽ, h: height, w: weight
        Pen p = new Pen(Color.Blue, 3);
        double shapeArea = 0;
        const double Pi = 3.1416;

        private void frmDrawShapes_Load(object sender, EventArgs e)
        {

        }

        private void IsMouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x; // chiều cao hình vẽ = tọa độ x ban đầu - x hiện tại
            w = e.Y - y;
            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if(radioCircle.Checked)
            {
                p.Color = Color.Blue;
                g.DrawEllipse(p, shape);
                // show the shape's area
                shapeArea = h * w * Pi / 4;
                // MessageBox.Show("Diện tích = " + shapeArea.ToString());
            }
            else if(radioRectangle.Checked)
            {
                p.Color = Color.Red;
                g.DrawRectangle(p, shape);
            }
            else if (radioLine.Checked)
            {
                p.Color = Color.Green;
                g.DrawLine(p, x, y, e.X, e.Y);
            }

        }

        private void IsMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        public frmDrawShapes()
        {
            InitializeComponent();
        }

    }
}
