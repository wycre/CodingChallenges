namespace RockPaperScissorsProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

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
    }
}
