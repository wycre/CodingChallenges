using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    /// <summary>
    /// An instance of GameManager represents one running app, and holds settings and methods useful for its execution
    /// </summary>
    internal class GameManager
    {
        #region Static Members
        public enum RoundChoices
        {
            BestOfOne,
            BestOfThree,
            BestOfFive
        }

        public enum Outcome
        {
            Win,
            Lose,
            Tie
        }

        #endregion


        #region Fields

        private MainWindow mainWindow;
        private RoundChoices roundChoice;
        private int maxWins;

        private int playerWins;
        private int opponentWins;

        private bool? playerIsWinner;

        #endregion

        #region Properties

        public RoundChoices RoundType 
        {   get 
            { return roundChoice; } 
            set 
            { 
                roundChoice = value;
                if (roundChoice == RoundChoices.BestOfOne) maxWins = 1;
                if (roundChoice == RoundChoices.BestOfThree) maxWins = 3;
                if (roundChoice == RoundChoices.BestOfFive) maxWins = 5;
            } 
        }

        public MainWindow MainWindow { get { return mainWindow; } }

        public bool? PlayerIsWinner { get { return playerIsWinner; } }

        #endregion

        #region Methods

        public GameManager(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.playerWins = 0;
            this.opponentWins = 0;
            this.playerIsWinner = null;
        }

        public void ActivateGame()
        {
            mainWindow.Controls["gameSetup1"]?.Hide();
            mainWindow.Controls["gameControl1"]?.Show();
        }

        /// <summary>
        /// Registers a round outcome with the game manager
        /// </summary>
        /// <param name="playerOutcome">The Outcome that the player received in the most recent round</param>
        /// <returns>true if the game ends with this round, othewise false</returns>
        public bool RegisterOutcome(Outcome playerOutcome)
        {
            // Increment the win counter
            if (playerOutcome == Outcome.Win)
            {
                playerWins++;
            }
            else if (playerOutcome == Outcome.Lose)
            {
                opponentWins++;
            }

            // Determine if the game should end
            if (playerWins >=  maxWins || opponentWins >= maxWins)
            {
                if (playerWins >= maxWins) playerIsWinner = true;
                if (opponentWins >= maxWins) playerIsWinner = false;
                return true;
            }
            else return false;
        }

        #endregion

    }
}
