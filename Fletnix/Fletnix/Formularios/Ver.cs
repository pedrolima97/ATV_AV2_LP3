using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix.Formularios
{
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }

        public string tipo;
        
        private void Ver_Load(object sender, EventArgs e)
        {
            this.Text = "Informações sobre "+tipo;
            
            lbl_titulo.Text = Dados.FilmeSerie.tittle.Titulo;
            lbl_lancamento.Text = Convert.ToString(Dados.FilmeSerie.tittle.Lancamento);
            lbl_duracao.Text = Dados.FilmeSerie.tittle.Duracao;
            lbl_genero.Text = Dados.FilmeSerie.tittle.Genero;
            lbl_direcao.Text = Dados.FilmeSerie.tittle.Direcao;
            lbl_produtora.Text = Dados.FilmeSerie.tittle.Produtora;
            lbl_sinopse.Text = Dados.FilmeSerie.tittle.Sinopse;
            Bitmap bmp = new Bitmap(Application.StartupPath.ToString() + "\\Cartazz\\" + Dados.FilmeSerie.tittle.Cartaz + ".bmp");
            picture_cartaz.Image = bmp;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Editar _editar = new Editar();
            _editar.cod_tittle = Dados.FilmeSerie.tittle.Cod;
            _editar.tipo = Dados.FilmeSerie.tittle.Tipo;
            _editar.ShowDialog();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Funcoes.DeleteBD.Delete(Dados.FilmeSerie.tittle.Cod, Dados.FilmeSerie.tittle.Tipo);
            }

            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (Funcoes.DeleteBD.Resposta())
                {
                    MessageBox.Show("Título removido com sucesso");
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
