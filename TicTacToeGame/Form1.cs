using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class mainForm : Form
    {
        enum PlayerTurn { None, Player1,Player2 };
        PlayerTurn turn;
        int Score1 = 0,Score2=0;
        Winner winner;
        enum Winner { None,Player1,Player2,Draw}
        void OnNewGame()
        {
     
        //Set the turn
            turn = PlayerTurn.Player1;

            winner = Winner.None;
        }
        void ClearScore()
        {
            //Reset the score
            Score1 = 0;
            Score2 = 0;
            lblScore.Text = String.Format("{0}:{1}", Score1, Score2);
        }
        void ClearBoard()
        {
            //Clear the game board
            PictureBox[] allPictures = {pbChoice0,
                                        pbChoice1,
                                        pbChoice2,
                                        pbChoice3,
                                        pbChoice4,
                                        pbChoice5,
                                        pbChoice6,
                                        pbChoice7,
                                        pbChoice8,};

            foreach (var p in allPictures)
            {
                p.Image = null;
            }

        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            OnNewGame();
        }
        // Setting the Click event
        private void OnClick(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p.Image!=null)
            {
                return;
            }
            if (turn==PlayerTurn.Player1)
            {
                p.Image = pbPlayer1.Image;
            }
            else
            {
                p.Image = pbPlayer2.Image;
            }
            // Defining the winner
            winner = GetWinner();
            if (winner == Winner.None)
            {
                turn = (PlayerTurn.Player1 == turn) ? PlayerTurn.Player2 : PlayerTurn.Player1;
            }
            switch(winner)
            {
                case Winner.None:
                    break;
                case Winner.Player1:
                    Score1 += 1;
                    lblScore.Text = String.Format("{0}:{1}", Score1, Score2);
                    OnNewGame();
                    break;
                case Winner.Player2:
                    Score2 += 1;
                    lblScore.Text = String.Format("{0}:{1}", Score1, Score2);
                    OnNewGame();
                    break;
                case Winner.Draw:
                    MessageBox.Show("The game is draw - no winner", "The winner", MessageBoxButtons.OK);
                    OnNewGame();
                    ClearBoard();
                    break;
            }

        }

        // Definig the winnig combination
        Winner GetWinner()
        {
            PictureBox[] allWinning = {pbChoice0, pbChoice1, pbChoice2,
                                        
                                       pbChoice3, pbChoice4, pbChoice5,

                                       pbChoice6, pbChoice7, pbChoice8,

                                       pbChoice0, pbChoice3,  pbChoice6,

                                       pbChoice1, pbChoice4, pbChoice7,

                                       pbChoice2, pbChoice5, pbChoice8,

                                       pbChoice0, pbChoice4, pbChoice8,

                                       pbChoice2, pbChoice4, pbChoice6,
                                        };
       
            for (int i = 0; i < allWinning.Length; i+=3)
            {
                if (allWinning[i].Image!=null)
                {
                    if ((allWinning[i].Image==allWinning[i+1].Image)&&(allWinning[i].Image == allWinning[i + 2].Image))
                    {
                        if (allWinning[i].Image==pbPlayer1.Image)
                        {
                            ClearBoard();
                            return Winner.Player1;
                            
                        }
                        else
                        {
                            ClearBoard();
                            return Winner.Player2;
                            
                        }
                    }
                }
            }

            PictureBox[] allCheck = {   pbChoice0,
                                        pbChoice1,
                                        pbChoice2,
                                        pbChoice3,
                                        pbChoice4,
                                        pbChoice5,
                                        pbChoice6,
                                        pbChoice7,
                                        pbChoice8,};

            foreach (var p in allCheck)
            {
                if (p.Image == null)
                {
                    return Winner.None;
                }
                
            }
            return Winner.Draw;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                OnNewGame();
                ClearScore();
                ClearBoard();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            {
                OnNewGame();
                ClearBoard();
            }
          
        }
    }
}
