using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Triangle
{
    public partial class mainDisplay : Form
    {
        Pen drawpen;
        Graphics g;

        public mainDisplay()
        {
            InitializeComponent();
            
        }
        public void drawTriangle(double xOne, double xTwo, double xThree, double yOne, double yTwo, double yThree)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(drawpen, xOne, yOne, xTwo, yTwo);
        }
        private void mainDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
