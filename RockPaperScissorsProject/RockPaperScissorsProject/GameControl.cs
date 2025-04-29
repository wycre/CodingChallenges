using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsProject
{
    public partial class GameControl : UserControl
    {
        public GameControl()
        {
            InitializeComponent();
        }

        private enum PlayChoices
        {
            Rock,
            Paper,
            Scissors
        }

        /// <summary>
        /// Recursively changes the forground color of a control, useful when changing the ForeColor of labels
        /// </summary>
        /// <param name="control">The control the be changed</param>
        /// <param name="color">The color to change the control to</param>
        private void ChangeLabelColor(Control control, Color color)
        {
            control.ForeColor = color;
            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    ChangeLabelColor(childControl, color);
                }
            }
        }

        private GameManager.Outcome RoundAdjudicator(PlayChoices playerChoice, PlayChoices opponentChoice)
        {
            if (playerChoice == PlayChoices.Rock && opponentChoice == PlayChoices.Scissors)
            {
                return GameManager.Outcome.Win;
            }
            else if (playerChoice == PlayChoices.Paper && opponentChoice == PlayChoices.Rock)
            {
                return GameManager.Outcome.Win;
            }
            else if (playerChoice == PlayChoices.Scissors && opponentChoice == PlayChoices.Paper)
            {
                return GameManager.Outcome.Win;
            }
            else if (playerChoice == opponentChoice)
            {
                return GameManager.Outcome.Tie;
            }
            else return GameManager.Outcome.Lose;
        }

        private void PlayTurn(PlayChoices choice)
        {
            // Generate random play from computer
            Random random = new Random();
            PlayChoices compChoice = (PlayChoices)random.Next(3);
            oppChoiceText.Text = compChoice.ToString();

            GameManager.Outcome playerOutcome = RoundAdjudicator(choice, compChoice);

            bool gameOver = Program.gameManager.RegisterOutcome(playerOutcome);

            winStatusLabel.Show();
            if (playerOutcome == GameManager.Outcome.Win)
            {
                winStatusLabel.Text = "You Won This Round";
                ChangeLabelColor(winStatusLabel, Color.Green);
                playerScoreLabel.Text = Program.gameManager.PlayerWinCount.ToString();
            }
            else if (playerOutcome == GameManager.Outcome.Lose)
            {
                winStatusLabel.Text = "You Lost This Round";
                ChangeLabelColor(winStatusLabel, Color.Red);
                opponentScoreLabel.Text = Program.gameManager.OpponentWinCount.ToString();
            }
            else if (playerOutcome == GameManager.Outcome.Tie)
            {
                winStatusLabel.Text = "You Tied This Round";
                ChangeLabelColor(winStatusLabel, Color.Black);
            }


            if (gameOver)
            {
                EndGame();
            }
        }


        private void EndGame()
        {
            rockButton.Enabled = false;
            paperButton.Enabled = false;
            Scissors.Enabled = false;

            if (Program.gameManager.PlayerIsWinner == true)
            {
                winStatusLabel.Text = "You Won This Match";
                ChangeLabelColor(winStatusLabel, Color.Green);
            }
            else
            {
                winStatusLabel.Text = "You Lost This Match";
                ChangeLabelColor(winStatusLabel, Color.Red);
            }

            returnButton.Visible = true;
            returnButton.Enabled = true;

            Program.gameManager.ResetGame();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            PlayTurn(PlayChoices.Rock);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            PlayTurn(PlayChoices.Paper);
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            PlayTurn(PlayChoices.Scissors);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            rockButton.Enabled = true;
            paperButton.Enabled = true;
            Scissors.Enabled = true;

            winStatusLabel.Visible = false;
            returnButton.Visible = false;

            oppChoiceText.Text = "Waiting for play";

            playerScoreLabel.Text = "0";
            opponentScoreLabel.Text = "0";

            Program.gameManager.DeactivateGame();
        }
    }
}
