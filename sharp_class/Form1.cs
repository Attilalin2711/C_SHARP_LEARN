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

        private void button3_Click(object sender, EventArgs e)
        {
            //reference type
            //記憶體存放著物件記憶體位置(存放於Heap),-->因此s1與s2的記憶體位置相同-->更改時呈現s2結果
            //型別:class
            Student s1 = new Student();
            s1.Name = "Han";
            s1.Grade = 3;

            Student s2 = s1;
            s2.Name = "Attila";
            s2.Grade = 2;
            MessageBox.Show(s2.Say());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //value type
            //型別:int short float double ....數字與bool型別
            int a = 10;
            int b = a;
            b = 20;
            MessageBox.Show("a=" + a + ", b=" + b);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            建構子 constructor
            1.Method的一種
            2.在物件建立時執行
            */
            ///constructor預先設定好grade
            Student maybin = new Student();
            MessageBox.Show(maybin.Say());
            
        }
    }
}
