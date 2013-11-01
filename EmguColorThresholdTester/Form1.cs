using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace EmguColorThresholdTester
{
    public partial class frmMain : Form
    {
        private Image<Hsv, Byte> m_imgSource;
        private Image<Gray, Byte> m_imgThreshold;

        private ImageViewer m_frmSourceImage;
        private ImageViewer m_frmThresholdImage;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenFileDialog dlgSourcePicture = new OpenFileDialog();
            dlgSourcePicture.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dlgSourcePicture.Multiselect = false;
            if (dlgSourcePicture.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                Application.Exit();

            m_imgSource = new Image<Bgr, Byte>((Bitmap) Image.FromFile(dlgSourcePicture.FileName)).Convert<Hsv, Byte>();
            m_imgThreshold = new Image<Gray, Byte>(m_imgSource.Size);

            m_frmSourceImage = new ImageViewer(m_imgSource, "Original Image");
            m_frmSourceImage.Show();
            m_frmSourceImage.SetDesktopLocation(100, 100);

            m_frmThresholdImage = new ImageViewer(m_imgThreshold, "Threshold Image");
            m_frmThresholdImage.Show();
            m_frmThresholdImage.SetDesktopLocation(m_frmSourceImage.DesktopLocation.X + m_frmSourceImage.Size.Width + 100, 100);

            ProduceThresholdImage();
        }

        private void ProduceThresholdImage()
        {
            int HueLow = trackHueLow.Value;
            int SatLow = trackSatLow.Value;
            int ValLow = trackValLow.Value;
            int HueHigh = trackHueHigh.Value;
            int SatHigh = trackSatHigh.Value;
            int ValHigh = trackValHigh.Value;

            lblHueLow.Text = "Low Hue = " + HueLow.ToString() + "°";
            lblHueHigh.Text = "High Hue = " + HueHigh.ToString() + "°";
            lblSatLow.Text = "Low Sat = " + SatLow.ToString();
            lblSatHigh.Text = "High Sat = " + SatHigh.ToString();
            lblValLow.Text = "Low Val = " + ValLow.ToString();
            lblValHigh.Text = "High Val = " + ValHigh.ToString();

            m_imgThreshold = m_imgSource.InRange(new Hsv(HueLow, SatLow, ValLow), new Hsv(HueHigh, SatHigh, ValHigh));
            m_frmThresholdImage.Image = m_imgThreshold;
        }

        private void trackHueLow_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackHueHigh_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackSatLow_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackSatHigh_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackValLow_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackValHigh_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("InRange(new Hsv(" + trackHueLow.Value.ToString() + ", " + trackSatLow.Value.ToString() + ", " + trackValLow.Value.ToString() + "), " +
                                "new Hsv(" + trackHueHigh.Value.ToString() + ", " + trackSatHigh.Value.ToString() + ", " + trackValHigh.Value.ToString() + "))");
        }

        private void lnkBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkBlog.Text);
        }
    }
}
