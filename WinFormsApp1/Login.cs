using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = tb_usuario.Text;
            string senha = tb_senha.Text;

            if (AutenticarUsuario(login, senha))
            {
                //MessageBox.Show("Login realizado com sucesso!");
                MessageBox.Show("Login realizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Abra o formulário principal do sistema
                Reserva reserva = new Reserva();
                reserva.Show();

                this.Hide(); // Oculta o formulário de login
            }
            else
            {
                //MessageBox.Show("Nome de usuário ou senha incorretos.");
                MessageBox.Show("Nome de usuário ou senha incorretos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AutenticarUsuario(string login, string senha)
        {
            BancoDadosHelper dbHelper = new BancoDadosHelper();
            SQLiteDataReader leitor = dbHelper.ConsultarUsuarios();

            while (leitor.Read())
            {
                if (leitor["login"].ToString() == login && leitor["senha"].ToString() == senha)
                {
                    leitor.Close();
                    return true; // Usuário autenticado
                }
            }

            leitor.Close();
            return false; // Usuário não encontrado ou senha incorreta
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}