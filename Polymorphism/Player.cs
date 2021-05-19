using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Player:Creature
    {
        //Creature 含有建構子,Player同樣必須有建構子,利用base呼叫Creature建構子,再將name傳入
        //那麼即可將name傳給Creature建構子
        public Player(string name):base(name)
        {

        }

        public override string say()
        {
            return "haha! i'm player " + name + " HP:" + hp;
        }
    }
}
