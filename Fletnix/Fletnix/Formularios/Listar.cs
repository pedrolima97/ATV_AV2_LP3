using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix.Formularios
{
    public partial class Listar : Form
    {
        public static string tipo;
        public static string cod_tittle;
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                Ver visu = new Ver();
                cod_tittle = textBox1.Text;
                char tp_tt = cod_tittle[0];
                if (tp_tt == 'F')
                {
                    tipo = "filme";
                    visu.tipo = "o filme";
                }

                else if (tp_tt == 'S')
                {
                    tipo = "serie";
                    visu.tipo = "a série";
                }

                Funcoes.BuscaBD.Buscar(cod_tittle, tipo);

                if (Funcoes.BuscaBD.status)
                {
                    visu.ShowDialog();
                }

                else
                {
                    return;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar _cadastrar = new Cadastrar();
            _cadastrar.ShowDialog();
        }
    }
}
