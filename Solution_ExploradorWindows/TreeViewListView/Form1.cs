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


namespace TreeViewListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TreeNode CrearArbol(DirectoryInfo directoryInfo)
        {
            TreeNode treeNode = new TreeNode(directoryInfo.Name);
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(CrearArbol(item));
            }
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(new TreeNode  (item.Name));
            }
            return treeNode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Ruta = "C:\\Users/IFTS 18/Documents/COSAS";
            treeView1.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(Ruta);
            treeView1.Nodes.Add(CrearArbol(directoryInfo));

        }
    }
    
}﻿
 
