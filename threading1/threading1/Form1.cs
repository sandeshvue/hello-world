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

namespace threading1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.Nodes.Add((textBox1.Text));
            FolderBrowserDialog dlgBrowseFolder = new FolderBrowserDialog();
            if (dlgBrowseFolder.ShowDialog() == DialogResult.OK)
                textBox1.Text = dlgBrowseFolder.SelectedPath;
            string SubFoldersString = textBox1.Text;
            string[] SubFolders = SubFoldersString.Split(Path.DirectorySeparatorChar);
            getSubFolders(treeView1.Nodes, SubFolders);
        }
        private  void getSubFolders(TreeNodeCollection nodes, string[] SubFolders)
        {
            
           
            for (int i=1; i<=SubFolders.Length;i++)
            {
                TreeNode node1 = treeView1.Nodes.Add(SubFolders[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgBrowseFolder = new FolderBrowserDialog();
            if (dlgBrowseFolder.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlgBrowseFolder.SelectedPath;
            }
        }
    }
}
