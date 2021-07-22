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
    public partial class Form2 : Form
    {
        Form1 form1;
        int num;

       
        public Form2(Form1 form1,int num)//需要帶上Form1做參數,用以實例化聲明的主窗體
        {
            InitializeComponent();
            this.form1 = form1;
            this.num = num;
            this.Text = "Form" + num;
            //註冊Form2顯示方法註冊到Form1的委託中
            this.form1.SendEvent += new SendEventHandler(form1_SendEvent);
        }

        void form1_SendEvent(string msg)
        {
            txExecute.Text = this.num.ToString() + ":" + msg;
        }

        private void txExecute_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
