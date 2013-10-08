namespace C4.Presentation
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this._lblYellowToken = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.lblRedToken = new System.Windows.Forms.Label();
            this._btnStartGame = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelYellow.SuspendLayout();
            this.panelRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelGrid);
            this.panel1.Controls.Add(this.panelYellow);
            this.panel1.Controls.Add(this.panelRed);
            this.panel1.Controls.Add(this._btnStartGame);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 317);
            this.panel1.TabIndex = 0;
            // 
            // panelYellow
            // 
            this.panelYellow.Controls.Add(this._lblYellowToken);
            this.panelYellow.Location = new System.Drawing.Point(263, 277);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(200, 37);
            this.panelYellow.TabIndex = 1;
            // 
            // _lblYellowToken
            // 
            this._lblYellowToken.AutoSize = true;
            this._lblYellowToken.Location = new System.Drawing.Point(4, 20);
            this._lblYellowToken.Name = "_lblYellowToken";
            this._lblYellowToken.Size = new System.Drawing.Size(38, 13);
            this._lblYellowToken.TabIndex = 0;
            this._lblYellowToken.Text = "Yellow";
            // 
            // panelRed
            // 
            this.panelRed.Controls.Add(this.lblRedToken);
            this.panelRed.Location = new System.Drawing.Point(3, 277);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(200, 37);
            this.panelRed.TabIndex = 1;
            // 
            // lblRedToken
            // 
            this.lblRedToken.AutoSize = true;
            this.lblRedToken.Location = new System.Drawing.Point(4, 21);
            this.lblRedToken.Name = "lblRedToken";
            this.lblRedToken.Size = new System.Drawing.Size(27, 13);
            this.lblRedToken.TabIndex = 0;
            this.lblRedToken.Text = "Red";
            // 
            // _btnStartGame
            // 
            this._btnStartGame.Location = new System.Drawing.Point(183, 3);
            this._btnStartGame.Name = "_btnStartGame";
            this._btnStartGame.Size = new System.Drawing.Size(75, 23);
            this._btnStartGame.TabIndex = 0;
            this._btnStartGame.Text = "Start";
            this._btnStartGame.UseVisualStyleBackColor = true;
            this._btnStartGame.Click += new System.EventHandler(this._btnStartGame_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(10, 24);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(444, 247);
            this.panelGrid.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 342);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelYellow.ResumeLayout(false);
            this.panelYellow.PerformLayout();
            this.panelRed.ResumeLayout(false);
            this.panelRed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnStartGame;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label _lblYellowToken;
        private System.Windows.Forms.Label lblRedToken;
        private System.Windows.Forms.Panel panelGrid;
    }
}

