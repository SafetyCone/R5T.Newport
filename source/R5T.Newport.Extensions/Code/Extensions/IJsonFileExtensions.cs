using System;

using Newtonsoft.Json;

using R5T.Newport;


namespace System
{
    public static class IJsonFileExtensions
    {
        public static T Load<T>(this IJsonFile _,
            string jsonFilePath)
        {
            var output = JsonFileHelper.LoadFromFile<T>(jsonFilePath);
            return output;
        }

        public static bool TryLoad<T>(this IJsonFile jsonFile,
            string jsonFilePath,
            out T value)
        {
            try
            {
                value = jsonFile.Load<T>(jsonFilePath);

                return true;
            }
            catch
            {
                value = default;

                return false;
            }
        }

        public static void Save<T>(this IJsonFile _,
            string jsonFilePath,
            T value)
        {
            JsonFileHelper.WriteToFile(jsonFilePath, value);
        }
    }
}
