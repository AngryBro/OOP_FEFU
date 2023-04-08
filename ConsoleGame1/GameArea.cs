using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame1
{
    internal class GameArea
    {
        private int width;
        private int height;
        private List<List<string>> symbols = new List<List<string>>();

        public GameArea(int width, int height)
        {
            this.width = width;
            this.height = height;
            for(int i = 0; i<height; i++)
            {
                List<string> temp = new List<string>();
                for(int j = 0; j<width; j++)
                {
                    if(i==0 || (i==height-1) || j==0 || (j==width-1))
                    {
                        temp.Add("#");
                    }
                    else
                    {
                        temp.Add(" ");
                    }
                }
                symbols.Add(temp);
            }
        }

        public void Draw()
        {
            for(int i = 0; i<height; i++)
            {
               
                for (int j = 0; j<width; j++)
                {
                    Console.SetCursorPosition(j+1, i + 1);
                    Console.Write(symbols[i][j]);
                }
            }
        }

        public void Set(int x, int y, string s)
        {
            symbols[x][y] = s;
        }


    }
}
