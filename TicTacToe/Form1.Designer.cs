namespace TicTacToe
{
    partial class GameForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.GameDropdownList = new System.Windows.Forms.ToolStripMenuItem();
            this.AIGameRight = new System.Windows.Forms.ToolStripMenuItem();
            this.AIFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.DoubleGame = new System.Windows.Forms.ToolStripMenuItem();
            this.BackHand = new System.Windows.Forms.ToolStripMenuItem();
            this.WinningList = new System.Windows.Forms.ToolStripMenuItem();
            this.Board2_0 = new System.Windows.Forms.Label();
            this.Board1_0 = new System.Windows.Forms.Label();
            this.Board0_0 = new System.Windows.Forms.Label();
            this.Board0_1 = new System.Windows.Forms.Label();
            this.Board1_1 = new System.Windows.Forms.Label();
            this.Board2_1 = new System.Windows.Forms.Label();
            this.Board0_2 = new System.Windows.Forms.Label();
            this.Board1_2 = new System.Windows.Forms.Label();
            this.Board2_2 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameDropdownList,
            this.BackHand,
            this.WinningList});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(326, 24);
            this.menu.TabIndex = 0;
            // 
            // GameDropdownList
            // 
            this.GameDropdownList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AIGameRight,
            this.DoubleGame});
            this.GameDropdownList.Name = "GameDropdownList";
            this.GameDropdownList.Size = new System.Drawing.Size(58, 22);
            this.GameDropdownList.Text = "新游戏";
            // 
            // AIGameRight
            // 
            this.AIGameRight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AIFirst,
            this.PlayerFirst});
            this.AIGameRight.Name = "AIGameRight";
            this.AIGameRight.Size = new System.Drawing.Size(152, 22);
            this.AIGameRight.Text = "人机对战";
            // 
            // AIFirst
            // 
            this.AIFirst.Name = "AIFirst";
            this.AIFirst.Size = new System.Drawing.Size(126, 22);
            this.AIFirst.Text = "机器先手";
            this.AIFirst.Click += new System.EventHandler(this.AIFirst_Click);
            // 
            // PlayerFirst
            // 
            this.PlayerFirst.Name = "PlayerFirst";
            this.PlayerFirst.Size = new System.Drawing.Size(126, 22);
            this.PlayerFirst.Text = "玩家先手";
            this.PlayerFirst.Click += new System.EventHandler(this.PlayerFirst_Click);
            // 
            // DoubleGame
            // 
            this.DoubleGame.Name = "DoubleGame";
            this.DoubleGame.Size = new System.Drawing.Size(152, 22);
            this.DoubleGame.Text = "人人对战";
            this.DoubleGame.Click += new System.EventHandler(this.DoubleGame_Click);
            // 
            // BackHand
            // 
            this.BackHand.Name = "BackHand";
            this.BackHand.Size = new System.Drawing.Size(45, 22);
            this.BackHand.Text = "悔棋";
            this.BackHand.Click += new System.EventHandler(this.BackHand_Click);
            // 
            // WinningList
            // 
            this.WinningList.Name = "WinningList";
            this.WinningList.Size = new System.Drawing.Size(58, 22);
            this.WinningList.Text = "胜利榜";
            this.WinningList.Click += new System.EventHandler(this.WinningList_Click);
            // 
            // Board2_0
            // 
            this.Board2_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board2_0.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board2_0.Location = new System.Drawing.Point(9, 280);
            this.Board2_0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board2_0.Name = "Board2_0";
            this.Board2_0.Size = new System.Drawing.Size(101, 109);
            this.Board2_0.TabIndex = 3;
            this.Board2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board1_0
            // 
            this.Board1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board1_0.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board1_0.Location = new System.Drawing.Point(9, 160);
            this.Board1_0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board1_0.Name = "Board1_0";
            this.Board1_0.Size = new System.Drawing.Size(101, 109);
            this.Board1_0.TabIndex = 2;
            this.Board1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board0_0
            // 
            this.Board0_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board0_0.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board0_0.Location = new System.Drawing.Point(9, 40);
            this.Board0_0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board0_0.Name = "Board0_0";
            this.Board0_0.Size = new System.Drawing.Size(101, 109);
            this.Board0_0.TabIndex = 4;
            this.Board0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board0_1
            // 
            this.Board0_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board0_1.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board0_1.Location = new System.Drawing.Point(113, 40);
            this.Board0_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board0_1.Name = "Board0_1";
            this.Board0_1.Size = new System.Drawing.Size(101, 109);
            this.Board0_1.TabIndex = 5;
            this.Board0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board1_1
            // 
            this.Board1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board1_1.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board1_1.Location = new System.Drawing.Point(113, 160);
            this.Board1_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board1_1.Name = "Board1_1";
            this.Board1_1.Size = new System.Drawing.Size(101, 109);
            this.Board1_1.TabIndex = 6;
            this.Board1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board2_1
            // 
            this.Board2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board2_1.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board2_1.Location = new System.Drawing.Point(113, 280);
            this.Board2_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board2_1.Name = "Board2_1";
            this.Board2_1.Size = new System.Drawing.Size(101, 109);
            this.Board2_1.TabIndex = 7;
            this.Board2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board0_2
            // 
            this.Board0_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board0_2.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board0_2.Location = new System.Drawing.Point(217, 40);
            this.Board0_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board0_2.Name = "Board0_2";
            this.Board0_2.Size = new System.Drawing.Size(101, 109);
            this.Board0_2.TabIndex = 8;
            this.Board0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board1_2
            // 
            this.Board1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board1_2.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board1_2.Location = new System.Drawing.Point(217, 160);
            this.Board1_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board1_2.Name = "Board1_2";
            this.Board1_2.Size = new System.Drawing.Size(101, 109);
            this.Board1_2.TabIndex = 9;
            this.Board1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Board2_2
            // 
            this.Board2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Board2_2.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Board2_2.Location = new System.Drawing.Point(217, 280);
            this.Board2_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Board2_2.Name = "Board2_2";
            this.Board2_2.Size = new System.Drawing.Size(101, 109);
            this.Board2_2.TabIndex = 10;
            this.Board2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 404);
            this.Controls.Add(this.Board2_2);
            this.Controls.Add(this.Board1_2);
            this.Controls.Add(this.Board0_2);
            this.Controls.Add(this.Board2_1);
            this.Controls.Add(this.Board1_1);
            this.Controls.Add(this.Board0_1);
            this.Controls.Add(this.Board0_0);
            this.Controls.Add(this.Board2_0);
            this.Controls.Add(this.Board1_0);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "TicTacToe";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem GameDropdownList;
        private System.Windows.Forms.ToolStripMenuItem AIGameRight;
        private System.Windows.Forms.ToolStripMenuItem DoubleGame;
        private System.Windows.Forms.ToolStripMenuItem WinningList;
        private System.Windows.Forms.Label Board2_0;
        private System.Windows.Forms.Label Board1_0;
        private System.Windows.Forms.Label Board0_0;
        private System.Windows.Forms.Label Board0_1;
        private System.Windows.Forms.Label Board1_1;
        private System.Windows.Forms.Label Board2_1;
        private System.Windows.Forms.Label Board0_2;
        private System.Windows.Forms.Label Board1_2;
        private System.Windows.Forms.Label Board2_2;
        private System.Windows.Forms.ToolStripMenuItem AIFirst;
        private System.Windows.Forms.ToolStripMenuItem PlayerFirst;
        private System.Windows.Forms.ToolStripMenuItem BackHand;
    }
}

