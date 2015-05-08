using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;



namespace GraphicsTest
{
    public partial class Form1 : Form
    {
        String msg;
        Boolean[] bin_msg;
        float L;
        float bit_circle_rad;
        float rnd_circle_rad;
        float first_circle_rad;
        float second_circle_rad;
        PointF[] hexcenter;

        public Form1()
        {
            msg = "";
            bin_msg = new Boolean[12 * 6];
            for (int i = 0; i < 12 * 6; i++) bin_msg[i] = false;

            L = 100;
            
            bit_circle_rad = 5;
            rnd_circle_rad = 10;
            first_circle_rad = 15;
            second_circle_rad = 25;
            //int X = pictureBox1.Width;
            //int Y = pictureBox1.Height;
            
                                 
            InitializeComponent();
        }



        //------ Graphics part------------------------------
        


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //this.DoubleBuffered = true;

            
            SolidBrush opaqueBrush = new SolidBrush(Color.FromArgb(32, 0, 0, 255));
            SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(32, 0, 255, 0));
            int X = 450;//0.5 * pictureBox1.Width;
            int Y = 325;//0.5 * pictureBox1.Height;
            PointF[] hexcenter = {
                new PointF((float)((float)X - 1.5F * (float)L), (float)((float)Y - 0.866025F * (float)L)),
                new PointF((float)X , (float)(Y - 1.732051F * L)),
                new PointF((float)(X + 1.5F * L), (float)(Y - 0.866025F * L)),
                new PointF((float)(X + 1.5F * L), (float)(Y + 0.866025F * L)),
                new PointF((float)X, (float)(Y + 1.732051F * L)),
                new PointF((float)X, (float)Y)
            };

            Pen pen = new Pen(opaqueBrush, 4);

