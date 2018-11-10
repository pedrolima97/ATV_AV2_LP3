using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix.Formularios.Avisos
{
    public partial class Avisos : Form
    {
        public Avisos()
        {
            InitializeComponent();
        }

        private void Avisos_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }
    }
}
