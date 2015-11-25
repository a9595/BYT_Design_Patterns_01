namespace BYT_Design_Patterns_03_Momento
{
    public class GameState
    {
        private int health;
        private int killedMonsters;

        public GameState(int health, int killedMonsters)
        {
            this.health = health;
            this.killedMonsters = killedMonsters;

        }

        public double Health
        {
            get { return health; }
            
        }

        public int KilledMonsters { get { return killedMonsters; } }


        public override string ToString()
        {
            return "Health" + Health + "\n" + "Killed" + KilledMonsters;
        }
    }
}