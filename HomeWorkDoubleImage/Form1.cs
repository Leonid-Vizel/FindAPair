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

namespace HomeWorkDoubleImage
{
    public partial class Form1 : Form
    {
        private PictureBox preLastClickedPictureBox = null;
        private PictureBox lastClickedPictureBox = null;
        private Image[] images = new Image[18];
        private PictureBox[,] pictureboxes = new PictureBox[6, 6];
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
            int x, y;
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
                    Controls.Add(pictureBox);
                    pictureboxes[i, j] = pictureBox;
                }
            }
        }

        private void ClickPictureBox(object senderObj, EventArgs e)
        {
            PictureBox sender = (PictureBox)senderObj;
            if (sender == null || sender.Tag == null)
            {
                return;
            }
            (int, bool) currentInfo = ((int, bool))sender.Tag;
            if (currentInfo.Item2)
            {
                return;
            }
            sender.Image = images[currentInfo.Item1];
            if (lastClickedPictureBox != null)
            {
                (int, bool) lastInfo = ((int, bool))lastClickedPictureBox.Tag;
                if (!lastInfo.Item2)
                {
                    if (lastInfo.Item1 == currentInfo.Item1)
                    {
                        lastInfo
                    }
                }
            }


            preLastClickedPictureBox = lastClickedPictureBox;
            lastClickedPictureBox = sender;
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
    }
}