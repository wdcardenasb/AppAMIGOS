using System;
using System.Collections.Generic;
using System.Text;

namespace FriendApp.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
