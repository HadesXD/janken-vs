using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class HelperClass
    {
        public static Random rand = new Random();

        public static int GetState()
        {
            return rand.Next(0, 3);
        }
    }

    public class Game
    {

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public int Player1State { get; set; }
        public int Player2State { get; set; }
        public static int Player1Highscore { get; set; }
        public static int Player2Highscore { get; set; }

        public int Play(int winner = 0)
        {
            Player1State = HelperClass.GetState();
            Player2State = HelperClass.GetState();

            if (Player1State == 0 && Player2State == 0) //paper vs paper = no winner
            {
                winner = 0;
            }
            if (Player1State == 1 && Player2State == 1) //rock vs rock = no winner
            {
                winner = 0;
            }
            if (Player1State == 2 && Player2State == 2) //scissors vs scissors = no winner
            {
                winner = 0;
            }

            if (Player1State == 0 && Player2State == 1) //paper vs rock = paper
            {
                winner = 1;
                Player1Score = Player1Score + 1;
            }
            if (Player1State == 2 && Player2State == 0) //scissors vs paper = scissors
            {
                winner = 1;
                Player1Score = Player1Score + 1;
            }
            if (Player1State == 1 && Player2State == 2) //rock vs scissors = rock
            {
                winner = 1;
                Player1Score = Player1Score + 1;
            }

            if (Player1State == 1 && Player2State == 0) //rock vs paper = paper
            {
                winner = 2;
                Player2Score = Player2Score + 1;
            }
            if  (Player1State == 0 && Player2State == 2) //paper vs scissors = scissors
            {
                winner = 2;
                Player2Score = Player2Score + 1;

            }
            if (Player1State == 2 && Player2State == 1) //scissors vs rock = rock
            {
                winner = 2;
                Player2Score = Player2Score + 1;
            }

            return winner;
            /*return Player1State;
            return Player2State;
            return Player1Score;
            return Player2Score;
            */
        }

        public int Reset()
        {
            Player1Score = 0;
            Player2Score = 0;
           
            return Player1Score;
            return Player2Score;
        }
    }
}
