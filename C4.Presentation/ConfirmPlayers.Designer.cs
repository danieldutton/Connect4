namespace C4.Presentation
{
    partial class ConfirmPlayers
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
            this._txtBoxYellowPlayerName = new System.Windows.Forms.TextBox();
            this._txtBoxRedPlayerName = new System.Windows.Forms.TextBox();
            this._panelYellowSquare = new System.Windows.Forms.Panel();
            this._panelRedSquare = new System.Windows.Forms.Panel();
            this._btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._rdoBtnRedPlayerStart = new System.Windows.Forms.RadioButton();
            this._rdoBtnYellowPlayerStart = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblPlayer1
            // 
            this._lblPlayer1.AutoSize = true;
            this._lblPlayer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPlayer1.ForeColor = System.Drawing.Color.White;
            this._lblPlayer1.Location = new System.Drawing.Point(27, 9);
            this._lblPlayer1.Name = "_lblPlayer1";
            this._lblPlayer1.Size = new System.Drawing.Size(56, 14);
            this._lblPlayer1.TabIndex = 0;
            this._lblPlayer1.Text = "Player 1";
            // 
            // _lblPlayer2
            // 
            this._lblPlayer2.AutoSize = true;
            this._lblPlayer2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPlayer2.ForeColor = System.Drawing.Color.White;
            this._lblPlayer2.Location = new System.Drawing.Point(27, 8);
            this._lblPlayer2.Name = "_lblPlayer2";
            this._lblPlayer2.Size = new System.Drawing.Size(56, 14);
            this._lblPlayer2.TabIndex = 1;
            this._lblPlayer2.Text = "Player 2";
            // 
            // _txtBoxYellowPlayerName
            // 
            this._txtBoxYellowPlayerName.BackColor = System.Drawing.Color.White;
            this._txtBoxYellowPlayerName.Location = new System.Drawing.Point(89, 7);
            this._txtBoxYellowPlayerName.Name = "_txtBoxYellowPlayerName";
            this._txtBoxYellowPlayerName.Size = new System.Drawing.Size(133, 20);
            this._txtBoxYellowPlayerName.TabIndex = 2;
            // 
            // _txtBoxRedPlayerName
            // 
            this._txtBoxRedPlayerName.BackColor = System.Drawing.Color.White;
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
            this._btnConfirm.Location = new System.Drawing.Point(95, 80);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 23);
            this._btnConfirm.TabIndex = 6;
            this._btnConfirm.Text = "Start";
            this._btnConfirm.UseVisualStyleBackColor = false;
            this._btnConfirm.Click += new System.EventHandler(this.ConfirmPlayers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._rdoBtnRedPlayerStart);
            this.panel1.Controls.Add(this._rdoBtnYellowPlayerStart);
            this.panel1.Location = new System.Drawing.Point(230, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 69);
            this.panel1.TabIndex = 7;
            // 
            // _rdoBtnRedPlayerStart
            // 
            this._rdoBtnRedPlayerStart.AutoSize = true;
            this._rdoBtnRedPlayerStart.Location = new System.Drawing.Point(5, 45);
            this._rdoBtnRedPlayerStart.Name = "_rdoBtnRedPlayerStart";
            this._rdoBtnRedPlayerStart.Size = new System.Drawing.Size(14, 13);
            this._rdoBtnRedPlayerStart.TabIndex = 1;
            this._rdoBtnRedPlayerStart.UseVisualStyleBackColor = true;
            // 
            // _rdoBtnYellowPlayerStart
            // 
            this._rdoBtnYellowPlayerStart.AutoSize = true;
            this._rdoBtnYellowPlayerStart.Checked = true;
            this._rdoBtnYellowPlayerStart.Location = new System.Drawing.Point(5, 10);
            this._rdoBtnYellowPlayerStart.Name = "_rdoBtnYellowPlayerStart";
            this._rdoBtnYellowPlayerStart.Size = new System.Drawing.Size(14, 13);
            this._rdoBtnYellowPlayerStart.TabIndex = 0;
            this._rdoBtnYellowPlayerStart.TabStop = true;
            this._rdoBtnYellowPlayerStart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._panelYellowSquare);
            this.panel2.Controls.Add(this._lblPlayer1);
            this.panel2.Controls.Add(this._txtBoxYellowPlayerName);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 34);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._panelRedSquare);
            this.panel3.Controls.Add(this._lblPlayer2);
            this.panel3.Controls.Add(this._txtBoxRedPlayerName);
            this.panel3.Location = new System.Drawing.Point(2, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 34);
            this.panel3.TabIndex = 10;
            // 
            // ConfirmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(261, 115);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(277, 149);
            this.Name = "ConfirmPlayers";
            this.Text = "Confirm Players";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCrossClicked_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblPlayer1;
        private System.Windows.Forms.Label _lblPlayer2;
        private System.Windows.Forms.TextBox _txtBoxYellowPlayerName;
        private System.Windows.Forms.TextBox _txtBoxRedPlayerName;
        private System.Windows.Forms.Panel _panelYellowSquare;
        private System.Windows.Forms.Panel _panelRedSquare;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton _rdoBtnRedPlayerStart;
        private System.Windows.Forms.RadioButton _rdoBtnYellowPlayerStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}