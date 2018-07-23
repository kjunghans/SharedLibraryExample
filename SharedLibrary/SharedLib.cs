using System;
using System.Diagnostics;

namespace SharedLibrary
{
    public class SharedLib
    {

        public string GetVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }
    }
}
