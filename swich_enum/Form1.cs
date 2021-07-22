using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swich_enum
{
    public partial class Form1 : Form
    {
        Monster m = new Monster();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m.ReportPostition());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //m.Move(1);///造成閱讀上的不方便,不知道1實際上代表的方位
            m.Move_switch_enum(Direction.UP);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //m.Move(4);///造成閱讀上的不方便,不知道1實際上代表的方位
            m.Move_switch_enum(Direction.RIGHT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //m.Move(3);///造成閱讀上的不方便,不知道1實際上代表的方位
            m.Move_switch_enum(Direction.LEFT);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //m.Move(2);///造成閱讀上的不方便,不知道1實際上代表的方位
            m.Move_switch_enum(Direction.DOWN);
        }
    }
}
