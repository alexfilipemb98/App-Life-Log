using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace LifeLog.Views.Games
{
    public sealed partial class TicTacToeView : UserControl
    {
        // Variáveis de estado do jogo
        private bool _isPlayerXTurn = true;
        private string[] _board = new string[9];
        private bool _gameActive = true;

        // Pontuações
        private int _scoreX = 0;
        private int _scoreO = 0;
        private int _scoreDraw = 0;

        // Cores (X = Tema Accent / O = Laranja)
        private Brush _colorX = App.Current.Resources["SystemControlForegroundAccentBrush"] as Brush;
        private Brush _colorO = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 249, 115, 22)); // Laranja
        private Brush _colorDefault = App.Current.Resources["TextFillColorPrimaryBrush"] as Brush;

        public TicTacToeView()
        {
            this.InitializeComponent();
            ResetBoard();
        }

        // Quando clicas num dos 9 botões
        private void Cell_Click(object sender, RoutedEventArgs e)
        {
            if (!_gameActive) return; // Se o jogo acabou, não faz nada

            Button btn = sender as Button;
            int index = int.Parse(btn.Tag.ToString());

            // Verifica se a célula já está ocupada
            if (!string.IsNullOrEmpty(_board[index])) return;

            // Faz a jogada
            string currentPlayer = _isPlayerXTurn ? "X" : "O";
            _board[index] = currentPlayer;
            btn.Content = currentPlayer;
            btn.Foreground = _isPlayerXTurn ? _colorX : _colorO;

            // Verifica se alguém ganhou
            if (CheckWin(currentPlayer, out int[] winningLine))
            {
                EndGame(currentPlayer, winningLine);
            }
            else if (IsDraw())
            {
                EndGame("Draw", null);
            }
            else
            {
                // Passa a vez
                _isPlayerXTurn = !_isPlayerXTurn;
                StatusText.Text = $"Player {(_isPlayerXTurn ? "X" : "O")}'s Turn";
                StatusText.Foreground = _isPlayerXTurn ? _colorX : _colorO;
            }
        }

        // Verifica todas as combinações de vitória possíveis
        private bool CheckWin(string player, out int[] winningLine)
        {
            int[][] winLines = new int[][]
            {
                new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, // Linhas Horizontais
                new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, // Linhas Verticais
                new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 }                         // Diagonais
            };

            foreach (var line in winLines)
            {
                if (_board[line[0]] == player && _board[line[1]] == player && _board[line[2]] == player)
                {
                    winningLine = line;
                    return true;
                }
            }

            winningLine = null;
            return false;
        }

        // Verifica se o tabuleiro está cheio
        private bool IsDraw()
        {
            foreach (string cell in _board)
            {
                if (string.IsNullOrEmpty(cell)) return false;
            }
            return true;
        }

        // Lida com o final do jogo (Vitória ou Empate)
        private void EndGame(string result, int[] winningLine)
        {
            _gameActive = false;

            if (result == "Draw")
            {
                StatusText.Text = "It's a Draw!";
                StatusText.Foreground = _colorDefault;
                _scoreDraw++;
                ScoreDrawText.Text = _scoreDraw.ToString();
            }
            else
            {
                StatusText.Text = $"Player {result} Wins!";

                // Atualiza o placar
                if (result == "X")
                {
                    _scoreX++;
                    ScoreXText.Text = _scoreX.ToString();
                }
                else
                {
                    _scoreO++;
                    ScoreOText.Text = _scoreO.ToString();
                }

                // Destaca os botões vencedores pintando o fundo
                if (winningLine != null)
                {
                    HighlightButton(winningLine[0], result);
                    HighlightButton(winningLine[1], result);
                    HighlightButton(winningLine[2], result);
                }
            }
        }

        // Pinta a linha vencedora para ser fácil de identificar
        private void HighlightButton(int index, string winner)
        {
            string btnName = $"Cell{index}";
            Button btn = BoardGrid.FindName(btnName) as Button;

            if (btn != null)
            {
                // Um fundo subtil com a cor do vencedor
                btn.Background = winner == "X"
                    ? new SolidColorBrush(Windows.UI.Color.FromArgb(50, 0, 120, 215)) // Azul Transparente
                    : new SolidColorBrush(Windows.UI.Color.FromArgb(50, 249, 115, 22)); // Laranja Transparente
            }
        }

        // Botão Play Again
        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        {
            ResetBoard();
        }

        // Limpa o tabuleiro para uma nova partida
        private void ResetBoard()
        {
            _board = new string[9];
            _gameActive = true;

            // O jogador X começa sempre o jogo novo (podes mudar isto se quiseres alternar)
            _isPlayerXTurn = true;
            StatusText.Text = "Player X's Turn";
            StatusText.Foreground = _colorX;

            // Limpar os botões visuais
            Brush defaultBg = App.Current.Resources["LayerFillColorAltBrush"] as Brush;

            for (int i = 0; i < 9; i++)
            {
                Button btn = BoardGrid.FindName($"Cell{i}") as Button;
                if (btn != null)
                {
                    btn.Content = "";
                    btn.Background = defaultBg;
                }
            }
        }
    }
}