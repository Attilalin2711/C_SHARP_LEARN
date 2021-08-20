using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
namespace @try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string srcpath = "C://Users//david2711//Desktop//專案//U65-100//程式//Contrel_LOT_V1.3//Contrel_LOT//bin//Release//LOT_Recipe//003//";
            string destpath = "C://Users//david2711//Desktop//專案//U65-100//程式//Contrel_LOT_V1.3//Contrel_LOT//bin//Release//LOT_Recipe//004//";
            if (destpath[destpath.Length - 1] != Path.DirectorySeparatorChar)
                destpath += Path.DirectorySeparatorChar;
            MessageBox.Show(destpath);
        }
    }
}
