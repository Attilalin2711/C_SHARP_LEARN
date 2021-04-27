using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Student
    {
        /// property
        public string StudentID;
        public string Name;
        public int Grade;
        /// <summary>
        /// static概念同樣也可使用在變數
        /// 假設需要為每個同學設定同樣及格分數,也可直接使用static變數,就可避免產生物件可能給PASS_Score不同分數的問題
        /// static variable特徵有二:
        /// 1.可以直接透過class名稱存取
        /// 2.所有的class物件共用同一個static變數
        /// </summary>
        public int Score;
        public static int PASS_Score = 60;
        /// method
        public string Say()
        {
            return "我的名子是" + Name + " ,我是" + Grade + "年級學生";
        }
        public string Talk(Student s)
        {
            return Grade + "年級的" + Name + "對" + s.Grade + "年級的" + s.Name + "說您好~";
        }
        public void upgrade()
        {
            Grade++;
        }
        public bool isPass()
        {
            if (Score > PASS_Score)
                return true;
            else
                return false;
        }
    }
}
