using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day11thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private  TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }
        public void loadMyTree()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.loadMyTree));
            }
            else
            {
                FolderBrowserDialog FD = new FolderBrowserDialog();
                FD.ShowDialog();
                if (FD.ShowDialog() == DialogResult.OK)
                {
                    treeView1.Nodes.Clear();
                    var rootDirectoryInfo = new DirectoryInfo(FD.SelectedPath);
                    treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
                }
            }
        }
        public async void btnClicked(object s, EventArgs e)
        {
            await Task.Run(() => loadMyTree());
        }















        //private void loadMyTree(string pth)
        //{
        //    FolderBrowserDialog FD = new FolderBrowserDialog();
        //    if (FD.ShowDialog() == DialogResult.OK)
        //    {
        //        DirectoryInfo mainFolderInfo = new DirectoryInfo(FD.SelectedPath);
        //        FileInfo[] files = mainFolderInfo.GetFiles();
        //        DirectoryInfo[] dirs = mainFolderInfo.GetDirectories();


        //        TreeNode t = new TreeNode(mainFolderInfo.Name);

        //        foreach (FileInfo file in files)
        //            treeView1.Nodes.Add(file.Name);
        //        foreach (DirectoryInfo dir in dirs)
        //            treeView1.Nodes.Add(loadMyTree(dir.FullName));
        //    }
          
         
        }
    }

