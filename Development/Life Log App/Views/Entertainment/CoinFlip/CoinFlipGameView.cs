using DevExpress.XtraEditors;
using Life_Log_App.Helpers;
using Life_Log_App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Life_Log_App.Views.Entertainment.CoinFlip
{
    /// <summary>
    /// Game flip the coin
    /// </summary>
    public partial class CoinFlipGameView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private Coin turn;
        private Dictionary<Coin, int> scores = new Dictionary<Coin, int>
        {
            { Coin.Heads, 0 },
            { Coin.Tails, 0 }
        };

        //ENUM

        private enum Coin
        {
            Heads,
            Tails
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CoinFlipGameView() => InitializeComponent();

        /// <summary>
        /// On layout resize, ajust the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CoinFlipGameView_Resize(object sender, EventArgs e)
        {
            int h1 = Math.Min(layoutControl.Height - 125, layoutControl.Width - 50);
            Size size = new Size(h1, h1);

            lciPeGameImage.MaxSize = size;
            lciPeGameImage.MinSize = size;
            lciPeGameImage.Size = size;

            int widthFinal = (esiLeft.Width + esiRight.Width) / 2;
            int wt = (esiTopLeft.Width + esiTopRight.Width) / 2;

            esiLeft.Width = widthFinal;
            esiRight.Width = widthFinal;

            esiTopLeft.Width = wt;
            esiTopRight.Width = wt;
        }

        #endregion

        #region ITEM CLICK

        /// <summary>
        /// Flip the coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiFlipCoin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bbiFlipCoin.Enabled = false;

                int timesToPlay = 10;

                turn = (new Random().Next(10) % 2 == 0) ? Coin.Heads : Coin.Tails;
                peCoinGame.SvgImage = turn == Coin.Heads ? Resources.coin_heads : Resources.coin_tails;

                for (int i = 0; i < timesToPlay; i++)
                {
                    int randomNumber = new Random().Next(1000);

                    if (i == timesToPlay - 1)
                    {
                        Coin final = (randomNumber % 2 == 0) ? Coin.Heads : Coin.Tails;

                        if (final == turn)
                        {
                            peCoinGame.SvgImage = turn == Coin.Heads ? Resources.coin_tails : Resources.coin_heads;
                            await Task.Delay(250);
                        }

                        scores[final]++;
                        peCoinGame.SvgImage = final == Coin.Heads ? Resources.coin_heads : Resources.coin_tails;
                        UpdateSocreBoard();
                    }
                    else
                    {
                        turn = turn == Coin.Heads ? Coin.Tails : Coin.Heads;
                        peCoinGame.SvgImage = turn == Coin.Heads ? Resources.coin_heads : Resources.coin_tails;
                    }

                    await Task.Delay(250);
                }

                bbiFlipCoin.Enabled = true;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region FUNCTION

        /// <summary>
        /// Update the score board
        /// </summary>
        private void UpdateSocreBoard()
        {
            lcScoreHeads.Text = scores[Coin.Heads].ToString();
            lcScoreTails.Text = scores[Coin.Tails].ToString();
        }

        #endregion
    }
}
