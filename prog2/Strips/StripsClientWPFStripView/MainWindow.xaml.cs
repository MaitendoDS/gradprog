using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using REST.DTO;

namespace StripsClientWPFStripView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient _httpClient;
        public MainWindow()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7181/api/") };
        }

        private void GetStripBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(IdTextBox.Text, out int stripId))
            {
                MessageBox.Show("id is ongeldig");
                return;
            }


            try
            {
                var response = _httpClient.GetAsync($"Strip/GetStripById/{stripId}").Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("niet gevonden");
                    return;
                }
                var responseContent = response.Content.ReadAsStringAsync().Result;

                var strip = JsonSerializer.Deserialize<GetStripDTO>(responseContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                TitelTextBox.Text = strip.Titel;
                NummerTextBox.Text = strip.Nummer?.ToString() ?? string.Empty;
                ReeksTextBox.Text = strip.Reeks;
                UitgeverijTextBox.Text = strip.Uitgeverij;

                List<string> auteurs = new List<string>();
                for (int i = 0; i < strip.AuteurStripDTO.Count; i++)
                {
                    auteurs.Add(strip.AuteurStripDTO[i].Auteur);
                }

                AuteursListBox.ItemsSource = auteurs;
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een fout opgetreden.");
            }
        }
    }
}