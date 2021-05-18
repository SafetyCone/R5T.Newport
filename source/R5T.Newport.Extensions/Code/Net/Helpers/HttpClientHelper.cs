using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

using MagyarHttpClientHelper = R5T.Magyar.Net.HttpClientHelper;


namespace R5T.Newport.Net
{
    public static class HttpClientHelper
    {
        public static async Task<T> GetFromJsonAsync<T>(string jsonUrlEndpoint)
        {
            var json = await MagyarHttpClientHelper.GetStringAsync(jsonUrlEndpoint);

            var output = JsonConvert.DeserializeObject<T>(json);
            return output;
        }
    }
}
