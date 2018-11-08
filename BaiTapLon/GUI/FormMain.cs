using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using BaiTapLon.Handler;

namespace BaiTapLon.GUI
{
    public partial class FormMain : Form
    {
        private FilterInfoCollection _CaptureDevece;
        private VideoCaptureDevice _FinalFrame;
        private Bitmap _BitmapOld = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _FinalFrame = new VideoCaptureDevice(_CaptureDevece[comboBox1.SelectedIndex].MonikerString);
            _FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            _FinalFrame.Start();
        }
        private int w, h, c1, c2, d;
        Bitmap bitmapNew;
        Bitmap bitmapTemp;
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            _BitmapOld = bitmapTemp;
            bitmapTemp = new Bitmap(ConvertToGrayImage.ConvertToGrayScaleImage((Bitmap)eventArgs.Frame.Clone()));
            pictureBox1.Image = bitmapTemp;
            bitmapNew = (Bitmap) bitmapTemp.Clone();
            w = bitmapNew.Width;
            h = bitmapNew.Height;
            if (_BitmapOld != null)
            {
                for(int i=0; i< w; i+=3)
                {
                    for(int j = 0; j < h; j+=3)
                    {
                        c1 = bitmapNew.GetPixel(i, j).ToArgb();
                        c2 = _BitmapOld.GetPixel(i, j).ToArgb();
                        d = Math.Abs(c1 - c2);
                        if (d >500000)
                        {
                            bitmapNew.SetPixel(i, j, Color.Red);
                        }
                    }
                }
                pictureBox2.Image = bitmapNew;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _CaptureDevece = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in _CaptureDevece)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            _FinalFrame = new VideoCaptureDevice();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_FinalFrame.IsRunning)
            {
                _FinalFrame.Stop();
            }
        }
    }
}
