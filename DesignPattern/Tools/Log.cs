using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {

        //readonly es de escritura
        private  static Log _instance = null;
        private string _path;
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            lock (_protect){ 
            if (_instance == null)
            {
                _instance = new Log(path);
            }
        }
            return _instance;
        }
        //constructor 
        private Log(string path)
        {
            _path = path;
        }

        //escritura
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

    }
}