            #region drawBorders
            //drawborder           
            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)Y, (float)(X - (float)(2.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2.5 * L)), (float)(Y - (float)(0.866025F * L)), (float)(X - (float)(2 * L)), (float)(Y - (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)(Y - (float)(1.732051F * L)), (float)(X - (float)L), (float)(Y - (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X - (float)(0.5 * L)), (float)(Y - (float)(2.598076F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y - (float)(2.598076F * L)), (float)(X + (float)(0.5 * L)), (float)(Y - (float)(2.598076F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(0.5 * L)), (float)(Y - (float)(2.598076F * L)), (float)(X + (float)L), (float)(Y - (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X + (float)(2 * L)), (float)(Y - (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(2 * L)), (float)(Y - (float)(1.732051F * L)), (float)(X + (float)(2.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(2.5 * L)), (float)(Y - (float)(0.866025F * L)), (float)(X + (float)(2 * L)), (float)Y);

            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)Y, (float)(X - (float)(2.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2.5 * L)), (float)(Y + (float)(0.866025F * L)), (float)(X - (float)(2 * L)), (float)(Y + (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)(Y + (float)(1.732051F * L)), (float)(X - (float)L), (float)(Y + (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X - (float)(0.5 * L)), (float)(Y + (float)(2.598076F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y + (float)(2.598076F * L)), (float)(X + (float)(0.5 * L)), (float)(Y + (float)(2.598076F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(0.5 * L)), (float)(Y + (float)(2.598076F * L)), (float)(X + (float)L), (float)(Y + (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X + (float)(2 * L)), (float)(Y + (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(2 * L)), (float)(Y + (float)(1.732051F * L)), (float)(X + (float)(2.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(2.5 * L)), (float)(Y + (float)(0.866025F * L)), (float)(X + (float)(2 * L)), (float)Y);

            // draw inner borders
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X - (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X + (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)), (float)(X + (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X - (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X + (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)), (float)(X + (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)Y, (float)(X - (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X + (float)(2 * L)), (float)Y, (float)(X + (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)Y, (float)(X - (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)Y, (float)(X + (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)Y, (float)(X - (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)Y, (float)(X + (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));

            //draw triangle borders
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X + (float)L), (float)(Y - (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y - (float)(2.598076F * L)), (float)(X + (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(0.5 * L)), (float)(Y - (float)(2.598076F * L)), (float)(X - (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X + (float)L), (float)(Y + (float)(1.732051F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y + (float)(2.598076F * L)), (float)(X + (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(0.5 * L)), (float)(Y + (float)(2.598076F * L)), (float)(X - (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)Y, (float)(X + (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)), (float)(X + (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)), (float)(X + (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)(Y - (float)(1.732051F * L)), (float)(X - (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X - (float)(2 * L)), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X - (float)(2.5 * L)), (float)(Y - (float)(0.866025F * L)), (float)(X - (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(2 * L)), (float)(Y - (float)(1.732051F * L)), (float)(X + (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)(Y - (float)(1.732051F * L)), (float)(X + (float)(2 * L)), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X + (float)(2.5 * L)), (float)(Y - (float)(0.866025F * L)), (float)(X + (float)(0.5 * L)), (float)(Y - (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X - (float)(2 * L)), (float)(Y + (float)(1.732051F * L)), (float)(X - (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X - (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X - (float)(2 * L)), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X - (float)(2.5 * L)), (float)(Y + (float)(0.866025F * L)), (float)(X - (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            e.Graphics.DrawLine(pen, (float)(X + (float)(2 * L)), (float)(Y + (float)(1.732051F * L)), (float)(X + (float)L), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X + (float)L), (float)(Y + (float)(1.732051F * L)), (float)(X + (float)(2 * L)), (float)Y);
            e.Graphics.DrawLine(pen, (float)(X + (float)(2.5 * L)), (float)(Y + (float)(0.866025F * L)), (float)(X + (float)(0.5 * L)), (float)(Y + (float)(0.866025F * L)));
            #endregion


            //draw circles

           

            PointF[] pf = new PointF[134];
            float closedist = (float)(0.37153F * L);
            float fardist = (float)(0.717564F * L);
            SolidBrush trueBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 0));
            SolidBrush falseBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 255));

            int N = 0;
            for (int i = 0; i < 6; i++)
            {
                pf[N] = new PointF(hexcenter[i].X, hexcenter[i].Y);
                N++;
                /*
                for (int k = 30; k <=360; k += 60)
                {
                    pf[N++] = new PointF(hexcenter[i].X + (float)(Math.Cos((double)k) * closedist), hexcenter[i].Y + (float)(Math.Sin((double)k) * closedist));
                    e.Graphics.FillEllipse(trueBrush, pf[N-1].X, pf[N-1].Y, 10, 10);
                }
                for (int k = 15; k <= 360; k += 30)
                {
                    pf[N++] = new PointF(hexcenter[i].X + (float)(Math.Cos((double)k) * fardist), hexcenter[i].Y + (float)(Math.Sin((double)k) * fardist));
                    e.Graphics.FillEllipse(trueBrush, pf[N - 1].X, pf[N - 1].Y, 10, 10);
                }*/
                pf[N++] = new PointF(hexcenter[i].X + (float)(closedist * 0.866025F), hexcenter[i].Y - (float)(closedist / 2));
                pf[N++] = new PointF(hexcenter[i].X, hexcenter[i].Y - (float)closedist);
                pf[N++] = new PointF(hexcenter[i].X - (float)(closedist * 0.866025F), hexcenter[i].Y - (float)(closedist / 2));
                pf[N++] = new PointF(hexcenter[i].X - (float)(closedist * 0.866025F), hexcenter[i].Y + (float)(closedist / 2));
                pf[N++] = new PointF(hexcenter[i].X, hexcenter[i].Y + (float)closedist);
                pf[N++] = new PointF(hexcenter[i].X + (float)(closedist * 0.866025F), hexcenter[i].Y + (float)(closedist / 2));

                pf[N++] = new PointF(hexcenter[i].X + (float)(fardist * 0.965926), hexcenter[i].Y - (float)(fardist * 0.258819));
                pf[N++] = new PointF(hexcenter[i].X + (float)(fardist * 0.707107), hexcenter[i].Y - (float)(fardist * 0.707107));
                pf[N++] = new PointF(hexcenter[i].X + (float)(fardist * 0.258819), hexcenter[i].Y - (float)(fardist * 0.965926));
                pf[N++] = new PointF(hexcenter[i].X - (float)(fardist * 0.258819), hexcenter[i].Y - (float)(fardist * 0.965926));
                pf[N++] = new PointF(hexcenter[i].X - (float)(fardist * 0.707107), hexcenter[i].Y - (float)(fardist * 0.707107));
                pf[N++] = new PointF(hexcenter[i].X - (float)(fardist * 0.965926), hexcenter[i].Y - (float)(fardist * 0.258819));

                pf[N++] = new PointF(hexcenter[i].X - (float)(fardist * 0.965926), hexcenter[i].Y + (float)(fardist * 0.258819));
                pf[N++] = new PointF(hexcenter[i].X - (float)(fardist * 0.707107), hexcenter[i].Y + (float)(fardist * 0.707107));
                pf[N++] = new PointF(hexcenter[i].X - (float)(fardist * 0.258819), hexcenter[i].Y + (float)(fardist * 0.965926));
                pf[N++] = new PointF(hexcenter[i].X + (float)(fardist * 0.258819), hexcenter[i].Y + (float)(fardist * 0.965926));
                pf[N++] = new PointF(hexcenter[i].X + (float)(fardist * 0.707107), hexcenter[i].Y + (float)(fardist * 0.707107));
                pf[N++] = new PointF(hexcenter[i].X + (float)(fardist * 0.965926), hexcenter[i].Y + (float)(fardist * 0.258819));
            }
            SolidBrush NullBrush = new SolidBrush(Color.FromArgb(255, 125, 125, 125));
            for (int i = 0; i < N; i++)
            {
                if (i >= 72) e.Graphics.FillEllipse(NullBrush, (int)pf[i].X, (int)pf[i].Y, 10, 10);
                else
                {
                    if (bin_msg[i] == true) e.Graphics.FillEllipse(trueBrush, (int)pf[i].X, (int)pf[i].Y, 10, 10);
                    else e.Graphics.FillEllipse(falseBrush, (int)pf[i].X, (int)pf[i].Y, 10, 10);
                }
            }

            PointF[] pfV = new PointF[N];
            float delta = 10.0F;
            float temp = 0F;
            int signx, signy;
            Random rnd = new Random();
            signx = signy = 1;
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            for (int i = 0; i < N; i++)
            {

                temp = (float)rnd.NextDouble(); //0..1
                if (rnd.Next(0, 2) == 1) signx = -1 * signx;
                if (rnd.Next(0, 2) == 1) signy = -1 * signy;
                pfV[i] = new PointF(pf[i].X + delta * signx * temp, pf[i].Y + delta * signy * (float)Math.Sqrt(1 - temp * temp));
                e.Graphics.FillEllipse(blackBrush, (int)pfV[i].X, (int)pfV[i].Y, 5, 5);
            }
        }

        //------ Graphics part END------------------------------
// Generating message and button work
        String genMsg()
        {
            // lowChars 97-122
            // highChars 65 - 90
            // nums 48 - 57
            String k = "";
            Random rnd = new Random();
            int l = 0;
            l = rnd.Next(0, 3);

            for (int i = 0; i < 12; i++)
            {
                switch (l)
                {
                    case 0: k = k + (char)(rnd.Next(48, 58)); break;
                    case 1: k = k + (char)(rnd.Next(97, 123)); break;
                    case 2: k = k + (char)(rnd.Next(65, 91)); break;
                }
                l = rnd.Next(0, 3);
            }
            return k;
        }
        void MsgToBinary(String msg)
        {
            // lowChars 97-122
            // highChars 65 - 90
            // nums 48 - 57
            
            Byte x;
            for (int i = 0; i < 12; i++)
            {
                x = (byte)msg[i];

                if (char.IsLower(msg[i])) x = (byte)(x - (byte)97);
                else
                {
                    if (char.IsUpper(msg[i])) x = (byte)(x-(byte)36); //x-65+26
                    else if (char.IsDigit(msg[i])) x = (byte)(x + (byte)4); //x-48+26+26
                }
                for (int j = 0; j <= 5; j++) bin_msg[i * 6 + 5 - j] = Convert.ToBoolean(x & (int)Math.Pow(2,j));
            }
        }

        private void SaveImgBtn_Click(object sender, EventArgs e)
        {
            /*
             *  SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
        sfd.Title = "Сохранение картинки в файл";
        sfd.ShowDialog();
        if(sfd.FileName != "")
        {
          FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
          switch (Path.GetExtension(sfd.FileName).ToUpper())
          {
            case ".TIF":
              picfrmCarrierService.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
              break;
            case ".JPG":
              picfrmCarrierService.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
              break;
            case ".PNG":
              picfrmCarrierService.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
              break;
            case ".GIF":
              picfrmCarrierService.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
              break;
          }
          fs.Close();  
        }
          
       }
            */
            /*
          Bitmap bmpSave = (Bitmap)pictureBox1.Image;
          SaveFileDialog sfd = new SaveFileDialog();
          sfd.DefaultExt = "bmp";
          sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
          if (sfd.ShowDialog() == DialogResult.OK)
              bmpSave.Save(sfd.FileName, ImageFormat.Bmp);*/
            //pictureBox.Image.Save(@"", ImageFormat.Png);
            string path;
            path = System.IO.Path.GetDirectoryName(
               System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);


            Bitmap savedBit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(savedBit, pictureBox1.ClientRectangle);
            savedBit.Save("C:\\1.bmp");
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            msg = genMsg();
            MsgTextBox.Text = msg;
            MsgToBinary(msg);
            pictureBox1.Refresh();
        }


        private void ManGenerateBtn_Click(object sender, EventArgs e)
        {
            string s = "";
            s = ManualTextBox.Text;
            if (s.Length > 0 && s.Length <= 12)
            {
                 MsgToBinary(s);
                 pictureBox1.Refresh();
             }
        }

    }
}
