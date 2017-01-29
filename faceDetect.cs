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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.Cuda;
using System.Diagnostics;
using Emgu.CV.UI;
using System.IO;

namespace FaceRecogniztion
{
    public partial class faceDetect : Form
    {
        Mat matImg;//摄像头图像
        Capture capture;//摄像头对象

        Util.KingFaceDetect kfd;
        public faceDetect()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            kfd = new Util.KingFaceDetect();
            try
            {
                capture = new Capture();
                capture.Start();//摄像头开始工作
                capture.ImageGrabbed += frameProcess;//实时获取图像
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void frameProcess(object sender, EventArgs arg)
        {
            matImg = new Mat();
            capture.Retrieve(matImg, 0);
            picShow.Image = matImg.Bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            markFaces();//100毫秒检测一次人脸
        }
        private void markFaces()
        {
            try
            {
                picShow.Image = kfd.faceRecognize(capture.QueryFrame()).originalImg.Bitmap;
            }
            catch
            {
            }
        }

        private void 获取样本图片_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "")
            {
                MessageBox.Show("请输入样本姓名。");
            }
            else
            {
                string filePath = Application.StartupPath + "\\trainedFaces\\" + fullname.Text + "_" + System.Guid.NewGuid().ToString() + ".jpg";
                //sampleBox.Image.Save(filePath);
                Bitmap bmp = new Bitmap(sampleBox.Width, sampleBox.Height);
                sampleBox.DrawToBitmap(bmp, new Rectangle(0, 0, sampleBox.Width, sampleBox.Height));
                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("样本保存完毕。");
            }
        }


        int currentFaceFlag = 0;
        Util.KingFaceDetect.faceDetectedObj currentfdo;//点击鼠标时的人脸检测对象
        private void sampleBox_Click(object sender, EventArgs e)
        {
            currentfdo = kfd.GetFaceRectangle(capture.QueryFrame());
            currentFaceFlag = 0;
            getCurrentFaceSample(0);
        }

        private void getCurrentFaceSample(int i)
        {
            try
            {
                fullname.Text = "";
                Image<Gray, byte> result = currentfdo.originalImg.ToImage<Gray, byte>().Copy(currentfdo.facesRectangle[i]).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                result._EqualizeHist();//灰度直方图均衡化
                sampleBox.Image = result.Bitmap;
            }
            catch(Exception ex)
            {
                MessageBox.Show("没有检测到人脸");
            }
        }

        private void getFaceSample(int i)
        {
            try
            {
                fullname.Text = "";
                Image<Gray, byte> result = currentfdo.originalImg.ToImage<Gray, byte>().Copy(currentfdo.facesRectangle[i]).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                result._EqualizeHist();//灰度直方图均衡化
                sampleBox.Image = result.Bitmap;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("没有检测到人脸");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentFaceFlag == 0)
            {
                MessageBox.Show("已经是第一张");
            }
            else
            {
                currentFaceFlag--;
                
                getCurrentFaceSample(currentFaceFlag);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentfdo != null && currentFaceFlag == currentfdo.facesRectangle.Count-1)
            {
                MessageBox.Show("已经是最后一张");
            }
            else
            {
                currentFaceFlag++;
                getCurrentFaceSample(currentFaceFlag);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (recognizerType.Text)
            {
                case "EigenFaceRecognizer":
                    kfd.SetTrainedFaceRecognizer(Util.KingFaceDetect.FaceRecognizerType.EigenFaceRecognizer);
                    break;
                case "FisherFaceRecognizer":
                    kfd.SetTrainedFaceRecognizer(Util.KingFaceDetect.FaceRecognizerType.FisherFaceRecognizer);
                    break;
                case "LBPHFaceRecognizer":
                    kfd.SetTrainedFaceRecognizer(Util.KingFaceDetect.FaceRecognizerType.LBPHFaceRecognizer);
                    break;
            }
        }
    }
}
