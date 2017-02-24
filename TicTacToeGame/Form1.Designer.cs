namespace TicTacToeGame
{
    partial class mainForm
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.gbGameField = new System.Windows.Forms.GroupBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbChoice8 = new System.Windows.Forms.PictureBox();
            this.pbChoice7 = new System.Windows.Forms.PictureBox();
            this.pbChoice6 = new System.Windows.Forms.PictureBox();
            this.pbChoice5 = new System.Windows.Forms.PictureBox();
            this.pbChoice4 = new System.Windows.Forms.PictureBox();
            this.pbChoice3 = new System.Windows.Forms.PictureBox();
            this.pbChoice2 = new System.Windows.Forms.PictureBox();
            this.pbChoice1 = new System.Windows.Forms.PictureBox();
            this.pbChoice0 = new System.Windows.Forms.PictureBox();
            this.gbGameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice0)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(207, 494);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(140, 54);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // gbGameField
            // 
            this.gbGameField.Controls.Add(this.pbChoice8);
            this.gbGameField.Controls.Add(this.pbChoice7);
            this.gbGameField.Controls.Add(this.pbChoice6);
            this.gbGameField.Controls.Add(this.pbChoice5);
            this.gbGameField.Controls.Add(this.pbChoice4);
            this.gbGameField.Controls.Add(this.pbChoice3);
            this.gbGameField.Controls.Add(this.pbChoice2);
            this.gbGameField.Controls.Add(this.pbChoice1);
            this.gbGameField.Controls.Add(this.pbChoice0);
            this.gbGameField.Location = new System.Drawing.Point(207, 141);
            this.gbGameField.Name = "gbGameField";
            this.gbGameField.Size = new System.Drawing.Size(314, 330);
            this.gbGameField.TabIndex = 1;
            this.gbGameField.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(51, 160);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(128, 112);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(552, 160);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(128, 112);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(248, 9);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(230, 76);
            this.lblScoreTitle.TabIndex = 6;
            this.lblScoreTitle.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(327, 90);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(74, 44);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0:0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(381, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 54);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.ErrorImage = global::TicTacToeGame.Properties.Resources.circleRed;
            this.pbPlayer2.Image = global::TicTacToeGame.Properties.Resources.circleRegular;
            this.pbPlayer2.Location = new System.Drawing.Point(554, 197);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(100, 93);
            this.pbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer2.TabIndex = 5;
            this.pbPlayer2.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.ErrorImage = global::TicTacToeGame.Properties.Resources.crossRed;
            this.pbPlayer1.Image = global::TicTacToeGame.Properties.Resources.crossRegular;
            this.pbPlayer1.Location = new System.Drawing.Point(53, 197);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(100, 93);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer1.TabIndex = 4;
            this.pbPlayer1.TabStop = false;
            // 
            // pbChoice8
            // 
            this.pbChoice8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice8.Location = new System.Drawing.Point(208, 221);
            this.pbChoice8.Name = "pbChoice8";
            this.pbChoice8.Size = new System.Drawing.Size(95, 95);
            this.pbChoice8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice8.TabIndex = 8;
            this.pbChoice8.TabStop = false;
            this.pbChoice8.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice7
            // 
            this.pbChoice7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice7.Location = new System.Drawing.Point(107, 221);
            this.pbChoice7.Name = "pbChoice7";
            this.pbChoice7.Size = new System.Drawing.Size(95, 95);
            this.pbChoice7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice7.TabIndex = 7;
            this.pbChoice7.TabStop = false;
            this.pbChoice7.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice6
            // 
            this.pbChoice6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice6.Location = new System.Drawing.Point(6, 221);
            this.pbChoice6.Name = "pbChoice6";
            this.pbChoice6.Size = new System.Drawing.Size(95, 95);
            this.pbChoice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice6.TabIndex = 6;
            this.pbChoice6.TabStop = false;
            this.pbChoice6.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice5
            // 
            this.pbChoice5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice5.Location = new System.Drawing.Point(208, 120);
            this.pbChoice5.Name = "pbChoice5";
            this.pbChoice5.Size = new System.Drawing.Size(95, 95);
            this.pbChoice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice5.TabIndex = 5;
            this.pbChoice5.TabStop = false;
            this.pbChoice5.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice4
            // 
            this.pbChoice4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice4.Location = new System.Drawing.Point(107, 120);
            this.pbChoice4.Name = "pbChoice4";
            this.pbChoice4.Size = new System.Drawing.Size(95, 95);
            this.pbChoice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice4.TabIndex = 4;
            this.pbChoice4.TabStop = false;
            this.pbChoice4.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice3
            // 
            this.pbChoice3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice3.Location = new System.Drawing.Point(6, 120);
            this.pbChoice3.Name = "pbChoice3";
            this.pbChoice3.Size = new System.Drawing.Size(95, 95);
            this.pbChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice3.TabIndex = 3;
            this.pbChoice3.TabStop = false;
            this.pbChoice3.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice2
            // 
            this.pbChoice2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice2.Location = new System.Drawing.Point(208, 19);
            this.pbChoice2.Name = "pbChoice2";
            this.pbChoice2.Size = new System.Drawing.Size(95, 95);
            this.pbChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice2.TabIndex = 2;
            this.pbChoice2.TabStop = false;
            this.pbChoice2.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice1
            // 
            this.pbChoice1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice1.Location = new System.Drawing.Point(107, 19);
            this.pbChoice1.Name = "pbChoice1";
            this.pbChoice1.Size = new System.Drawing.Size(95, 95);
            this.pbChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice1.TabIndex = 1;
            this.pbChoice1.TabStop = false;
            this.pbChoice1.Click += new System.EventHandler(this.OnClick);
            // 
            // pbChoice0
            // 
            this.pbChoice0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbChoice0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChoice0.Location = new System.Drawing.Point(6, 19);
            this.pbChoice0.Name = "pbChoice0";
            this.pbChoice0.Size = new System.Drawing.Size(95, 95);
            this.pbChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoice0.TabIndex = 0;
            this.pbChoice0.TabStop = false;
            this.pbChoice0.Click += new System.EventHandler(this.OnClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 560);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.gbGameField);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gbGameField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoice0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.GroupBox gbGameField;
        private System.Windows.Forms.PictureBox pbChoice8;
        private System.Windows.Forms.PictureBox pbChoice7;
        private System.Windows.Forms.PictureBox pbChoice6;
        private System.Windows.Forms.PictureBox pbChoice5;
        private System.Windows.Forms.PictureBox pbChoice4;
        private System.Windows.Forms.PictureBox pbChoice3;
        private System.Windows.Forms.PictureBox pbChoice2;
        private System.Windows.Forms.PictureBox pbChoice1;
        private System.Windows.Forms.PictureBox pbChoice0;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
    }
}

