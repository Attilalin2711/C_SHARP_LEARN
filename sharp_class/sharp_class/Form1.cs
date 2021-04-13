using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharp_class
{
    public partial class Form1 : Form
    {
        Student David = new Student();
        Student John = new Student();
        public Form1()
        {
            InitializeComponent();
            David.Grade = 3;
            John.Grade = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            David.Name = "David";
            David.StudentID = "10225232";
            MessageBox.Show(David.Say());
        }
        private void btnupgrade_Click(object sender, EventArgs e)
        {
            David.upgrade();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            John.Name = "John";
            John.StudentID = "10675024";
            MessageBox.Show(John.Talk(David));
        }
    }
}
