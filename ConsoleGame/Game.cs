using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleGame
{
    internal class Game
    {
        private int framerate = 10;
        private string output = "qwer";
        private GameArea gamearea = new GameArea(15, 30);
        private Cube cube = new Cube(5,5,".");
        public void Run()
        {
            Timer timer = new Timer(new TimerCallback(Loop), null, 0, 1000 / framerate);
        }

        private void Loop(object obj)
        {
            this.Update();
            this.Draw();
        }

        private void Update()
        {
            
        }

        private void Draw()
        {
            gamearea.Draw();
            cube.Draw();
        }
    }
}
