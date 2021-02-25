using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         text
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            public void ChooseFolder()
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                }
            }
    }
}
