using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarbageCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Grade = 3;
            s.Name = "小三";
            /*
             ex. Student s = new Student();
             在Reference type時說過,Heap其實就是物件的倉庫
             1.當new Students->產生一個物件時,物件的變數(屬性 方法)就會占用Heap內一塊記憶體空間
             2.變數s也稱作reference,可以視為儲存物件記憶體空間位址之變數(指標),相當於目錄
             3.C#的GrabageCollection機制會去檢查物件是否有變數指向它,如果沒有將會自動將物件給刪除,釋放記憶體空間
             4.本例變數s只在button_click括號裡有效,相當於跑完括號內程式,變數就失效,此時沒有變數指向student這個物件
             便會自動刪除student物件釋放記憶體空間
             
             */
        }
    }
}
