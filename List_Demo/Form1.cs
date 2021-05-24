using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///一般陣列
            int[] array = new int[5];

            array[0] = 9453;
            array[1] = 42;
            array[2] = 44;
            array[3] = 5422;
            array[4] = 123;
            /*陣列缺點
              1.需要預先知道總共需要多大空間
              2.陣列建立後未使用到即浪費空間,大部分只用到前面幾格
              3.ex.線上遊戲儲存玩家資料變數--> 預先無法知道多少玩家上線
                                           --> 假設開了1000格只用到100格,因為部分使用到,garbage collection並不會啟動回收機制
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            list.Add(514);
            list.Add(5323);
            list.Add(21);
            /*
             此時便需要List<T>-->串列結構
             <T>語法為泛型語法
             1.可以想成設計List的作者留下的型別保留符號--> 代表 "要在List中放什麼型別資料"
             2.建立物件時,List<T>的T要換成實際要存入的型別--> 例如: List<int>代表的是 "存放int型別資料的List"
                                                          --> Generic會自動將List<T>的class與method裡面出現T的地方都換成int
                                                                 ex. Add(T x)->Add(int x)
                                                                     Remove(T x)->Remove(int x)
                                                                     Contains(T x)->Contains(int x)
             3.假設有一個List<T>的物件list(不須設定大小)
                (1)新增一個物件x
                  --> list.Add(x)
                (2)取得位置pos上的值
                  --> list[pos]
                (3)刪除在位置pos上的物件   
                  -->list.RemoveAt(pos)
                (4)刪除在位置x上的物件       *使用x.equals(y)判斷
                  -->list.Remove(x)
                (5)取得現在有幾個物件  
                  -->list.Count
                (6)檢查是否有物件x           *使用x.equals(y)判斷
                  -->list.Contains(x)
                (7)排序                      *儲存的資料型別必須實作IComparable
                  -->list.Sort()
            */
            list.RemoveAt(1);//刪除5215 程式自動將後面資料往前遞補

            MessageBox.Show("有沒有514: "+ list.Contains(514));

            for (int i = 0; i < list.Count; i++) 
                MessageBox.Show("第 " + i + "個資料是" + list[i]);
        }
    }
}
