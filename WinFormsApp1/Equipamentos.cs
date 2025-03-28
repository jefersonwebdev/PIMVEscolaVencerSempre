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
using System.Windows.Forms.VisualStyles;

namespace PIMVEscolaVencerSempre
{
    public partial class Equipamentos : Form
    {
        public Equipamentos()
        {
            InitializeComponent();
            CarregarEquipamentos();
        }

        private void CarregarEquipamentos()
        {
            BancoDadosHelper dbHelper = new BancoDadosHelper();
            SQLiteDataReader leitor = dbHelper.ConsultarEquipamentos();

            DataTable tabelaEquipamentos = new DataTable();
            tabelaEquipamentos.Load(leitor);

            dataGridViewEquipamentos.DataSource = tabelaEquipamentos;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            
        }                
    }
}
