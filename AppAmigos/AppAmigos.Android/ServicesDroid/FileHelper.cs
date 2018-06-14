using AppAmigos.Droid.ServicesDroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace AppAmigos.Droid.ServicesDroid
{
    using System;
    using AppAmigos.Services;
    using System.IO;
    
    public class FileHelper:IFileHelper
    {
        public FileHelper()
        {
        }

        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path,fileName);
        }
    }
}