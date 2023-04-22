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
        private int fps = 10;
        private GameArea gamearea = new GameArea(40, 20);
        private Cube cube = new Cube(5,5,".");
        private Frame frame = new Frame("#");

        public void Run()
        {
            Timer timer = new Timer(new TimerCallback(Loop), null, 0, 1000 / fps);
            while(!Keyboard.KeyPressed(ConsoleKey.Escape))
            {
                Keyboard.Key = Console.ReadKey(true).Key;
                Keyboard.KeyUsed = false;
            }
            timer.Dispose();
            Environment.Exit(0);
        }

        private void Loop(object obj)
        {
            this.Draw();
            this.Update();

        }

        
        private void Update()
        {
            cube.Move(gamearea);
            cube.Shoot();
        }

        private void Draw()
        {
            cube.Draw(gamearea);
            frame.Draw(gamearea);
            gamearea.Draw();
        }
    }
}
