using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dibuja_estrella
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //para hacer estrella se puede con un poligono
            Point [] estrella = { new Point (200,20),
                                 new Point (170,135),
                                 new Point (100,140),
                                 new Point (145,160),
                                 new Point (150,300),
                                 new Point (200,250),
                                 new Point (250,300),
                                 new Point (245,160),
                                 new Point (300,140),
                                 new Point (230,135)};

            Graphics papel = this.CreateGraphics();
            papel.FillPolygon(Brushes.Pink, estrella);

                 

        }
    }
}
