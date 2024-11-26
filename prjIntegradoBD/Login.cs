using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            AutenticarUsuario();
        }

        private void AutenticarUsuario()
        {
            // String de conexão fornecida
            string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string usuario = txtUser.Text.Trim();
            string senha = txtSenha.Text;

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Usuário e senha são obrigatórios.");
                return;
            }

            // Query SQL para autenticar o usuário
            string query = "SELECT cargo FROM Admin WHERE nome_usuario = @usuario AND senha = @senha";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    connection.Open();
                    object cargo = command.ExecuteScalar();

                    if (cargo != null)
                    {
                        string cargoStr = cargo.ToString();

                        // Verifica o cargo e abre o formulário correspondente
                        if (cargoStr == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (cargoStr == "empregado")
                        {
                            EmpregadoForm empregadoForm = new EmpregadoForm();
                            empregadoForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Cargo inválido. Entre em contato com o administrador do sistema.");
                        }

                        this.Hide(); // Esconde o formulário de login
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao autenticar usuário: {ex.Message}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mostrar o formulário Home
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mostrar o formulário de criação de usuário
            Adicionar adicionarForm = new Adicionar();
            adicionarForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
