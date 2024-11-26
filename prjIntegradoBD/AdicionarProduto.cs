using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class AdicionarProduto : Form
    {
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtQTD.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar entrada numérica para preço e quantidade
            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || !int.TryParse(txtQTD.Text, out int quantidade))
            {
                MessageBox.Show("Preço e quantidade devem ser valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Produto (nome_produto, descricao, categoria, preco, quantidade) VALUES (@nome, @descricao, @categoria, @preco, @quantidade)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                    command.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    command.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                    command.Parameters.AddWithValue("@preco", preco);
                    command.Parameters.AddWithValue("@quantidade", quantidade);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após a inserção
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtQTD.Clear();
        }
    }
}
