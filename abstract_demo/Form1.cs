using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstract_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///
            ///Monster monster = new Monster(); abstract後無法實體化Monster類
            ///因為abstact class內的方法只有在子類實現,因此無法實作(本身的方法未定義)
            ///abstract同時也可以強迫子類別一定要去實作父類功能
            Monster monster = new slime();
            MessageBox.Show("" + monster.attack());
        }
    }
}
