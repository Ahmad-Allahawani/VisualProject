using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
namespace visualProject
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );




        public Form1()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));



            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_One.Top;
            PanNav.Left = Category_One.Left;
            Category_One.BackColor = Color.FromArgb(46, 51, 73);
            Category_One.ForeColor = Color.FromArgb(105, 24, 131);

            pictureBox4.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\Images\\musical-note_updated.png");
            pictureBox4.Size = new Size(110, 60);
            pictureBox4.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox4.Width, pictureBox4.Height, 10, 10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Category_One_Click(object sender, EventArgs e)
        {

            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_One.Top;
            PanNav.Left = Category_One.Left;
            Category_One.BackColor = Color.FromArgb(168, 136, 255);
            Category_One.ForeColor = Color.FromArgb(105, 24, 131);

        }

        private void Category_Two_Click(object sender, EventArgs e)
        {



            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_Two.Top;
            Category_Two.BackColor = Color.FromArgb(168, 136, 255);
            Category_Two.ForeColor = Color.FromArgb(105, 24, 131);

        }

        private void Category_three_Click(object sender, EventArgs e)
        {




            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_three.Top;
            Category_three.BackColor = Color.FromArgb(168, 136, 255);
            Category_three.ForeColor = Color.FromArgb(105, 24, 131);
        }

        private void Category_four_Click(object sender, EventArgs e)
        {



            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_four.Top;
            Category_four.BackColor = Color.FromArgb(168, 136, 255);
            Category_four.ForeColor = Color.FromArgb(105, 24, 131);
        }

        private void Category_five_Click(object sender, EventArgs e)
        {




            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_five.Top;
            Category_five.BackColor = Color.FromArgb(168, 136, 255);
            Category_five.ForeColor = Color.FromArgb(105, 24, 131);
        }

        private void Category_six_Click(object sender, EventArgs e)
        {




            PanNav.Height = Category_One.Height;
            PanNav.Top = Category_six.Top;
            Category_six.BackColor = Color.FromArgb(168, 136, 255);
            Category_six.ForeColor = Color.FromArgb(105, 24, 131);
        }

        private void Category_One_Leave(object sender, EventArgs e)
        {


            Category_One.ForeColor = Color.MediumSlateBlue;
            Category_Two.ForeColor = Color.MediumSlateBlue;
            Category_three.ForeColor = Color.MediumSlateBlue;
            Category_four.ForeColor = Color.MediumSlateBlue;
            Category_five.ForeColor = Color.MediumSlateBlue;
            Category_six.ForeColor = Color.MediumSlateBlue;


            Category_One.BackColor = Color.FromArgb(40, 30, 78);
            Category_Two.BackColor = Color.FromArgb(40, 30, 78);
            Category_three.BackColor = Color.FromArgb(40, 30, 78);
            Category_four.BackColor = Color.FromArgb(40, 30, 78);
            Category_five.BackColor = Color.FromArgb(40, 30, 78);
            Category_six.BackColor = Color.FromArgb(40, 30, 78);




        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {

            PictureBox leave_pic = sender as PictureBox;
            if (leave_pic.Image == pictureBox6.Image)
            {
                leave_pic.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\upload_recolored.png");
                leave_pic.Size = new Size(221, 121);
            }
            else if (leave_pic.Image == pictureBox7.Image)
            {
                leave_pic.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\delete.png");
                leave_pic.Size = new Size(221, 121);

            }
        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            PictureBox leave_pic = sender as PictureBox;
            if (leave_pic.Image == pictureBox2.Image)
            {
                leave_pic.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\visualProject\\visualProject\\Images\\upload_recolored.png");
                leave_pic.Size = new Size(221, 121);
            }
            else if (leave_pic.Image == pictureBox9.Image)
            {
                leave_pic.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\upload_colored.png");
                leave_pic.Size = new Size(221, 121);

            }
        }
        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            PictureBox leave_pic = sender as PictureBox;
            if (leave_pic.Image == pictureBox12.Image)
            {
                leave_pic.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\upload_colored.png");
                leave_pic.Size = new Size(221, 121);
            }
            else if (leave_pic.Image == pictureBox10.Image)
            {
                leave_pic.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\delete.png");
                leave_pic.Size = new Size(221, 121);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox.Image == pictureBox5.Image)
            {
                clickedPictureBox.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\gallery_updated.png");
                clickedPictureBox.Size = new Size(110, 60);
                clickedPictureBox.BackColor = Color.FromArgb(128, 128, 255);
                clickedPictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clickedPictureBox.Width, clickedPictureBox.Height, 10, 10));

                pictureBox9.Visible = true;
                pictureBox2.Visible = true;

                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;


                panel4.Visible = true;
                panel3.Visible = false;
                panel5.Visible = false;


                panel4.Size = new Size(493, 373);
                panel4.Location = new Point(192, 85);

                pictureBox9.Size = new Size(221, 121);
                pictureBox9.Location = new Point(710, 294);
                pictureBox2.Size = new Size(221, 121);
                pictureBox2.Location = new Point(710, 119);



                pictureBox4.Size = new Size(100, 50);
                pictureBox4.BackColor = Color.MediumSlateBlue;
                pictureBox4.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\musical-note.png");

                pictureBox3.Size = new Size(100, 50);
                pictureBox3.BackColor = Color.MediumSlateBlue;
                pictureBox3.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\video.png");


            }
            else if (clickedPictureBox.Image == pictureBox4.Image)
            {
                clickedPictureBox.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\musical-note_updated.png");
                clickedPictureBox.Size = new Size(110, 60);
                clickedPictureBox.BackColor = Color.FromArgb(128, 128, 255);
                clickedPictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clickedPictureBox.Width, clickedPictureBox.Height, 10, 10));

                pictureBox7.Visible = true;
                pictureBox6.Visible = true;

                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
                pictureBox2.Visible = false;
                pictureBox9.Visible = false;


                panel5.Visible = true;
                panel4.Visible = false;
                panel3.Visible = false;

                panel5.Size = new Size(493, 373);
                panel5.Location = new Point(192, 85);

                pictureBox7.Size = new Size(221, 121);
                pictureBox7.Location = new Point(710, 294);
                pictureBox6.Size = new Size(221, 121);
                pictureBox6.Location = new Point(710, 119);



                pictureBox5.Size = new Size(100, 50);
                pictureBox5.BackColor = Color.MediumSlateBlue;
                pictureBox5.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\gallery.png");

                pictureBox3.Size = new Size(100, 50);
                pictureBox3.BackColor = Color.MediumSlateBlue;
                pictureBox3.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\video.png");
            }
            else if (clickedPictureBox.Image == pictureBox3.Image)
            {
                clickedPictureBox.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\video_updated.png");
                clickedPictureBox.Size = new Size(110, 60);
                clickedPictureBox.BackColor = Color.FromArgb(128, 128, 255);
                clickedPictureBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clickedPictureBox.Width, clickedPictureBox.Height, 10, 10));


                pictureBox10.Visible = true;
                pictureBox12.Visible = true;

                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox2.Visible = false;
                pictureBox9.Visible = false;


                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;


                pictureBox10.Size = new Size(221, 121);
                pictureBox10.Location = new Point(710, 294);
                pictureBox12.Size = new Size(221, 121);
                pictureBox12.Location = new Point(710, 119);


                panel3.Size = new Size(493, 373);
                panel3.Location = new Point(192, 85);



                pictureBox4.Size = new Size(100, 50);
                pictureBox4.BackColor = Color.MediumSlateBlue;
                pictureBox4.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\musical-note.png");

                pictureBox5.Size = new Size(100, 50);
                pictureBox5.BackColor = Color.MediumSlateBlue;
                pictureBox5.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\gallery.png");
            }

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PictureBox HoveredPic = sender as PictureBox;

            HoveredPic.Size = new Size(225, 125);

            if (HoveredPic.Image == pictureBox2.Image)
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\upload_colored.png");
            }
            else if (HoveredPic.Image == pictureBox9.Image)
            {
                pictureBox9.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\delete_colored.png");
            }
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            PictureBox HoveredPic = sender as PictureBox;

            HoveredPic.Size = new Size(225, 125);

            if (HoveredPic.Image == pictureBox6.Image)
            {
                pictureBox6.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\upload_colored.png");
            }
            else if (HoveredPic.Image == pictureBox7.Image)
            {
                pictureBox7.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\Images\\delete_colored.png");
            }

        }
        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            PictureBox HoveredPic = sender as PictureBox;

            HoveredPic.Size = new Size(225, 125);

            if (HoveredPic.Image == pictureBox12.Image)
            {
                pictureBox12.Image = Image.FromFile("C:\\Users\\Users\\raghe\\Downloads\\visualProject\\visualProject\\Images\\upload_colored.png");
            }
            else if (HoveredPic.Image == pictureBox10.Image)
            {
                pictureBox10.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\visualProject\\Images\\delete_colored.png");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;

            if (clickedPic == pictureBox6)
            {
                OpenFileDialog openFileMusic = new OpenFileDialog
                {
                    Filter = "Music Files (*.mp3;*.wav;*.flac;*.aac;*.ogg)|*.mp3;*.wav;*.flac;*.aac;*.ogg",
                    Title = "Select a Music File",
                    Multiselect = false
                };
                if (openFileMusic.ShowDialog() == DialogResult.OK)
                {

                    string selectedFilePath = openFileMusic.FileName;

                }




                OpenFileDialog openFileImage = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                    Title = "Select a Music image",
                    Multiselect = false
                };

                if (openFileImage.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileImage.FileName);
                    imageList1.Images.Add(selectedImage);

                    string selectedFilePath = openFileImage.FileName;
                }


            }
            else if (clickedPic == pictureBox7)
            {
                int counter = 0;
                bool imageFound = false;

                foreach (Image image in imageList1.Images)
                {
                    if (ImagesAreEqual(image, pictureBox8.Image))
                    {
                        imageFound = true;
                        break;
                    }
                    counter++;
                }

                if (imageFound)
                {
                    pictureBox8.Image = Image.FromFile("C:\\Users\\raghe\\Downloads\\visualProject\\visualProject\\Images\\musical-note.png"); // Clear the PictureBox (optional)
                    imageList1.Images.RemoveAt(counter);

                }
                else
                {
                    MessageBox.Show("Image not found in ImageList.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Helper Method: Compare images pixel by pixel
                bool ImagesAreEqual(Image img1, Image img2)
                {
                    if (img1 == null || img2 == null)
                        return false;

                    if (img1.Size != img2.Size)
                        return false;

                    using (var bmp1 = new Bitmap(img1))
                    using (var bmp2 = new Bitmap(img2))
                    {
                        for (int x = 0; x < bmp1.Width; x++)
                        {
                            for (int y = 0; y < bmp1.Height; y++)
                            {
                                if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }


            }
        }

        int i = 0;
        private void NextButton_click(object sender, EventArgs e)
        {

            if (imageList1.Images.Count > 0)
            {
                if (i < imageList1.Images.Count)
                {
                    pictureBox8.Image = imageList1.Images[i];
                    i++;
                    i = i % imageList1.Images.Count;
                }
                else
                {
                    pictureBox8.Image = imageList1.Images[i - 1];
                    i++;
                    i = i % imageList1.Images.Count;
                }


            }
            else
            {
                MessageBox.Show("There is no music to play. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void PreviousButton_click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0 && i >= 0)
            {
                i -= 1;
                if (i < 0)
                {
                    i = imageList1.Images.Count - 1;
                }

                pictureBox8.Image = imageList1.Images[i];


            }
            else
            {
                MessageBox.Show("There is no music to play.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void pause_play_buttons_click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;

            if (clickedPic == play_button)
            {
                play_button.Visible = false;
                pause_button.Visible = true;
                pause_button.Size = new Size(51, 47);
                pause_button.Location = new Point(223, 315);
            }
            else if (clickedPic == pause_button)
            {
                pause_button.Visible = false;
                play_button.Visible = true;
                play_button.Size = new Size(51, 47);
                play_button.Location = new Point(223, 315);
            }
        }

       
    }
}
