using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba8Tir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.TransparencyKey = System.Drawing.Color.FromArgb(255, 128, 128);
            this.ResumeLayout(false);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics graphic = CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 128, 128));

            graphic.FillEllipse(brush, new Rectangle(e.X - 50, e.Y - 50, 100, 100));
        }
    }
}
