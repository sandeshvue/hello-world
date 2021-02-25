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

        public string path= "C:\\Users\\Sandesh\\Downloads";




        public Form1()
        {
            InitializeComponent();
            string ourdata;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = path;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult ToDisplay = MessageBox.Show(textBox1.Text);

            //TreeNode treenode1 = treeView1.Nodes.Add("{0}", textBox1.Text);
           



        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult ToDisplay = MessageBox.Show(textBox1.Text);

            
          
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}