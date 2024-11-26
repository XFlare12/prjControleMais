using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class AlteraProduto : Form
    {
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private int produtoId;

        // Delegate e evento para notificar o formulário principal
        public delegate void ProdutoAlteradoHandler();
        public event ProdutoAlteradoHandler ProdutoAlterado;

        public AlteraProduto(int id)
        {
            InitializeComponent();
            produtoId = id;
            CarregarDadosProduto();
        }

        private void CarregarDadosProduto()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Produto WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", produtoId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtID.Text = reader["Id"].ToString();
                        txtNomeProduto.Text = reader["Nome_Produto"].ToString();
                        txtCategoria.Text = reader["Categoria"].ToString();
                        txtPreco.Text = reader["Preco"].ToString();
                        txtQTD.Text = reader["Quantidade"].ToString();
                        txtDescricao.Text = reader["Descricao"].ToString();
                        txtID.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum produto encontrado com o ID {produtoId}.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do produto: {ex.Message}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE Produto 
                        SET Nome_Produto = @nome, 
                            Categoria = @categoria, 
                            Preco = @preco, 
                            Quantidade = @quantidade, 
                            Descricao = @descricao 
                        WHERE Id = @id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", produtoId);
                    command.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                    command.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                    command.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text));
                    command.Parameters.AddWithValue("@quantidade", int.Parse(txtQTD.Text));
                    command.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produto alterado com sucesso!");

                        // Notifica o formulário principal
                        ProdutoAlterado?.Invoke();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar o produto: {ex.Message}");
            }
        }
    }
}
