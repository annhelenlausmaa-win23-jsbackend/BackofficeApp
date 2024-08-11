using BackofficeApp.Models;
using System.Text;

namespace BackofficeApp.Services
{
    public class SubscribeService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<SubscribeModel>> GetAllSubscribersAsync()
        {
            try
            {
                StringContent content = new StringContent("", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync("https://subscribeprovider-ahl.azurewebsites.net/api/GetAllSubscribers?code=TRdkjppbD9hhoHYJbqCpIwqJMGsVyjGaTOgVbO4PltRGAzFuBlfDCQ%3D%3D", content);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<SubscribeModel>>();
                    if (data == null)
                    {
                        Console.WriteLine("Deserialization returned null.");
                    }
                    return data;
                }
                return null!;
            }
            catch
            {
                return null!;
            }
        }
    }
}
