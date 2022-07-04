
namespace Minesweeper
{
    partial class frmMinersweeper
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMinersweeper));
            this.tlpGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.nudSizeBoard = new System.Windows.Forms.NumericUpDown();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pcbClock = new System.Windows.Forms.PictureBox();
            this.lblNumberFlag = new System.Windows.Forms.Label();
            this.pcbFlag = new System.Windows.Forms.PictureBox();
            this.lblBombsLimits = new System.Windows.Forms.Label();
            this.lblSizeLimits = new System.Windows.Forms.Label();
            this.lblSizeBoard = new System.Windows.Forms.Label();
            this.lblBombs = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pcbBombs = new System.Windows.Forms.PictureBox();
            this.pcbSizeBoard = new System.Windows.Forms.PictureBox();
            this.nudBombs = new System.Windows.Forms.NumericUpDown();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.helpMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMines = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSizeBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBombs)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.helpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGrid
            // 
            this.tlpGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGrid.ColumnCount = 2;
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrid.Location = new System.Drawing.Point(79, 41);
            this.tlpGrid.Name = "tlpGrid";
            this.tlpGrid.RowCount = 2;
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGrid.Size = new System.Drawing.Size(3, 3);
            this.tlpGrid.TabIndex = 0;
            this.tlpGrid.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.nudSizeBoard);
            this.pnlMenu.Controls.Add(this.lblTimer);
            this.pnlMenu.Controls.Add(this.pcbClock);
            this.pnlMenu.Controls.Add(this.lblNumberFlag);
            this.pnlMenu.Controls.Add(this.pcbFlag);
            this.pnlMenu.Controls.Add(this.lblBombsLimits);
            this.pnlMenu.Controls.Add(this.lblSizeLimits);
            this.pnlMenu.Controls.Add(this.lblSizeBoard);
            this.pnlMenu.Controls.Add(this.lblBombs);
            this.pnlMenu.Controls.Add(this.btnNewGame);
            this.pnlMenu.Controls.Add(this.pcbBombs);
            this.pnlMenu.Controls.Add(this.pcbSizeBoard);
            this.pnlMenu.Controls.Add(this.nudBombs);
            this.pnlMenu.Location = new System.Drawing.Point(12, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 412);
            this.pnlMenu.TabIndex = 1;
            // 
            // nudSizeBoard
            // 
            this.nudSizeBoard.BackColor = System.Drawing.SystemColors.Control;
            this.nudSizeBoard.Location = new System.Drawing.Point(140, 71);
            this.nudSizeBoard.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudSizeBoard.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudSizeBoard.Name = "nudSizeBoard";
            this.nudSizeBoard.Size = new System.Drawing.Size(69, 20);
            this.nudSizeBoard.TabIndex = 12;
            this.nudSizeBoard.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(177, 312);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(35, 13);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "label1";
            // 
            // pcbClock
            // 
            this.pcbClock.Image = global::Minesweeper.Properties.Resources.clock;
            this.pcbClock.Location = new System.Drawing.Point(125, 296);
            this.pcbClock.Name = "pcbClock";
            this.pcbClock.Size = new System.Drawing.Size(46, 48);
            this.pcbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbClock.TabIndex = 11;
            this.pcbClock.TabStop = false;
            // 
            // lblNumberFlag
            // 
            this.lblNumberFlag.AutoSize = true;
            this.lblNumberFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberFlag.Location = new System.Drawing.Point(67, 312);
            this.lblNumberFlag.Name = "lblNumberFlag";
            this.lblNumberFlag.Size = new System.Drawing.Size(35, 13);
            this.lblNumberFlag.TabIndex = 10;
            this.lblNumberFlag.Text = "label1";
            this.lblNumberFlag.Click += new System.EventHandler(this.lblNumberFlag_Click);
            // 
            // pcbFlag
            // 
            this.pcbFlag.Image = global::Minesweeper.Properties.Resources.flag;
            this.pcbFlag.Location = new System.Drawing.Point(15, 296);
            this.pcbFlag.Name = "pcbFlag";
            this.pcbFlag.Size = new System.Drawing.Size(46, 48);
            this.pcbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFlag.TabIndex = 9;
            this.pcbFlag.TabStop = false;
            // 
            // lblBombsLimits
            // 
            this.lblBombsLimits.AutoSize = true;
            this.lblBombsLimits.Location = new System.Drawing.Point(137, 190);
            this.lblBombsLimits.Name = "lblBombsLimits";
            this.lblBombsLimits.Size = new System.Drawing.Size(34, 13);
            this.lblBombsLimits.TabIndex = 8;
            this.lblBombsLimits.Text = "[9-35]";
            // 
            // lblSizeLimits
            // 
            this.lblSizeLimits.AutoSize = true;
            this.lblSizeLimits.Location = new System.Drawing.Point(137, 41);
            this.lblSizeLimits.Name = "lblSizeLimits";
            this.lblSizeLimits.Size = new System.Drawing.Size(34, 13);
            this.lblSizeLimits.TabIndex = 7;
            this.lblSizeLimits.Text = "[9-23]";
            // 
            // lblSizeBoard
            // 
            this.lblSizeBoard.AutoSize = true;
            this.lblSizeBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeBoard.Location = new System.Drawing.Point(135, 22);
            this.lblSizeBoard.Name = "lblSizeBoard";
            this.lblSizeBoard.Size = new System.Drawing.Size(54, 22);
            this.lblSizeBoard.TabIndex = 6;
            this.lblSizeBoard.Text = "Size ";
            this.lblSizeBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBombs
            // 
            this.lblBombs.AutoSize = true;
            this.lblBombs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombs.Location = new System.Drawing.Point(135, 168);
            this.lblBombs.Name = "lblBombs";
            this.lblBombs.Size = new System.Drawing.Size(68, 22);
            this.lblBombs.TabIndex = 5;
            this.lblBombs.Text = "Mines ";
            this.lblBombs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(81, 374);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "NewGame";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pcbBombs
            // 
            this.pcbBombs.Image = global::Minesweeper.Properties.Resources.bombee;
            this.pcbBombs.Location = new System.Drawing.Point(15, 168);
            this.pcbBombs.Name = "pcbBombs";
            this.pcbBombs.Size = new System.Drawing.Size(105, 100);
            this.pcbBombs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBombs.TabIndex = 3;
            this.pcbBombs.TabStop = false;
            // 
            // pcbSizeBoard
            // 
            this.pcbSizeBoard.Image = global::Minesweeper.Properties.Resources.GRID;
            this.pcbSizeBoard.Location = new System.Drawing.Point(15, 20);
            this.pcbSizeBoard.Name = "pcbSizeBoard";
            this.pcbSizeBoard.Size = new System.Drawing.Size(105, 100);
            this.pcbSizeBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSizeBoard.TabIndex = 2;
            this.pcbSizeBoard.TabStop = false;
            // 
            // nudBombs
            // 
            this.nudBombs.BackColor = System.Drawing.SystemColors.Control;
            this.nudBombs.Location = new System.Drawing.Point(140, 219);
            this.nudBombs.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudBombs.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudBombs.Name = "nudBombs";
            this.nudBombs.Size = new System.Drawing.Size(69, 20);
            this.nudBombs.TabIndex = 0;
            this.nudBombs.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // pnlGrid
            // 
            this.pnlGrid.AutoSize = true;
            this.pnlGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.tlpGrid);
            this.pnlGrid.Location = new System.Drawing.Point(254, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(2, 49);
            this.pnlGrid.TabIndex = 2;
            // 
            // helpMenu
            // 
            this.helpMenu.BackColor = System.Drawing.Color.Green;
            this.helpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.helpMenu.Location = new System.Drawing.Point(0, 0);
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(580, 24);
            this.helpMenu.TabIndex = 3;
            this.helpMenu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tmrMines
            // 
            this.tmrMines.Enabled = true;
            this.tmrMines.Tick += new System.EventHandler(this.tmrMines_Tick);
            // 
            // frmMinersweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(580, 529);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.helpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMinersweeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.frmMinersweeper_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSizeBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBombs)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.helpMenu.ResumeLayout(false);
            this.helpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGrid;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.PictureBox pcbSizeBoard;
        private System.Windows.Forms.NumericUpDown nudBombs;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.MenuStrip helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblSizeBoard;
        private System.Windows.Forms.Label lblBombs;
        private System.Windows.Forms.Label lblBombsLimits;
        private System.Windows.Forms.Label lblSizeLimits;
        private System.Windows.Forms.PictureBox pcbFlag;
        private System.Windows.Forms.PictureBox pcbBombs;
        private System.Windows.Forms.Label lblNumberFlag;
        private System.Windows.Forms.PictureBox pcbClock;
        private System.Windows.Forms.Timer tmrMines;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown nudSizeBoard;
    }
}

