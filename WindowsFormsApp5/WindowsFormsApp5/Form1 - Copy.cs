using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgBrowseFolder = new FolderBrowserDialog();
            if (dlgBrowseFolder.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlgBrowseFolder.SelectedPath;
            }

            string path = txtPath.Text;
            string[] paths = path.Split(Path.DirectorySeparatorChar);

            //TreeNode node = treeView1.Nodes.Add("{0}", path[0]);
            //treeView1.Nodes[0].Nodes.Add("{0}", path[1]);
            //treeView1.Nodes[0].Nodes[0].Nodes.Add("{0}", path[2]);
            //treeview1.nodes[0].nodes[0].nodes[0].nodes.add("{0}", path[3]);
            //treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(" "); 
            //CallRecursive(treeView1);

            DisplayTreeview(treeView1.Nodes, paths);
        }

        private void DisplayTreeview(TreeNodeCollection nodes, string[] paths)
        {
            try
            {
                if (paths.Length > 0)
                {
                    nodes.Add(paths[0]);
                    string[] remainingPaths = new string[paths.Length - 1];
                    for (int i = 1; i < paths.Length; i++)
                    {
                        remainingPaths[i - 1] = paths[i];
                    }
                    DisplayTreeview(nodes[0].Nodes, remainingPaths); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
