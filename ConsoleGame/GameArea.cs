using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class GameArea
    {
        public int Width { get; }
        public int Height { get; }
        private List<List<string>> dots;
        private List<List<string>> clear_dots;

        public GameArea(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.clear_dots = new List<List<string>>();
            this.dots = new List<List<string>>();
            for (int j = 0; j<height; j++)
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < width; i++)
                {
                    temp.Add(" ");
                }
                this.clear_dots.Add(temp);
                
            }
            for (int j = 0; j < height; j++)
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < width; i++)
                {
                    temp.Add(" ");
                }
                
                this.dots.Add(temp);
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for(int i = 0; i<this.dots.Count; i++)
            {
                Console.WriteLine(string.Join("", this.dots[i]));
            }
            for (int i = 0; i < this.dots.Count; i++)
            {
                for (int j = 0; j < this.dots[0].Count; j++)
                {
                    this.dots[i][j] = this.clear_dots[i][j];
                }
            }

        }
        public void Draw(int x, int y, string s)
        {
            this.dots[y][x] = s;
        }
    }
}
