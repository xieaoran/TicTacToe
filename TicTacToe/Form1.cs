using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicTacToe.Core;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private string _aiContent;
        private GameCore _currentGame;

        public GameForm()
        {
            InitializeComponent();
            foreach (var label in Controls.OfType<Label>())
            {
                label.MouseClick += BoardClicked;
                label.Enabled = false;
            }
            _aiContent = "";
        }

        private void BoardClicked(object sender, MouseEventArgs e)
        {
            var clickedBoard = (Label) sender;
            if (clickedBoard.Text != "") return;
            var row = int.Parse(clickedBoard.Name[5].ToString());
            var column = int.Parse(clickedBoard.Name[7].ToString());
            clickedBoard.Text = _currentGame.NextHandContent;
            _currentGame.CurrentHand(row, column);
            var judgePlayer = _currentGame.JudgeGame();
            JudgeCallback(judgePlayer);
            if (judgePlayer.Result != Judge.JudgeResult.Unfinished) return;
            if (_currentGame.Mode == GameCore.GameMode.AI)
            {
                AICallback(_currentGame.AICalc());
                var judgeAI = _currentGame.JudgeGame();
                JudgeCallback(judgeAI);
            }
        }

        private void AICallback(AIResult result)
        {
            if (result == null) return;
            Controls.Find(result.LabelName, false).First().Text = result.Content;
        }

        private void JudgeCallback(Judge judge)
        {
            switch (judge.Result)
            {
                case Judge.JudgeResult.OWins:
                    JudgeShowWin(judge);
                    break;
                case Judge.JudgeResult.XWins:
                    JudgeShowWin(judge);
                    break;
                case Judge.JudgeResult.Draw:
                    JudgeShowDraw();
                    break;
            }
        }

        private void JudgeShowWin(Judge judge)
        {
            foreach (var label in Controls.OfType<Label>())
            {
                label.Enabled = false;
            }
            foreach (
                var reasonLabel in
                    judge.ReasonLine.Members.Select(
                        reasonElement => "Board" + reasonElement.Row + "_" + reasonElement.Column))
            {
                Controls.Find(reasonLabel, false).First().BackColor = Color.FromArgb(255, 193, 7);
            }
            switch (_currentGame.Mode)
            {
                case GameCore.GameMode.AI:
                    if ((judge.Result == Judge.JudgeResult.OWins && _aiContent == "X") ||
                        (judge.Result == Judge.JudgeResult.XWins && _aiContent == "O"))
                    {
                        var victoryForm = new Victory(_currentGame.Mode, _currentGame.HistoryHands);
                        victoryForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("胜败乃兵家常事，大侠请重新来过。", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case GameCore.GameMode.Manual:
                    if (judge.Result == Judge.JudgeResult.OWins || judge.Result == Judge.JudgeResult.XWins)
                    {
                        var victoryForm = new Victory(_currentGame.Mode, _currentGame.HistoryHands);
                        victoryForm.Show();
                    }
                    break;
            }
        }

        private void JudgeShowDraw()
        {
            foreach (var label in Controls.OfType<Label>())
            {
                label.Enabled = false;
            }
            MessageBox.Show("平局！", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AIFirst_Click(object sender, EventArgs e)
        {
            ClearBoard();
            _aiContent = "X";
            _currentGame = new GameCore(GameCore.GameMode.AI);
            _currentGame.AnalyzeBoard();
            AICallback(_currentGame.AICalc());
        }

        private void PlayerFirst_Click(object sender, EventArgs e)
        {
            ClearBoard();
            _aiContent = "O";
            _currentGame = new GameCore(GameCore.GameMode.AI);
        }

        private void ClearBoard()
        {
            foreach (var label in Controls.OfType<Label>())
            {
                label.Text = "";
                label.Enabled = true;
                label.BackColor = SystemColors.Control;
            }
        }

        private void DoubleGame_Click(object sender, EventArgs e)
        {
            ClearBoard();
            _currentGame = new GameCore(GameCore.GameMode.Manual);
        }

        private void BackHand_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<Label>().All(label => label.Text == "")) return;
            if (_currentGame.GameFinished)
            {
                foreach (var label in Controls.OfType<Label>())
                {
                    label.Enabled = true;
                    label.BackColor = SystemColors.Control;
                }
                _currentGame.GameFinished = false;
            }
            var backHandResult = _currentGame.BackHand();
            if (backHandResult != null)
            {
                foreach (var aiResult in backHandResult)
                {
                    AICallback(aiResult);
                }
            }
            if (_currentGame.NextHandContent == _aiContent)
            {
                _currentGame.AnalyzeBoard();
                AICallback(_currentGame.AICalc());
            }
        }

        private void WinningList_Click(object sender, EventArgs e)
        {
            var recordForm = new RecordForm();
            recordForm.Show();
        }
    }
}