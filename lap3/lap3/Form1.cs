using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Windows.Forms;


namespace lap3
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        Image<Bgr, Byte> My_Image;
        Image<Gray, Byte> Gray_Image;
        private PictureBox pictureBox2;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(opf.FileName);
                pictureBox1.Image = My_Image.ToBitmap();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnConverttoGray_Click(object sender, EventArgs e)
        {

            if (My_Image != null)
            {
                Gray_Image = My_Image.Convert<Gray, Byte>();
                pictBoxGray.Image = Gray_Image.ToBitmap();

            }

            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (e.X >= 0 && e.X < My_Image.Width && e.Y >= 0 && e.Y < My_Image.Height)
                {
                    lblX.Text = "X: " + e.X.ToString();
                    lblY.Text = "Y: " + e.Y.ToString();
                    lblValue.Text = "Value: " + My_Image[e.Y, e.X].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (My_Image == null)
            {
                MessageBox.Show("Please load an image first.");
            }
            else if (Gray_Image == null)
            {
                MessageBox.Show("Please convert the image to grayscale first.");
            }
            else
            {
                using (SaveFileDialog saveImage = new SaveFileDialog())
                {
                    saveImage.Title = "Save Gray Image";
                    string imageName = "My image";

                    // Set the file name
                    saveImage.FileName = imageName;
                    saveImage.DefaultExt = "*.jpg";
                    saveImage.Filter = "JPEG Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|BMP files(*.bmp)|*.bmp";

                    if (saveImage.ShowDialog() == DialogResult.OK)
                    {
                        Gray_Image.Save(saveImage.FileName);
                        MessageBox.Show("Saving Complete");
                    }
                }
            }
        }
    }
}
    
