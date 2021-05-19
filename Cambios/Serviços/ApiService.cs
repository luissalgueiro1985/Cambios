
namespace Cambios.Serviços
{
    using Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApiService
    {
        public async Task<Response> GetRates(string urlBase, string controler)
        {
            try
            {
                var client = new HttpClient();

                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controler);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSucess = false,
                        Message = result
                    };
                }

                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

                return new Response
                {
                    IsSucess = true,
                    Result = rates

                };

            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSucess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
