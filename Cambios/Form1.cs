﻿using Cambios.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Cambios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;
            ProgressBar1.Value = 0;

            var client = new HttpClient();

            client.BaseAddress = new Uri("http://cambios.somee.com");

            var response = await client.GetAsync("/api/rates");

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase);
                return;
            }

            var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

            ComboBoxOrigem.DataSource = rates;
            ComboBoxOrigem.DisplayMember = "Name";

            //corrige bug da microsoft
            ComboBoxDestino.BindingContext = new BindingContext();

            ComboBoxDestino.DataSource = rates;
            ComboBoxDestino.DisplayMember = "Name";

            ProgressBar1.Value = 100;

        }
    }
}
