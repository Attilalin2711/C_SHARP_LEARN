using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protect_use
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monster m = new Monster();
            m.getHP();//想獲得private只能透過public的方法間接獲得
            MessageBox.Show("" + m.getHP());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slime s = new Slime();
            MessageBox.Show("" + s.getHP());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Slime s = new Protect_use.Slime();
            MessageBox.Show(s.introduceSelf());

        }
    }
}
