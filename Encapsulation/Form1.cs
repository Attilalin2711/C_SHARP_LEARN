using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User("Attilalin","1234");
            string result = "";

            if (user.ComparePassword("123"))
                result = "password correct";
            else
                result = "incorrect password";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User("Attilalin", "1234");
            user.hurt(30);
            MessageBox.Show("" + user.getHP());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User("Attilalin", "1234");
            user.HP = -10;//變數將儲存於value變數中
            MessageBox.Show("" + user.HP);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User user = new User("Attilalin", "1234");
            MessageBox.Show("" + user.Money);
        }
    }
}
