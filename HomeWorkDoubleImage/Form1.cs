using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkDoubleImage
{
    public partial class Form1 : Form
    {
        #region For Wrong Timer
        private PictureBox hide1 = null;
        private PictureBox hide2 = null;
        #endregion

        private bool blockClick = false;
        private PictureBox lastClickedPictureBox = null;
        private int count;
        private float time;
        private Image[] images = new Image[18];
        private const int side = 100;
        private const int between = 5;
        private Color defaultBackColor = Color.Gray;

        public Form1()
        {
            InitializeComponent();
            LoadImages();
            InitializePictureBoxes(Shuffle());
        }

        private void InitializePictureBoxes(int[,] inputTags)
        {
            int x = 0, y = 0;
            for (int i = 0; i < 6; i++)
            {
                y = between + i * (side + between);
                for (int j = 0; j < 6; j++)
                {
                    x = between + j * (side + between);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(side, side);
                    pictureBox.Location = new Point(x, y);
                    pictureBox.Tag = (inputTags[i, j],false);
                    pictureBox.BackColor = defaultBackColor;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += ClickPictureBox;
                    pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    gamePanel.Controls.Add(pictureBox);
                }
            }
            gamePanel.Size = new Size(x + between + side, y + between + side);
        }

        private void ClickPictureBox(object senderObj, EventArgs e)
        {
            if (blockClick) return;
            PictureBox sender = (PictureBox)senderObj;
            if (sender == null || lastClickedPictureBox == sender || sender.Tag == null)
            {
                return;
            }
            (int, bool) imageInfo = ((int, bool))sender.Tag;
            if (imageInfo.Item2)
            {
                return;
            }
            sender.Image = images[imageInfo.Item1];
            if (lastClickedPictureBox == null)
            {
                lastClickedPictureBox = sender;
                sender.Image = images[imageInfo.Item1];
                statusLabel.Text = "Выберите картинку";
                statusLabel.BackColor = Color.Gray;
            }
            else
            {
                (int, bool) lastImageInfo = ((int, bool))lastClickedPictureBox.Tag;
                if (lastImageInfo.Item1 == imageInfo.Item1)
                {
                    sender.Image = images[imageInfo.Item1];
                    lastImageInfo.Item2 = imageInfo.Item2 = true;
                    lastClickedPictureBox.Tag = lastImageInfo;
                    sender.Tag = imageInfo;
                    ballsLabel.Text = $"Очки: {++count}";
                    statusLabel.Text = "Верно!";
                    statusLabel.BackColor = Color.Green;
                    if (count >= 18)
                    {
                        statusLabel.Text = "Верно!";
                        Close();
                    }
                }
                else
                {
                    sender.Image = images[imageInfo.Item1];
                    statusLabel.Text = "Неверно! Ожидайте";
                    statusLabel.BackColor = Color.Red;
                    blockClick = true;
                    hide1 = sender;
                    hide2 = lastClickedPictureBox;
                    wrongTimer.Start();
                }
                lastClickedPictureBox = null;
            }
        }

        private void LoadImages()
        {
            string[] paths = Directory.GetFiles("politics");
            if (paths.Length < 18)
            {
                MessageBox.Show("Требую больше картинок!");
            }
            for (int i = 0; i < 18; i++)
            {
                images[i] = Image.FromFile(paths[i]);
            }
        }

        private int[,] Shuffle()
        {
            int[,] shuffleArray = new int[6, 6]
            {
                { 0, 0, 1, 1, 2, 2 },
                { 3, 3, 4, 4, 5, 5 },
                { 6, 6, 7, 7, 8, 8 },
                { 9, 9, 10, 10, 11, 11 },
                { 12, 12, 13, 13, 14, 14 },
                { 15, 15, 16, 16, 17, 17 }
            };
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int temp;
            for (int i = 0; i < 100; i++)
            {
                int firstX = random.Next(0, 6);
                int firstY = random.Next(0, 6);
                int secondX = random.Next(0, 6);
                int secondY = random.Next(0, 6);
                temp = shuffleArray[firstX, firstY];
                shuffleArray[firstX, firstY] = shuffleArray[secondX, secondY];
                shuffleArray[secondX, secondY] = temp;
            }
            return shuffleArray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            time += 0.1F;
            if (time < 60)
            {
                timeLabel.Text = $"Время:\n{Math.Round(time, 1)} сек";
            }
            else
            {
                int mins = (int)time / 60;
                float secs = time % 60;
                timeLabel.Text = $"Время:\n{mins} мин {Math.Round(secs, 1)} сек";
            }
        }

        private void wrongTimer_Tick(object sender, EventArgs e)
        {
            hide1.Image = hide2.Image = null;
            statusLabel.Text = "Выберите картинку";
            statusLabel.BackColor = Color.Gray;
            blockClick = false;
            wrongTimer.Stop();
        }
    }
}