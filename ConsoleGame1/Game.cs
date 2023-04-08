using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleGame1
{
    internal class Game
    {
        private int fps;
        private GameArea gamearea;
        private Cube cube = new Cube(5, 5, ".");

        public Game(int fps)
        {
            this.fps = fps;
            gamearea = new GameArea(30, 15);
        }
        public void Run()
        {
            Timer timer = new Timer(new TimerCallback(Loop), null, 0, 1000 / fps);
        }

        public void Key(ConsoleKey key)
        {
            cube.Key(key);
        }

        private void Loop(object obj)
        {
            Update();
            Draw();
        }

        private void Update()
        {
            cube.Move();
        }

        private void Draw()
        {
            gamearea.Draw();
            cube.Draw(gamearea);
        }
    }
}
