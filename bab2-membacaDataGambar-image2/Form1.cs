﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bab2_membacaDataGambar_image2
{
   public partial class Form1 : Form
   {
      Bitmap objBitmap;
      Bitmap objBitmap1;

      public Form1()
      {
         InitializeComponent();
      }

        private void button1_Click(object sender, EventArgs e)
        {
         DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
               objBitmap = new Bitmap(openFileDialog1.FileName);
               pictureBox1.Image = objBitmap;
            }
        }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 0; x < objBitmap.Width; x++)
            for (int y = 0; y < objBitmap.Height; y++)
            {
               Color w = objBitmap.GetPixel(x, y);
               objBitmap1.SetPixel(x, y, w);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void button3_Click(object sender, EventArgs e)
      {
         objBitmap1 = new Bitmap(objBitmap);
         for(int x = 0; x < objBitmap.Width; x++)
            for (int y = 0; y < objBitmap.Height; y++)
            {
               Color w = objBitmap.GetPixel(x ,y);
               objBitmap1.SetPixel(objBitmap.Width - 1 - x, y, w);
            }
         pictureBox2.Image = objBitmap1;
      }
   }
}
