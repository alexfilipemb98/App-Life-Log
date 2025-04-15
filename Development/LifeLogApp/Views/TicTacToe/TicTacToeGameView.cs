using DevExpress.XtraEditors;
using LifeLogApp.Helpers;
using LifeLogApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Life_Log.Views.Entertainment.TicTacToe
{
    /// <summary>
    /// Tic tac toe game
    /// </summary>
    public partial class TicTacToeGameView : XtraUserControl
    {
        #region MAIN

        //*// Variables /*/

        private Player[,] board = new Player[3, 3];
        private Player playerTurn = Player.PlayerN;
        private Player playerWin = Player.PlayerN;
        private Dictionary<Player, int> scores = new Dictionary<Player, int>
        {
            { Player.PlayerN, 0 },
            { Player.PlayerO, 0 },
            { Player.PlayerX, 0 }
        };

        private enum Player
        {
            PlayerN = 0,
            PlayerO = 1,
            PlayerX = 2
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="idPassword"></param>
        public TicTacToeGameView() => InitializeComponent();

        #endregion

        #region ITEM CLICK

        /// <summary>
        /// Reset the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiResetGame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearGameBoard();

            scores = new Dictionary<Player, int>
            {
                { Player.PlayerN, 0 },
                { Player.PlayerO, 0 },
                { Player.PlayerX, 0 }
            };
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Click event of pictures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pe_Click(object sender, EventArgs e) => SetGameBoard(sender as PictureEdit);

        #endregion

        #region RESIZE

        /// <summary>
        /// Game resize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TicTacToeGameView_Resize(object sender, EventArgs e)
        {
            //height for the controlls
            int h1 = layoutControl.Height;
            int newHeight = (h1 - 125) / 3;
            Size size = new Size(newHeight, newHeight);
            int wt = (esiTopLeft.Width + esiTopRight.Width) / 2;
            int widthFinal = (esiLeft.Width + esiRight.Width) / 2;

            //1
            lciPe1_1.MaxSize = size;
            lciPe1_1.MinSize = size;
            lciPe1_1.Size = size;

            lciPe1_2.MaxSize = size;
            lciPe1_2.MinSize = size;
            lciPe1_2.Size = size;

            lciPe1_3.MaxSize = size;
            lciPe1_3.MinSize = size;
            lciPe1_3.Size = size;

            //2
            lciPe2_1.MaxSize = size;
            lciPe2_1.MinSize = size;
            lciPe2_1.Size = size;

            lciPe2_2.MaxSize = size;
            lciPe2_2.MinSize = size;
            lciPe2_2.Size = size;

            lciPe2_3.MaxSize = size;
            lciPe2_3.MinSize = size;
            lciPe2_3.Size = size;

            //3
            lciPe3_1.MaxSize = size;
            lciPe3_1.MinSize = size;
            lciPe3_1.Size = size;

            lciPe3_2.MaxSize = size;
            lciPe3_2.MinSize = size;
            lciPe3_2.Size = size;

            lciPe3_3.MaxSize = size;
            lciPe3_3.MinSize = size;
            lciPe3_3.Size = size;

            esiLeft.Width = widthFinal;
            esiRight.Width = widthFinal;

            esiTopLeft.Width = wt;
            esiTopRight.Width = wt;
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Start the game
        /// </summary>
        public void StartGame()
        {
            ClearGameBoard();
            playerTurn = GetRandomPlayer();
        }

        /// <summary>
        /// Game logic board
        /// </summary>
        /// <param name="picture"></param>
        private void SetGameBoard(PictureEdit picture)
        {
            string[] ste = picture.Name.Split('_');
            int row = int.Parse(ste[1]) - 1;
            int col = int.Parse(ste[2]) - 1;

            if (board[row, col] == Player.PlayerN)
            {
                picture.SvgImage = playerTurn == Player.PlayerO ? Resources.tictactoe_playerO : Resources.tictactoe_playerX;
                board[row, col] = playerTurn == Player.PlayerO ? Player.PlayerO : Player.PlayerX;
                playerTurn = playerTurn == Player.PlayerO ? Player.PlayerX : Player.PlayerO;
            }

            if (HasWinner(board))
            {
                XtraMessageBox.Show($"Player o who won is '{playerWin}'");
                scores[playerWin]++;
                ClearGameBoard();
                UpdateScores();
            }
            else if (IsBoardFull(board))
            {
                XtraMessageBox.Show($"No player was won ");
                scores[Player.PlayerN]++;
                playerWin = GetRandomPlayer();
                ClearGameBoard();
                UpdateScores();
            }
        }

        /// <summary>
        /// Clears the game board.
        /// </summary>
        private void ClearGameBoard()
        {
            pe_1_1.SvgImage = null;
            pe_1_2.SvgImage = null;
            pe_1_3.SvgImage = null;

            pe_2_1.SvgImage = null;
            pe_2_2.SvgImage = null;
            pe_2_3.SvgImage = null;

            pe_3_1.SvgImage = null;
            pe_3_2.SvgImage = null;
            pe_3_3.SvgImage = null;

            board = new Player[3, 3];
            playerTurn = playerWin == Player.PlayerO ? Player.PlayerX : Player.PlayerO;
            playerWin = Player.PlayerN;
        }

        /// <summary>
        /// Gets a ramdom player to play
        /// </summary>
        /// <returns></returns>
        private Player GetRandomPlayer()
        {
            Random random = new Random();
            int randomPlayerNumber = random.Next(2);
            return (Player)randomPlayerNumber + 1;
        }

        /// <summary>
        /// Main function to check for a winner
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool HasWinner(Player[,] board)
        {
            return CheckRows(board) || CheckColumns(board) || CheckDiagonals(board);
        }

        /// <summary>
        /// Checks if is any winner per rows
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool CheckRows(Player[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != Player.PlayerN)
                {
                    playerWin = board[i, 0];
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if is any winner per columns
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool CheckColumns(Player[,] board)
        {

            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != Player.PlayerN)
                {
                    playerWin = board[0, j];
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if is any winner in diagonals
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool CheckDiagonals(Player[,] board)
        {
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                if (board[1, 1] != Player.PlayerN)
                {
                    playerWin = board[1, 1];
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the board is board full for tie
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        private bool IsBoardFull(Player[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == Player.PlayerN)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Updates the scores.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void UpdateScores()
        {
            lcPlayerXSocre.Text = scores[Player.PlayerX].ToString();
            lcPlayerOScore.Text = scores[Player.PlayerO].ToString();
            lcTieScore.Text = scores[Player.PlayerN].ToString();
        }

        #endregion
    }
}
