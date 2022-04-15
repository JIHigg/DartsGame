using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsGame
{
    /// <summary>
    /// A Game Containment class for objects for easier saving and loading
    /// </summary>
    [Serializable]
    public class Game
    {
        private Player player1 = new Player();
        private Player player2 = new Player();
        private Dartboard dartboard = new Dartboard();
        private int turnScore = 0;
        private int[] turnDarts = new int[3];
        private int dartCounter = 0;

        public Player Player1 { get { return player1; } set { player1 = value; } }
        public Player Player2 { get { return player2; } set { player2 = value; } }
        public Dartboard Dartboard { get { return dartboard; } set { dartboard = value; } }
        public int TurnScore { get { return turnScore; } set { turnScore = value; } }
        public int[] TurnDarts { get { return turnDarts; } set { turnDarts = value; } }
        public int DartCounter { get { return dartCounter; } set { dartCounter = value; } }

        public Game()
        {

        }

        
    }
}
