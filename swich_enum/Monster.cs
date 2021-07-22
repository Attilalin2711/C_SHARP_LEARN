using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swich_enum
{
    class Monster
    {
        private int X;
        private int Y;
        //direction: 1 =>up ,2 =>down, 3=>left, 4=>right
        public void Move(int direction)
        {
            if (direction == 1){Y += 1;}
            else if (direction == 2) { Y-=1;}
            else if (direction == 3) {X-=1;}
            else if (direction == 4) { X += 1; }
        }

        public void Move_switch(int direction)
        {
            switch(direction)//給要判定變數direction
            {
                case 1://1為direction值
                    Y += 1;
                    break;
                case 2:
                    Y -= 1;
                    break;
                case 3:
                    X -= 1;
                    break;
                case 4:
                    X += 1;
                    break;
            }
        }

        public void Move_switch_enum(Direction direction)
        {
            switch (direction)//給要判定變數direction
            {
                case Direction.UP://1為direction值
                    Y += 1;
                    break;
                case Direction.DOWN:
                    Y -= 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X += 1;
                    break;
                default://變數不符合上述四種狀況
                    //Error
                    break;
            }
        }
        public string ReportPostition()
        {
            return "Monster postion: (" + X + "," + Y + ")";
        }
    }
}
