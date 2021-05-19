using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creature c = new Creature("Cat");
            c.injured(1000);
            MessageBox.Show(c.say());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player p = new Player("Cater");
            p.injured(10);
            MessageBox.Show(p.say());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Village v = new Village();
            v.injured(10);
            MessageBox.Show(v.say());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///什麼是利用統一介面去存取物件呢
            ///在宣告player village等操作時,可以使用一個Creature變數去儲存Creature的衍生類別
            ///相當於是player也是一種Creature
            ///c 實際上為一個生物變數,系統並不知道下面實際上是透過player去實作
            ///如此我們只需知道Creature提供了什麼方法,不用太在意實際上的實作是如何
            
            Creature c = new Player("Caterine");
            c.injured(10);
            MessageBox.Show(c.say());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /// 範例二
            /// 假設Monster可以攻擊palyer與village
            /// 此時不用分別寫兩個attack函數
            /// 可以直接將attack的傳入變數設為Creature變數
            /// 如此外面操坐時, 不管是player變數或是village變數都可傳入
            /// 相當於對所有的衍生類別做相同行為
            
            Player p = new Player("Cater");
            Village v = new Village();
            Monster m = new Monster();

            m.attack(p);
            m.attack(v);

            MessageBox.Show(p.say());
            MessageBox.Show(v.say());
        }
    }
}
/*
多型的好處:
 * 可以降低對介面的依賴程度,增加維護程式的彈性
 ->不需要知道有那些衍生類別
 ->不需要位每個衍生類別特別處理
 ->可以隨意新增或刪除衍生類別(都是對生物界面去做操作,衍生類別新增實作並不影響操作)
 
 繼承 vs 多型:
 * 繼承-->強調減少重複的動作 ex.重複的變數hp ,重複的method
 * 多型-->強調透過統一的界面(基底類別)操作,降低對實作的依賴
 
*/