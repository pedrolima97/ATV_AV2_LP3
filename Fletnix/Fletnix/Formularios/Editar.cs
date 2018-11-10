using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Fletnix.Formularios
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        public string cod_tittle, tipo;
        bool cartaz = true;
        public string n_cartaz;

        private void Ver_Load(object sender, EventArgs e)
        {
            this.Text = "Editar Título";
            Funcoes.BuscaBD.Buscar(cod_tittle, tipo);
            txt_titulo.Text = Dados.FilmeSerie.tittle.Titulo;
            txt_direcao.Text = Dados.FilmeSerie.tittle.Direcao;
            txt_distrib.Text = Dados.FilmeSerie.tittle.Produtora;
            txt_duracao.Text = Dados.FilmeSerie.tittle.Duracao;
            txt_genero.Text = Dados.FilmeSerie.tittle.Genero;
            txt_lancamento.Text = Convert.ToString(Dados.FilmeSerie.tittle.Lancamento);
            txt_sinopse.Text = Dados.FilmeSerie.tittle.Sinopse;
            Bitmap bmp = new Bitmap(Application.StartupPath.ToString() + "\\Cartazz\\" + Dados.FilmeSerie.tittle.Cartaz + ".bmp");
            picture_cartaz.Image = bmp;
            
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

            try
            {
                if ((txt_titulo.Text == "") || (txt_sinopse.Text == "") || (txt_duracao.Text == "") || (txt_lancamento.Text == "")
                    || (txt_direcao.Text == "") || (txt_genero.Text == "") || (txt_distrib.Text == "") || cartaz == false)
                {
                    MessageBox.Show("Existem campos vazios no formulário!");
                }
                else
                {
                    
                    if (tipo == "filme")
                    {
                       n_cartaz = "IMG_" + tipo + cod_tittle;
                    }
                    else if (tipo == "serie")
                    {
                        n_cartaz = "IMG_" + tipo + cod_tittle;
                    }

                    Dados.FilmeSerie.tittle.Titulo = txt_titulo.Text;
                    Dados.FilmeSerie.tittle.Sinopse = txt_sinopse.Text;
                    Dados.FilmeSerie.tittle.Produtora = txt_distrib.Text;
                    Dados.FilmeSerie.tittle.Lancamento = Convert.ToInt32(txt_lancamento.Text);
                    Dados.FilmeSerie.tittle.Genero = txt_genero.Text;
                    Dados.FilmeSerie.tittle.Duracao = txt_duracao.Text;
                    Dados.FilmeSerie.tittle.Direcao = txt_direcao.Text;
                    Dados.FilmeSerie.tittle.Cartaz = n_cartaz;

                    Funcoes.UpdateBD.Update(cod_tittle, tipo);
                    picture_cartaz.Image.Save(Application.StartupPath.ToString() + "\\Cartazz\\" + Dados.FilmeSerie.tittle.Cartaz + ".bmp", ImageFormat.Bmp);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
