using MyLibrary;
namespace FxConsoleApp
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
