namespace TicTacToe
{
    partial class RecordForm
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
            this.RecordsView = new System.Windows.Forms.DataGridView();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinnerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsView)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordsView
            // 
            this.RecordsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.ModeColumn,
            this.WinnerColumn,
            this.StepsCountColumn,
            this.StepsColumn});
            this.RecordsView.Location = new System.Drawing.Point(13, 13);
            this.RecordsView.Name = "RecordsView";
            this.RecordsView.Size = new System.Drawing.Size(845, 601);
            this.RecordsView.TabIndex = 0;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "时间";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeColumn.Width = 150;
            // 
            // ModeColumn
            // 
            this.ModeColumn.HeaderText = "模式";
            this.ModeColumn.Name = "ModeColumn";
            this.ModeColumn.ReadOnly = true;
            this.ModeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // WinnerColumn
            // 
            this.WinnerColumn.HeaderText = "胜者";
            this.WinnerColumn.Name = "WinnerColumn";
            this.WinnerColumn.ReadOnly = true;
            this.WinnerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StepsCountColumn
            // 
            this.StepsCountColumn.HeaderText = "步数";
            this.StepsCountColumn.Name = "StepsCountColumn";
            this.StepsCountColumn.ReadOnly = true;
            this.StepsCountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StepsColumn
            // 
            this.StepsColumn.HeaderText = "全盘";
            this.StepsColumn.Name = "StepsColumn";
            this.StepsColumn.ReadOnly = true;
            this.StepsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StepsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StepsColumn.Width = 350;
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 626);
            this.Controls.Add(this.RecordsView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.Text = "胜利榜";
            ((System.ComponentModel.ISupportInitialize)(this.RecordsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinnerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepsColumn;
    }
}