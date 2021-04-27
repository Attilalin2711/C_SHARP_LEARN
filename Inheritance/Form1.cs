using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Villager v1 = new Villager();
            MessageBox.Show("" + v1.GetHP());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monster mon1 = new Monster();
            Villager v2 = new Villager();
            v2.Injured(mon1.Attack());
            MessageBox.Show("" + v2.GetHP());
        }
    }
}
