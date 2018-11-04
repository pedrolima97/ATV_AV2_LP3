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
            SingletonBD obj = SingletonBD.getInstance;
            if (obj != null)
            {
                obj.Buscar();
                MessageBox.Show("Busca OK");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ver visu = new Ver();
            visu.ShowDialog();
        }
    }
}
