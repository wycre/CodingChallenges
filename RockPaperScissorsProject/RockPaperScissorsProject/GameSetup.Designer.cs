namespace RockPaperScissorsProject
{
    partial class GameSetup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            label2 = new Label();
            bestOfFiveButton = new Button();
            bestOfThreeButton = new Button();
            bestOfOneButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 24F);
            startButton.Location = new Point(221, 291);
            startButton.Name = "startButton";
            startButton.Size = new Size(220, 60);
            startButton.TabIndex = 7;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(147, 160);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 9;
            label2.Text = "Choose Your Mode:";
            // 
            // bestOfFiveButton
            // 
            bestOfFiveButton.Font = new Font("Segoe UI", 12F);
            bestOfFiveButton.Location = new Point(403, 184);
            bestOfFiveButton.Name = "bestOfFiveButton";
            bestOfFiveButton.Size = new Size(110, 30);
            bestOfFiveButton.TabIndex = 11;
            bestOfFiveButton.Text = "Best of 5";
            bestOfFiveButton.UseVisualStyleBackColor = true;
            bestOfFiveButton.Click += bestOfFiveButton_Click;
            // 
            // bestOfThreeButton
            // 
            bestOfThreeButton.Font = new Font("Segoe UI", 12F);
            bestOfThreeButton.Location = new Point(276, 184);
            bestOfThreeButton.Name = "bestOfThreeButton";
            bestOfThreeButton.Size = new Size(110, 30);
            bestOfThreeButton.TabIndex = 10;
            bestOfThreeButton.Text = "Best Of 3";
            bestOfThreeButton.UseVisualStyleBackColor = true;
            bestOfThreeButton.Click += bestOfThreeButton_Click;
            // 
            // bestOfOneButton
            // 
            bestOfOneButton.Enabled = false;
            bestOfOneButton.Font = new Font("Segoe UI", 12F);
            bestOfOneButton.Location = new Point(147, 184);
            bestOfOneButton.Name = "bestOfOneButton";
            bestOfOneButton.Size = new Size(110, 30);
            bestOfOneButton.TabIndex = 8;
            bestOfOneButton.Text = "Best Of 1";
            bestOfOneButton.UseVisualStyleBackColor = true;
            bestOfOneButton.Click += bestOfOneButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(147, 59);
            label1.Name = "label1";
            label1.Size = new Size(366, 54);
            label1.TabIndex = 6;
            label1.Text = "Rock Paper Scissors";
            // 
            // GameSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(startButton);
            Controls.Add(label2);
            Controls.Add(bestOfFiveButton);
            Controls.Add(bestOfThreeButton);
            Controls.Add(bestOfOneButton);
            Controls.Add(label1);
            Name = "GameSetup";
            Size = new Size(660, 410);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label2;
        private Button bestOfFiveButton;
        private Button bestOfThreeButton;
        private Button bestOfOneButton;
        private Label label1;
    }
}
