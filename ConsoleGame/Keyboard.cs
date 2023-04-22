using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Keyboard
    {
        public static ConsoleKey Key { get; set; }
        public static bool KeyUsed { get; set; }
        public static bool KeyPressed(ConsoleKey key)
        {
            bool t = key.Equals(Keyboard.Key) && !Keyboard.KeyUsed;
            if(t)
            {
                KeyUsed = true;
            }
            return t;
        }
    }
}
