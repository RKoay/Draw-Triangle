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
        Pen pen;
        Random ranGen = new Random();
        
        public mainDisplay()
        {
            InitializeComponent();
            
        }
        public void DrawTriangle(int penOne, int penTwo, int penThree, int penFour, int xOne, int xTwo, int xThree, int yOne, int yTwo, int yThree)
        {
            Graphics g = this.CreateGraphics();

            pen.Color = Color.FromArgb(penOne, penTwo, penThree, penFour);
            g.DrawLine(pen, xOne, yOne, xTwo, yTwo);
            g.DrawLine(pen, xTwo, yTwo, xThree, yThree);
            g.DrawLine(pen, xOne, yOne, xThree, yThree);
        }
        private void drawTri_Click(object sender, EventArgs e)
        {
            int penNumberOne = ranGen.Next(1, 255);
            int penNumberTwo = ranGen.Next(1, 255);
            int penNumberThree = ranGen.Next(1, 255);
            int penNumberFour = ranGen.Next(1, 255);
            int valueOne = ranGen.Next(1, 200);
            int valueTwo = ranGen.Next(1, 200);
            int valueThree = ranGen.Next(1, 200);
            int valueYOne = ranGen.Next(50, 300);
            int valueYTwo = ranGen.Next(50, 300);
            int valueYThree = ranGen.Next(50, 300);
            DrawTriangle(penNumberOne, penNumberTwo, penNumberThree, penNumberFour, valueOne, valueTwo, valueThree, valueYOne, valueYTwo, valueYThree);
        }
    }
}
