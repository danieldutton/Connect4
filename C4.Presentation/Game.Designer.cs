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
            this._panelYellowToken = new System.Windows.Forms.Panel();
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
            this._lblPlayerYellow = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this._panelRedToken = new System.Windows.Forms.Panel();
            this._lblPlayerRed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelDropPanels.SuspendLayout();
            this.panelYellow.SuspendLayout();
            this.panelRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._panelYellowToken);
            this.panel1.Controls.Add(this.panelDropPanels);
            this.panel1.Controls.Add(this.panelGrid);
            this.panel1.Controls.Add(this.panelYellow);
            this.panel1.Controls.Add(this.panelRed);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 302);
            this.panel1.TabIndex = 0;
            // 
            // _panelYellowToken
            // 
            this._panelYellowToken.BackColor = System.Drawing.Color.Yellow;
            this._panelYellowToken.Location = new System.Drawing.Point(160, 279);
            this._panelYellowToken.Name = "_panelYellowToken";
            this._panelYellowToken.Size = new System.Drawing.Size(91, 19);
            this._panelYellowToken.TabIndex = 2;
            this._panelYellowToken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DropYellowGameToken_MouseDown);
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
            this.panelDrop6.Size = new System.Drawing.Size(30, 10);
            this.panelDrop6.TabIndex = 6;
            this.panelDrop6.Tag = "6";
            this.panelDrop6.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelDrop5
            // 
            this.panelDrop5.AllowDrop = true;
            this.panelDrop5.BackColor = System.Drawing.Color.Brown;
            this.panelDrop5.Location = new System.Drawing.Point(175, 3);
            this.panelDrop5.Name = "panelDrop5";
            this.panelDrop5.Size = new System.Drawing.Size(30, 10);
            this.panelDrop5.TabIndex = 5;
            this.panelDrop5.Tag = "5";
            this.panelDrop5.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelDrop4
            // 
            this.panelDrop4.AllowDrop = true;
            this.panelDrop4.BackColor = System.Drawing.Color.Brown;
            this.panelDrop4.Location = new System.Drawing.Point(140, 3);
            this.panelDrop4.Name = "panelDrop4";
            this.panelDrop4.Size = new System.Drawing.Size(30, 10);
            this.panelDrop4.TabIndex = 4;
            this.panelDrop4.Tag = "4";
            this.panelDrop4.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelDrop3
            // 
            this.panelDrop3.AllowDrop = true;
            this.panelDrop3.BackColor = System.Drawing.Color.Brown;
            this.panelDrop3.Location = new System.Drawing.Point(105, 3);
            this.panelDrop3.Name = "panelDrop3";
            this.panelDrop3.Size = new System.Drawing.Size(30, 10);
            this.panelDrop3.TabIndex = 0;
            this.panelDrop3.Tag = "3";
            this.panelDrop3.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelDrop2
            // 
            this.panelDrop2.AllowDrop = true;
            this.panelDrop2.BackColor = System.Drawing.Color.Brown;
            this.panelDrop2.Location = new System.Drawing.Point(70, 3);
            this.panelDrop2.Name = "panelDrop2";
            this.panelDrop2.Size = new System.Drawing.Size(30, 10);
            this.panelDrop2.TabIndex = 2;
            this.panelDrop2.Tag = "2";
            this.panelDrop2.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelDrop1
            // 
            this.panelDrop1.AllowDrop = true;
            this.panelDrop1.BackColor = System.Drawing.Color.Brown;
            this.panelDrop1.Location = new System.Drawing.Point(35, 3);
            this.panelDrop1.Name = "panelDrop1";
            this.panelDrop1.Size = new System.Drawing.Size(30, 10);
            this.panelDrop1.TabIndex = 1;
            this.panelDrop1.Tag = "1";
            this.panelDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelDrop0
            // 
            this.panelDrop0.AllowDrop = true;
            this.panelDrop0.BackColor = System.Drawing.Color.Brown;
            this.panelDrop0.Location = new System.Drawing.Point(1, 3);
            this.panelDrop0.Name = "panelDrop0";
            this.panelDrop0.Size = new System.Drawing.Size(30, 10);
            this.panelDrop0.TabIndex = 0;
            this.panelDrop0.Tag = "0";
            this.panelDrop0.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameTokenToSlot_DragEnter);
            // 
            // panelGrid
            // 
            this.panelGrid.Location = new System.Drawing.Point(10, 33);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(244, 220);
            this.panelGrid.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.Controls.Add(this._lblPlayerYellow);
            this.panelYellow.Location = new System.Drawing.Point(160, 251);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(94, 47);
            this.panelYellow.TabIndex = 1;
            // 
            // _lblPlayerYellow
            // 
            this._lblPlayerYellow.AutoSize = true;
            this._lblPlayerYellow.Location = new System.Drawing.Point(4, 5);
            this._lblPlayerYellow.Name = "_lblPlayerYellow";
            this._lblPlayerYellow.Size = new System.Drawing.Size(0, 13);
            this._lblPlayerYellow.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.Controls.Add(this._panelRedToken);
            this.panelRed.Controls.Add(this._lblPlayerRed);
            this.panelRed.Location = new System.Drawing.Point(10, 251);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(97, 47);
            this.panelRed.TabIndex = 1;
            // 
            // _panelRedToken
            // 
            this._panelRedToken.BackColor = System.Drawing.Color.Red;
            this._panelRedToken.Location = new System.Drawing.Point(2, 28);
            this._panelRedToken.Name = "_panelRedToken";
            this._panelRedToken.Size = new System.Drawing.Size(92, 18);
            this._panelRedToken.TabIndex = 2;
            this._panelRedToken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DropRedGameToken_MouseDown);
            // 
            // _lblPlayerRed
            // 
            this._lblPlayerRed.AutoSize = true;
            this._lblPlayerRed.Location = new System.Drawing.Point(3, 5);
            this._lblPlayerRed.Name = "_lblPlayerRed";
            this._lblPlayerRed.Size = new System.Drawing.Size(0, 13);
            this._lblPlayerRed.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Location = new System.Drawing.Point(-4, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(279, 57);
            this.panelHeader.TabIndex = 1;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(271, 369);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelDropPanels.ResumeLayout(false);
            this.panelYellow.ResumeLayout(false);
            this.panelYellow.PerformLayout();
            this.panelRed.ResumeLayout(false);
            this.panelRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDropPanels;
        private System.Windows.Forms.Panel panelDrop0;
        private System.Windows.Forms.Panel panelDrop6;
        private System.Windows.Forms.Panel panelDrop5;
        private System.Windows.Forms.Panel panelDrop4;
        private System.Windows.Forms.Panel panelDrop3;
        private System.Windows.Forms.Panel panelDrop2;
        private System.Windows.Forms.Panel panelDrop1;
        private System.Windows.Forms.Label _lblPlayerYellow;
        private System.Windows.Forms.Label _lblPlayerRed;
        private System.Windows.Forms.Panel _panelRedToken;
        private System.Windows.Forms.Panel _panelYellowToken;
    }
}

