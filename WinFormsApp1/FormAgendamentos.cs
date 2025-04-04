﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PIMVEscolaVencerSempre
{
    public partial class FormAgendamentos : Form
    {
        public FormAgendamentos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgendamentos_Load(object sender, EventArgs e)
        {
            CarregarAgendamentos();
        }

        private void CarregarAgendamentos()
        {
            BancoDadosHelper dbHelper = new BancoDadosHelper();
            SQLiteDataReader leitor = dbHelper.ConsultarAgendamentosComNomes();

            DataTable tabelaAgendamentos = new DataTable();
            tabelaAgendamentos.Load(leitor);

            dataGridViewAgendamentos.DataSource = tabelaAgendamentos;
        }
    }
}
