using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class UpdateBD
    {
        static public void Update(string cod_tittle, string tipo)
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

                    string Titulo = Dados.FilmeSerie.tittle.Titulo;
                    string Produtora = Dados.FilmeSerie.tittle.Produtora;
                    string Genero = Dados.FilmeSerie.tittle.Genero;
                    string Sinopse = Dados.FilmeSerie.tittle.Sinopse;
                    string Duracao = Dados.FilmeSerie.tittle.Duracao;
                    int Lancamento = Dados.FilmeSerie.tittle.Lancamento;
                    string Direcao = Dados.FilmeSerie.tittle.Direcao;

                    string InsComand = "UPDATE " + table + " SET titulo = '" + Titulo + "', produtora = '" + Produtora + "', genero = '" + Genero +
                    "', sinopse = '" + Sinopse + "', duracao =  '" + Duracao + "', lancamento = '" + Lancamento +
                    "', direcao = '" + Direcao + " WHERE cod_titulo = '" + cod_tittle + "'";
                    MySqlCommand updatee = new MySqlCommand(InsComand, connecta);
                    updatee.ExecuteNonQuery();
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
