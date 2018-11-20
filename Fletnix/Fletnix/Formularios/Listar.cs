using MySql.Data.MySqlClient;
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
            using (MySqlConnection connecta = Dados.DAO_conn.getSqlConnection())
            try
            {
                    connecta.Open();
                    string buscaf = "SELECT cod_titulo, titulo FROM filmes UNION " +
                        "SELECT cod_titulo, titulo FROM series";
                    MySqlCommand insertt = new MySqlCommand(buscaf, connecta);
                    MySqlDataReader listaf = insertt.ExecuteReader(); 

                    int nColunas = listaf.FieldCount;

                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView1.Columns.Add(listaf.GetName(i).ToUpper(), listaf.GetName(i).ToUpper());
                }

                //Define um array de strings com ncolunas
                string[] linhaDados = new string[nColunas];

                //Percorre o DataRead
                while (listaf.Read())
                {
                    //Percorre cada uma das colunas
                    for (int a = 0; a < nColunas; a++)
                    {
                        //Verifica o tipo de dados da coluna

                        if (listaf.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = listaf.GetInt32(a).ToString();
                        }

                        if (listaf.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = listaf.GetString(a).ToString();
                        }

                        if (listaf.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = listaf.GetDateTime(a).ToString();
                        }
                    }

                    //Atribui a linha ao datagridview
                    dataGridView1.Rows.Add(linhaDados);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                Ver visu = new Ver();
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

        private void Set_Cod(object sender, DataGridViewCellEventArgs e)
        {
            cod_tittle = Convert.ToString(dataGridView1["cod_titulo", e.RowIndex].Value);
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar _cadastrar = new Cadastrar();
            _cadastrar.ShowDialog();
        }

        
    }
}
