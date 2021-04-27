using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class User
    {
        /// public-->代表該property或method在程式任一處皆可存取
        private string Username;//狀況二, 想使用唯讀模式-->可以使用private 屬性,搭配public method顯示(getUsername)
        private string Password;///狀況一, 有些class的property不想讓人看到,無法讀寫,但可由public method取得資訊(ComparePassword)
        private int hp;//狀況三,想在某些property設定上增加一些限制,例如hurt()我們希望HP不會為負數

        private int count1, count5, count10;
        public int Money//get,set存取器可以讓計算用變數呈現
        {
            get { return count1 + count5 * 5 + count10 * 10; } 
        }
        //為了防止意外操作,除了將變數設為private並利用method做媒介
        //也可使用get&set存取器
        //get程式碼會在嘗試讀取變數內容時呼叫
        //set程式碼會再嘗試寫入數值時呼叫
        public int HP 
        {
            get { return hp; } //讀取時自動呼叫
            set //寫入時自動呼叫,寫入的值存入value中(若移除set,則自動變成唯讀模式)
            {
                if (value < 0)
                    hp = 0;
                else
                    hp = value;
            }
        }
        public User(string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
            this.hp = 20;
            this.count1 = 1;
            this.count5 = 1;
            this.count10 = 1;
        }
        public int getHP()
        {
            return hp;
        }
        public void hurt(int decreaseHP)
        {
            if (hp >= decreaseHP)
                hp -= decreaseHP;
            else
                hp = 0;
        }

        public bool ComparePassword(string targetPassword)
        {
            if (this.Password == targetPassword)
                return true;
            else
                return false;
        }
        public string getUsername()
        {
            return Username;
        }
        private void reset()
        {
            Password = "";
        }


    }
}
