namespace Connect4
{
    partial class MainForm
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
            this.lblConnect4 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.cbPlayer1 = new System.Windows.Forms.ComboBox();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbPlayer2 = new System.Windows.Forms.ComboBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.gbGame.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnect4
            // 
            this.lblConnect4.AutoSize = true;
            this.lblConnect4.Font = new System.Drawing.Font("Sylfaen", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnect4.Location = new System.Drawing.Point(278, 48);
            this.lblConnect4.Name = "lblConnect4";
            this.lblConnect4.Size = new System.Drawing.Size(271, 78);
            this.lblConnect4.TabIndex = 0;
            this.lblConnect4.Text = "connect4";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(84, 45);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(112, 36);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1";
            // 
            // cbPlayer1
            // 
            this.cbPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbPlayer1.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayer1.FormattingEnabled = true;
            this.cbPlayer1.Location = new System.Drawing.Point(47, 106);
            this.cbPlayer1.Name = "cbPlayer1";
            this.cbPlayer1.Size = new System.Drawing.Size(190, 37);
            this.cbPlayer1.TabIndex = 3;
            // 
            // tbPlayer
            // 
            this.tbPlayer.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer.Location = new System.Drawing.Point(272, 52);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(187, 38);
            this.tbPlayer.TabIndex = 8;
            this.tbPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPlayer_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(290, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 49);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbPlayer2
            // 
            this.cbPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbPlayer2.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayer2.FormattingEnabled = true;
            this.cbPlayer2.Location = new System.Drawing.Point(479, 106);
            this.cbPlayer2.Name = "cbPlayer2";
            this.cbPlayer2.Size = new System.Drawing.Size(190, 37);
            this.cbPlayer2.TabIndex = 5;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(518, 45);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(112, 36);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Player 2";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(290, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 49);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.cbPlayer1);
            this.gbGame.Controls.Add(this.btnStart);
            this.gbGame.Controls.Add(this.lblPlayer1);
            this.gbGame.Controls.Add(this.cbPlayer2);
            this.gbGame.Controls.Add(this.lblPlayer2);
            this.gbGame.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGame.Location = new System.Drawing.Point(17, 144);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(711, 186);
            this.gbGame.TabIndex = 1;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.tbPlayer);
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdd.Location = new System.Drawing.Point(17, 349);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(711, 186);
            this.gbAdd.TabIndex = 7;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Player";
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.btnView);
            this.gbScore.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScore.Location = new System.Drawing.Point(17, 556);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(711, 137);
            this.gbScore.TabIndex = 10;
            this.gbScore.TabStop = false;
            this.gbScore.Text = "Scores";
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(290, 53);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(149, 49);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 713);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.lblConnect4);
            this.Name = "MainForm";
            this.Text = "Connect4";
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnect4;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.ComboBox cbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.Button btnView;
    }
}

