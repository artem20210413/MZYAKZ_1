using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOYKZ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showSizeInput()
        {
            if (_imgInput != null)
                sizeInput.Text = _imgInput.Size.Width.ToString() + "x" + _imgInput.Size.Height.ToString();
           
        }
        private void showSizeOutput()
        {
            if (_imgOutput != null)
                sizeOutput.Text = _imgOutput.Size.Width.ToString() + "x" + _imgOutput.Size.Height.ToString();

        }

        private Bitmap _imgInput;
        private Bitmap _imgOutput;

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBoxInput.SizeMode = PictureBoxSizeMode.Zoom;
                this._imgInput = new Bitmap(openFile.FileName);
                pictureBoxInput.Image = this._imgInput;
                showSizeInput();
            }

            
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);
            ProcessImage(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.Image = this._imgOutput;

            showSizeOutput();
        }

        public void ProcessImage(Bitmap bmp)
        {
            for(int i = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor =  bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    //int gray = (byte)(.299 * red + .587 * green + .114 * blue);
                    int gray = (byte)((red+green+blue)/3);
                    red = gray;
                    green = gray;
                    blue = gray;

                    bmp.SetPixel(i,j,Color.FromArgb(red, green, blue));
                }

            }

        }

        private void buttonInversion_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);
            colorInversion(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.Image = this._imgOutput;

            showSizeOutput();
        }

        private void colorInversion(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = 255 - bmpColor.R;
                    int green = 255 - bmpColor.G;
                    int blue = 255 - bmpColor.B;

                    bmp.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }

            }

        }

        private void buttonBinarization_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);
            byte T = Convert.ToByte(textBoxBinarization.Text);

            binarization(this._imgOutput, T);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.Image = this._imgOutput;

            showSizeOutput();
        }

        private void binarization(Bitmap bmp, int T)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int average = (byte)((red + green + blue) / 3);
                    byte binarization;
                    if (average < T)
                    {
                        binarization = 0;
                    }
                    else
                    {
                        binarization = 255;
                    }

                    bmp.SetPixel(i, j, Color.FromArgb(binarization, binarization, binarization));
                }

            }
        }

        

        

        private void buttonСontrasting_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);

            contrasting(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.Image = this._imgOutput;

            showSizeOutput();
        }

        private void contrasting(Bitmap bmp)
        {
            double min = 255, max = 0, color;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);

                    color = Convert.ToInt32((bmpColor.R + bmpColor.G + bmpColor.B) / 3);

                    if (min > color)
                        min = color;
                    if (max < color)
                        max = color;
                }

            }
            int result;
            int fix(double value)
            {
                result = Convert.ToInt32( Math.Round(((value - min) / (max - min)) * 255));
                return (result < 0) ? 0 : (result > 255) ? 255 : result;
            }
            int red, green, blue;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);

                    red = fix(bmpColor.R);
                    green = fix(bmpColor.G);
                    blue = fix(bmpColor.B);
                    bmp.SetPixel(i, j, Color.FromArgb(bmpColor.A, red, green, blue));
                }
            }
        }
        private void buttonIncreaseSize_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);

            extropolation(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.Image = this._imgOutput;

            showSizeOutput();
        }
        private void extropolation(Bitmap bmp)
        {
            Bitmap bitmap = new Bitmap(bmp.Width*2, bmp.Height * 2, PixelFormat.Format24bppRgb);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    bitmap.SetPixel(    i * 2,          j * 2       , bmp.GetPixel(i, j));
                    bitmap.SetPixel(    i * 2 + 1,      j * 2       , bmp.GetPixel(i, j));
                    bitmap.SetPixel(    i * 2,          j * 2 + 1   , bmp.GetPixel(i, j));
                    bitmap.SetPixel(    i * 2 + 1,      j * 2 + 1   , bmp.GetPixel(i, j));

                }
            }
            this._imgOutput = bitmap;

        }
        

        private void buttonIntropolation_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);

            intropolation(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.Image = this._imgOutput;

            showSizeOutput();
        }

        private void intropolation(Bitmap bmp)
        {

            byte s(double a, double b)
            { 
                return Convert.ToByte(Math.Round((a + b) / 2));
            }

            Bitmap bitmap = new Bitmap(bmp.Width * 2, bmp.Height * 2, PixelFormat.Format24bppRgb);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color C = bmp.GetPixel(i, j);              //bmpColor
                    bitmap.SetPixel(i * 2, j * 2, bmp.GetPixel(i, j));

                    if (i < bmp.Width-1)
                    {
                        Color CR = bmp.GetPixel(i + 1, j);     //bmpColorR
                        bitmap.SetPixel(i * 2 + 1, j * 2, Color.FromArgb(s(C.A, CR.A), s(C.R, CR.R), s(C.G, CR.G), s(C.B, CR.B)));
                    }
                    else
                        bitmap.SetPixel(i * 2 + 1, j * 2, bmp.GetPixel(i, j));

                    if (j < bmp.Height-1)
                    {
                        Color CB = bmp.GetPixel(i, j + 1);     //bmpColorB
                        bitmap.SetPixel(i * 2, j * 2 + 1, Color.FromArgb(s(C.A, CB.A), s(C.R, CB.R), s(C.G, CB.G), s(C.B, CB.B)));
                    }
                    else
                        bitmap.SetPixel(i * 2, j * 2 + 1, bmp.GetPixel(i, j));

                    if (i < bmp.Width-1 && j < bmp.Height-1)
                    {
                        Color CRB = bmp.GetPixel(i + 1, j + 1);  //bmpColorRB
                        bitmap.SetPixel(i * 2 + 1, j * 2 + 1, Color.FromArgb(s(C.A, CRB.A), s(C.R, CRB.R), s(C.G, CRB.G), s(C.B, CRB.B)));
                    }
                    else
                        bitmap.SetPixel(i * 2 + 1, j * 2 + 1, bmp.GetPixel(i, j));
                }
            }
            this._imgOutput = bitmap;
        }

        private void buttonLinearHistogram_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);


            this._imgOutput = linearHistogram(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOutput.Image = this._imgOutput;


        }

        private Bitmap linearHistogram(Bitmap bmp)
        {

            int[] arrBright = new int[256];


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int gray = (byte)((red + green + blue) / 3);

                    arrBright[gray]++;

                }

            }

            return showHistogram(arrBright);
        }

        int[] bubbleSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int z = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = z;
                    }
                }
            }
            return A;
        }

        int[] cumulativeSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
               //A[i] += (i!=0)? A[i - 1]: A[i];
               A[i] += A[i - 1];
            }
            return A;
        }

        private void cumulativeHistogram_Click(object sender, EventArgs e)
        {
            this._imgOutput = new Bitmap((Bitmap)this._imgInput);

            this._imgOutput = _cumulativeHistogram(this._imgOutput);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOutput.Image = this._imgOutput;

        }
        private Bitmap _cumulativeHistogram(Bitmap bmp)
        {

            int[] arrBright = new int[256];


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int gray = (byte)((red + green + blue) / 3);

                    arrBright[gray]++;

                }

            }

            arrBright = cumulativeSort(arrBright);

            return showHistogram(arrBright);
        }



        private Bitmap showHistogram(int[] arrBright)
        {

            int maxCountBright = 0;
            foreach (int el in arrBright)
            {
                if (maxCountBright < el)
                    maxCountBright = el;

            }

            int x = 255, y = maxCountBright;

            Bitmap bitmap = new Bitmap(x, y, PixelFormat.Format24bppRgb);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j <= arrBright[i])
                        bitmap.SetPixel(i, y - j - 1, Color.FromArgb(0, 0, 0, 0));
                    else
                        bitmap.SetPixel(i, y - j - 1, Color.FromArgb(255, 255, 255, 255));

                }
            }
            return bitmap;

        }

       
    }
}
