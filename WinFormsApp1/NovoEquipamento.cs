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
    public partial class NovoEquipamento : Form
    {
        public NovoEquipamento()
        {
            InitializeComponent();
        }

        private void NovoEquipamento_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string tipo = tb_tipo.Text;
            string descricao = tb_descricao.Text;
            string status = cb_status.SelectedItem.ToString();

            BancoDadosHelper dbHelper = new BancoDadosHelper();
            int resultado = dbHelper.InserirEquipamento(nome, tipo, descricao, status);

            if (resultado > 0)
            {
                MessageBox.Show("Equipamento cadastrado com sucesso!");
                this.Close(); // Fecha o formulário de cadastro
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar equipamento.");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
