using MyLibrary;

namespace CoreConsoleApp
{
    public class SharedLibWrapper
    {
        SharedLib sharedLib;
        public SharedLibWrapper()
        {
            sharedLib = new SharedLib();
        }

        public string Version { get { return sharedLib.GetProductVersion(); } }
    }
}
