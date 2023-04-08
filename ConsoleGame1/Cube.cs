using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame1
{
    internal class Cube: GameObject
    {
        private string s;
        public Cube(int x, int y, string s)
        {
            this.s = s;
            this.x = x;
            this.y = y;
        }

        public void Move()
        {
            if(key.Equals(ConsoleKey.UpArrow))
            {
                y--;
            }
        }

        public void Draw(GameArea gamearea)
        {
            gamearea.Set(x, y, s);
            gamearea.Set(x+1, y, s);
            gamearea.Set(x, y+1, s);
            gamearea.Set(x+1, y+1, s);
        }

    }
}
