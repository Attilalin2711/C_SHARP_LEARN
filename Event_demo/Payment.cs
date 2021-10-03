using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Event_demo
{
    //創建商品類型-->包含商品名稱  價格  數量
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
    }

    //建構一個當事件發生時要傳遞的參數(Event Args)
    //包含商品列表
    //為事件發生時傳遞的附加訊息
    class PayEventArgs
    {
        //商品列表
        public List<Product> ListProducts { get; set; }
    }

    //申明事件的處理器(Event handler)--->命名規則:事件+EventHandler
    //提供一個泛型TEventArgs-->事件要傳遞的參數
    //sender事件發送者
    public delegate void PayEventHandler<TEventArgs>(object sender, TEventArgs args);

    class Buyer
    {
        private PayEventHandler<PayEventArgs> pay;

        //Event
        public event PayEventHandler<PayEventArgs> Pay
        {
            //Add表示添加器-->登記一個方法對事件的關注
            add
            {
                //+=-->多播委託
                pay += value;
            }
            //Add表示添加器-->移除一個方法對事件的關注
            remove
            {  //-=-->多播委託
                pay -= value;
            }
        }

        //添加事件觸發方法(Invoke event)
        //命名規則:On+事件名稱
        public void OnPay(PayEventArgs eventArgs)
        {
            //?
            //this即為sender
            pay?.Invoke(this, eventArgs);
        }


        public void SimulateShopping()
        {
            for(int i = 0;i<5;i++)
            {
                Console.WriteLine("shopping.." + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Buy something");
            PayEventArgs eventArgs = new PayEventArgs();
            eventArgs.ListProducts = new List<Product>();
            eventArgs.ListProducts.Add(new Product("notebook", 3.5, 2));
            eventArgs.ListProducts.Add(new Product("apple", 5.5, 3));

            Console.WriteLine("Finish..");

            OnPay(eventArgs);
        }
    }

    class Seller
    {
        //關注事件的方法原型必須符合委託類型所申明的方法原型
        public void CheckPayment(object sender, PayEventArgs eventArgs)
        {
            Console.WriteLine("Start checking payment..");
            Thread.Sleep(2000);

            double totalPrice = 0;
            foreach(var product in eventArgs.ListProducts)
            {
                totalPrice += product.Price * product.Amount;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Total price = " + totalPrice);
        }
    }
}
