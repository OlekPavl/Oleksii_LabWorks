using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_4_1
{
    public partial class Form5 : Form
    {
        Point Bgn;
        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.SkyBlue;
            btnext.Text = "Close";
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath my_pth = new System.Drawing.Drawing2D.GraphicsPath();
            my_pth.AddEllipse(0, 0, this.Width, this.Height);
            Region my_rg = new Region(my_pth);
            this.Region = my_rg;
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Bgn = new Point(e.X, e.Y);
            }
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point dP = new Point(e.X - Bgn.X, e.Y - Bgn.Y);
                this.Location = new Point(this.Location.X + dP.X,
                  this.Location.Y + dP.Y);
            }
        }
    }
}
