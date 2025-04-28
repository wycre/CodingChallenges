namespace RockPaperScissorsProject
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameSetup1 = new GameSetup();
            gameControl1 = new GameControl();
            SuspendLayout();
            // 
            // gameSetup1
            // 
            gameSetup1.Location = new Point(75, 10);
            gameSetup1.Name = "gameSetup1";
            gameSetup1.Size = new Size(660, 410);
            gameSetup1.TabIndex = 0;
            // 
            // gameControl1
            // 
            gameControl1.Location = new Point(75, 10);
            gameControl1.Name = "gameControl1";
            gameControl1.Size = new Size(660, 410);
            gameControl1.TabIndex = 1;
            gameControl1.Visible = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gameSetup1);
            Controls.Add(gameControl1);
            Name = "MainWindow";
            Text = "Rock Paper Scissors";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private GameSetup gameSetup1;
        private GameControl gameControl1;
    }
}
