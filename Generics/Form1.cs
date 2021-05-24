using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///繼承無法輕易從程式做出相同限制
            Building b = new Building();

            b.Add(new Worker("David"));
            b.Add(new Worker("John"));
            MessageBox.Show(b.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///泛型限制了P只能是同一個類別
            Building_g<Worker> b = new Building_g<Worker>();

            b.Add(new Worker("David"));
            b.Add(new Worker("John"));
            //b.Add(new Resident("Jennita")); -->顯示錯誤,building_g只接受worker
            MessageBox.Show(b.ToString());
        }
    }
}

/*
 * 典型就像List<T>-->藉由將T換成想要的型別,就可以在List中存入該型別的資料
 * 泛型可以想成是 "暫時替代型別的placeholder"-->可以不用決定 T 是什麼型別,就可以完成class或method的設計 

 */
