using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Frame
    {
        private string fill;
        public Frame(string fill)
        {
            this.fill = fill;
        }

        public void Draw(GameArea gameArea)
        {
            for(int i = 0; i < gameArea.Width; i++)
            {
                gameArea.Draw(i, 0, fill);
                gameArea.Draw(i, gameArea.Height - 1, fill);
            }
            for(int i = 0; i < gameArea.Height; i++)
            {
                gameArea.Draw(0, i, fill);
                gameArea.Draw(gameArea.Width-1, i, fill);
            }
        }

    }
}
