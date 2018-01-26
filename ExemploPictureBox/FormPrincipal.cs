using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            pictureBoxs = new PictureBox[4];

            pictureBoxs[0] = pictureBox1;
            pictureBoxs[1] = pictureBox2;
            pictureBoxs[2] = pictureBox3;
            pictureBoxs[3] = pictureBox4;


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
    }
}
