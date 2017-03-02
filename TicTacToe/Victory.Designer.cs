using System;

namespace TicTacToe
{
    partial class Victory
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
            this.VictoryPicture = new System.Windows.Forms.PictureBox();
            this.Winner = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // VictoryPicture
            // 
            this.VictoryPicture.Image = global::TicTacToe.Properties.Resources.Trophy;
            this.VictoryPicture.Location = new System.Drawing.Point(12, 12);
            this.VictoryPicture.Name = "VictoryPicture";
            this.VictoryPicture.Size = new System.Drawing.Size(549, 479);
            this.VictoryPicture.TabIndex = 0;
            this.VictoryPicture.TabStop = false;
            // 
            // Winner
            // 
            this.Winner.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.Location = new System.Drawing.Point(238, 362);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(100, 43);
            this.Winner.TabIndex = 1;
            this.Winner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(12, 498);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(549, 39);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "继续";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 549);
            this.ControlBox = false;
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.VictoryPicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Victory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "胜利";
            this.Closed += Victory_Closed;
            ((System.ComponentModel.ISupportInitialize)(this.VictoryPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VictoryPicture;
        private System.Windows.Forms.TextBox Winner;
        private System.Windows.Forms.Button ContinueButton;
    }
}