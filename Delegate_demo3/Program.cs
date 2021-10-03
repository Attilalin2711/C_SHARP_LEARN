using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_demo3
{
    /// 自定義委託實際上為一種class,宣告的位置應與class同級
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
        //Action測試(無返回值)
        public void Print()
        {
            Console.WriteLine("print....");
        }
        public void PrintTest(string text)
        {
            Console.WriteLine(text);
        }
        //Func測試(有返回值)
        public int Test()
        {
            return 1;
        }
        public int TestSum(int x, int y)
        {
            return x + y;
        }
        //多播委託測試
        public void GetSum()
        {
            Console.WriteLine("test get sum");
        }
        public void GetSum02()
        {
            Console.WriteLine("test get sum02");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("自定義委託測試結果:");
            //new出實例
            DemoDelegate demo = new DemoDelegate();
            //使用delegate進行封裝(綁定)-->綁定方法時需要提供方法名稱而非調用--->demo.AddDouble()
            MyDelagate myDelagate = demo.AddDouble;
            //可以使用Invoke去觸發方法
            var result = myDelagate.Invoke(1.0,2.0);
            //也可以省略  
            //var result = myDelagate(1.0,2.0);
            Console.WriteLine(result);
            //Console.ReadKey();

            Console.WriteLine("系統委託測試結果:");
            //*系統委託(系統定義好的-->不需宣告)
            //1.Action為提供輸入參數的委託,可提供多個泛型參數,但沒有輸出(無返回值)
            Action action = new Action(demo.Print);
            action();
            Action<string> action01 = new Action<string>(demo.PrintTest);
            action01("test action01");

            //2.Func同樣提供輸入參數的委託,可提供多個泛型參數,但有輸出(無返回值)
            //其中最後一個參數為返回值參數類型(若單個參數,代表此參數無輸入參數)
            Func<int> func = new Func<int>(demo.Test);
            Console.WriteLine(func());
            Func<int, int, int> func01 = new Func<int, int, int>(demo.TestSum);
            Console.WriteLine(func01(1,5));

            //多播委託
            Console.WriteLine("多播委託測試結果1:");
            //當使用一個委託去封裝多個方法,這些方法會構成委託鍊,invoke委託時會去循環的調用所有方法
            Action actiontest = new Action(demo.GetSum);
            //使用+=去添加新的方法
            actiontest += new Action(demo.GetSum02);
            //也可使用-=去移除方法
            actiontest -= new Action(demo.GetSum02);
            actiontest();

            //+=也可寫成下面形式,同樣把兩個Action結合在一起
            Console.WriteLine("多播委託測試結果2:");
            Action actionDemo = (Action)Delegate.Combine(new Action(demo.GetSum), new Action(demo.GetSum02));
            actionDemo();
            var actionResult = (Action)Delegate.Remove(actionDemo, new Action(demo.GetSum02));
            actionResult();
            Console.ReadKey();
        }
    }
}
