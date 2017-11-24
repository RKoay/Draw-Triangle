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
        Pen drawpen = new Pen(Color.Black);
        Random ranGen = new Random();
        
        public mainDisplay()
        {
            InitializeComponent();
            
        }
        public void drawTriangle(int xOne, int xTwo, int xThree, int yOne, int yTwo, int yThree)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.DrawLine(drawpen, xOne, yOne, xTwo, yTwo);
            g.DrawLine(drawpen, xTwo, yTwo, xThree, yThree);
            g.DrawLine(drawpen, xOne, yOne, xThree, yThree);
        }
        private void drawTri_Click(object sender, EventArgs e)
        {
            int valueOne = ranGen.Next(1, 200);
            int valueTwo = ranGen.Next(1, 200);
            int valueThree = ranGen.Next(1, 200);
            int valueYOne = ranGen.Next(1, 200);
            int valueYTwo = ranGen.Next(1, 200);
            int valueYThree = ranGen.Next(1, 200);
            drawTriangle(valueOne, valueTwo, valueThree, valueYOne, valueYTwo, valueYThree);
        }
    }
}
