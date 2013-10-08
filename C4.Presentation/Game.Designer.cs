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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this._lblYellowToken = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.lblRedToken = new System.Windows.Forms.Label();
            this._btnStartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelDropPanels = new System.Windows.Forms.Panel();
            this.panelDrop0 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelYellow.SuspendLayout();
            this.panelRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelDropPanels.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDropPanels);
            this.panel1.Controls.Add(this._btnStartGame);
            this.panel1.Controls.Add(this.panelGrid);
            this.panel1.Controls.Add(this.panelYellow);
            this.panel1.Controls.Add(this.panelRed);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 302);
            this.panel1.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(10, 35);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(244, 220);
            this.panelGrid.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.Controls.Add(this._lblYellowToken);
            this.panelYellow.Location = new System.Drawing.Point(160, 261);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(94, 37);
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
            this.panelRed.Location = new System.Drawing.Point(10, 261);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(97, 37);
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
            this.lblRedToken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // _btnStartGame
            // 
            this._btnStartGame.Location = new System.Drawing.Point(113, 272);
            this._btnStartGame.Name = "_btnStartGame";
            this._btnStartGame.Size = new System.Drawing.Size(40, 23);
            this._btnStartGame.TabIndex = 0;
            this._btnStartGame.Text = "Start";
            this._btnStartGame.UseVisualStyleBackColor = true;
            this._btnStartGame.Click += new System.EventHandler(this._btnStartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Location = new System.Drawing.Point(13, 13);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(262, 43);
            this.panelHeader.TabIndex = 1;
            // 
            // panelDropPanels
            // 
            this.panelDropPanels.Controls.Add(this.panel6);
            this.panelDropPanels.Controls.Add(this.panel5);
            this.panelDropPanels.Controls.Add(this.panel4);
            this.panelDropPanels.Controls.Add(this.panel3);
            this.panelDropPanels.Controls.Add(this.panel2);
            this.panelDropPanels.Controls.Add(this.panelDrop0);
            this.panelDropPanels.Location = new System.Drawing.Point(10, 4);
            this.panelDropPanels.Name = "panelDropPanels";
            this.panelDropPanels.Size = new System.Drawing.Size(244, 25);
            this.panelDropPanels.TabIndex = 3;
            // 
            // panelDrop0
            // 
            this.panelDrop0.AllowDrop = true;
            this.panelDrop0.BackColor = System.Drawing.Color.Brown;
            this.panelDrop0.Location = new System.Drawing.Point(4, 3);
            this.panelDrop0.Name = "panelDrop0";
            this.panelDrop0.Size = new System.Drawing.Size(27, 10);
            this.panelDrop0.TabIndex = 0;
            this.panelDrop0.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop0_DragEnter);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(37, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 10);
            this.panel2.TabIndex = 0;
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop0_DragEnter);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(70, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 10);
            this.panel3.TabIndex = 0;
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop0_DragEnter);
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Location = new System.Drawing.Point(103, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 10);
            this.panel4.TabIndex = 0;
            this.panel4.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop0_DragEnter);
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Location = new System.Drawing.Point(136, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(27, 10);
            this.panel5.TabIndex = 0;
            this.panel5.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop0_DragEnter);
            // 
            // panel6
            // 
            this.panel6.AllowDrop = true;
            this.panel6.BackColor = System.Drawing.Color.Brown;
            this.panel6.Location = new System.Drawing.Point(169, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(27, 10);
            this.panel6.TabIndex = 0;
            this.panel6.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop0_DragEnter);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(271, 369);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelYellow.ResumeLayout(false);
            this.panelYellow.PerformLayout();
            this.panelRed.ResumeLayout(false);
            this.panelRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelDropPanels.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDropPanels;
        private System.Windows.Forms.Panel panelDrop0;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

