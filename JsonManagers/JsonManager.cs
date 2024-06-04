using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentManager.JsonManagers
{
    public abstract class JsonManager
    {
        protected string Path;
        protected string Username;

        public JsonManager(string path, string username)
        {
            Path = System.IO.Path.Combine(path, "UserData");
            Username = username;
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }
    }
}
