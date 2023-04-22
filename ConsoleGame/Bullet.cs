using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Bullet: GameObject
    {
        public Bullet(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(GameArea gameArea)
        {
            if(x < gameArea.Width-3) x++;
        }
        public void Draw(GameArea gameArea)
        {
            gameArea.Draw(x, y, "-");
            gameArea.Draw(x+1, y, ">");
        }
    }
}
