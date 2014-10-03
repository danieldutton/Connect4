namespace C4.Presentation
{
    partial class GameSetup
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
            this._lbYellowPlayer = new System.Windows.Forms.Label();
            this._lblRedPlayer = new System.Windows.Forms.Label();
            this._txtBoxYellowPlayerName = new System.Windows.Forms.TextBox();
            this._txtBoxRedPlayerName = new System.Windows.Forms.TextBox();
            this._panelYellowSquare = new System.Windows.Forms.Panel();
            this._panelRedSquare = new System.Windows.Forms.Panel();
            this._btnConfirm = new System.Windows.Forms.Button();
            this._panelRdoButtons = new System.Windows.Forms.Panel();
            this._lblPlaysFirst = new System.Windows.Forms.Label();
            this._rdoBtnRed = new System.Windows.Forms.RadioButton();
            this._rdoBtnYellow = new System.Windows.Forms.RadioButton();
            this._panelPlayer1Master = new System.Windows.Forms.Panel();
            this._panelPlayer2Master = new System.Windows.Forms.Panel();
            this._panelRdoButtons.SuspendLayout();
            this._panelPlayer1Master.SuspendLayout();
            this._panelPlayer2Master.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lbYellowPlayer
            // 
            this._lbYellowPlayer.AutoSize = true;
            this._lbYellowPlayer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbYellowPlayer.ForeColor = System.Drawing.Color.White;
            this._lbYellowPlayer.Location = new System.Drawing.Point(27, 9);
            this._lbYellowPlayer.Name = "_lbYellowPlayer";
            this._lbYellowPlayer.Size = new System.Drawing.Size(56, 14);
            this._lbYellowPlayer.TabIndex = 0;
            this._lbYellowPlayer.Text = "Player 1";
            // 
            // _lblRedPlayer
            // 
            this._lblRedPlayer.AutoSize = true;
            this._lblRedPlayer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRedPlayer.ForeColor = System.Drawing.Color.White;
            this._lblRedPlayer.Location = new System.Drawing.Point(27, 8);
            this._lblRedPlayer.Name = "_lblRedPlayer";
            this._lblRedPlayer.Size = new System.Drawing.Size(56, 14);
            this._lblRedPlayer.TabIndex = 1;
            this._lblRedPlayer.Text = "Player 2";
            // 
            // _txtBoxYellowPlayerName
            // 
            this._txtBoxYellowPlayerName.BackColor = System.Drawing.Color.Gainsboro;
            this._txtBoxYellowPlayerName.Location = new System.Drawing.Point(89, 7);
            this._txtBoxYellowPlayerName.Name = "_txtBoxYellowPlayerName";
            this._txtBoxYellowPlayerName.Size = new System.Drawing.Size(133, 20);
            this._txtBoxYellowPlayerName.TabIndex = 2;
            // 
            // _txtBoxRedPlayerName
            // 
            this._txtBoxRedPlayerName.BackColor = System.Drawing.Color.Gainsboro;
            this._txtBoxRedPlayerName.Location = new System.Drawing.Point(89, 6);
            this._txtBoxRedPlayerName.Name = "_txtBoxRedPlayerName";
            this._txtBoxRedPlayerName.Size = new System.Drawing.Size(133, 20);
            this._txtBoxRedPlayerName.TabIndex = 3;
            // 
            // _panelYellowSquare
            // 
            this._panelYellowSquare.BackColor = System.Drawing.Color.Yellow;
            this._panelYellowSquare.ForeColor = System.Drawing.Color.Yellow;
            this._panelYellowSquare.Location = new System.Drawing.Point(6, 8);
            this._panelYellowSquare.Name = "_panelYellowSquare";
            this._panelYellowSquare.Size = new System.Drawing.Size(16, 16);
            this._panelYellowSquare.TabIndex = 4;
            // 
            // _panelRedSquare
            // 
            this._panelRedSquare.BackColor = System.Drawing.Color.Red;
            this._panelRedSquare.Location = new System.Drawing.Point(6, 8);
            this._panelRedSquare.Name = "_panelRedSquare";
            this._panelRedSquare.Size = new System.Drawing.Size(16, 16);
            this._panelRedSquare.TabIndex = 5;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.BackColor = System.Drawing.Color.White;
            this._btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnConfirm.Location = new System.Drawing.Point(94, 85);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 23);
            this._btnConfirm.TabIndex = 6;
            this._btnConfirm.Text = "Start";
            this._btnConfirm.UseVisualStyleBackColor = false;
            this._btnConfirm.Click += new System.EventHandler(this.ConfirmPlayers_Click);
            // 
            // _panelRdoButtons
            // 
            this._panelRdoButtons.Controls.Add(this._lblPlaysFirst);
            this._panelRdoButtons.Controls.Add(this._rdoBtnRed);
            this._panelRdoButtons.Controls.Add(this._rdoBtnYellow);
            this._panelRdoButtons.Location = new System.Drawing.Point(233, 14);
            this._panelRdoButtons.Name = "_panelRdoButtons";
            this._panelRdoButtons.Size = new System.Drawing.Size(54, 69);
            this._panelRdoButtons.TabIndex = 7;
            // 
            // _lblPlaysFirst
            // 
            this._lblPlaysFirst.AutoSize = true;
            this._lblPlaysFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPlaysFirst.ForeColor = System.Drawing.Color.White;
            this._lblPlaysFirst.Location = new System.Drawing.Point(-3, 27);
            this._lblPlaysFirst.Name = "_lblPlaysFirst";
            this._lblPlaysFirst.Size = new System.Drawing.Size(56, 13);
            this._lblPlaysFirst.TabIndex = 11;
            this._lblPlaysFirst.Text = "Plays First";
            // 
            // _rdoBtnRed
            // 
            this._rdoBtnRed.AutoSize = true;
            this._rdoBtnRed.Location = new System.Drawing.Point(5, 45);
            this._rdoBtnRed.Name = "_rdoBtnRed";
            this._rdoBtnRed.Size = new System.Drawing.Size(14, 13);
            this._rdoBtnRed.TabIndex = 1;
            this._rdoBtnRed.UseVisualStyleBackColor = true;
            // 
            // _rdoBtnYellow
            // 
            this._rdoBtnYellow.AutoSize = true;
            this._rdoBtnYellow.Checked = true;
            this._rdoBtnYellow.Location = new System.Drawing.Point(5, 10);
            this._rdoBtnYellow.Name = "_rdoBtnYellow";
            this._rdoBtnYellow.Size = new System.Drawing.Size(14, 13);
            this._rdoBtnYellow.TabIndex = 0;
            this._rdoBtnYellow.TabStop = true;
            this._rdoBtnYellow.UseVisualStyleBackColor = true;
            // 
            // _panelPlayer1Master
            // 
            this._panelPlayer1Master.Controls.Add(this._panelYellowSquare);
            this._panelPlayer1Master.Controls.Add(this._lbYellowPlayer);
            this._panelPlayer1Master.Controls.Add(this._txtBoxYellowPlayerName);
            this._panelPlayer1Master.Location = new System.Drawing.Point(5, 14);
            this._panelPlayer1Master.Name = "_panelPlayer1Master";
            this._panelPlayer1Master.Size = new System.Drawing.Size(227, 34);
            this._panelPlayer1Master.TabIndex = 9;
            // 
            // _panelPlayer2Master
            // 
            this._panelPlayer2Master.Controls.Add(this._panelRedSquare);
            this._panelPlayer2Master.Controls.Add(this._lblRedPlayer);
            this._panelPlayer2Master.Controls.Add(this._txtBoxRedPlayerName);
            this._panelPlayer2Master.Location = new System.Drawing.Point(5, 49);
            this._panelPlayer2Master.Name = "_panelPlayer2Master";
            this._panelPlayer2Master.Size = new System.Drawing.Size(227, 34);
            this._panelPlayer2Master.TabIndex = 10;
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(291, 114);
            this.Controls.Add(this._panelPlayer2Master);
            this.Controls.Add(this._panelPlayer1Master);
            this.Controls.Add(this._panelRdoButtons);
            this.Controls.Add(this._btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(307, 148);
            this.Name = "GameSetup";
            this.Text = "Confirm Players";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCrossClicked_FormClosing);
            this._panelRdoButtons.ResumeLayout(false);
            this._panelRdoButtons.PerformLayout();
            this._panelPlayer1Master.ResumeLayout(false);
            this._panelPlayer1Master.PerformLayout();
            this._panelPlayer2Master.ResumeLayout(false);
            this._panelPlayer2Master.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lbYellowPlayer;
        private System.Windows.Forms.Label _lblRedPlayer;
        private System.Windows.Forms.TextBox _txtBoxYellowPlayerName;
        private System.Windows.Forms.TextBox _txtBoxRedPlayerName;
        private System.Windows.Forms.Panel _panelYellowSquare;
        private System.Windows.Forms.Panel _panelRedSquare;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.Panel _panelRdoButtons;
        private System.Windows.Forms.RadioButton _rdoBtnRed;
        private System.Windows.Forms.RadioButton _rdoBtnYellow;
        private System.Windows.Forms.Panel _panelPlayer1Master;
        private System.Windows.Forms.Panel _panelPlayer2Master;
        private System.Windows.Forms.Label _lblPlaysFirst;
    }
}