using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateSumLoop(int n, int p)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum +=(p+i);
            }
            return sum;
        }
        private int CalculateSumFormula(int n,int p)
        {
            return (n + 1) * (2*p + n) / 2;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            int p = trackBar2.Value;
            textBox1.Text = n.ToString();
            textBox2.Text = p.ToString();

            int sumLoop = CalculateSumLoop(n, p);
            int sumFormula = CalculateSumFormula(n,p);
            textBox3.Text = sumLoop.ToString();
            textBox4.Text = sumFormula.ToString();
        }
    }
}
