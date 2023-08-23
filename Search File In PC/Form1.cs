using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_File_In_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Searching(txtFileName.Text);
        }

        public void Searching(string fileName)
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                var path = @"C:\Users\ersir\Downloads\Music";
                foreach (string file in Directory.EnumerateFiles(s))
                {
                    try
                    {
                        if (file.ToLower().Contains(fileName))
                        {
                            lstFilteredFiles.Items.Add(file);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void lstFilteredFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstFilteredFiles.SelectedItems.Count != 0)
            {
                Process.Start(lstFilteredFiles.SelectedItems[0].ToString());
            }
        }
    }
}
