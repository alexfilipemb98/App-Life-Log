using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.UI.FrontEnd.Views.Entertainment.Dice
{
    /// <summary>
    /// Roll the dice game
    /// </summary>
    public partial class DiceGameView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private Dictionary<Dice, int> scores = new Dictionary<Dice, int>
        {
            { Dice.One, 0 },
            { Dice.Two, 0 },
            { Dice.Three, 0 },
            { Dice.Four, 0 },
            { Dice.Five, 0 },
            { Dice.Six, 0 },
        };

        //ENUM
        private enum Dice
        {
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DiceGameView() => InitializeComponent();

        /// <summary>
        /// layout on resize, ajust the game layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DiceGameView_Resize(object sender, EventArgs e)
        {
            int h1 = Math.Min(layoutControl.Height - 125, layoutControl.Width - 50);
            Size size = new Size(h1, h1);

            lciPictureDice.MaxSize = size;
            lciPictureDice.MinSize = size;
            lciPictureDice.Size = size;

            int wt = (esiTopLeft.Width + esiTopRight.Width) / 2;
            int widthFinal = (esiLeft.Width + esiRight.Width) / 2;

            esiLeft.Width = widthFinal;
            esiRight.Width = widthFinal;

            esiTopLeft.Width = wt;
            esiTopRight.Width = wt;
        }

        #endregion

        #region ITEM CLICK

        /// <summary>
        /// Roll the dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiReRoll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                layoutControl.Invoke((MethodInvoker)(() => bbiReRoll.Enabled = false));

                int timesToPlay = 25;
                Dice turn = (Dice)new Random().Next(6);
                layoutControl.Invoke((MethodInvoker)(() => peDice.SvgImage = GetImage(turn)));

                Random random = new Random(); // Instância única de Random

                for (int i = 0; i < timesToPlay; i++)
                {
                    int randomNumber = random.Next(6);

                    if (i == timesToPlay - 1)
                    {
                        Dice final = (Dice)randomNumber;

                        if (final == turn) // Verifica se é o mesmo resultado
                        {
                            do
                            {
                                randomNumber = random.Next(6);
                            } while (final == (Dice)randomNumber);

                            layoutControl.Invoke((MethodInvoker)(() => peDice.SvgImage = GetImage((Dice)randomNumber)));
                            await Task.Delay(150); // Aguardar o delay
                        }

                        scores[final]++;

                        layoutControl.Invoke((MethodInvoker)(() => peDice.SvgImage = GetImage(final)));

                        UpdateScores();
                    }
                    else
                    {
                        if (turn == (Dice)randomNumber)
                        {
                            do
                            {
                                randomNumber = random.Next(6);
                            } while (turn == (Dice)randomNumber);
                        }

                        turn = (Dice)randomNumber;
                      
                        layoutControl.Invoke((MethodInvoker)(() => peDice.SvgImage = GetImage(turn)));

                    }

                    // Atualiza o texto do formulário
                    this.Invoke((MethodInvoker)(() => this.Text = randomNumber.ToString()));
                    await Task.Delay(150); // Aguardar o delay
                }

                layoutControl.Invoke((MethodInvoker)(() => bbiReRoll.Enabled = true));
            }
            catch (Exception ex)
            {
                //ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Returns the image that correspondes to the number
        /// </summary>
        /// <param name="dice"></param>
        /// <returns></returns>
        private SvgImage GetImage(Dice dice)
        {
            SvgImage img = null;

            switch (dice)
            {
                case Dice.One:
                    img = Base.Assets.Resources.dice_1;
                    break;
                case Dice.Two:
                    img = Base.Assets.Resources.dice_2;
                    break;
                case Dice.Three:
                    img = Base.Assets.Resources.dice_3;
                    break;
                case Dice.Four:
                    img = Base.Assets.Resources.dice_4;
                    break;
                case Dice.Five: 
                    img = Base.Assets.Resources.dice_5;
                    break;
                case Dice.Six:
                    img = Base.Assets.Resources.dice_6;
                    break;
            }

            return img;
        }

        /// <summary>
        /// Update the scores
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void UpdateScores()
        {
            lcScore1.Text = scores[Dice.One].ToString();
            lcScore2.Text = scores[Dice.Two].ToString();
            lcScore3.Text = scores[Dice.Three].ToString();
            lcScore4.Text = scores[Dice.Four].ToString();
            lcScore5.Text = scores[Dice.Five].ToString();
            lcScore6.Text = scores[Dice.Six].ToString();
        }

        #endregion
    }
}
