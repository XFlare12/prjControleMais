using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjIntegradoBD
{
    public partial class AdicionarFuncionario : Form
    {
        private readonly string connectionString = "Server=tcp:prjuni92024-2.database.windows.net,1433;Initial Catalog=prjuni92024.2;Persist Security Info=False;User ID=xflare12;Password=Feli@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public AdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtIdade.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar entrada numérica para preço e quantidade
            if (!int.TryParse(txtIdade.Text, out int idade) || !decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                MessageBox.Show("Preço e quantidade devem ser valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Funcionarios (nome, endereco, idade, cargo, salario) VALUES (@nome, @endereco, @idade, @cargo, @salario)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", txtNomeFunc.Text);
                    command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    command.Parameters.AddWithValue("@idade", txtIdade.Text);
                    command.Parameters.AddWithValue("@cargo", txtCargo.Text);
                    command.Parameters.AddWithValue("@salario", salario);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Funcionário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após a inserção
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar o funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário
        }

        private void LimparCampos()
        {
            txtNomeFunc.Clear();
            txtEndereco.Clear();
            txtIdade.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
        }
    }
}
