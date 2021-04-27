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

        private void button6_Click(object sender, EventArgs e)
        {
            math m = new math();
            int a = 10;
            int b = 20;
            int c = m.max(a, b);

            ////若使用靜態方法,則可以不用為了方法而多產生一個物件(避免浪費)
            ////static的特稱為不須建立物件即可使用class的功能,只需要使用物件名稱存取即可
            int d = math.static_max(a, b);
            MessageBox.Show("c=" + c +" d=" + d);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Student david = new Student();
            david.Score = 40;
            Student josh = new Student();
            josh.Score = 50;

            Student.PASS_Score = 40;///將及格分數改為40,因static variable為所有物件共用,所以兩人應該都及格

            if(david.isPass())
                MessageBox.Show("david及格");
            if(josh.isPass())
                MessageBox.Show("josh及格");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             C#中, Math為一個常見的靜態類別,靜態類別有以下特性
             1.無法使用static class建立物件(無法new建立,建立也沒用)
             */
            int a = 10;
            int b = 20;
            Math.Cos(a);
            ///Math m = new Math(); 無法創建
        }
    }
}
