using System;

namespace SharedLibrary
{
    public class SharedLib
    {
        private const string version = "1.0.1";

        public string GetVersion()
        {
            return version;
        }
    }
}
