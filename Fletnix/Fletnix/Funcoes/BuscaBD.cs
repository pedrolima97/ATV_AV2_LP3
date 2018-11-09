using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class BuscaBD
    {
        public static bool status = false;
        static public void Buscar(string cod_tittle, string tipo)
        {
                using (MySqlConnection connecta = Dados.DAO_conn.getSqlConnection())
                try
                {
                    string table = "";
                    connecta.Open();
                    if (tipo == "serie")
                    {
                        table = "series";
                    }

                    else if (tipo == "filme")
                    {
                        table = "filmes";
                    }

                    string InsComand = "SELECT titulo, produtora, genero, sinopse, duracao, lancamento, direcao, folder FROM " + table + " WHERE cod_titulo='" + cod_tittle + "'";
                    MySqlCommand buscaa = new MySqlCommand(InsComand, connecta);
                    MySqlDataReader tittlee = buscaa.ExecuteReader();

                    tittlee.Read();

                    Dados.FilmeSerie.tittle.Cod = cod_tittle;
                    Dados.FilmeSerie.tittle.Tipo = tipo;
                    Dados.FilmeSerie.tittle.Titulo = tittlee["titulo"].ToString();
                    Dados.FilmeSerie.tittle.Produtora = tittlee["produtora"].ToString();
                    Dados.FilmeSerie.tittle.Genero = tittlee["genero"].ToString();
                    Dados.FilmeSerie.tittle.Sinopse = tittlee["sinopse"].ToString();
                    Dados.FilmeSerie.tittle.Duracao = tittlee["duracao"].ToString();
                    Dados.FilmeSerie.tittle.Lancamento = Convert.ToInt32(tittlee["lancamento"]);
                    Dados.FilmeSerie.tittle.Direcao = tittlee["direcao"].ToString();
                    Dados.FilmeSerie.tittle.Cartaz = tittlee["folder"].ToString();

                    status = true;

                }

                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    status = false;
                }

                finally
                {
                    connecta.Close();
                }
        }
    }
}
