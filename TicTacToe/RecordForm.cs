using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicTacToe.Core;

namespace TicTacToe
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
            foreach (var record in XMLHelper.Records)
            {
                var mode = "";
                switch (record.Mode)
                {
                    case GameCore.GameMode.AI:
                        mode = "人机对战";
                        break;
                    case GameCore.GameMode.Manual:
                        mode = "人人对战";
                        break;
                }
                var stepDetails = new List<string>(record.Steps.Count);
                stepDetails.AddRange(
                    record.Steps.Select(step => "(" + step.Row + "," + step.Column + "):" + step.Content));
                RecordsView.Rows.Add(record.Time.ToString("yyyy-MM-dd HH:mm:ss"), mode, record.Winner,
                    record.Steps.Count, string.Join("|", stepDetails));
            }
        }

        private void RecordForm_Closed(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}