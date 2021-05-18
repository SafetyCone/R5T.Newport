using System;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using R5T.Magyar.IO;


namespace Newtonsoft.Json
{
    public static class JsonHelper
    {
        public static async Task<JObject> LoadAsJObject(string jsonFilePath)
        {
            using (var streamReader = StreamReaderHelper.New(jsonFilePath))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var output = await JObject.LoadAsync(jsonTextReader);
                return output;
            }
        }
    }
}
