using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class AlteraFuncionario : Form
    {
        public event EventHandler FuncionarioAlterado; // Evento para notificar o pai
        private Form parentForm;
        private int funcionarioId;
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public AlteraFuncionario(Form parent, int id)
        {
            InitializeComponent();
            parentForm = parent;
            funcionarioId = id;
        }

        private void AlteraFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDadosFuncionario();
        }

        private void CarregarDadosFuncionario()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Funcionarios WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", funcionarioId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtID.Text = reader["Id"].ToString();
                        txtNomeCategoria.Text = reader["Nome"].ToString();
                        txtEndereco.Text = reader["Endereco"].ToString();
                        txtIdade.Text = reader["Idade"].ToString();
                        txtCargo.Text = reader["Cargo"].ToString();
                        txtSalario.Text = reader["Salario"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Funcionário com ID {funcionarioId} não encontrado.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Funcionarios SET Nome = @nome, Endereco = @endereco, Idade = @idade, Cargo = @cargo, Salario = @salario WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", funcionarioId);
                    command.Parameters.AddWithValue("@nome", txtNomeCategoria.Text);
                    command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    command.Parameters.AddWithValue("@idade", int.Parse(txtIdade.Text));
                    command.Parameters.AddWithValue("@cargo", txtCargo.Text);
                    command.Parameters.AddWithValue("@salario", decimal.Parse(txtSalario.Text));

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Funcionário alterado com sucesso!");

                // Dispara o evento para notificar o formulário pai
                FuncionarioAlterado?.Invoke(this, EventArgs.Empty);

                this.Close(); // Fecha o formulário
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar funcionário: {ex.Message}");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm?.Show();
        }
    }
}
