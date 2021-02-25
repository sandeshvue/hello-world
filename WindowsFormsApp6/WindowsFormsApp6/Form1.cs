using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);
            long intermediateresult = Factorial(x);
            label1.Text = intermediateresult.ToString();
            textBox2.Text = ("Factorial of entered number ="); 


            long Factorial(int x)
            {
                if (x == 0)
                    return 1;
                return x * Factorial(x - 1);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
