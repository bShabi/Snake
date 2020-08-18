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
    public partial class Form1 : Form
    {

        private const string c_ImageFolderName = "image";
        private const string c_SnakeMenuImage = "SnakeMenu.png";
        private const int c_IconWidth = 120;
        private const int c_IconHeight = 200;
        private const int c_FormWidth = 700;
        private const int c_FormHeight = 700;
        private string m_Player;

        
        private frmSnakeBoard m_frmGameBoard;
        private Label lblTitle = new Label();
        private PictureBox SnakeMenuImage = new PictureBox();
        private Button btnNewGame = new Button();
        private Button btnShowPlayers = new Button();
        private Button btnExit = new Button();


        public Form1()
        {
            InitializeComponent();
            SetDeisgin();
            btnNewGame.MouseDown += ClickNewGame;
            btnExit.MouseDown += ClickToExit;
        }



        private void ClickNewGame(object sender, MouseEventArgs e)
        {
            if (m_frmGameBoard == null)
            {
                InitPlayerName();
                m_frmGameBoard = new frmSnakeBoard(NamePlayer: m_Player);
                m_frmGameBoard.ShowDialog();
            }
        }
        private void InitPlayerName()
        {
            
            DialogSetName frm_SetPlayer = new DialogSetName();
            frm_SetPlayer.ShowDialog();
            m_Player = frm_SetPlayer.Name;
            frm_SetPlayer.Close();
        }

        private void ClickToExit(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Close();
        }

        private void SetDeisgin()
        {
            this.Size = new Size(c_FormWidth, c_FormHeight);
            this.BackColor = Color.AntiqueWhite;


            lblTitle.Text = "Snake Game";
            lblTitle.Size = new Size(100, 50);
            lblTitle.Location = new Point(300, 50);
            lblTitle.ForeColor = System.Drawing.Color.Black;
            this.Controls.Add(lblTitle);

            SnakeMenuImage.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, c_ImageFolderName, c_SnakeMenuImage));
            SnakeMenuImage.Size = new Size(c_IconWidth, c_IconHeight);
            SnakeMenuImage.Location = new Point(250, 150);
            SnakeMenuImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(SnakeMenuImage);

            btnNewGame.Text = "New Game";
            btnShowPlayers.Text = "Stats Players";
            btnExit.Text = "Exit";
            btnNewGame.Location = new Point(150, 400);
            btnShowPlayers.Location = new Point(250, 400);
            btnExit.Location = new Point(350, 400);

            this.Controls.Add(btnNewGame);
            this.Controls.Add(btnShowPlayers);
            this.Controls.Add(btnExit);


        }
    }
}
