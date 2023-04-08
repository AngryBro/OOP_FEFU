using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame1
{
    internal class GameObject
    {
        protected int x;
        protected int y;
        protected ConsoleKey key;

        public void Key(ConsoleKey key)
        {
            this.key = key;
        }
    }
}
