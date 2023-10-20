using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarimagem_Click(object sender, EventArgs e)
        {
            //Mostrar a caixa de diálogo Abrir arquivo. Se o usuário clicar em OK, carregue o imagem que o usuário escolheu.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            
            
                // limpar a imagem.
                pictureBox1.Image = null;
            
        }

        private void definircor_Click(object sender, EventArgs e)
        {

            // Mostrar a caixa de diálogo de cor.Se o usuário clicar em OK, altere o
            // Plano de fundo do controle PictureBox para a cor que o usuário escolheu.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            //fechar
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Se o usuário marcar a caixa de seleção Alongar, alterar o PictureBox
            //SizeMode propriedade para "Stretch".Se o usuário limpar
            //a caixa de seleção, altere - a para "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
