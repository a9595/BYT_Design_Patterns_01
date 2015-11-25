using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Design_Patterns_03_Momento
{
    class GameOriginator
    {
        private GameState _state = new GameState(100, 0);
        public void Play()
        {   _state = new GameState((int)(_state.Health * 0.9), _state.KilledMonsters + 2);
            Console.WriteLine(_state.ToString());
        }
        public GameMemento GameSave()
        {
            return new GameMemento(_state);
        }
        public void LoadGame(GameMemento memento)
        {
            _state = memento.GetState();
        }
    }
}
