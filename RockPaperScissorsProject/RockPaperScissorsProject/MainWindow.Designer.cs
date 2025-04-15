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
            label1 = new Label();
            bestOfOneButton = new Button();
            bestOfThreeButton = new Button();
            bestOfFiveButton = new Button();
            label2 = new Label();
            startButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 54);
            label1.TabIndex = 0;
            label1.Text = "Rock Paper Scissors";
            // 
            // bestOfOneButton
            // 
            bestOfOneButton.Enabled = false;
            bestOfOneButton.Font = new Font("Segoe UI", 12F);
            bestOfOneButton.Location = new Point(210, 134);
            bestOfOneButton.Name = "bestOfOneButton";
            bestOfOneButton.Size = new Size(110, 30);
            bestOfOneButton.TabIndex = 3;
            bestOfOneButton.Text = "Best Of 1";
            bestOfOneButton.UseVisualStyleBackColor = true;
            bestOfOneButton.Click += bestOfOneButton_Click;
            // 
            // bestOfThreeButton
            // 
            bestOfThreeButton.Font = new Font("Segoe UI", 12F);
            bestOfThreeButton.Location = new Point(339, 134);
            bestOfThreeButton.Name = "bestOfThreeButton";
            bestOfThreeButton.Size = new Size(110, 30);
            bestOfThreeButton.TabIndex = 4;
            bestOfThreeButton.Text = "Best Of 3";
            bestOfThreeButton.UseVisualStyleBackColor = true;
            bestOfThreeButton.Click += bestOfThreeButton_Click;
            // 
            // bestOfFiveButton
            // 
            bestOfFiveButton.Font = new Font("Segoe UI", 12F);
            bestOfFiveButton.Location = new Point(466, 134);
            bestOfFiveButton.Name = "bestOfFiveButton";
            bestOfFiveButton.Size = new Size(110, 30);
            bestOfFiveButton.TabIndex = 5;
            bestOfFiveButton.Text = "Best of 5";
            bestOfFiveButton.UseVisualStyleBackColor = true;
            bestOfFiveButton.Click += bestOfFiveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(210, 110);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 4;
            label2.Text = "Choose Your Mode:";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 24F);
            startButton.Location = new Point(284, 241);
            startButton.Name = "startButton";
            startButton.Size = new Size(220, 60);
            startButton.TabIndex = 1;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startButton);
            Controls.Add(label2);
            Controls.Add(bestOfFiveButton);
            Controls.Add(bestOfThreeButton);
            Controls.Add(bestOfOneButton);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "Rock Paper Scissors";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bestOfOneButton;
        private Button bestOfThreeButton;
        private Button bestOfFiveButton;
        private Label label2;
        private Button startButton;
    }
}
