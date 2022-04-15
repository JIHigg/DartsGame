using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsGame
{
    [Serializable]
    public class Player
    {
        //Fields
        private string name;
        private List<Turns> turns = new List<Turns>();
        private Dartboard dartboard = new Dartboard();
        private bool isCom = false;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int TurnsCount
        {
            get { return turns.Count(); }
            set { value = turns.Count(); }
        }

        public List<Turns> Turns { get { return turns; } set { turns = value; } }

        public bool IsCom
        {
            get { return isCom; }
            set { isCom = value; }
        }

        //Constructor
        public Player(string newName = "Player")
        {
            Name = newName;
        }

        public Player()
        {

        }

        /// <summary>
        /// Returns total score of player in game
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            int score = 0;

            foreach (var turn in turns)
            {
                for (int i = 0; i < 3; i++)
                {
                    score += turn.Darts[i];
                }
            }
            return score;
        }

        /// <summary>
        /// Adds Turn object with three darts to Player
        /// </summary>
        public void AddTurn(int[] newTurn)
        {
            
            int[] turn = new int[] { 0, 0, 0 };
            Array.Copy(newTurn, turn, newTurn.Length);
            turns.Add(new Turns(turn));
        }

        /// <summary>
        /// Returns formatted String displaying darts for Turn[n]
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string ShowTurn(int n)
        {
            string result = "";

            if (turns.Count > n)
            {
                Turns thisRound = turns[n];
                foreach (var dart in thisRound.Darts)
                    result += $" {dart} ";
            }

            return result;
        }
    }
}
