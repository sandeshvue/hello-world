using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void 
        private void button1_Click(object sender, EventArgs e)
        
        {
             void repeat (string input)
            { treeView1.Nodes[0].Nodes.Add("{0}", input); }




          treeView1.Nodes.Add("{0}", textBox1.Text);
            string input = textbox1.text;
            repeat(string input);







        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        



    }
}
