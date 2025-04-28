namespace RockPaperScissorsProject
{
    partial class GameControl
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
            rockButton = new Button();
            paperButton = new Button();
            Scissors = new Button();
            label1 = new Label();
            label2 = new Label();
            oppChoiceText = new Label();
            winStatusLabel = new Label();
            SuspendLayout();
            // 
            // rockButton
            // 
            rockButton.Font = new Font("Segoe UI", 15F);
            rockButton.Location = new Point(50, 309);
            rockButton.Name = "rockButton";
            rockButton.Size = new Size(150, 60);
            rockButton.TabIndex = 9;
            rockButton.Text = "Rock";
            rockButton.UseVisualStyleBackColor = true;
            rockButton.Click += rockButton_Click;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("Segoe UI", 15F);
            paperButton.Location = new Point(253, 309);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(150, 60);
            paperButton.TabIndex = 10;
            paperButton.Text = "Paper";
            paperButton.UseVisualStyleBackColor = true;
            paperButton.Click += paperButton_Click;
            // 
            // Scissors
            // 
            Scissors.Font = new Font("Segoe UI", 15F);
            Scissors.Location = new Point(455, 309);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(150, 60);
            Scissors.TabIndex = 11;
            Scissors.Text = "Scissors";
            Scissors.UseVisualStyleBackColor = true;
            Scissors.Click += Scissors_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(50, 269);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 12;
            label1.Text = "Make Your Choice:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(50, 24);
            label2.Name = "label2";
            label2.Size = new Size(249, 37);
            label2.TabIndex = 13;
            label2.Text = "Opponent's Choice:";
            // 
            // oppChoiceText
            // 
            oppChoiceText.AutoSize = true;
            oppChoiceText.Font = new Font("Segoe UI", 15F);
            oppChoiceText.Location = new Point(253, 94);
            oppChoiceText.Name = "oppChoiceText";
            oppChoiceText.Size = new Size(152, 28);
            oppChoiceText.TabIndex = 14;
            oppChoiceText.Text = "Waiting for play";
            oppChoiceText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winStatusLabel
            // 
            winStatusLabel.AutoSize = true;
            winStatusLabel.Font = new Font("Segoe UI", 15F);
            winStatusLabel.ForeColor = Color.Green;
            winStatusLabel.Location = new Point(236, 193);
            winStatusLabel.Name = "winStatusLabel";
            winStatusLabel.Size = new Size(191, 28);
            winStatusLabel.TabIndex = 15;
            winStatusLabel.Text = "You Won This Round";
            winStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            winStatusLabel.Visible = false;
            // 
            // GameControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(winStatusLabel);
            Controls.Add(oppChoiceText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Scissors);
            Controls.Add(paperButton);
            Controls.Add(rockButton);
            Name = "GameControl";
            Size = new Size(660, 410);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button rockButton;
        private Button paperButton;
        private Button Scissors;
        private Label label1;
        private Label label2;
        private Label oppChoiceText;
        private Label winStatusLabel;
    }
}
