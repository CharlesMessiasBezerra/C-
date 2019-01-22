using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI
{
    public partial class frmMain : Form
    {
        public OpenFileDialog dlg;
        public Bitmap bmp;
        public Image img;
        public int[] listRed;
        public int[] listGreen;
        public int[] listBlue;
        public int[] listBlack;
        public int[] Qr;
        public int[] Qg;
        public int[] Qb;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "files (*.bmp; *.jpg; *.jpeg,*.png)| *.BMP; *.JPG; *.JPEG; *.PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                img = Image.FromFile(dlg.FileName);
                //PcbImagem.Width = img.Width;
                //PcbImagem.Height = img.Height;
                PcbImagem.Image = (img);

                GetPixel(img);
            }
        }    

        public void GetPixel(Image img)
        {
            bmp = new Bitmap(img);

            

            listRed = new int[256];
            listGreen = new int[256];
            listBlue = new int[256];
            listBlack = new int[256];

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    listRed[clr.R] += 1;
                    listGreen[clr.G] += 1;
                    listBlue[clr.B] += 1;
                    listBlack[((clr.R + clr.G + clr.B)/3)] += 1; 

                }
            }

            CtHist.Series[0].Points.DataBindY(listRed);
            CtHist.Series[1].Points.DataBindY(listGreen);
            CtHist.Series[2].Points.DataBindY(listBlue);
            CtHist.Series[3].Points.DataBindY(listBlack);
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void PcbImagem_MouseMove(object sender, MouseEventArgs e)
        {

            if (dlg != null)
            {

                lblPX.Text = " Posição X : " + Convert.ToString(Cursor.Position.X);
                lblPY.Text = " Posição Y : " + Convert.ToString(Cursor.Position.Y);             

            }

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            if (dlg != null && dlg.FileName != null)
            {

                img = Image.FromFile(dlg.FileName);
                PcbImagem.Image = (img);

                GetPixel(img);
            }

        }

        private void btnEqualizar_Click(object sender, EventArgs e)
        {
            if (!(listRed != null && listGreen != null && listBlue != null && listBlack != null && img != null)) {
                return;
            }

            int i,j,Sr,Sg,Sb;

            Qr = new int[256];
            Qg = new int[256];
            Qb = new int[256];

            
            i = (((img.Height * img.Width) / 256) - 1);

            Sr = 0;
            Sg = 0;
            Sb = 0;            
            // Red
            for ( int x =0; x < 256; x++ ) {

                Sr = Sr + listRed[x];
                Qr[x] = (Sr / i);

                Sb = Sb + listBlue[x];
                Qb[x] = (Sb / i);

                Sg = Sg + listGreen[x];
                Qg[x] = (Sg / i);
            }

            
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    

                    bmp.SetPixel(x, y,Color.FromArgb(bmp.GetPixel(x,y).A,Qr[bmp.GetPixel(x, y).R], Qg[bmp.GetPixel(x, y).G], Qb[bmp.GetPixel(x, y).B]));                    
                }
            }
            
            PcbImagem.Image = bmp;

        }
    }
}