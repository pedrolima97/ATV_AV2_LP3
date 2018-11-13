using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Fletnix.Formularios
{
    public partial class Cadastrar : Form
    {
        bool cartaz = false;

        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Ver_Load(object sender, EventArgs e)
        {
            this.Text = "Adicionar Título";
        }

        private void btn_buscaimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Localizar Cartaz";
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "Arquivo PNG, JPG (*.png, *.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome_a = openFileDialog1.FileName;
                Bitmap bmp = new Bitmap(nome_a);
                picture_cartaz.Image = bmp;
                cartaz = true;

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Dados.FilmeSerie.tittle.Direcao = txt_direcao.Text;
            Dados.FilmeSerie.tittle.Titulo = txt_titulo.Text;
            Dados.FilmeSerie.tittle.Sinopse = txt_sinopse.Text;
            Dados.FilmeSerie.tittle.Duracao = txt_duracao.Text;
            Dados.FilmeSerie.tittle.Lancamento = Convert.ToInt32(txt_lancamento.Text);
            Dados.FilmeSerie.tittle.Genero = txt_genero.Text;
            Dados.FilmeSerie.tittle.Produtora = txt_distrib.Text;

            Funcoes.InsertBD.Insert();

            picture_cartaz.Image.Save(Application.StartupPath.ToString() + "\\Cartazz\\" + Dados.FilmeSerie.tittle.Cartaz + ".bmp", ImageFormat.Bmp);


        }
    }
}
