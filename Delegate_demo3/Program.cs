using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_demo3
{
    /// 委託實際上為一種class,宣告的位置應與class同級
    /// 並且宣告所要委託的方法原型  double MyDelagate(double x, double y)
    /// 本身是一種回調函數(函数指针变量可以作为某个函数的参数来使用), 類似C++函數指針,能夠封裝並間接調用方法
    delegate double MyDelagate(double x, double y);
    
    ///定義好之後可以使用這個委託去封裝所定義方法的原型,通過委託去建這個方法
    
    class DemoDelegate
    {
        //此處宣告方法與委託所宣告的方法原型是保持一致的(參數的類型與數量)
        public double AddDouble(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //new出實例
            DemoDelegate demo = new DemoDelegate();
            //使用delegate進行封裝(綁定)-->綁定方法時需要提供方法名稱而非調用--->demo.AddDouble()
            MyDelagate myDelagate = demo.AddDouble;
            //可以使用Invoke去觸發方法
            var result = myDelagate.Invoke(1.0,2.0);
            //也可以省略  
            //var result = myDelagate(1.0,2.0);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
