using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class AlteraCategoria : Form
    {
        public event EventHandler CategoriaAlterada; // Evento para notificar alterações
        private readonly int categoriaId; // ID da categoria a ser alterada
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public AlteraCategoria(int id)
        {
            InitializeComponent();
            categoriaId = id;
            CarregarDadosCategoria();
        }

        private void CarregarDadosCategoria()
        {
            try
            {
                // Exibir o ID diretamente no txtID
                txtID.Text = categoriaId.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT nome_categoria, descricao_categoria FROM Categoria WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", categoriaId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNomeCategoria.Text = reader["nome_categoria"].ToString(); // Carrega o nome da categoria
                            txtDescricao.Text = reader["descricao_categoria"].ToString(); // Carrega a descrição
                        }
                        else
                        {
                            MessageBox.Show("Categoria não encontrada.");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
                Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Categoria SET nome_categoria = @nome, descricao_categoria = @descricao WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", txtNomeCategoria.Text);
                    command.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    command.Parameters.AddWithValue("@id", categoriaId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Categoria alterada com sucesso!");
                        CategoriaAlterada?.Invoke(this, EventArgs.Empty); // Aciona o evento
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi realizada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar a categoria: {ex.Message}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário sem realizar alterações
        }
    }
}
