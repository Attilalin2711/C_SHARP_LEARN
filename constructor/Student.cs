using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;///想要使用MessageBox需要使用
namespace constructor
{
    class Student
    {
        /// property
        public string StudentID;
        public string Name;
        public int Grade;
        public int height;
        /*
        constructor(一種method)
        1.沒有output輸出
        2.名稱與class名稱相同
        3.建構子可給予input(引數 or 輸入值)用於幫助設定物件
        */
        public Student(string studentId, string name, int grade,int height)
        {
            Name = name;
            StudentID = studentId;
            Grade = grade;
            //這個物件的height = height
            //this 為一個reference type變數-->指向自己物件的物件變數變數(自己物件的物件變數)
            //this變數為物件產生時即產生
            this.height = height;  
            

        }
        /*
        overloaded(多載)
        不同情況使用不同建構子
        此建構子for新生,年級為1
        上面建構子for轉學生,年級可自己指定
        */
        public Student(string studentId, string name)
        {
            Name = name;
            StudentID = studentId;
            Grade = 1;
        }
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
    }
}
