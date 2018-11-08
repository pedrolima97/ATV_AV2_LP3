﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Funcoes
{
    class ReaderDGV
    {
        public static bool status = false;
        static public void Select(string cod_tittle, string tipo)
        {
            Dados.FilmeSerie tittle = new Dados.FilmeSerie();
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

                    string InsComand = "SELECT titulo, produtora, genero, sinopse, duracao, lancamento, direcao FROM " + table + " WHERE cod_titulo='" + cod_tittle + "'";
                    MySqlCommand buscaa = new MySqlCommand(InsComand, connecta);
                    MySqlDataReader tittlee = buscaa.ExecuteReader();
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
