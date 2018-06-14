using System.Collections.Generic;
using System.Text;

namespace AppAmigos.Services
{
    using System;
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
