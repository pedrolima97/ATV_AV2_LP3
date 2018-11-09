using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletnix.Dados
{
    public sealed class FilmeSerie
    {
        private string titulo;
        private string sinopse;
        private string duracao;
        private int lancamento;
        private string direcao;
        private string genero;
        private string produtora;
        private string cartaz;

        public string Tipo;
        public string Cod;
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Sinopse { get { return sinopse; } set { sinopse = value; } }
        public string Duracao { get { return duracao; } set { duracao = value; } }
        public int Lancamento { get { return lancamento; } set { lancamento = value; } }
        public string Direcao { get { return direcao; } set { direcao = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Produtora { get { return produtora; } set { produtora = value; } }
        public string Cartaz { get { return cartaz; } set { cartaz = value; } }

        //retornar imagem do bd

        public static FilmeSerie tittle = new FilmeSerie();
        


    }
}
