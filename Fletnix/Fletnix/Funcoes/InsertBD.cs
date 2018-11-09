using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class InsertBD
    {
        static public void Insert()
        {
                using (MySqlConnection connecta = Dados.DAO_conn.getSqlConnection())
                try
                {
                    string Tipo = Dados.FilmeSerie.tittle.Tipo;
                    string table = "";
                    connecta.Open();
                    if (Tipo == "S")
                    {
                        table = "series";
                    }

                    else if (Tipo == "F")
                    {
                        table = "filmes";
                    }

                    string Cod = Dados.FilmeSerie.tittle.Cod;
                    string Titulo = Dados.FilmeSerie.tittle.Titulo;
                    string Produtora = Dados.FilmeSerie.tittle.Produtora;
                    string Genero = Dados.FilmeSerie.tittle.Genero;
                    string Sinopse = Dados.FilmeSerie.tittle.Sinopse;
                    string Duracao = Dados.FilmeSerie.tittle.Duracao;
                    int Lancamento = Dados.FilmeSerie.tittle.Lancamento;
                    string Direcao = Dados.FilmeSerie.tittle.Direcao;
                    string Cartaz = Dados.FilmeSerie.tittle.Cartaz;

                    
                    string InsComand = "INSERT INTO " + table + " (cod_titulo ,titulo, produtora, genero, sinopse, duracao, lancamento, direcao, folder)" +
                        " VALUES ('" + Cod + "','" + Titulo + "','" + Produtora + "','" + Genero + "','" + Sinopse +"', '" + Duracao + "', '" + Lancamento + "', '" + Direcao + "','"+ Cartaz +"')";
                    MySqlCommand insertt = new MySqlCommand(InsComand, connecta);
                    insertt.ExecuteNonQuery();

                }

                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                finally
                {
                    connecta.Close();
                }
        }
    }
}
