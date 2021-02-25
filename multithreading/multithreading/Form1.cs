using System;
using System.Windows.Forms;
using System.IO;

namespace multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void GetDirectoryBtn(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgBrowseFolder = new FolderBrowserDialog();
            if (dlgBrowseFolder.ShowDialog() == DialogResult.OK)
            {

                DirectoryString.Text = dlgBrowseFolder.SelectedPath;
               
            }
        }

        private void LoadDirectoryBtn(object sender, EventArgs e)
        {
            TreeNode node = ViewDirectory.Nodes.Add((DirectoryString.Text));
            ListDirectory(ViewDirectory, (DirectoryString.Text));
       }
        private void DisplaySubFolders(TreeNodeCollection nodes, string MyString)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo((DirectoryString.Text));
            System.IO.FileSystemInfo[] files = di.GetDirectories();
            foreach (FileSystemInfo subFolders in files)
            {
                ViewDirectory.Nodes[0].Nodes.Add((subFolders.Name));
            }
        }
        private static TreeNode CreateSubFolderNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateSubFolderNode(directory));
            foreach (var files in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(files.Name));
            return directoryNode;
        }
        private void ListDirectory(TreeView treeView, string path)
        {
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateSubFolderNode(rootDirectoryInfo));
        }
        private void ViewDirectory_AfterSelect(object sender, TreeViewEventArgs e)

        {

        }
    }
}
