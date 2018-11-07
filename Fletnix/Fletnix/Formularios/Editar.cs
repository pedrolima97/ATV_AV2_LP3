using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        static public string cod_tittle;
        static string tipo;
        Funcoes.FilmeSerie tittle = new Funcoes.FilmeSerie();


        private void Editar_Load(object sender, EventArgs e)
        {
            char tp_tt = cod_tittle[0];
            if (tp_tt == 'F')
            {
                tipo = "filme";
            }

            else if (tp_tt == 'S')
            {
                tipo = "serie";
            }
            Funcoes.BuscaBD.Buscar(cod_tittle, tipo);

            txt_titulo.Text = tittle.Nome;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            tittle.Nome = txt_titulo.Text;
            Funcoes.UpdateBD.Update(cod_tittle, tipo);
        }
    }
}
