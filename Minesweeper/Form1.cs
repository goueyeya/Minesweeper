//author Gaëtan Oueyeya
using System;
using System.Drawing;
using System.Media;// library for sounds
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class frmMinersweeper : Form
    {
        private const int SIZE_CELL = 40; //size of every cell
        private const int DEFAULT_BOARD = 20; //default size of the board (10*10)
        private int currentBoard = 9;// current size of the grid, to be replaced by user value
        private int nbBombs = 9; // number of bombs
        private int nbActiveButtons; //number of buttons that are still active (clickable)
        private int[,] matrixBoard; //-1 if bomb, else number of bombs around //[,] create a 2D array
        private Random rand; // random number where to put the bomb
        private const int BOMB = -1;// Const Bomb
        private bool gameLost;// boolean is true if the game is lost 
        private SoundPlayer sound = new SoundPlayer();//the sound when a game is lost
        private int nbFlag;//number of flag (also number of bombs) that we can display
        private int timeS;// number of seconds
        private int timeM;//number of minutes 


        public frmMinersweeper()
        {
            InitializeComponent();
        }

        private void frmMinersweeper_Load(object sender, EventArgs e)
        {
            InitializeNewGame();
        }

        private void InitializeNewGame()
        {
            //lauch the timer and display it
            tmrMines.Start();
            ResetTime();
            //Initialize the boolean gameLost to false
            gameLost = false;
            //Initialization of the TLP
            tlpGrid.Dispose(); // release all the components of the grid
            tlpGrid = new TableLayoutPanel();// instantiate a new tablelayout panel
            tlpGrid.Visible = false;
            tlpGrid.AutoSize = true;
            tlpGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.None; // initialize a border for every cell of the grid
            tlpGrid.Dock = DockStyle.Fill;
            tlpGrid.RowCount = currentBoard; // number of lines 
            tlpGrid.ColumnCount = currentBoard; // number of columns
            tlpGrid.RowStyles.Clear();
            tlpGrid.ColumnStyles.Clear();
            //loop that create the element of the grid 
            for (int i = 0; i < currentBoard; i++)
            {
                tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, SIZE_CELL));
                tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, SIZE_CELL));
            }
            //double loop that create buttons at the position (i,j) of the TableLayoutPanel
            for (int i = 0; i < currentBoard; i++)
            {
                for (int j = 0; j < currentBoard; j++)
                {
                    Button btn = new Button();
                    btn.MouseDown += btn_Click;
                    btn.Enabled = true;
                    btn.Margin = new Padding(0);
                    tlpGrid.Controls.Add(btn, i, j);
                    btn.Dock = DockStyle.Fill;
                    btn.FlatStyle = FlatStyle.Popup; //style of the button
                    btn.BackColor = Color.FromArgb(218, 247, 166); // color of the background
                    btn.Font = new Font(btn.Font, FontStyle.Bold); // fontstyle bold
                    //btn.EnabledChanged += btn_EnabledChanged;
                }
            }
            //initialization of the matrix and placement of bombs
            matrixBoard = new int[currentBoard, currentBoard]; // instantiate a new matrix that will contains
            bombMatrix();
            //intialize the number of active Buttons
            nbActiveButtons = currentBoard * currentBoard - nbBombs;
            //initiliaze the number of flags and display it
            nbFlag = nbBombs;
            lblNumberFlag.Text = nbFlag.ToString();
            // dispay the TLP
            pnlGrid.Controls.Add(tlpGrid);
            tlpGrid.Visible = true;

        }

        //create a new Button
        //private Button newButton()
        //{

        //    return btn;
        //}

        // create the matrix that will contain the popsition of the bomb 
        private void bombMatrix()// place the bomb on the matrix
        {
            rand = new Random();
            int cpt = 0;

            //loop that place the bomb in the matrix and then add +1 to the surrounding cells 
            while (cpt < nbBombs)
            {
                int line = rand.Next(0, currentBoard);
                int col = rand.Next(0, currentBoard);
                if (matrixBoard[line, col] != BOMB)// check if the button is not already a bomb
                {
                    matrixBoard[line, col] = BOMB;
                    cellSurrondings(line, col);
                    cpt++;
                }
            }
            //print the bombs and number of surroundings bombs
            //for (int i = 0; i < currentBoard; i++)
            //{
            //    for (int j = 0; j < currentBoard; j++)
            //    {
            //        tlpGrid.GetControlFromPosition(i, j).Text = matrixBoard[i, j].ToString();
            //    }
            //}
        }

        //add all the surroundings cells if they are in the range
        private void cellSurrondings(int line, int col)
        {
            for (int x = line - 1; x <= line + 1; x++)
            {
                for (int y = col - 1; y <= col + 1; y++)
                {
                    if (cellValid(x, y))
                    {
                        matrixBoard[x, y]++;
                    }
                }
            }
        }

        // Returns true if row number and column number is in range
        private bool cellValid(int line, int col)
        {
            return (line >= 0) && (line < currentBoard) && (col >= 0) && (col < currentBoard) && (matrixBoard[line, col] != BOMB);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            Button btn = (Button)sender;
            if (m.Button == MouseButtons.Left)//left click if the user wants to check the cell
            {
                int line = tlpGrid.GetRow(btn); // get the row of the button that was clicked
                int col = tlpGrid.GetColumn(btn);// same 
                ((Button)sender).BackgroundImage = null;// if there is a flag disable it
                checkCell(col, line);
                if (gameLost == true)//the game is lost
                {
                    //Launch a sound
                    sound.SoundLocation = @".\lost.wav";
                    sound.Play();
                    //stop the timer
                    tmrMines.Stop();
                    //display position of mines
                    for (int i = 0; i < currentBoard; i++)
                    {
                        for (int j = 0; j < currentBoard; j++)
                        {
                            Button btn2 = ((Button)tlpGrid.GetControlFromPosition(i, j));
                            if (matrixBoard[i, j] == BOMB)
                            {
                                btn2.BackgroundImageLayout = ImageLayout.Zoom;
                                btn2.BackgroundImage = Minesweeper.Properties.Resources.bombee;
                            }
                        }
                    }
                    if (MessageBox.Show("You lost ! \n Your game last : " + lblTimer.Text + "\nDo you want to try again ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        InitializeNewGame();

                    }
                    else
                    {
                        Close();
                    }


                }
                else if (nbActiveButtons == 0)//the game is Won
                {

                    //launch the sound
                    sound.SoundLocation = @".\win.wav";
                    sound.Play();
                    //stop the timer
                    tmrMines.Stop();
                    if (MessageBox.Show("You won ! \n Your game last : " + lblTimer.Text + "\n Do you want to try again ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        InitializeNewGame();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            else if (m.Button == MouseButtons.Right)//right click if the user want to put a flag on a cell
            {
                if (btn.BackgroundImage == null && nbFlag > 0)// there is no flage then display it
                {
                    btn.BackgroundImageLayout = ImageLayout.Zoom;//propertie that allow the image to fit in the button
                    btn.BackgroundImage = Minesweeper.Properties.Resources.flag;
                    nbFlag--;//decrements the number of flags
                    lblNumberFlag.Text = nbFlag.ToString();//display the number of flags
                }
                else if (btn.BackgroundImage != null)//there is a flag then remove it 
                {
                    btn.BackgroundImage = null;
                    nbFlag++;//increments the number of flags
                    lblNumberFlag.Text = nbFlag.ToString();//display the number of flags
                }
            }
        }

        //set the colour of the surroundings bombs
        private void btn_EnabledChanged(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            int line = tlpGrid.GetRow((Button)sender); // get the row of the button that was clicked
            int col = tlpGrid.GetColumn((Button)sender);// same 
            switch (matrixBoard[col, line])
            {
                case 1:
                    btn.ForeColor = Color.Blue; break;
                case 2:
                    btn.ForeColor = Color.Green; break;
                case 3:
                    btn.ForeColor = Color.Orange; break;
                case 4:
                    btn.ForeColor = Color.OrangeRed; break;
                case 5:
                    btn.ForeColor = Color.Red; break;
                case 6:
                    btn.ForeColor = Color.DarkRed; break;
                case 7:
                    btn.ForeColor = Color.DarkGray; break;
                case 8:
                    btn.ForeColor = Color.Black; break;
                default: break;
            }
        }

        // display the number of surroundings bombs and color them 
        private void btn_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int line = tlpGrid.GetRow(btn); // get the row of the button that was clicked
            int col = tlpGrid.GetColumn(btn);// same 
            SolidBrush drawBrush = new SolidBrush(btn.ForeColor);//get the color of the button
            StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };//initialize the format of the button's text
            e.Graphics.DrawString(matrixBoard[col, line].ToString(), btn.Font, drawBrush, e.ClipRectangle, sf);
        }

        private void checkCell(int col, int line)
        {
            Button btn = ((Button)tlpGrid.GetControlFromPosition(col, line));
            if (btn.Enabled == true && gameLost == false)
            {
                btn.Enabled = false;// if it is enabled we disable it first
                if (matrixBoard[col, line] != 0)
                {
                    btn.Paint += btn_Paint;// add the Paint Event to the button 
                }
                btn.BackColor = Color.FromArgb(232, 196, 156);// color the cell that has been explored
                nbActiveButtons--;//decrements the number of active buttons
                if (btn.BackgroundImage != null)//actualize the number of flag 
                {
                    nbFlag++;
                    lblNumberFlag.Text = nbFlag.ToString();
                }
                btn.BackgroundImage = null; // remove the possible flag when the recursive function is called

                if (matrixBoard[col, line] == BOMB) // the game is lost
                {
                    gameLost = true;
                }
                else
                {//We check in matrixBoard the number of neighboring bombs
                    if (matrixBoard[col, line] == 0)
                    {
                        //then the procedure calls itself on the neighboring cells
                        for (int i = Math.Max(0, col - 1); i <= Math.Min(currentBoard - 1, col + 1); i++)
                        {
                            for (int j = Math.Max(0, line - 1); j <= Math.Min(currentBoard - 1, line + 1); j++)
                            {
                                checkCell(i, j);
                            }
                        }
                    }
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want a restart a Game ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NewGame();
            }

        }

        //launch a new Game
        private void NewGame()
        {
            int size = (int)nudSizeBoard.Value;
            int bombs = (int)nudBombs.Value;
            if (size == 0 || bombs == 0)
            {
                MessageBox.Show("Set a number for the size and the number of bombs !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bombs > size * size)
            {
                MessageBox.Show("Number of bombs invalid !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sound.SoundLocation = @".\newgame.wav";
                sound.Play();
                currentBoard = size;
                nbBombs = bombs;
                InitializeNewGame();
            }
        }

        //show the help the user may need
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to play Minesweeper: \n \n " +
               "The goal of the game is to find and mark the grid boxes that camouflage a mine.\n " +
               "When you click on a cell, it will tell you the number of adjacent cells containing a mine.  \n " +
               "If you click on a cell with no mine around it, it will automatically reveal the adjacent cells.  \n " +
               "You can mark the boxes you suspect of hiding a mine by placing a marker on it with the right-click.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrMines_Tick(object sender, EventArgs e)
        {
            tmrMines.Interval = 1000;
            timeS++;
            if (timeS >= 60)
            {
                timeM++;
                timeS = 0;
            }
            DrawTime();
        }

        //reset the timer
        private void ResetTime()
        {
            timeM = 0;
            timeS = 0;
        }

        //draw the timer
        private void DrawTime()
        {
            lblTimer.Text = String.Format("{0:00}", timeM) + " : " + String.Format("{0:00}", timeS);
        }

        private void lblNumberFlag_Click(object sender, EventArgs e)
        {

        }
    }

}

