using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class frmSnakeBoard : Form
    {

        private enum eLevelGame
        {
            BeginnerMode = 0,
            MediumMode = 1,
            ExpertMode = 2,
        }
        private enum eSnakePostion
        {
            Left,
            Right,
            Up,
            Down

        };
        private const string c_SnakeImageName = "HeadSnake.png";
        private const string c_AppleImageName = "Apple.png";
        private const string c_ImageFolderName = "image";
        private List<PictureBox> AppleList;
        private Snake SnakeParts;
        private PictureBox SnakePic 
        {
            get { return SnakeParts.SnakePicture; }
        }

        private Image SnakeImageRight;
        private Image SnakeImageLeft;
        private Image SnakeImageUp;
        private Image SnakeImageDown;
        private eSnakePostion m_CurrentPosttion = eSnakePostion.Right;
        private DateTime m_StartTime;
        private Timer m_UpdateTimeLblTimer;
        private Timer m_KeepMoveTimer;
        private Timer m_SetAppleOnBoardTimer;
        private bool m_IsPlayGame = true;
        private int m_Score = 0;
        private int m_SpeedGame = (int)eLevelGame.BeginnerMode;

        public frmSnakeBoard(string NamePlayer)
        {

            InitializeComponent();
            InitComboBoxLevel();
            lblNameValue.Text = NamePlayer;

            this.KeyPress += MoveHandler;

            btnNewGame.Click += BtnNewGame_Click;

            StartGame();

        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            // pnlBoard.Controls.Clear();
            pnlBoard.Controls.Clear();
            StopTimer();
            StartGame();
        }

        private void StartGame()
        {
            InitImage();
            
            m_IsPlayGame = true;
            m_Score = 0;

            lblScoreValue.Text = m_Score.ToString();
            m_UpdateTimeLblTimer = new Timer();
            m_UpdateTimeLblTimer.Interval = 1000;
            m_UpdateTimeLblTimer.Tick += (sender, e) =>
            {
                lblTimerValue.Text = GetGameTime();
            };// lambda expression with action 
            m_UpdateTimeLblTimer.Start();

            m_KeepMoveTimer = new Timer();
            m_KeepMoveTimer.Interval = 200;
            m_KeepMoveTimer.Tick += (sender, e) =>
            {
                KeepMoving(m_IsPlayGame);
            };// lambda expression with action 

            AppleList = new List<PictureBox>();
            m_SetAppleOnBoardTimer = new Timer();
            m_SetAppleOnBoardTimer.Interval = 10000;
            m_SetAppleOnBoardTimer.Tick += (sender, e) =>
            {
                AddAppleToPnl(m_IsPlayGame);
            };// lambda expression with action 




        }
        private void GameOver()
        {
            StopTimer();

            DialogResult result = MessageBox.Show("Your Score " + m_Score + "\nDo you want to play again?", "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                pnlBoard.Controls.Clear();
                StartGame();
            }
            else
            {
                m_KeepMoveTimer.Stop();
                m_SetAppleOnBoardTimer.Stop();
                m_UpdateTimeLblTimer.Stop();
                m_IsPlayGame = false;



            }
        }
        private void StopTimer()
        {
            m_KeepMoveTimer.Dispose();
            m_SetAppleOnBoardTimer.Dispose();
            m_UpdateTimeLblTimer.Dispose();

            m_StartTime = default;
        }
        private void MoveHandler(object sender, KeyPressEventArgs e)
        {
            if (!m_IsPlayGame)
                return;

            if ((e.KeyChar == 'D' || e.KeyChar == 'd') && (m_CurrentPosttion != eSnakePostion.Left))
            {
                MoveRight(m_IsPlayGame);
                m_CurrentPosttion = eSnakePostion.Right;
            }
            if ((e.KeyChar == 'A' || e.KeyChar == 'a') && (m_CurrentPosttion != eSnakePostion.Right))
            {
                MoveLeft(m_IsPlayGame);
                m_CurrentPosttion = eSnakePostion.Left;
            }
            if ((e.KeyChar == 'W' || e.KeyChar == 'w') && (m_CurrentPosttion != eSnakePostion.Down))
            {
                MoveUp(m_IsPlayGame);
                m_CurrentPosttion = eSnakePostion.Up;
            }
            if ((e.KeyChar == 'X' || e.KeyChar == 'x') && (m_CurrentPosttion != eSnakePostion.Up))
            {
                MoveDown(m_IsPlayGame);
                m_CurrentPosttion = eSnakePostion.Down;
            }

            // ======= START GAME ========
            if (m_StartTime == default) // defualt == Date time null
            {
                m_StartTime = DateTime.Now;
                m_KeepMoveTimer.Start();
                m_SetAppleOnBoardTimer.Start();
            }
        }
        private string GetGameTime()
        {
            if (m_StartTime == default)
                return "00:00:00";
            return (DateTime.Now - m_StartTime).ToString(@"hh\:mm\:ss");

        }
        private void KeepMoving(bool m_IsPlayGame)
        {
            if (!m_IsPlayGame)
                return;

            switch (m_CurrentPosttion)
            {
                case eSnakePostion.Left:
                    MoveLeft(m_IsPlayGame);
                    break;
                case eSnakePostion.Right:
                    MoveRight(m_IsPlayGame);
                    break;
                case eSnakePostion.Up:
                    MoveUp(m_IsPlayGame);
                    break;
                case eSnakePostion.Down:
                    MoveDown(m_IsPlayGame);
                    break;
            }


        }


        private void RemoveAppleFromPnl()
        {
            PictureBox AppleToRemove = null;
            var cloneAppleList = AppleList.ToList();
            foreach (var Apple in cloneAppleList)
            {
                if (IsApple(Apple.Location.X, Apple.Location.Y))
                {
                    AppleToRemove = Apple;
                    break;
                }
            }
            if (AppleToRemove == null)
                return;

            m_SetAppleOnBoardTimer.Stop();
            AppleList.Remove(AppleToRemove);
            pnlBoard.Controls.Remove(AppleToRemove);
            lblScoreValue.Text = (++m_Score).ToString();
            m_SetAppleOnBoardTimer.Start();
        }


        private void AddAppleToPnl(bool m_IsPlayGame)
        {
            if (!m_IsPlayGame)
                return;


            var rnd = new Random();
            var pointX = rnd.Next(0, pnlBoard.Width);
            var pointY = rnd.Next(0, pnlBoard.Height);

            //TODO: Check x and y is not on snake or another apples
            foreach (var Apple in AppleList)
            {
                if (Apple.Location.X == pointX || Apple.Location.Y == pointY || IsInFormBound(pointX, pointY))
                {
                    pointX = rnd.Next(0, pnlBoard.Width);
                    pointY = rnd.Next(0, pnlBoard.Height);
                }

            }


            var AppleIcon = new PictureBox();
            AppleIcon.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_AppleImageName));

            AppleIcon.Size = new Size(25, 25);
            AppleIcon.Location = new Point(pointX, pointY);
            AppleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            AppleList.Add(AppleIcon);
            pnlBoard.Controls.Add(AppleIcon);

        }
        private bool IsApple(int x, int y)
        {
            if (x > SnakePic.Location.X &&
               x < SnakePic.Location.X + SnakePic.Size.Width &&
               y > SnakePic.Location.Y &&
               y < SnakePic.Location.Y + SnakePic.Size.Height)
                return true;

            return false;
        }


        private void MoveDown(bool m_IsPlayGame)
        {
            if (!m_IsPlayGame)
                return;

            if (IsInFormBound(SnakePic.Location.X, SnakePic.Location.Y + SnakePic.Height + 5))
                SnakePic.Location = new Point(SnakePic.Location.X, SnakePic.Location.Y + 5);
            else
                GameOver();

            if (m_CurrentPosttion != eSnakePostion.Down)
                SnakePic.Image = SnakeImageDown;

            RemoveAppleFromPnl();

        }

        private void MoveUp(bool m_IsPlayGame)
        {
            if (!m_IsPlayGame)
                return;

            if (IsInFormBound(SnakePic.Location.X, SnakePic.Location.Y - 5))
                SnakePic.Location = new Point(SnakePic.Location.X, SnakePic.Location.Y - 5);
            else
                GameOver();

            if (m_CurrentPosttion != eSnakePostion.Up)
            {
                SnakePic.Image = SnakeImageUp;
            }
            RemoveAppleFromPnl();

        }

        private void MoveLeft(bool m_IsPlayGame)
        {
            if (!m_IsPlayGame)
                return;

            if (IsInFormBound(SnakePic.Location.X - 5, SnakePic.Location.Y))
            {
                SnakePic.Location = new Point(SnakePic.Location.X - 5, SnakePic.Location.Y);

            }
            else
                GameOver();

            if (m_CurrentPosttion != eSnakePostion.Left)
            {
                SnakePic.Image = SnakeImageLeft;
            }


            RemoveAppleFromPnl();

        }

        private void MoveRight(bool m_IsPlayGame)
        {
            if (!m_IsPlayGame)
                return;
            if (IsInFormBound(SnakePic.Location.X + SnakePic.Width + 5, SnakePic.Location.Y))
                SetSnakeLocation(new Point(SnakePic.Location.X + 5, SnakePic.Location.Y));
            else
                GameOver();

            if (m_CurrentPosttion != eSnakePostion.Right)
            {
                SnakePic.Image = SnakeImageRight;
            }
            RemoveAppleFromPnl();


        }

        private void SetSnakeLocation(Point newLocation)
        {
            SnakeParts.SnakePicture.Location = newLocation;
            
        }

        private bool IsInFormBound(int x, int y)
        {
            return x < pnlBoard.Width && x > 0 &&
                    y < pnlBoard.Height && y > 0;
        }


        private Image RotateImage(eSnakePostion newPosstion, Image img)
        {
            Image flipImage = img;
            switch (newPosstion)
            {
                case eSnakePostion.Left:
                    flipImage.RotateFlip(RotateFlipType.Rotate180FlipY);

                    break;
                case eSnakePostion.Right:
                    break;
                case eSnakePostion.Up:
                    flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);

                    break;
                case eSnakePostion.Down:
                    flipImage.RotateFlip(RotateFlipType.Rotate270FlipY);

                    break;
            }
            return flipImage;

        }

        private void InitComboBoxLevel()
        {
            cbLevel.Items.AddRange(Enum.GetNames(typeof(eLevelGame)));
            cbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLevel.MaxDropDownItems = 3;
            cbLevel.TabIndex = 0;
            cbLevel.SelectedIndex = (int)eLevelGame.BeginnerMode;
            cbLevel.BackColor = System.Drawing.Color.BlanchedAlmond;
            cbLevel.ForeColor = System.Drawing.Color.Black;
            cbLevel.SelectedIndexChanged += CbLevel_SelectedIndexChanged;
        }

        private void CbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            int selectedIndex = cb.SelectedIndex;

            switch (selectedIndex)
            {
                case (int)eLevelGame.BeginnerMode:

                default:
                    break;
            }
        }
        private void InitImage()
        {

            var SnakePic = new PictureBox();
            SnakeImageRight = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_SnakeImageName));
            SnakeImageLeft = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_SnakeImageName));
            SnakeImageUp = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_SnakeImageName));
            SnakeImageDown = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_SnakeImageName));
            SnakePic.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_SnakeImageName));
            SnakePic.Size = new Size(40, 40);
            SnakePic.Location = new Point(350, 150);
            SnakePic.SizeMode = PictureBoxSizeMode.StretchImage;

            SnakeImageLeft = RotateImage(eSnakePostion.Left, SnakeImageLeft);
            SnakeImageUp = RotateImage(eSnakePostion.Up, SnakeImageUp);
            SnakeImageDown = RotateImage(eSnakePostion.Down, SnakeImageDown);

            SnakeParts = new Snake(SnakePic);

            pnlBoard.Controls.Add(SnakeParts.SnakePicture);
        }



    }

}