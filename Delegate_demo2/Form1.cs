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
        public delegate void ValueChanged(object sender, EventArgs e);
        private int myValue;
        //與委託關聯事件
        public event ValueChanged OnValuechanged;

        public int Myvalue
        {
            get { return myValue; }
            set
            {
                //改變參數呼叫觸發事件
                if (value != myValue)
                {

                }
                myValue = value;
            }
        }

        public Form1()
        {

            InitializeComponent();
            myValue = 0;
            OnValuechanged += new ValueChanged(afterValueChanged);
        }
        //事件處理函式，在這裡新增變數改變之後的操作
        private void afterValueChanged(object sender, EventArgs e)
        {
            bool changed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
