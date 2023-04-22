using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleGame
{
    internal class Cube : GameObject
    {
        private string s;
        private List<Bullet> bullets = new List<Bullet>();

        public Cube(int x, int y, string s)
        {
            this.x = x;
            this.y = y;
            this.s = s;
        }
        public void Draw(GameArea gameArea)
        {
            gameArea.Draw(x, y, s);
            gameArea.Draw(x+1, y, s);
            gameArea.Draw(x, y+1, s);
            gameArea.Draw(x+1, y+1, s);
            for(int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Draw(gameArea);
            }
        }

        public void Shoot()
        {
            if(Keyboard.KeyPressed(ConsoleKey.Q))
            {
                Bullet bullet = new Bullet(x + 2, y + 1);
                bullets.Add(bullet);
            }

        }

        public void Move(GameArea gameArea)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Move(gameArea);
            }
            if(Keyboard.KeyPressed(ConsoleKey.UpArrow) && y > 1)
            {
                y--;
            }
            if (Keyboard.KeyPressed(ConsoleKey.DownArrow) && y < gameArea.Height-3)
            {
                y++;
            }
            if (Keyboard.KeyPressed(ConsoleKey.LeftArrow) && x > 1)
            {
                x--;
            }
            if (Keyboard.KeyPressed(ConsoleKey.RightArrow) && x < gameArea.Width-3)
            {
                x++;
            }
        }

    }
}
