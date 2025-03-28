using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIMVEscolaVencerSempre;

namespace WinFormsApp1
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgendamentos principal = new FormAgendamentos();
            principal.MdiParent = this;
            principal.Show();
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new NovoUsuario();
            novoUsuario.ShowDialog();
        }

        private void gestãoDeEquipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipamentos equipamentos = new Equipamentos();
            equipamentos.MdiParent = this;            
            equipamentos.Show();
        }

        private void novoEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoEquipamento novoEquipamento = new NovoEquipamento();
            novoEquipamento.ShowDialog();
        }

        private void gestãoDeUsuáriosToolStripMenuItem_click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;            
            formUsuarios.Show();
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void gestaoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;            
            formUsuarios.Show();
        }
    }
}
