using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class EmpregadoForm : Form
    {
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public EmpregadoForm()
        {
            InitializeComponent();

            // Ajustar propriedades iniciais do DataGridView
            dgvTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabela.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void EmpregadoForm_Load(object sender, EventArgs e)
        {
            // Configurações adicionais no carregamento, se necessário
        }

        private void btnMostrarProduto_Click(object sender, EventArgs e)
        {
            MostrarTabela("Produto");
        }

        private void btnMostrarCategoria_Click(object sender, EventArgs e)
        {
            MostrarTabela("Categoria");
        }

        private void MostrarTabela(string tabela)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM {tabela}";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);

                    // Configura a fonte de dados do DataGridView
                    dgvTabela.DataSource = dataTable;

                    // Ajustar automaticamente o layout
                    dgvTabela.AutoResizeColumns();
                    dgvTabela.AutoResizeRows();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados da tabela '{tabela}': {ex.Message}");
            }
        }

        private void btnAdcProd_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário AdicionarProduto
            AdicionarProduto adicionarProdutoForm = new AdicionarProduto();

            // Exibe o formulário de maneira modal (impede interação com o formulário principal)
            adicionarProdutoForm.ShowDialog();

            // Após fechar o formulário de adicionar, atualiza a tabela de produtos
            MostrarTabela("Produto");

        }

        private void btnAdcCategoria_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário AdicionarCategoria
            AdicionarCategoria adicionarCategoriaForm = new AdicionarCategoria();

            // Exibe o formulário de maneira modal
            adicionarCategoriaForm.ShowDialog();

            // Após fechar o formulário de adicionar, atualiza a tabela de categorias
            MostrarTabela("Categoria");
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            DeletarRegistro("Produto", "produto");
        }

        private void btnDelCategoria_Click(object sender, EventArgs e)
        {
            DeletarRegistro("Categoria", "categoria");
        }

        private void DeletarRegistro(string tabela, string tipo)
        {
            // Exibe um Prompt para o usuário
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Qual o ID do {tipo} que deseja deletar?",
                $"Deletar {tipo}",
                "");

            // Verifica se o usuário digitou algo
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Operação cancelada: Nenhum ID fornecido.");
                return;
            }

            // Converte o ID para um número inteiro
            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("ID inválido. Por favor, insira um número.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"DELETE FROM {tabela} WHERE Id = @id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{tipo} com ID {id} foi deletado com sucesso!");

                        // Atualiza a tabela após a exclusão
                        MostrarTabela(tabela);
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum {tipo} encontrado com o ID {id}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar o {tipo}: {ex.Message}");
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Qual o ID do produto que deseja alterar?",
                "Alterar Produto",
                "");

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Operação cancelada: Nenhum ID fornecido.");
                return;
            }

            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.");
                return;
            }

            AlteraProduto alteraProdutoForm = new AlteraProduto(id);

            // Associa o evento ProdutoAlterado para atualizar a tabela
            alteraProdutoForm.ProdutoAlterado += () =>
            {
                MostrarTabela("Produto");
            };

            alteraProdutoForm.Show();
        }

        private void btnAlterarCategoria_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Qual o ID da categoria que deseja alterar?",
                "Alterar Categoria",
                "");

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Operação cancelada: Nenhum ID fornecido.");
                return;
            }

            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Categoria WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        AlteraCategoria alteraCategoriaForm = new AlteraCategoria(id);

                        // Assina o evento CategoriaAlterada
                        alteraCategoriaForm.CategoriaAlterada += (s, ea) =>
                        {
                            // Atualiza a tabela após a categoria ser alterada
                            MessageBox.Show("Atualizando tabela de categorias.");
                            AtualizarTabelaCategorias();
                        };

                        alteraCategoriaForm.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Nenhuma categoria encontrada com o ID {id}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar a categoria: {ex.Message}");
            }
        }

        // Método para atualizar a tabela de categorias
        private void AtualizarTabelaCategorias()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Categoria";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvTabela.DataSource = dataTable; // Atualiza o DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar tabela de categorias: {ex.Message}");
            }
        }
    }
}