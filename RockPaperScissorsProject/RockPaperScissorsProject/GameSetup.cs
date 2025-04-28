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
    public partial class GameSetup : UserControl
    {
        public GameSetup()
        {
            InitializeComponent();
        }

        private void bestOfOneButton_Click(object sender, EventArgs e)
        {
            // Swap button state
            if (bestOfThreeButton.Enabled == false)
            {
                bestOfThreeButton.Enabled = true;
            }
            else if (bestOfFiveButton.Enabled == false)
            {
                bestOfFiveButton.Enabled = true;
            }
            bestOfOneButton.Enabled = false;
            Program.gameManager.RoundType = GameManager.RoundChoices.BestOfOne;
        }

        private void bestOfThreeButton_Click(object sender, EventArgs e)
        {
            // Swap button state
            if (bestOfOneButton.Enabled == false)
            {
                bestOfOneButton.Enabled = true;
            }
            else if (bestOfFiveButton.Enabled == false)
            {
                bestOfFiveButton.Enabled = true;
            }
            bestOfThreeButton.Enabled = false;
            Program.gameManager.RoundType = GameManager.RoundChoices.BestOfThree;
        }

        private void bestOfFiveButton_Click(object sender, EventArgs e)
        {
            // Swap button state
            if (bestOfOneButton.Enabled == false)
            {
                bestOfOneButton.Enabled = true;
            }
            else if (bestOfThreeButton.Enabled == false)
            {
                bestOfThreeButton.Enabled = true;
            }
            bestOfFiveButton.Enabled = false;
            Program.gameManager.RoundType = GameManager.RoundChoices.BestOfFive;
        }

        // New window to show game
        private void startButton_Click(object sender, EventArgs e)
        {
            Program.gameManager.ActivateGame();
        }
    }
}
