using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_demo2
{
    class param
    {
        public delegate void ValueChanged(object sender, EventArgs e);
        private int myValue;
        public event ValueChanged OnValuechanged;
        public bool changed;
        public int Myvalue
        {
            get { return myValue; }
            set
            {
                //改變參數呼叫觸發事件
                if (value != myValue)
                {
                    WhenMyValueChange();//委派
                }
                myValue = value;
            }
        }

        public param()
        {
            changed = false;
            myValue = 0;
            OnValuechanged += new ValueChanged(afterValueChanged);
        }
        private void WhenMyValueChange()
        {
            if (OnValuechanged != null)
            {
                OnValuechanged(this, null);
            }
        }
        //事件處理函式，在這裡新增變數改變之後的操作
        private void afterValueChanged(object sender, EventArgs e)
        {
            changed = true;
        }
    }
}
