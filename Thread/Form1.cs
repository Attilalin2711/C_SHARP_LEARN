using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///
using System.Threading;

namespace Thread
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        static void MyBackgroundTask()
        {
            for(int i = 0; i<500; i++)
            {
                //Console.Write("[" + Thread.CurrentThread.ManagedThreadId + "]");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
