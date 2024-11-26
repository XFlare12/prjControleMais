using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();

            // Configurar os campos de senha para exibir asteriscos
            txtSenha.PasswordChar = '*';
            txtSenhaConfirm.PasswordChar = '*';
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {
            // Configuração inicial, caso necessário
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;
            string senhaConfirm = txtSenhaConfirm.Text;

            // Verificar se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(senhaConfirm))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            // Verificar se apenas uma opção está selecionada
            if (checkOpcoes.CheckedItems.Count != 1)
            {
                MessageBox.Show("Por favor, selecione apenas um tipo de usuário.");
                return;
            }

            // Determinar o cargo selecionado
            string tipoUsuario = checkOpcoes.CheckedItems[0].ToString().ToLower();

            // Verificar se as senhas coincidem
            if (senha != senhaConfirm)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // String de conexão com o banco de dados
            string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            // Query para inserir novo usuário na tabela
            string queryInserir = "INSERT INTO Admin (nome, nome_usuario, senha, cargo) VALUES (@nome, @usuario, @senha, @tipoUsuario)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand commandInserir = new SqlCommand(queryInserir, connection);
                    commandInserir.Parameters.AddWithValue("@nome", nome);
                    commandInserir.Parameters.AddWithValue("@usuario", usuario);
                    commandInserir.Parameters.AddWithValue("@senha", senha);
                    commandInserir.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);

                    commandInserir.ExecuteNonQuery();
                    MessageBox.Show("Usuário criado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar usuário: {ex.Message}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Retornar ao formulário de login
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
