using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_demo2
{
    public partial class Form1 : Form
    {
        public bool changed;
        param param1 = new param();
        //與委託關聯事件
        public Form1()
        {
            
            InitializeComponent();
            comboBox1.Items.Add("0");
            comboBox1.Items.Add("90");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            param1.Myvalue = Convert.ToInt16(comboBox1.SelectedItem);
            param1.changed = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            param1.Myvalue = Convert.ToInt16(comboBox1.SelectedItem); 

            if(param1.changed)
            {
                MessageBox.Show("參數已改變 是否丟棄並離開");
            }
        }
    }
}
