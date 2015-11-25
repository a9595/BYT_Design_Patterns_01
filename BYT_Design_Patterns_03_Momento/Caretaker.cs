using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_03_Momento
{
    class Caretaker
    {
        private readonly GameOriginator _game = new GameOriginator();
        private readonly Stack<GameMemento> _quickSaves = new Stack<GameMemento>();
        public void ShootThatDumbAss()
        {
            _game.Play();
        }
        public void F5()
        {
            _quickSaves.Push(_game.GameSave());
            Console.WriteLine("F5");
        }
        public void F9()
        {
            _game.LoadGame(_quickSaves.Peek());
            Console.WriteLine("F9");
        }
    }
}
