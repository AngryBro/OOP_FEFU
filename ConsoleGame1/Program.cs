using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1);
            game.Run();
            while (true)
            {
                game.Key(Console.ReadKey().Key);
            }
        }
    }
}
