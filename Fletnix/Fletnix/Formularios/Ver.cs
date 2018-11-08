﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fletnix
{
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }

        public string tipo;
        
        private void Ver_Load(object sender, EventArgs e)
        {
            this.Text = "Informações sobre "+tipo;
            
            lbl_titulo.Text = Dados.FilmeSerie.tittle.Titulo;
            lbl_lancamento.Text = Convert.ToString(Dados.FilmeSerie.tittle.Lancamento);
            lbl_duracao.Text = Dados.FilmeSerie.tittle.Duracao;
            lbl_genero.Text = Dados.FilmeSerie.tittle.Genero;
            lbl_direcao.Text = Dados.FilmeSerie.tittle.Direcao;
            lbl_produtora.Text = Dados.FilmeSerie.tittle.Produtora;
            lbl_sinopse.Text = Dados.FilmeSerie.tittle.Sinopse;
        }
    }
}
