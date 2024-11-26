using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace prjIntegradoBD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            await AtualizarPrevisaoTempo();
        }

        private async Task AtualizarPrevisaoTempo()
        {
            string apiKey = "9936cda32da2ba8b1491762cd9ea3d29";  // Sua chave de API
            string cidade = "São Paulo";
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={apiKey}&units=metric&lang=pt_br";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Enviar requisição GET para a API
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();  // Garantir que a resposta seja bem-sucedida

                    // Ler a resposta da API
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse do JSON retornado
                    JObject weatherData = JObject.Parse(responseBody);

                    // Acessar as informações de descrição do tempo e temperatura
                    string descricao = weatherData["weather"][0]["description"].ToString();  // Descrição do clima
                    string temperatura = weatherData["main"]["temp"].ToString();  // Temperatura em Celsius

                    // Exibir apenas os dois primeiros dígitos da temperatura
                    string temperaturaCortada = temperatura.Length > 1 ? temperatura.Substring(0, 2) : temperatura;

                    // Exibir as informações no label
                    lblTempo.Text = $"Tempo em São Paulo: {descricao}, {temperaturaCortada}°C";
                }
                catch (HttpRequestException ex)
                {
                    // Caso ocorra algum erro na requisição
                    MessageBox.Show("Erro ao obter a previsão do tempo: " + ex.Message);
                }
            }
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Abre o formulário de Login para o Admin
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            // Abre o formulário de Login para o Funcionário
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void lblTempo_Click(object sender, EventArgs e)
        {
            // Qualquer ação necessária ao clicar no lblTempo
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
