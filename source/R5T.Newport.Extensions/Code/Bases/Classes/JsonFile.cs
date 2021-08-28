using System;


namespace R5T.Newport
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class JsonFile : IJsonFile
    {
        #region Static
        
        public static JsonFile Instance { get; } = new JsonFile();
        
        #endregion
    }
}