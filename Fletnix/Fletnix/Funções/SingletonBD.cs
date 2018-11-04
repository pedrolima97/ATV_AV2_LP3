using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix
{
    public sealed class SingletonBD
    {
        static private SingletonBD instance = null;
        private static readonly object padlock = new object();

        private SingletonBD()
        {

        }

        static public SingletonBD getInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonBD();
                    }
                }
                return instance;
            }
        }

        static string connet = "Server=localhost;Database=filmeseseries;Uid=pedro;Pwd=2a4d5M675U2CD!";
        MySqlConnection conn = new MySqlConnection(connet);

        public void Buscar()
        {
            try
            {
                conn.Open();
                string queryyadd = "SELECT * FROM series";
                MySqlCommand buscaa = new MySqlCommand(queryyadd, conn);
                buscaa.ExecuteNonQuery();                
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
            }

            finally
            {
                conn.Close();
            }

        }

        public void Inserir()
        {
            try
            {
                conn.Open();
                string queryyadd = "SELECT * FROM series";
                MySqlCommand inseree = new MySqlCommand(queryyadd, conn);
                inseree.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
            }

            finally
            {
                conn.Close();
            }

        }

        public void Remover()
        {
            try
            {
                conn.Open();
                string queryyadd = "SELECT * FROM series";
                MySqlCommand removee = new MySqlCommand(queryyadd, conn);
                removee.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
            }

            finally
            {
                conn.Close();
            }

        }

        public void Atualizar()
        {
            try
            {
                conn.Open();
                string queryyadd = "SELECT * FROM series";
                MySqlCommand atualizz = new MySqlCommand(queryyadd, conn);
                atualizz.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
            }

            finally
            {
                conn.Close();
            }

        }
    }
}
