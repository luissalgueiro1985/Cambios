using Cambios.Modelos;
using Cambios.Serviços;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambios
{
    public partial class Form1 : Form
    {
        #region Atributos

        private NetworkService networkService;

        private ApiService apiService;

        #endregion

        public List<Rate> Rates { get; set; } = new List<Rate>();

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;

            LabelResultado.Text = "A actualizar taxas...";

            var connection = networkService.CheckConnection();

            if(!connection.IsSucess)
            {
                MessageBox.Show(connection.Message);
                return;
            }
            else
            {
                await LoadApiRates();
            }

            ComboBoxOrigem.DataSource = Rates;
            ComboBoxOrigem.DisplayMember = "Name";

            //corrige bug da microsoft
            ComboBoxDestino.BindingContext = new BindingContext();

            ComboBoxDestino.DataSource = Rates;
            ComboBoxDestino.DisplayMember = "Name";

            ProgressBar1.Value = 100;

            LabelResultado.Text = "Taxas carregadas...";

        }

        private async Task LoadApiRates()
        {
            ProgressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>)response.Result;
        }
    }
}
