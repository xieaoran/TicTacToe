using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe.Core;

namespace TicTacToe
{
    public partial class Victory : Form
    {
        private GameCore.GameMode _mode;
        private List<Element> _steps;

        public Victory(GameCore.GameMode mode, List<Element> steps)
        {
            InitializeComponent();
            _mode = mode;
            _steps = steps;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            XMLHelper.Records.Add(new Record(_mode, Winner.Text, _steps));
            XMLHelper.Serialize();
            Dispose();
        }

        private void Victory_Closed(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}