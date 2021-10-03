using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_demo
{
    class Program
    {
        //Event-->也是類型的一種成員-->讓類型具有Notification的能力
        //可在某個動作發生之後通知事件的關注者並觸發動作

        static void Main(string[] args)
        {
            Buyer buyer = new Buyer();
            Seller seller = new Seller();

            buyer.Pay += seller.CheckPayment;
            //事件內主要五個組成
            //sender-->事件發送者
            //Event-->事件本身
            //+=-->掛載處理方法
            //seller-->事件響應對像
            //checkPayment-->事件處理器

            buyer.SimulateShopping();
            Console.ReadLine();
        }
    }
}
