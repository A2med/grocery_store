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
    public class ItemDatas 
    {

        HttpClient client;
        JsonSerializerOptions option;

        public ItemDatas()
        {
            option = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            client = new HttpClient();
        }
        public async Task<List<ItemData>> GetAll()
        {
            try
            {
                string url = string.Format("{0}{1}", DataBaseConstants.ApiServerUrl, "api/Items/");
                HttpResponseMessage message = await client.GetAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    string content = await message.Content.ReadAsStringAsync();
                    ApiResponse<ItemData> response = JsonSerializer.Deserialize<ApiResponse<ItemData>>(content, option);
                    return response.data;
                }
                return new List<ItemData>();
            }
            catch
            {
                return new List<ItemData>();
            }
        }


        public async Task <ItemData> Getbyid()
        {
            try
            {
                string url = string.Format("{0}{1}{2}", DataBaseConstants.ApiServerUrl, "api/Items/5");
                HttpResponseMessage message = await client.GetAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    string content = await message.Content.ReadAsStringAsync();
                    ApiObjectResponse<ItemData> response = JsonSerializer.Deserialize<ApiObjectResponse<ItemData>>(content, option);
                    return response.data;
                }
                return new ItemData();
            }
            catch
            {
                return new ItemData();
            }
        }


    }
}
