using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                Dispose();

                Menu _menu = new Menu();
                _menu.Show();
            }
        }
    }
}
