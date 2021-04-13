using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_class
{
    class Student
    {
        /// property
        public string StudentID;
        public string Name;
        public int Grade;

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
