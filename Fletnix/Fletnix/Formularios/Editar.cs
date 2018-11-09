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

        private void Ver_Load(object sender, EventArgs e)
        {
            this.Text = "Editar Título";
        }

        private void btn_buscaimg_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
               
        }
    }
}
