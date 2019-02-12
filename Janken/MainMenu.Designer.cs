namespace Janken
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player2HighScoreLabel = new System.Windows.Forms.Label();
            this.player1HighScoreLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.player2PictureBox = new System.Windows.Forms.PictureBox();
            this.player1PictureBox = new System.Windows.Forms.PictureBox();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.score1Label = new System.Windows.Forms.Label();
            this.score2Label = new System.Windows.Forms.Label();
            this.highScore1Label = new System.Windows.Forms.Label();
            this.highScore2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player2HighScoreLabel
            // 
            this.player2HighScoreLabel.AutoSize = true;
            this.player2HighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2HighScoreLabel.Location = new System.Drawing.Point(243, 427);
            this.player2HighScoreLabel.Name = "player2HighScoreLabel";
            this.player2HighScoreLabel.Size = new System.Drawing.Size(162, 20);
            this.player2HighScoreLabel.TabIndex = 15;
            this.player2HighScoreLabel.Text = "Igralec 2 HighScore:";
            // 
            // player1HighScoreLabel
            // 
            this.player1HighScoreLabel.AutoSize = true;
            this.player1HighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1HighScoreLabel.Location = new System.Drawing.Point(12, 427);
            this.player1HighScoreLabel.Name = "player1HighScoreLabel";
            this.player1HighScoreLabel.Size = new System.Drawing.Size(162, 20);
            this.player1HighScoreLabel.TabIndex = 14;
            this.player1HighScoreLabel.Text = "Igralec 1 HighScore:";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetButton.Location = new System.Drawing.Point(256, 377);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 33);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playButton.Location = new System.Drawing.Point(128, 377);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 33);
            this.playButton.TabIndex = 12;
            this.playButton.Text = "Igraj";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // player2PictureBox
            // 
            this.player2PictureBox.Location = new System.Drawing.Point(256, 72);
            this.player2PictureBox.Name = "player2PictureBox";
            this.player2PictureBox.Size = new System.Drawing.Size(168, 279);
            this.player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2PictureBox.TabIndex = 11;
            this.player2PictureBox.TabStop = false;
            // 
            // player1PictureBox
            // 
            this.player1PictureBox.Location = new System.Drawing.Point(39, 72);
            this.player1PictureBox.Name = "player1PictureBox";
            this.player1PictureBox.Size = new System.Drawing.Size(164, 279);
            this.player1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1PictureBox.TabIndex = 10;
            this.player1PictureBox.TabStop = false;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2Label.Location = new System.Drawing.Point(252, 28);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(86, 24);
            this.player2Label.TabIndex = 9;
            this.player2Label.Text = "Igralec 2:";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1Label.Location = new System.Drawing.Point(35, 28);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(86, 24);
            this.player1Label.TabIndex = 8;
            this.player1Label.Text = "Igralec 1:";
            // 
            // score1Label
            // 
            this.score1Label.AutoSize = true;
            this.score1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score1Label.Location = new System.Drawing.Point(154, 28);
            this.score1Label.Name = "score1Label";
            this.score1Label.Size = new System.Drawing.Size(20, 24);
            this.score1Label.TabIndex = 16;
            this.score1Label.Text = "0";
            // 
            // score2Label
            // 
            this.score2Label.AutoSize = true;
            this.score2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score2Label.Location = new System.Drawing.Point(361, 28);
            this.score2Label.Name = "score2Label";
            this.score2Label.Size = new System.Drawing.Size(20, 24);
            this.score2Label.TabIndex = 17;
            this.score2Label.Text = "0";
            // 
            // highScore1Label
            // 
            this.highScore1Label.AutoSize = true;
            this.highScore1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScore1Label.Location = new System.Drawing.Point(185, 427);
            this.highScore1Label.Name = "highScore1Label";
            this.highScore1Label.Size = new System.Drawing.Size(18, 20);
            this.highScore1Label.TabIndex = 18;
            this.highScore1Label.Text = "0";
            // 
            // highScore2Label
            // 
            this.highScore2Label.AutoSize = true;
            this.highScore2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScore2Label.Location = new System.Drawing.Point(420, 427);
            this.highScore2Label.Name = "highScore2Label";
            this.highScore2Label.Size = new System.Drawing.Size(18, 20);
            this.highScore2Label.TabIndex = 19;
            this.highScore2Label.Text = "0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 472);
            this.Controls.Add(this.highScore2Label);
            this.Controls.Add(this.highScore1Label);
            this.Controls.Add(this.score2Label);
            this.Controls.Add(this.score1Label);
            this.Controls.Add(this.player2HighScoreLabel);
            this.Controls.Add(this.player1HighScoreLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.player2PictureBox);
            this.Controls.Add(this.player1PictureBox);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player2HighScoreLabel;
        private System.Windows.Forms.Label player1HighScoreLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox player2PictureBox;
        private System.Windows.Forms.PictureBox player1PictureBox;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label score1Label;
        private System.Windows.Forms.Label score2Label;
        private System.Windows.Forms.Label highScore1Label;
        private System.Windows.Forms.Label highScore2Label;
    }
}

