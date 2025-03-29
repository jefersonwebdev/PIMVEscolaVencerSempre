using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMVEscolaVencerSempre
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;
            string tipo = comboBoxTipo.SelectedItem.ToString();

            BancoDadosHelper dbHelper = new BancoDadosHelper();
            int resultado = dbHelper.InserirUsuario(nome, login, senha, tipo);

            if (resultado > 0)
            {
                //MessageBox.Show("Usuário cadastrado com sucesso!");
                MessageBox.Show("Usuário cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Preencha todos os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Fecha o formulário de cadastro
            }
            else
            {
                //MessageBox.Show("Erro ao cadastrar usuário.");
                MessageBox.Show("Erro ao cadastrar usuário.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
