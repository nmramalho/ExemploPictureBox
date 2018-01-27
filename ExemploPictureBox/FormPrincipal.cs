using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExemploPictureBox
{
    public partial class FormPrincipal : Form
    {
        private string[] imagens = { "um", "dois", "tres", "quatro" };
        private PictureBox[] pictureBoxs;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            pictureBoxs = new PictureBox[4];

            // ativar a operação Drop (largar) nas PictureBox
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;

            pictureBoxs[0] = pictureBox1;
            pictureBoxs[1] = pictureBox2;
            pictureBoxs[2] = pictureBox3;
            pictureBoxs[3] = pictureBox4;

            textBoxInstrucoes.Text = " Objetivo da aplicação:\r\n\r\n  --> Agarrar e largar (Drag and Drop) a imagens dos números nas PictureBoxes maiores " +
                "\r\n\r\n  --> Carregar as imagens automaticamente nas PictureBoxes maiores de acordo com os nomes " +
                " encontrados num array de strings, por exemplo  string[] imagens = { \"um\", \"dois\", \"tres\",\"quatro\" };";

        }

        private void ButtonCarregarImagens_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                CarregaImagem(pictureBoxs[i], imagens[i]);
            }

        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LimpaImagens(pictureBoxs[i], imagens[i]);
            }


        }

        private void LimpaImagens(PictureBox pic, string v)
        {
            pic.Image = null;
        }

        private void CarregaImagem(PictureBox pic, string nome)
        {
            switch (nome)
            {
                case "um":
                    pic.Image = Properties.Resources.um;
                    break;

                case "dois":
                    pic.Image = Properties.Resources.dois;
                    break;

                case "tres":
                    pic.Image = Properties.Resources.tres;
                    break;

                case "quatro":
                    pic.Image = Properties.Resources.quatro;
                    break;

                default:
                    break;
            }

        }


        private void pictureBoxUM_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxUM.DoDragDrop(pictureBoxUM.Image, DragDropEffects.Copy);
        }

        private void pictureBoxDOIS_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxDOIS.DoDragDrop(pictureBoxDOIS.Image, DragDropEffects.Copy);
        }

        private void pictureBoxTRES_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxTRES.DoDragDrop(pictureBoxTRES.Image, DragDropEffects.Copy);
        }

        private void pictureBoxQUATRO_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxQUATRO.DoDragDrop(pictureBoxQUATRO.Image, DragDropEffects.Copy);
        }



        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }


        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }


    }
}
