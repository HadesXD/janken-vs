using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class;

namespace Janken
{
    public partial class MainMenu : Form
    {
        Game game = new Game();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int winner = game.Play();
            int Player1State = game.Player1State;
            int Player2State = game.Player2State;
            int Player1Score = game.Player1Score;
            int Player2Score = game.Player2Score;

            MessageBox.Show("player: " + winner + " wins " + Player1State + Player2State);

            if (winner == 0) //Tie
            {
                if (Player1State == 0 && Player2State == 0) //paper vs paper = no winner
                {
                    MessageBox.Show("Nobody wins!");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/paper.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/paper.jpg");
                }

                if (Player1State == 1 && Player2State == 1) //rock vs rock = no winner
                {
                    MessageBox.Show("Nobody wins!");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/rock.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/rock.jpg");
                }

                if (Player1State == 2 && Player2State == 2) //scissors vs scissors = no winner
                {
                    MessageBox.Show("Nobody wins!");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/scissors.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/scissors.jpg");
                }
            }

            if (winner == 1) //Player1 wins
            {
                if (Player1State == 0 && Player2State == 1) //paper vs rock = paper
                {
                    MessageBox.Show("Player 1 wins");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/paper.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/rock.jpg");
                    score1Label.Text = Convert.ToString(Player1Score);
                }

                if (Player1State == 2 && Player2State == 0) //scissors vs paper = scissors
                {
                    MessageBox.Show("Player 1 wins");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/scissors.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/paper.jpg");
                    score1Label.Text = Convert.ToString(Player1Score);
                }

                if (Player1State == 1 && Player2State == 2) //rock vs scissors = rock
                {
                    MessageBox.Show("Player 1 wins");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/rock.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/scissors.jpg");
                    score1Label.Text = Convert.ToString(Player1Score);
                }

            }

            if (winner == 2) //Player2 wins
            {
                if (Player1State == 1 && Player2State == 0) //rock vs paper = paper
                {
                    MessageBox.Show("Player 2 wins");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/rock.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/paper.jpg");
                    score2Label.Text = Convert.ToString(Player2Score);
                }

                if (Player1State == 0 && Player2State == 2) //paper vs scissors = scissors
                {
                    MessageBox.Show("Player 2 wins");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/paper.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/scissors.jpg");
                    score2Label.Text = Convert.ToString(Player2Score);
                }

                if (Player1State == 2 && Player2State == 1) //scissors vs rock = rock
                {
                    MessageBox.Show("Player 2 wins");
                    player1PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/scissors.jpg");
                    player2PictureBox.Load("C:/Users/theph/OneDrive/Dokumenti/Visual Studio 2017/Projects/Janken/Images/rock.jpg");
                    score2Label.Text = Convert.ToString(Player2Score);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            game.Reset();

            if (Convert.ToDouble(score1Label.Text) > Convert.ToDouble(highScore1Label.Text))
            {
                highScore1Label.Text = score1Label.Text;
            }

            if (Convert.ToDouble(score2Label.Text) > Convert.ToDouble(highScore2Label.Text))
            {
                highScore2Label.Text = score2Label.Text;
            }

            score1Label.Text = "0";
            score2Label.Text = "0";           
            
        }
    }
}
