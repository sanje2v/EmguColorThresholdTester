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
            dlgSourcePicture.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            dlgSourcePicture.Multiselect = false;
            if (dlgSourcePicture.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                Application.Exit();

            m_imgSource = new Image<Bgr, Byte>((Bitmap) Image.FromFile(dlgSourcePicture.FileName)).Convert<Hsv, Byte>();
            m_imgThreshold = new Image<Gray, Byte>(m_imgSource.Size);

            m_frmSourceImage = new ImageViewer(m_imgSource, "Original Image");
            m_frmSourceImage.ShowIcon = false;
            m_frmSourceImage.MaximizeBox = false;
            m_frmSourceImage.Show();
            m_frmSourceImage.SetDesktopLocation(100, 0);
            m_frmSourceImage.SizeChanged += m_frmSourceImage_SizeChanged;

            m_frmThresholdImage = new ImageViewer(m_imgThreshold, "Threshold Image");
            m_frmThresholdImage.ShowIcon = false;
            m_frmThresholdImage.MaximizeBox = false;
            m_frmThresholdImage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            m_frmThresholdImage.Show();
            m_frmThresholdImage.SetDesktopLocation(m_frmSourceImage.DesktopLocation.X + m_frmSourceImage.Size.Width + 100, m_frmSourceImage.DesktopLocation.Y);

            ProduceThresholdImage();
        }

        void m_frmSourceImage_SizeChanged(object sender, EventArgs e)
        {
            m_frmSourceImage.Image = m_imgSource.Resize(m_frmSourceImage.ClientSize.Width, m_frmSourceImage.ClientSize.Height, Emgu.CV.CvEnum.INTER.CV_INTER_NN);
            m_frmThresholdImage.Image = m_imgThreshold.Resize(m_frmSourceImage.ClientSize.Width, m_frmSourceImage.ClientSize.Height, Emgu.CV.CvEnum.INTER.CV_INTER_NN);

            m_frmThresholdImage.Size = m_frmSourceImage.Size;
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
            m_frmThresholdImage.Image = m_imgThreshold.Resize(m_frmThresholdImage.ClientSize.Width, m_frmThresholdImage.ClientSize.Height, Emgu.CV.CvEnum.INTER.CV_INTER_NN);
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
