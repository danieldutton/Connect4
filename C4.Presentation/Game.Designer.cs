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
            this.panelDropPanels = new System.Windows.Forms.Panel();
            this.panelDrop6 = new System.Windows.Forms.Panel();
            this.panelDrop5 = new System.Windows.Forms.Panel();
            this.panelDrop4 = new System.Windows.Forms.Panel();
            this.panelDrop3 = new System.Windows.Forms.Panel();
            this.panelDrop2 = new System.Windows.Forms.Panel();
            this.panelDrop1 = new System.Windows.Forms.Panel();
            this.panelDrop0 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this._panelYellowTurn = new System.Windows.Forms.Panel();
            this.txtBoxPlayer2 = new System.Windows.Forms.Label();
            this._panelYellowToken = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this._panelRedTurn = new System.Windows.Forms.Panel();
            this.txtBoxPlayer1 = new System.Windows.Forms.Label();
            this._panelRedToken = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelDropPanels.SuspendLayout();
            this.panelYellow.SuspendLayout();
            this.panelRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDropPanels);
            this.panel1.Controls.Add(this.panelGrid);
            this.panel1.Controls.Add(this.panelYellow);
            this.panel1.Controls.Add(this.panelRed);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 303);
            this.panel1.TabIndex = 0;
            // 
            // panelDropPanels
            // 
            this.panelDropPanels.Controls.Add(this.panelDrop6);
            this.panelDropPanels.Controls.Add(this.panelDrop5);
            this.panelDropPanels.Controls.Add(this.panelDrop4);
            this.panelDropPanels.Controls.Add(this.panelDrop3);
            this.panelDropPanels.Controls.Add(this.panelDrop2);
            this.panelDropPanels.Controls.Add(this.panelDrop1);
            this.panelDropPanels.Controls.Add(this.panelDrop0);
            this.panelDropPanels.Location = new System.Drawing.Point(11, 15);
            this.panelDropPanels.Name = "panelDropPanels";
            this.panelDropPanels.Size = new System.Drawing.Size(244, 14);
            this.panelDropPanels.TabIndex = 3;
            // 
            // panelDrop6
            // 
            this.panelDrop6.AllowDrop = true;
            this.panelDrop6.BackColor = System.Drawing.Color.Brown;
            this.panelDrop6.Location = new System.Drawing.Point(210, 3);
            this.panelDrop6.Name = "panelDrop6";
            this.panelDrop6.Size = new System.Drawing.Size(31, 10);
            this.panelDrop6.TabIndex = 6;
            this.panelDrop6.Tag = "6";
            this.panelDrop6.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelDrop5
            // 
            this.panelDrop5.AllowDrop = true;
            this.panelDrop5.BackColor = System.Drawing.Color.Brown;
            this.panelDrop5.Location = new System.Drawing.Point(175, 3);
            this.panelDrop5.Name = "panelDrop5";
            this.panelDrop5.Size = new System.Drawing.Size(31, 10);
            this.panelDrop5.TabIndex = 5;
            this.panelDrop5.Tag = "5";
            this.panelDrop5.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelDrop4
            // 
            this.panelDrop4.AllowDrop = true;
            this.panelDrop4.BackColor = System.Drawing.Color.Brown;
            this.panelDrop4.Location = new System.Drawing.Point(140, 3);
            this.panelDrop4.Name = "panelDrop4";
            this.panelDrop4.Size = new System.Drawing.Size(31, 10);
            this.panelDrop4.TabIndex = 4;
            this.panelDrop4.Tag = "4";
            this.panelDrop4.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelDrop3
            // 
            this.panelDrop3.AllowDrop = true;
            this.panelDrop3.BackColor = System.Drawing.Color.Brown;
            this.panelDrop3.Location = new System.Drawing.Point(105, 3);
            this.panelDrop3.Name = "panelDrop3";
            this.panelDrop3.Size = new System.Drawing.Size(31, 10);
            this.panelDrop3.TabIndex = 0;
            this.panelDrop3.Tag = "3";
            this.panelDrop3.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelDrop2
            // 
            this.panelDrop2.AllowDrop = true;
            this.panelDrop2.BackColor = System.Drawing.Color.Brown;
            this.panelDrop2.Location = new System.Drawing.Point(70, 3);
            this.panelDrop2.Name = "panelDrop2";
            this.panelDrop2.Size = new System.Drawing.Size(31, 10);
            this.panelDrop2.TabIndex = 2;
            this.panelDrop2.Tag = "2";
            this.panelDrop2.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelDrop1
            // 
            this.panelDrop1.AllowDrop = true;
            this.panelDrop1.BackColor = System.Drawing.Color.Brown;
            this.panelDrop1.Location = new System.Drawing.Point(35, 3);
            this.panelDrop1.Name = "panelDrop1";
            this.panelDrop1.Size = new System.Drawing.Size(31, 10);
            this.panelDrop1.TabIndex = 1;
            this.panelDrop1.Tag = "1";
            this.panelDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelDrop0
            // 
            this.panelDrop0.AllowDrop = true;
            this.panelDrop0.BackColor = System.Drawing.Color.Brown;
            this.panelDrop0.Location = new System.Drawing.Point(-2, 3);
            this.panelDrop0.Name = "panelDrop0";
            this.panelDrop0.Size = new System.Drawing.Size(33, 10);
            this.panelDrop0.TabIndex = 0;
            this.panelDrop0.Tag = "0";
            this.panelDrop0.DragDrop += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            this.panelDrop0.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(10, 33);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(244, 205);
            this.panelGrid.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.Controls.Add(this._panelYellowTurn);
            this.panelYellow.Controls.Add(this.txtBoxPlayer2);
            this.panelYellow.Controls.Add(this._panelYellowToken);
            this.panelYellow.Location = new System.Drawing.Point(160, 244);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(94, 59);
            this.panelYellow.TabIndex = 1;
            // 
            // _panelYellowTurn
            // 
            this._panelYellowTurn.BackColor = System.Drawing.Color.White;
            this._panelYellowTurn.Location = new System.Drawing.Point(1, 50);
            this._panelYellowTurn.Name = "_panelYellowTurn";
            this._panelYellowTurn.Size = new System.Drawing.Size(36, 3);
            this._panelYellowTurn.TabIndex = 4;
            // 
            // txtBoxPlayer2
            // 
            this.txtBoxPlayer2.AutoSize = true;
            this.txtBoxPlayer2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer2.ForeColor = System.Drawing.Color.White;
            this.txtBoxPlayer2.Location = new System.Drawing.Point(-2, 9);
            this.txtBoxPlayer2.Name = "txtBoxPlayer2";
            this.txtBoxPlayer2.Size = new System.Drawing.Size(87, 17);
            this.txtBoxPlayer2.TabIndex = 3;
            this.txtBoxPlayer2.Text = "txtBoxPlayer1";
            // 
            // _panelYellowToken
            // 
            this._panelYellowToken.BackColor = System.Drawing.Color.Yellow;
            this._panelYellowToken.Location = new System.Drawing.Point(1, 29);
            this._panelYellowToken.Name = "_panelYellowToken";
            this._panelYellowToken.Size = new System.Drawing.Size(92, 18);
            this._panelYellowToken.TabIndex = 2;
            this._panelYellowToken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DropYellowGameToken_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.Controls.Add(this._panelRedTurn);
            this.panelRed.Controls.Add(this.txtBoxPlayer1);
            this.panelRed.Controls.Add(this._panelRedToken);
            this.panelRed.Location = new System.Drawing.Point(10, 244);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(97, 59);
            this.panelRed.TabIndex = 1;
            // 
            // _panelRedTurn
            // 
            this._panelRedTurn.BackColor = System.Drawing.Color.White;
            this._panelRedTurn.Location = new System.Drawing.Point(1, 50);
            this._panelRedTurn.Name = "_panelRedTurn";
            this._panelRedTurn.Size = new System.Drawing.Size(36, 3);
            this._panelRedTurn.TabIndex = 4;
            // 
            // txtBoxPlayer1
            // 
            this.txtBoxPlayer1.AutoSize = true;
            this.txtBoxPlayer1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPlayer1.ForeColor = System.Drawing.Color.White;
            this.txtBoxPlayer1.Location = new System.Drawing.Point(0, 9);
            this.txtBoxPlayer1.Name = "txtBoxPlayer1";
            this.txtBoxPlayer1.Size = new System.Drawing.Size(87, 17);
            this.txtBoxPlayer1.TabIndex = 3;
            this.txtBoxPlayer1.Text = "txtBoxPlayer1";
            // 
            // _panelRedToken
            // 
            this._panelRedToken.BackColor = System.Drawing.Color.Red;
            this._panelRedToken.Location = new System.Drawing.Point(1, 29);
            this._panelRedToken.Name = "_panelRedToken";
            this._panelRedToken.Size = new System.Drawing.Size(92, 18);
            this._panelRedToken.TabIndex = 2;
            this._panelRedToken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DropRedGameToken_MouseDown);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(266, 305);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(282, 339);
            this.Name = "Game";
            this.Text = "Connect 4";
            this.panel1.ResumeLayout(false);
            this.panelDropPanels.ResumeLayout(false);
            this.panelYellow.ResumeLayout(false);
            this.panelYellow.PerformLayout();
            this.panelRed.ResumeLayout(false);
            this.panelRed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelDropPanels;
        private System.Windows.Forms.Panel panelDrop0;
        private System.Windows.Forms.Panel panelDrop6;
        private System.Windows.Forms.Panel panelDrop5;
        private System.Windows.Forms.Panel panelDrop4;
        private System.Windows.Forms.Panel panelDrop3;
        private System.Windows.Forms.Panel panelDrop2;
        private System.Windows.Forms.Panel panelDrop1;
        private System.Windows.Forms.Panel _panelRedToken;
        private System.Windows.Forms.Panel _panelYellowToken;
        private System.Windows.Forms.Label txtBoxPlayer2;
        private System.Windows.Forms.Label txtBoxPlayer1;
        private System.Windows.Forms.Panel _panelRedTurn;
        private System.Windows.Forms.Panel _panelYellowTurn;
    }
}

