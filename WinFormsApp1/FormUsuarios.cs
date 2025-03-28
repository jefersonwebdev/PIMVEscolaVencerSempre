using System;
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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            CarregarUsuarios();
        }


        private void CarregarUsuarios()
        {
            BancoDadosHelper dbHelper = new BancoDadosHelper();
            SQLiteDataReader leitor = dbHelper.ConsultarUsuarios();

            DataTable tabelaUsuarios = new DataTable();
            tabelaUsuarios.Load(leitor);

            dataGridViewUsuarios.DataSource = tabelaUsuarios;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
