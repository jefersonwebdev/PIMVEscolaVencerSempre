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
    //public partial class NovoAgendamento : Form
    //{
    //public NovoAgendamento()
    //{
    //InitializeComponent();
    //}

    //}
    //}



    public partial class NovoAgendamento : Form
    {
        //private int usuarioIdLogado;

        public NovoAgendamento()
        //public NovoAgendamento(int usuarioId)
        {
            InitializeComponent();
            //usuarioIdLogado = usuarioId;
            CarregarEquipamentosDisponiveis();
            CarregarUsuarios();
        }

        private void CarregarEquipamentosDisponiveis()
        {
            comboBoxEquipamento.DataSource = null;
            comboBoxEquipamento.Items.Clear();

            BancoDadosHelper dbHelper = new BancoDadosHelper();
            SQLiteDataReader leitor = dbHelper.ConsultarEquipamentosDisponiveis();

            while (leitor.Read())
            {
                comboBoxEquipamento.Items.Add(new Equipamento
                {
                    Id = Convert.ToInt32(leitor["id"]),
                    Nome = leitor["nome"].ToString()
                });
            }
            leitor.Close();
            comboBoxEquipamento.DisplayMember = "Nome";
            comboBoxEquipamento.ValueMember = "Id";
        }

        private void CarregarUsuarios()
        {
            comboBoxUsuario.DataSource = null;
            comboBoxUsuario.Items.Clear();

            BancoDadosHelper dbHelper = new BancoDadosHelper();
            SQLiteDataReader leitor = dbHelper.ConsultarUsuarios();

            while (leitor.Read())
            {
                comboBoxUsuario.Items.Add(new Usuario
                {
                    Id = Convert.ToInt32(leitor["id"]),
                    Nome = leitor["nome"].ToString()
                });
            }
            leitor.Close();
            comboBoxUsuario.DisplayMember = "Nome";
            comboBoxUsuario.ValueMember = "Id";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (comboBoxEquipamento.SelectedItem == null || comboBoxUsuario.SelectedItem == null)
            {
                // MessageBox.Show("Selecione um equipamento e um usuário.");
                MessageBox.Show("Selecione um equipamento e um usuário.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int equipamentoId = ((Equipamento)comboBoxEquipamento.SelectedItem).Id;
            int usuarioId = ((Usuario)comboBoxUsuario.SelectedItem).Id;
            string data = dateTimePickerData.Value.ToString("dd-MM-yyyy");
            string hora = maskedTextBoxHora.Text;
            string sala = textBoxSala.Text;

            BancoDadosHelper dbHelper = new BancoDadosHelper();
            int resultado = dbHelper.InserirAgendamento(equipamentoId, usuarioId, data, hora, sala);

            if (resultado > 0)
            {
                // MessageBox.Show("Agendamento cadastrado com sucesso!");
                MessageBox.Show("Agendamento cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // MessageBox.Show("Preencha todos os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Fecha o formulário de cadastro
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Equipamento
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        public class Usuario
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBoxEquipamento.SelectedItem == null || comboBoxUsuario.SelectedItem == null)
            {
                // MessageBox.Show("Selecione um equipamento e um usuário.");
                MessageBox.Show("Selecione um equipamento e um usuário.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int equipamentoId = ((Equipamento)comboBoxEquipamento.SelectedItem).Id;
            int usuarioId = ((Usuario)comboBoxUsuario.SelectedItem).Id;
            string data = dateTimePickerData.Value.ToString("dd-MM-yyyy");
            string hora = maskedTextBoxHora.Text;
            string sala = textBoxSala.Text;

            BancoDadosHelper dbHelper = new BancoDadosHelper();
            int resultado = dbHelper.InserirAgendamento(equipamentoId, usuarioId, data, hora, sala);

            if (resultado > 0)
            {
                dbHelper.AtualizarStatusEquipamento(equipamentoId, "Indisponível");
                // MessageBox.Show("Agendamento cadastrado com sucesso!");
                MessageBox.Show("Agendamento cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Preencha todos os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Fecha o formulário de cadastro
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar agendamento.");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
