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
                string name_arq = openFileDialog1.FileName;
                Bitmap bmp = new Bitmap(name_arq);
                picture_cartaz.Image = bmp;
                cartaz = true;
            }
            else
            {
                return;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sel_tipo.Text == "") || (txt_titulo.Text == "") || (txt_sinopse.Text == "") || (txt_duracao.Text == "")
                   || (txt_lancamento.Text == "") || (txt_direcao.Text == "") || (txt_genero.Text == "") || (txt_distrib.Text == "") || cartaz == false)
                {
                    MessageBox.Show("Há campos vazios no formulário");
                }

                else
                {
                    string tipo = "";

                    Random cood = new Random();
                    int cod = cood.Next(0000, 9999);

                    char tp = char.ToUpper(sel_tipo.Text[0]);

                    switch (tp)
                    {
                        case 'F':
                            tipo = "F";
                            Inserir();
                            break;

                        case 'S':
                            tipo = "S";
                            Inserir();
                            break;

                        default:
                            MessageBox.Show("Opção inválida para tipo de título");
                            sel_tipo.Focus();
                            break;
                    }

                    void Inserir()
                    {
                        string cartaz = "IMG_" + tipo + cod.ToString();

                        Dados.FilmeSerie.tittle.Tipo = tipo;
                        Dados.FilmeSerie.tittle.Cod = tipo + Convert.ToString(cod);
                        Dados.FilmeSerie.tittle.Titulo = txt_titulo.Text;
                        Dados.FilmeSerie.tittle.Sinopse = txt_sinopse.Text;
                        Dados.FilmeSerie.tittle.Duracao = txt_duracao.Text;
                        Dados.FilmeSerie.tittle.Lancamento = Convert.ToInt32(txt_lancamento.Text);
                        Dados.FilmeSerie.tittle.Direcao = txt_direcao.Text;
                        Dados.FilmeSerie.tittle.Genero = txt_genero.Text;
                        Dados.FilmeSerie.tittle.Produtora = txt_distrib.Text;
                        Dados.FilmeSerie.tittle.Cartaz = cartaz;

                        Funcoes.InsertBD.Insert();

                        picture_cartaz.Image.Save(Application.StartupPath.ToString() + "\\Cartazz\\" + cartaz + ".bmp", ImageFormat.Bmp);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (Funcoes.InsertBD.Resposta())
                {
                    MessageBox.Show("Título inserido com sucesso");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
        }

    }
}
