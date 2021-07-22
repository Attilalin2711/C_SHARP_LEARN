using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_demo
{
    public delegate void SendEventHandler(string msg); //宣告委託SendEventHandler

    public partial class Form1 : Form
    {
        public event SendEventHandler SendEvent;//宣告事件SendEvent,事件類型為委託SendEventHandler
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //“發送指令”按鈕事件中，直接調用事件
        //所有訂閱了該事件的子窗體，都會各自執行相關操作
        private void btSend_Click(object sender, EventArgs e)
        {
            if(this.SendEvent!=null)
            {
                //表示執行Send方法時 如果LeaderRun有註冊事件,則執行SendEvent
                this.SendEvent(tsMsg.Text);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, ++num);
            form2.Show();
        }
    }
}
