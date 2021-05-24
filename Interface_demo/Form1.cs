using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creature creature = new Villager();
            MessageBox.Show(creature.say());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creature creature = new Villager();
            ///透過介面可以定義我們特別要求存在的method,但不需要用原本Creature變數就可以使用這個method
            IAttackable someone = new Monster();
            someone.attack(creature);

            MessageBox.Show(creature.say());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Creature creature = new Villager();
            ITalkable someone = new Player();

            MessageBox.Show(someone.talkTo(creature));
        }
    }
}
