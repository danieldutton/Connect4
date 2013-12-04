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
            this._panelMaster = new System.Windows.Forms.Panel();
            this._panelColumns = new System.Windows.Forms.Panel();
            this._panelDrop6 = new System.Windows.Forms.Panel();
            this._panelDrop5 = new System.Windows.Forms.Panel();
            this._panelDrop4 = new System.Windows.Forms.Panel();
            this._panelDrop3 = new System.Windows.Forms.Panel();
            this._panelDrop2 = new System.Windows.Forms.Panel();
            this._panelDrop1 = new System.Windows.Forms.Panel();
            this._panelDrop0 = new System.Windows.Forms.Panel();
            this._panelGameGrid = new System.Windows.Forms.Panel();
            this._panelYellowMaster = new System.Windows.Forms.Panel();
            this._panelYellowTurn = new System.Windows.Forms.Panel();
            this._lblBoxPlayer2 = new System.Windows.Forms.Label();
            this._panelYellowToken = new System.Windows.Forms.Panel();
            this._panelRedMaster = new System.Windows.Forms.Panel();
            this._panelRedTurn = new System.Windows.Forms.Panel();
            this._lblPlayer1 = new System.Windows.Forms.Label();
            this._panelRedToken = new System.Windows.Forms.Panel();
            this._panelMaster.SuspendLayout();
            this._panelColumns.SuspendLayout();
            this._panelYellowMaster.SuspendLayout();
            this._panelRedMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMaster
            // 
            this._panelMaster.Controls.Add(this._panelColumns);
            this._panelMaster.Controls.Add(this._panelGameGrid);
            this._panelMaster.Controls.Add(this._panelYellowMaster);
            this._panelMaster.Controls.Add(this._panelRedMaster);
            this._panelMaster.Location = new System.Drawing.Point(1, 1);
            this._panelMaster.Name = "_panelMaster";
            this._panelMaster.Size = new System.Drawing.Size(264, 303);
            this._panelMaster.TabIndex = 0;
            // 
            // _panelColumns
            // 
            this._panelColumns.Controls.Add(this._panelDrop6);
            this._panelColumns.Controls.Add(this._panelDrop5);
            this._panelColumns.Controls.Add(this._panelDrop4);
            this._panelColumns.Controls.Add(this._panelDrop3);
            this._panelColumns.Controls.Add(this._panelDrop2);
            this._panelColumns.Controls.Add(this._panelDrop1);
            this._panelColumns.Controls.Add(this._panelDrop0);
            this._panelColumns.Location = new System.Drawing.Point(11, 15);
            this._panelColumns.Name = "_panelColumns";
            this._panelColumns.Size = new System.Drawing.Size(244, 14);
            this._panelColumns.TabIndex = 3;
            // 
            // _panelDrop6
            // 
            this._panelDrop6.AllowDrop = true;
            this._panelDrop6.BackColor = System.Drawing.Color.Brown;
            this._panelDrop6.Location = new System.Drawing.Point(210, 3);
            this._panelDrop6.Name = "_panelDrop6";
            this._panelDrop6.Size = new System.Drawing.Size(31, 10);
            this._panelDrop6.TabIndex = 6;
            this._panelDrop6.Tag = "6";
            this._panelDrop6.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelDrop5
            // 
            this._panelDrop5.AllowDrop = true;
            this._panelDrop5.BackColor = System.Drawing.Color.Brown;
            this._panelDrop5.Location = new System.Drawing.Point(175, 3);
            this._panelDrop5.Name = "_panelDrop5";
            this._panelDrop5.Size = new System.Drawing.Size(31, 10);
            this._panelDrop5.TabIndex = 5;
            this._panelDrop5.Tag = "5";
            this._panelDrop5.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelDrop4
            // 
            this._panelDrop4.AllowDrop = true;
            this._panelDrop4.BackColor = System.Drawing.Color.Brown;
            this._panelDrop4.Location = new System.Drawing.Point(140, 3);
            this._panelDrop4.Name = "_panelDrop4";
            this._panelDrop4.Size = new System.Drawing.Size(31, 10);
            this._panelDrop4.TabIndex = 4;
            this._panelDrop4.Tag = "4";
            this._panelDrop4.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelDrop3
            // 
            this._panelDrop3.AllowDrop = true;
            this._panelDrop3.BackColor = System.Drawing.Color.Brown;
            this._panelDrop3.Location = new System.Drawing.Point(105, 3);
            this._panelDrop3.Name = "_panelDrop3";
            this._panelDrop3.Size = new System.Drawing.Size(31, 10);
            this._panelDrop3.TabIndex = 0;
            this._panelDrop3.Tag = "3";
            this._panelDrop3.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelDrop2
            // 
            this._panelDrop2.AllowDrop = true;
            this._panelDrop2.BackColor = System.Drawing.Color.Brown;
            this._panelDrop2.Location = new System.Drawing.Point(70, 3);
            this._panelDrop2.Name = "_panelDrop2";
            this._panelDrop2.Size = new System.Drawing.Size(31, 10);
            this._panelDrop2.TabIndex = 2;
            this._panelDrop2.Tag = "2";
            this._panelDrop2.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelDrop1
            // 
            this._panelDrop1.AllowDrop = true;
            this._panelDrop1.BackColor = System.Drawing.Color.Brown;
            this._panelDrop1.Location = new System.Drawing.Point(35, 3);
            this._panelDrop1.Name = "_panelDrop1";
            this._panelDrop1.Size = new System.Drawing.Size(31, 10);
            this._panelDrop1.TabIndex = 1;
            this._panelDrop1.Tag = "1";
            this._panelDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelDrop0
            // 
            this._panelDrop0.AllowDrop = true;
            this._panelDrop0.BackColor = System.Drawing.Color.Brown;
            this._panelDrop0.Location = new System.Drawing.Point(-2, 3);
            this._panelDrop0.Name = "_panelDrop0";
            this._panelDrop0.Size = new System.Drawing.Size(33, 10);
            this._panelDrop0.TabIndex = 0;
            this._panelDrop0.Tag = "0";
            this._panelDrop0.DragDrop += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            this._panelDrop0.DragEnter += new System.Windows.Forms.DragEventHandler(this.GameToken_DragDrop);
            // 
            // _panelGameGrid
            // 
            this._panelGameGrid.Location = new System.Drawing.Point(10, 33);
            this._panelGameGrid.Name = "_panelGameGrid";
            this._panelGameGrid.Size = new System.Drawing.Size(244, 205);
            this._panelGameGrid.TabIndex = 2;
            // 
            // _panelYellowMaster
            // 
            this._panelYellowMaster.Controls.Add(this._panelYellowTurn);
            this._panelYellowMaster.Controls.Add(this._lblBoxPlayer2);
            this._panelYellowMaster.Controls.Add(this._panelYellowToken);
            this._panelYellowMaster.Location = new System.Drawing.Point(160, 244);
            this._panelYellowMaster.Name = "_panelYellowMaster";
            this._panelYellowMaster.Size = new System.Drawing.Size(94, 59);
            this._panelYellowMaster.TabIndex = 1;
            // 
            // _panelYellowTurn
            // 
            this._panelYellowTurn.BackColor = System.Drawing.Color.White;
            this._panelYellowTurn.Location = new System.Drawing.Point(1, 50);
            this._panelYellowTurn.Name = "_panelYellowTurn";
            this._panelYellowTurn.Size = new System.Drawing.Size(36, 3);
            this._panelYellowTurn.TabIndex = 4;
            // 
            // _lblBoxPlayer2
            // 
            this._lblBoxPlayer2.AutoSize = true;
            this._lblBoxPlayer2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBoxPlayer2.ForeColor = System.Drawing.Color.White;
            this._lblBoxPlayer2.Location = new System.Drawing.Point(-2, 9);
            this._lblBoxPlayer2.Name = "_lblBoxPlayer2";
            this._lblBoxPlayer2.Size = new System.Drawing.Size(87, 17);
            this._lblBoxPlayer2.TabIndex = 3;
            this._lblBoxPlayer2.Text = "txtBoxPlayer1";
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
            // _panelRedMaster
            // 
            this._panelRedMaster.Controls.Add(this._panelRedTurn);
            this._panelRedMaster.Controls.Add(this._lblPlayer1);
            this._panelRedMaster.Controls.Add(this._panelRedToken);
            this._panelRedMaster.Location = new System.Drawing.Point(10, 244);
            this._panelRedMaster.Name = "_panelRedMaster";
            this._panelRedMaster.Size = new System.Drawing.Size(97, 59);
            this._panelRedMaster.TabIndex = 1;
            // 
            // _panelRedTurn
            // 
            this._panelRedTurn.BackColor = System.Drawing.Color.White;
            this._panelRedTurn.Location = new System.Drawing.Point(1, 50);
            this._panelRedTurn.Name = "_panelRedTurn";
            this._panelRedTurn.Size = new System.Drawing.Size(36, 3);
            this._panelRedTurn.TabIndex = 4;
            // 
            // _lblPlayer1
            // 
            this._lblPlayer1.AutoSize = true;
            this._lblPlayer1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblPlayer1.ForeColor = System.Drawing.Color.White;
            this._lblPlayer1.Location = new System.Drawing.Point(0, 9);
            this._lblPlayer1.Name = "_lblPlayer1";
            this._lblPlayer1.Size = new System.Drawing.Size(87, 17);
            this._lblPlayer1.TabIndex = 3;
            this._lblPlayer1.Text = "txtBoxPlayer1";
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
            this.Controls.Add(this._panelMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(282, 339);
            this.Name = "Game";
            this.Text = "Connect 4";
            this._panelMaster.ResumeLayout(false);
            this._panelColumns.ResumeLayout(false);
            this._panelYellowMaster.ResumeLayout(false);
            this._panelYellowMaster.PerformLayout();
            this._panelRedMaster.ResumeLayout(false);
            this._panelRedMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelMaster;
        private System.Windows.Forms.Panel _panelYellowMaster;
        private System.Windows.Forms.Panel _panelRedMaster;
        private System.Windows.Forms.Panel _panelGameGrid;
        private System.Windows.Forms.Panel _panelColumns;
        private System.Windows.Forms.Panel _panelDrop0;
        private System.Windows.Forms.Panel _panelDrop6;
        private System.Windows.Forms.Panel _panelDrop5;
        private System.Windows.Forms.Panel _panelDrop4;
        private System.Windows.Forms.Panel _panelDrop3;
        private System.Windows.Forms.Panel _panelDrop2;
        private System.Windows.Forms.Panel _panelDrop1;
        private System.Windows.Forms.Panel _panelRedToken;
        private System.Windows.Forms.Panel _panelYellowToken;
        private System.Windows.Forms.Label _lblBoxPlayer2;
        private System.Windows.Forms.Label _lblPlayer1;
        private System.Windows.Forms.Panel _panelRedTurn;
        private System.Windows.Forms.Panel _panelYellowTurn;
    }
}

