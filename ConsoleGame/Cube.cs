using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Cube : GameObject
    {
        private string s;

        public Cube(int x, int y, string s)
        {
            this.x = x;
            this.y = y;
            this.s = s;
        }
        public void Draw()
        {
            Symbol.Draw(x, y, s);
            Symbol.Draw(x+1, y, s);
            Symbol.Draw(x+1, y+1, s);
            Symbol.Draw(x, y+1, s);
        }

    }
}
