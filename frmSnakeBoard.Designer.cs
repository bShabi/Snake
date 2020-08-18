namespace SnakeGame
{
    partial class frmSnakeBoard
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
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.pnlManager = new System.Windows.Forms.Panel();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblTimerValue = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblBestScoreValue = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.pnlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBoard.BackColor = System.Drawing.Color.Khaki;
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBoard.Cursor = System.Windows.Forms.Cursors.No;
            this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(1022, 753);
            this.pnlBoard.TabIndex = 0;
            // 
            // pnlManager
            // 
            this.pnlManager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlManager.Controls.Add(this.cbLevel);
            this.pnlManager.Controls.Add(this.lblLevel);
            this.pnlManager.Controls.Add(this.lblBestScoreValue);
            this.pnlManager.Controls.Add(this.lblBestScore);
            this.pnlManager.Controls.Add(this.lblNameValue);
            this.pnlManager.Controls.Add(this.lblPlayerName);
            this.pnlManager.Controls.Add(this.btnNewGame);
            this.pnlManager.Controls.Add(this.lblTimerValue);
            this.pnlManager.Controls.Add(this.lblTimer);
            this.pnlManager.Controls.Add(this.lblScoreValue);
            this.pnlManager.Controls.Add(this.lblScore);
            this.pnlManager.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlManager.Location = new System.Drawing.Point(1028, 0);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(211, 753);
            this.pnlManager.TabIndex = 1;
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.Location = new System.Drawing.Point(117, 126);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 43);
            this.lblNameValue.TabIndex = 6;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlayerName.Location = new System.Drawing.Point(-8, 126);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(102, 43);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNewGame.Location = new System.Drawing.Point(17, 518);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(164, 64);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.lblTimerValue.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerValue.Location = new System.Drawing.Point(71, 44);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(0, 47);
            this.lblTimerValue.TabIndex = 3;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Maroon;
            this.lblTimer.Location = new System.Drawing.Point(-8, 48);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 43);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Time:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(119, 228);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(0, 46);
            this.lblScoreValue.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblScore.Location = new System.Drawing.Point(-9, 210);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 50);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblBestScore.Location = new System.Drawing.Point(18, 334);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(163, 47);
            this.lblBestScore.TabIndex = 7;
            this.lblBestScore.Text = "Best Score";
            // 
            // lblBestScoreValue
            // 
            this.lblBestScoreValue.AutoSize = true;
            this.lblBestScoreValue.Location = new System.Drawing.Point(47, 410);
            this.lblBestScoreValue.Name = "lblBestScoreValue";
            this.lblBestScoreValue.Size = new System.Drawing.Size(0, 13);
            this.lblBestScoreValue.TabIndex = 8;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Maroon;
            this.lblLevel.Location = new System.Drawing.Point(20, 606);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(157, 43);
            this.lblLevel.TabIndex = 9;
            this.lblLevel.Text = "Level Game";
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(26, 663);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(121, 21);
            this.cbLevel.TabIndex = 10;
            // 
            // frmSnakeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 753);
            this.Controls.Add(this.pnlManager);
            this.Controls.Add(this.pnlBoard);
            this.KeyPreview = true;
            this.Name = "frmSnakeBoard";
            this.Text = "frmSnakeBoard";
            this.pnlManager.ResumeLayout(false);
            this.pnlManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Panel pnlManager;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblTimerValue;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblBestScoreValue;
        private System.Windows.Forms.Label lblBestScore;
    }
}