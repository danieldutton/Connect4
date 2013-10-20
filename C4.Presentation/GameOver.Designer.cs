namespace C4.Presentation
{
    partial class GameOver
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
            this._lblWinner = new System.Windows.Forms.Label();
            this._btnExit = new System.Windows.Forms.Button();
            this._btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblWinner
            // 
            this._lblWinner.AutoSize = true;
            this._lblWinner.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWinner.ForeColor = System.Drawing.Color.White;
            this._lblWinner.Location = new System.Drawing.Point(12, 21);
            this._lblWinner.Name = "_lblWinner";
            this._lblWinner.Size = new System.Drawing.Size(43, 14);
            this._lblWinner.TabIndex = 0;
            this._lblWinner.Text = "label1";
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(12, 46);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 1;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // _btnPlayAgain
            // 
            this._btnPlayAgain.Location = new System.Drawing.Point(93, 46);
            this._btnPlayAgain.Name = "_btnPlayAgain";
            this._btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this._btnPlayAgain.TabIndex = 2;
            this._btnPlayAgain.Text = "Play Again";
            this._btnPlayAgain.UseVisualStyleBackColor = true;
            this._btnPlayAgain.Click += new System.EventHandler(this.RestartApplication_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(188, 81);
            this.Controls.Add(this._btnPlayAgain);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._lblWinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(204, 155);
            this.Name = "GameOver";
            this.Text = "Game Over";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOver_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblWinner;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnPlayAgain;
    }
}