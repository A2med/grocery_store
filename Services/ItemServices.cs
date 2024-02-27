using Gerocery.constant;
using Gerocery.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gerocery.Services
{
    public class ItemServices:IGeneric<Category2>
    {
        HttpClient client;
        JsonSerializerOptions option;

        public ItemServices()
        {
            option = new JsonSerializerOptions()
            {
                PropertyNamingPolicy=JsonNamingPolicy.CamelCase,
            };
            client = new HttpClient();
        }

       

        public async Task<List<Category2>> GetAll()

        {
            try
            {
                string url = string.Format("{0}{1}", DataBaseConstants.ApiServerUrl, "api/categories/");
                HttpResponseMessage message = await client.GetAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    string content = await message.Content.ReadAsStringAsync();
                    ApiResponse<Category2> response = JsonSerializer.Deserialize<ApiResponse<Category2>>(content, option);
                    return response.data;
                }
                return new List<Category2>();
            }
            catch
            {
                return new List<Category2>();
            }

        }

      //  public async Task<bool> save()
    }
}
