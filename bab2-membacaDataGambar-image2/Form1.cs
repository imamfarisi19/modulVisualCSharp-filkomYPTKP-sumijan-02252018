using System;
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
    }
}
