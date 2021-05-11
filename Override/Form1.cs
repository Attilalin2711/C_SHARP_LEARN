using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player p1 = new Player("NQKK");
            Monster m1 = new Monster("Terrorist_1");
            Hostage h1 = new Hostage("student");

            Creature c = m1; //小提示:可以使用Base Class的變數來存取繼承class的物件
            //重點一
            ///比起override,多寫另一個方法,可以同時實現向前向後的功能不是更加彈性?
            ///override的好處在於使用base class的變數仍可呼叫到被override方法
            ///使用多寫move2的功能時,只有在monster身分才有辦法呼叫它,使用Creature變數時並無法呼叫move2

            string message = c.move();
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///重點2 method hiding, 見Monster與Hostage類的move方法差異!
            ///繼承時,相當於將父類方法複製一份至子類
            ///它使用override時,會直接改寫複製的方法,因此不管使用父類或子類變數呼叫方法,皆會使用相同的方法
            ///但若忘記加上override,此時相當於在複製的方法外,另寫一個相同名稱的方法,
            ///因此使用父類變數呼叫時會呼叫到複製的方法(父類的方法),使用子類會呼叫到另寫的子類方法,稱為method hiding
            ///若想使用method hiding,建議將override改為new(相當於什麼都不做)
            Creature c = new Hostage("banker1");
            Hostage h = new Hostage("banker2");
            Creature c2 = new Monster("wolf");
            Monster m = new Monster("wolf2");
            MessageBox.Show(c.move());//move forward
            MessageBox.Show(h.move());//move right
            MessageBox.Show(c2.move());//move back
            MessageBox.Show(m.move());//move back
        }
    }
}
