using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class AdicionarCategoria : Form
    {
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public AdicionarCategoria()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Categoria (nome_categoria, descricao_categoria) VALUES (@nome, @descricao)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", txtNomeCategoria.Text);
                    command.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Categoria adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após a inserção
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar a categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário
        }

        private void LimparCampos()
        {
            txtNomeCategoria.Clear();
            txtDescricao.Clear();
        }
    }
}
