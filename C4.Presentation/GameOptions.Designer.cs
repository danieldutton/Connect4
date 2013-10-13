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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOptions));
            this._lblPlayer1 = new System.Windows.Forms.Label();
            this._lblPlayer2 = new System.Windows.Forms.Label();
            this._txtBoxYellowPlayer = new System.Windows.Forms.TextBox();
            this._txtBoxRedPlayer = new System.Windows.Forms.TextBox();
            this._panelYellowSquare = new System.Windows.Forms.Panel();
            this._panelRedSquare = new System.Windows.Forms.Panel();
            this._btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._rdoButtonRedStart = new System.Windows.Forms.RadioButton();
            this._rdoButtonYellowStart = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this._lblPlayer1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPlayer1.ForeColor = System.Drawing.Color.White;
            this._lblPlayer1.Location = new System.Drawing.Point(31, 7);
            this._lblPlayer1.Name = "_lblPlayer1";
            this._lblPlayer1.Size = new System.Drawing.Size(55, 16);
            this._lblPlayer1.TabIndex = 0;
            this._lblPlayer1.Text = "Player 1";
            // 
            // _lblPlayer2
            // 
            this._lblPlayer2.AutoSize = true;
            this._lblPlayer2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPlayer2.ForeColor = System.Drawing.Color.White;
            this._lblPlayer2.Location = new System.Drawing.Point(31, 7);
            this._lblPlayer2.Name = "_lblPlayer2";
            this._lblPlayer2.Size = new System.Drawing.Size(55, 16);
            this._lblPlayer2.TabIndex = 1;
            this._lblPlayer2.Text = "Player 2";
            // 
            // _txtBoxYellowPlayer
            // 
            this._txtBoxYellowPlayer.Location = new System.Drawing.Point(92, 7);
            this._txtBoxYellowPlayer.Name = "_txtBoxYellowPlayer";
            this._txtBoxYellowPlayer.Size = new System.Drawing.Size(125, 20);
            this._txtBoxYellowPlayer.TabIndex = 2;
            // 
            // _txtBoxRedPlayer
            // 
            this._txtBoxRedPlayer.Location = new System.Drawing.Point(92, 6);
            this._txtBoxRedPlayer.Name = "_txtBoxRedPlayer";
            this._txtBoxRedPlayer.Size = new System.Drawing.Size(125, 20);
            this._txtBoxRedPlayer.TabIndex = 3;
            // 
            // _panelYellowSquare
            // 
            this._panelYellowSquare.BackColor = System.Drawing.Color.Yellow;
            this._panelYellowSquare.ForeColor = System.Drawing.Color.Yellow;
            this._panelYellowSquare.Location = new System.Drawing.Point(3, 7);
            this._panelYellowSquare.Name = "_panelYellowSquare";
            this._panelYellowSquare.Size = new System.Drawing.Size(22, 20);
            this._panelYellowSquare.TabIndex = 4;
            // 
            // _panelRedSquare
            // 
            this._panelRedSquare.BackColor = System.Drawing.Color.Red;
            this._panelRedSquare.Location = new System.Drawing.Point(3, 6);
            this._panelRedSquare.Name = "_panelRedSquare";
            this._panelRedSquare.Size = new System.Drawing.Size(22, 20);
            this._panelRedSquare.TabIndex = 5;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.Location = new System.Drawing.Point(104, 99);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 23);
            this._btnConfirm.TabIndex = 6;
            this._btnConfirm.Text = "Start";
            this._btnConfirm.UseVisualStyleBackColor = true;
            this._btnConfirm.Click += new System.EventHandler(this.ConfirmPlayers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._rdoButtonRedStart);
            this.panel1.Controls.Add(this._rdoButtonYellowStart);
            this.panel1.Location = new System.Drawing.Point(244, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 75);
            this.panel1.TabIndex = 7;
            // 
            // _rdoButtonRedStart
            // 
            this._rdoButtonRedStart.AutoSize = true;
            this._rdoButtonRedStart.Location = new System.Drawing.Point(3, 50);
            this._rdoButtonRedStart.Name = "_rdoButtonRedStart";
            this._rdoButtonRedStart.Size = new System.Drawing.Size(14, 13);
            this._rdoButtonRedStart.TabIndex = 1;
            this._rdoButtonRedStart.UseVisualStyleBackColor = true;
            // 
            // _rdoButtonYellowStart
            // 
            this._rdoButtonYellowStart.AutoSize = true;
            this._rdoButtonYellowStart.Checked = true;
            this._rdoButtonYellowStart.Location = new System.Drawing.Point(3, 10);
            this._rdoButtonYellowStart.Name = "_rdoButtonYellowStart";
            this._rdoButtonYellowStart.Size = new System.Drawing.Size(14, 13);
            this._rdoButtonYellowStart.TabIndex = 0;
            this._rdoButtonYellowStart.TabStop = true;
            this._rdoButtonYellowStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Turn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._panelYellowSquare);
            this.panel2.Controls.Add(this._lblPlayer1);
            this.panel2.Controls.Add(this._txtBoxYellowPlayer);
            this.panel2.Location = new System.Drawing.Point(12, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 34);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._panelRedSquare);
            this.panel3.Controls.Add(this._lblPlayer2);
            this.panel3.Controls.Add(this._txtBoxRedPlayer);
            this.panel3.Location = new System.Drawing.Point(12, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 34);
            this.panel3.TabIndex = 10;
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(292, 129);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._btnConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOptions";
            this.Text = "GameOptions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblPlayer1;
        private System.Windows.Forms.Label _lblPlayer2;
        private System.Windows.Forms.TextBox _txtBoxYellowPlayer;
        private System.Windows.Forms.TextBox _txtBoxRedPlayer;
        private System.Windows.Forms.Panel _panelYellowSquare;
        private System.Windows.Forms.Panel _panelRedSquare;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton _rdoButtonRedStart;
        private System.Windows.Forms.RadioButton _rdoButtonYellowStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}