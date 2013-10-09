namespace C4.Presentation
{
    partial class GameOptions
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
            this._lblPlayer1 = new System.Windows.Forms.Label();
            this._lblPlayer2 = new System.Windows.Forms.Label();
            this._txtBoxPlayer1 = new System.Windows.Forms.TextBox();
            this._txtBoxPlayer2 = new System.Windows.Forms.TextBox();
            this._panelYellowSquare = new System.Windows.Forms.Panel();
            this._panelRedSquare = new System.Windows.Forms.Panel();
            this._btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblPlayer1
            // 
            this._lblPlayer1.AutoSize = true;
            this._lblPlayer1.Location = new System.Drawing.Point(16, 26);
            this._lblPlayer1.Name = "_lblPlayer1";
            this._lblPlayer1.Size = new System.Drawing.Size(45, 13);
            this._lblPlayer1.TabIndex = 0;
            this._lblPlayer1.Text = "Player 1";
            // 
            // _lblPlayer2
            // 
            this._lblPlayer2.AutoSize = true;
            this._lblPlayer2.Location = new System.Drawing.Point(16, 52);
            this._lblPlayer2.Name = "_lblPlayer2";
            this._lblPlayer2.Size = new System.Drawing.Size(45, 13);
            this._lblPlayer2.TabIndex = 1;
            this._lblPlayer2.Text = "Player 2";
            // 
            // _txtBoxPlayer1
            // 
            this._txtBoxPlayer1.Location = new System.Drawing.Point(80, 23);
            this._txtBoxPlayer1.Name = "_txtBoxPlayer1";
            this._txtBoxPlayer1.Size = new System.Drawing.Size(119, 20);
            this._txtBoxPlayer1.TabIndex = 2;
            // 
            // _txtBoxPlayer2
            // 
            this._txtBoxPlayer2.Location = new System.Drawing.Point(80, 49);
            this._txtBoxPlayer2.Name = "_txtBoxPlayer2";
            this._txtBoxPlayer2.Size = new System.Drawing.Size(119, 20);
            this._txtBoxPlayer2.TabIndex = 3;
            // 
            // _panelYellowSquare
            // 
            this._panelYellowSquare.Location = new System.Drawing.Point(220, 23);
            this._panelYellowSquare.Name = "_panelYellowSquare";
            this._panelYellowSquare.Size = new System.Drawing.Size(22, 20);
            this._panelYellowSquare.TabIndex = 4;
            // 
            // _panelRedSquare
            // 
            this._panelRedSquare.Location = new System.Drawing.Point(220, 49);
            this._panelRedSquare.Name = "_panelRedSquare";
            this._panelRedSquare.Size = new System.Drawing.Size(22, 20);
            this._panelRedSquare.TabIndex = 5;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.Location = new System.Drawing.Point(80, 82);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 23);
            this._btnConfirm.TabIndex = 6;
            this._btnConfirm.Text = "button1";
            this._btnConfirm.UseVisualStyleBackColor = true;
            this._btnConfirm.Click += new System.EventHandler(this.ConfirmPlayers_Click);
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 117);
            this.Controls.Add(this._btnConfirm);
            this.Controls.Add(this._panelRedSquare);
            this.Controls.Add(this._panelYellowSquare);
            this.Controls.Add(this._txtBoxPlayer2);
            this.Controls.Add(this._txtBoxPlayer1);
            this.Controls.Add(this._lblPlayer2);
            this.Controls.Add(this._lblPlayer1);
            this.Name = "GameOptions";
            this.Text = "GameOptions";
            this.Load += new System.EventHandler(this.GameOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblPlayer1;
        private System.Windows.Forms.Label _lblPlayer2;
        private System.Windows.Forms.TextBox _txtBoxPlayer1;
        private System.Windows.Forms.TextBox _txtBoxPlayer2;
        private System.Windows.Forms.Panel _panelYellowSquare;
        private System.Windows.Forms.Panel _panelRedSquare;
        private System.Windows.Forms.Button _btnConfirm;
    }
}