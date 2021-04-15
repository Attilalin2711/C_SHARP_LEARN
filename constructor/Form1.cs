using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            建構子 constructor
            1.Method的一種
            2.在物件建立時執行
            */
            ///constructor預先設定好grade
            Student Attila = new Student("10675024", "Attila", 3);
            Student Han = new Student("10225232", "Han");
            MessageBox.Show(Attila.Talk(Han));
        }
    }
}
