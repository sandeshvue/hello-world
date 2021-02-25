using System;
using System.IO;
using System.Windows.Forms;

namespace recursive
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

        private void Browsefilesbtn(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgBrowseFolder = new FolderBrowserDialog();
            if (dlgBrowseFolder.ShowDialog() == DialogResult.OK)
            {
                pathstring.Text = dlgBrowseFolder.SelectedPath;
            }
            string path = pathstring.Text;
            string[] subpath = path.Split(Path.DirectorySeparatorChar);
            DisplayTreeview(treeView1.Nodes, subpath);
        }

        private void DisplayTreeview(TreeNodeCollection nodes, string[] subpath)
        {
            try
            {
                if (subpath.Length > 0)
                {

                    nodes.Add(subpath[0]);
                    string[] subpathleft = new string[subpath.Length - 1];
                    for (int i = 1; i < subpath.Length; i++)
                    {
                        subpathleft[i - 1] = subpath[i];
                    }
                    DisplayTreeview(nodes[0].Nodes, subpathleft);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
