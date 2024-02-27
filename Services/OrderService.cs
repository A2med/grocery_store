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
    public class OrderService:IGeneric<OrderData>
    {
        HttpClient client;
        JsonSerializerOptions option;

        public OrderService()
        {
            option = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            client = new HttpClient();
        }
         async Task<List<OrderData>> GetAll()

        {
            try
            {
                string url = string.Format("{0}{1}", DataBaseConstants.ApiServerUrl, "api/order/");
                HttpResponseMessage message = await client.GetAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    string content = await message.Content.ReadAsStringAsync();
                    ApiResponse<OrderData> response = JsonSerializer.Deserialize<ApiResponse<OrderData>>(content, option);
                    return response.data;
                }
                return new List<OrderData>();
            }
            catch
            {
                return new List<OrderData>();
            }

        }

        public async Task<bool>save(OrderData item,bool isnewitem=false)
        {
            Uri uri = new Uri(string.Format("{0}{1}", DataBaseConstants.ApiServerUrl, "api/order/"));

            try
            {
                string json = JsonSerializer.Serialize<OrderData>(item, option);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                
                    response = await client.PostAsync(uri, content);
                
                if (response.IsSuccessStatusCode)
                {
                    string Jsoncontent = await response.Content.ReadAsStringAsync();
                   ApiResponse<bool> myresponse = JsonSerializer.Deserialize<ApiResponse<bool>>(Jsoncontent, option);
                    if (myresponse.errors == null)
                        return true;
                    else
                        return false;

                }

                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        Task<List<Category2>> IGeneric<OrderData>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
