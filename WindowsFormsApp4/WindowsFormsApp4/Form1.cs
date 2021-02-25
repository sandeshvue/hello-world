using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ToDisplay = MessageBox.Show(textBox1.Text);
            //TreeNode treenode1 = treeView1.Nodes.Add("{0}", textBox1.Text);
            
            treeView1.Nodes.Add("{0}", textBox1.Text);
            treeView1.Nodes[0].Nodes.Add("{0}", textBox1.Text);
                        
         
            treeView1.Nodes[0].Nodes[0].Nodes.Add("{0}", textBox1.Text);
              
            //treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("{0}", textBox1.Text);
            //treeView1.Nodes.Add("");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
