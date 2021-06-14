using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Project Designer: Edward Lale
 * Written for: CST_117
 * Instructor: Professor Pritchard
 * 
 * Intent:
 * This Project is a Tic Tac Toe game that allows the user to play the computer. The User can select their mores and the AI simulated
 * player uses the Random class to generate their move based on random selection of positions in a two-dimentional array. 
 */
namespace PP4_TicTacToe
{
    
    public partial class Form1 : Form
    {
        static  int ROWS = 3; //rows of game board
        static  int COLUMNS = 3; // columns of game board

        static int[,] gameBoard = new int[ROWS, COLUMNS]; //two dimentional array that represents the game board
        public Form1()
        {
            InitializeComponent();
              

        }

        // New game button click event which resets the board for another game.
        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            ResetBoard(gameBoard); // At the begining of each game, the reset board occurs  by resetBoard method call.
        }

        //This button click event closes the application

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();

        }

        //The following label control click events will mark the label with the users mark of 'O'. Then the gameBoard[,] will
        //update giving the value of 1 for the user. htne the CheckForUserWinner() method will see if the board reflects a winer.
        //If it does not, the method will return a boolean false which will be used to process code for the AI players turn and
        //their respective winning check.
        private void lb_Spot1_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot1.Text = "O";
            
            lb_Spot1.ForeColor = Color.Red;
            gameBoard[0, 0] = 1;
            userWin = CheckForUserWinner(gameBoard);
            
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }
           
        }

       
        //See Above Comment
        private void lb_Spot2_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot2.Text = "O";
            lb_Spot2.ForeColor = Color.Red;
            gameBoard[0, 1] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }


        }

        //See Above Comment
        private void lb_Spot3_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot3.Text = "O";
            lb_Spot3.ForeColor = Color.Red;
            gameBoard[0, 2] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }


        }

        //See Above Comment
        private void lb_Spot4_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot4.Text = "O";
            lb_Spot4.ForeColor = Color.Red;
            gameBoard[1, 0] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }

        }

        //See Above Comment
        private void lb_Spot5_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot5.Text = "O";
            lb_Spot5.ForeColor = Color.Red;
            gameBoard[1, 1] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }

        }

        //See Above Comment
        private void lb_Spot6_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot6.Text = "O";
            lb_Spot6.ForeColor = Color.Red;
            gameBoard[1, 2] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }

        }

        //See Above Comment
        private void lb_Spot7_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot7.Text = "O";
            lb_Spot7.ForeColor = Color.Red;
            gameBoard[2, 0] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }

        }

        //See Above Comment
        private void lb_Spot8_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot8.Text = "O";
            lb_Spot8.ForeColor = Color.Red;
            gameBoard[2, 1] = 1;
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }

        }

        //See Above Comment
        private void lb_Spot9_Click(object sender, EventArgs e)
        {
            bool userWin = false;
            lb_Spot9.Text = "O";
            lb_Spot9.ForeColor = Color.Red;
            gameBoard[2, 2] = 1;
            
            userWin = CheckForUserWinner(gameBoard);
            if (userWin == false)
            {
                AIPlay(gameBoard);
                CheckForAIWinner(gameBoard);
            }

        }

        //This method checks every possibility of winning combinations to see if the user wins.
        private bool CheckForUserWinner(int[,] gameBoard)
        {
            bool userWin = false;
            if (gameBoard[0, 0] == 1)
            {
                if (gameBoard[0, 1] == 1)
                {
                    if (gameBoard[0, 2] == 1)
                    {
                        lb_Spot1.BackColor = Color.Yellow;
                        lb_Spot2.BackColor = Color.Yellow;
                        lb_Spot3.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }
                else if (gameBoard[1, 0] == 1)
                {
                    if (gameBoard[2, 0] == 1)
                    {
                        lb_Spot1.BackColor = Color.Yellow;
                        lb_Spot4.BackColor = Color.Yellow;
                        lb_Spot7.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }
                else if (gameBoard[1, 1] == 1)
                {
                    if (gameBoard[2, 2] == 1)
                    {
                        lb_Spot1.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot9.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }
            }
            if (gameBoard[0, 1] == 1)
            {
                if (gameBoard[1, 1] == 1)
                {
                    if (gameBoard[2, 1] == 1)
                    {
                        lb_Spot2.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot8.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                        
                    }
                }
            }
            if (gameBoard[0, 2] == 1)
            {
                if (gameBoard[1, 2] == 1)
                {
                    if (gameBoard[2, 2] == 1)
                    {
                        lb_Spot3.BackColor = Color.Yellow;
                        lb_Spot6.BackColor = Color.Yellow;
                        lb_Spot9.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }
                else if (gameBoard[1, 1] == 1)
                {
                    if (gameBoard[2, 0] == 1)
                    {
                        lb_Spot3.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot7.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }

            }
            if (gameBoard[1, 0] == 1)
            {
                if (gameBoard[1, 1] == 1)
                {
                    if (gameBoard[1, 2] == 1)
                    {
                        lb_Spot4.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot6.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }

            }
            if (gameBoard[2, 0] == 1)
            {
                if (gameBoard[2, 1] == 1)
                {
                    if (gameBoard[2, 2] == 1)
                    {
                        lb_Spot7.BackColor = Color.Yellow;
                        lb_Spot8.BackColor = Color.Yellow;
                        lb_Spot9.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player X Winns!!!!";
                        userWin = true;
                    }
                }

            }
            return userWin;
        }

        //This is the AIPlay() method which creates two Random numbers representing the row and colomn of the gameBoard[,].
        //A do/while block will check to make sure that the spot is not alreaty taken, and if it is, randomly generate two
        //new integers between 0 and including 2 representing the gameBoard's rows and columns. This process will continue
        //until an empty spot is found and the AI will select that spot by calling the MarkAIPlay() method. 
        private void AIPlay(int[,] gameBoard)
        {
            Random randRow = new Random();
            Random randCol = new Random();

            
            bool played = false;
            
            do
            {
                int aIRow = randRow.Next(0, 3);
                int aICol = randCol.Next(0, 3);

                if (gameBoard[aIRow, aICol] == 0)
                {
                    gameBoard[aIRow, aICol] = 2;
                    MarkAIPlay(aIRow, aICol);
                    played = true;
                }
                
            } while (!played);
        }

        //The MarkAIPlay() method takes in the row and column of the chosen spot and marks the appropriate label with the AI's 
        //Mark of 'X'
        private void MarkAIPlay(int aIRow, int aICol)
        {
            if (aIRow.Equals(0) && aICol.Equals(0))
            {
                lb_Spot1.Text = "X";
                lb_Spot1.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(0) && aICol.Equals(1))
            {
                lb_Spot2.Text = "X";
                lb_Spot2.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(0) && aICol.Equals(2))
            {
                lb_Spot3.Text = "X";
                lb_Spot3.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(1) && aICol.Equals(0))
            {
                lb_Spot4.Text = "X";
                lb_Spot4.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(1) && aICol.Equals(1))
            {
                lb_Spot5.Text = "X";
                lb_Spot5.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(1) && aICol.Equals(2))
            {
                lb_Spot6.Text = "X";
                lb_Spot6.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(2) && aICol.Equals(0))
            {
                lb_Spot7.Text = "X";
                lb_Spot7.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(2) && aICol.Equals(1))
            {
                lb_Spot8.Text = "X";
                lb_Spot8.ForeColor = Color.Blue;

            }
            else if (aIRow.Equals(2) && aICol.Equals(2))
            {
                lb_Spot9.Text = "X";
                lb_Spot9.ForeColor = Color.Blue;

            }
        }


        //This method checks to see if the AI has won the game. It is called after every play of the AI. It is the same logic as
        //The User Check Winner method
        private void CheckForAIWinner(int[,] gameBoard)
        {
            if (gameBoard[0, 0] == 2)
            {
                if (gameBoard[0, 1] == 2)
                {
                    if (gameBoard[0, 2] == 2)
                    {
                        lb_Spot1.BackColor = Color.Yellow;
                        lb_Spot2.BackColor = Color.Yellow;
                        lb_Spot3.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }
                else if (gameBoard[1, 0] == 2)
                {
                    if (gameBoard[2, 0] == 2)
                    {
                        lb_Spot1.BackColor = Color.Yellow;
                        lb_Spot4.BackColor = Color.Yellow;
                        lb_Spot7.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }
                else if (gameBoard[1, 1] == 2)
                {
                    if (gameBoard[2, 2] == 2)
                    {
                        lb_Spot1.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot9.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }
            }
            if (gameBoard[0, 1] == 2)
            {
                if (gameBoard[1, 1] == 2)
                {
                    if (gameBoard[2, 1] == 2)
                    {
                        lb_Spot2.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot8.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }
            }
            if (gameBoard[0, 2] == 2)
            {
                if (gameBoard[1, 2] == 2)
                {
                    if (gameBoard[2, 2] == 2)
                    {
                        lb_Spot3.BackColor = Color.Yellow;
                        lb_Spot6.BackColor = Color.Yellow;
                        lb_Spot9.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }
                else if (gameBoard[1, 1] == 2)
                {
                    if (gameBoard[2, 0] == 2)
                    {
                        lb_Spot3.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot7.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }

            }
            if (gameBoard[1, 0] == 2)
            {
                if (gameBoard[1, 1] == 2)
                {
                    if (gameBoard[1, 2] == 2)
                    {
                        lb_Spot4.BackColor = Color.Yellow;
                        lb_Spot5.BackColor = Color.Yellow;
                        lb_Spot6.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }

            }
            if (gameBoard[2, 0] == 2)
            {
                if (gameBoard[2, 1] == 2)
                {
                    if (gameBoard[2, 2] == 2)
                    {
                        lb_Spot7.BackColor = Color.Yellow;
                        lb_Spot8.BackColor = Color.Yellow;
                        lb_Spot9.BackColor = Color.Yellow;

                        tb_Winner.Text = "Player Y Winns!!!!";
                        
                    }
                }

            }
        }

        //This method resets the board for a new game
        private void ResetBoard(int[,] gameBoard)
        {
            lb_Spot1.Text = "_";
            lb_Spot1.BackColor = Color.White;
            lb_Spot1.ForeColor = Color.Black;
            lb_Spot2.Text = "_";
            lb_Spot2.BackColor = Color.White;
            lb_Spot2.ForeColor = Color.Black;
            lb_Spot3.Text = "_";
            lb_Spot3.BackColor = Color.White;
            lb_Spot3.ForeColor = Color.Black;
            lb_Spot4.Text = "_";
            lb_Spot4.BackColor = Color.White;
            lb_Spot4.ForeColor = Color.Black;
            lb_Spot5.Text = "_";
            lb_Spot5.BackColor = Color.White;
            lb_Spot5.ForeColor = Color.Black;
            lb_Spot6.Text = "_";
            lb_Spot6.BackColor = Color.White;
            lb_Spot6.ForeColor = Color.Black;
            lb_Spot7.Text = "_";
            lb_Spot7.BackColor = Color.White;
            lb_Spot7.ForeColor = Color.Black;
            lb_Spot8.Text = "_";
            lb_Spot8.BackColor = Color.White;
            lb_Spot8.ForeColor = Color.Black;
            lb_Spot9.Text = "_";
            lb_Spot9.BackColor = Color.White;
            lb_Spot9.ForeColor = Color.Black;


            //for loop cycles through the gameBoard and sets all values to 0
            for (int resetCol = 0; resetCol < COLUMNS; resetCol++)
            {
                for (int resetRow = 0; resetRow < ROWS; resetRow++)
                {
                    gameBoard[resetCol, resetRow] = 0;

                }
            }

            tb_Winner.Clear();
        }
    }
}
