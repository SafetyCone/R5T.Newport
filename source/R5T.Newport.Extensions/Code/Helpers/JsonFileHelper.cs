using System;

using Newtonsoft.Json;

using R5T.Magyar.IO;

using NewportUtilities = R5T.Newport.Utilities;


namespace Newtonsoft.Json
{
    public static class JsonFileHelper
    {
        public static T LoadFromFile<T>(string jsonFilePath)
        {
            var serializer = NewportUtilities.GetStandardJsonSerializer();

            var output = serializer.Deserialize<T>(jsonFilePath);
            return output;
        }

        /// <summary>
        /// No async version since Newtonsoft does not have async!
        /// </summary>
        public static void WriteToFile<T>(string jsonFilePath, T value, Formatting formatting = JsonHelper.DefaultFormatting, bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            var serializer = NewportUtilities.GetStandardJsonSerializer(formatting);

            serializer.Serialize(jsonFilePath, value, overwrite);
        }
    }
}
