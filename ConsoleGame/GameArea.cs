using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class GameArea
    {
        private int width;
        private int height;

        public GameArea(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            for(int i = 0; i<height; i++)
            {
                for (int j = 0; j<width; j++)
                {
                    if(i == 0 || (i == height-1) || j == 0 || (j == width - 1))
                    {
                        Symbol.Draw(i,j,"#");
                    }
                    else
                    {
                        Symbol.Draw(i,j," ");
                    }
                }
            }
        }
    }
}
