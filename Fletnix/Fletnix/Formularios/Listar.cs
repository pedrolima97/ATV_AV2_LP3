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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ver visu = new Ver();
            visu.cod_tittle = textBox1.Text;
            visu.ShowDialog();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar _cadastrar = new Cadastrar();
            _cadastrar.ShowDialog();
        }
    }
}
