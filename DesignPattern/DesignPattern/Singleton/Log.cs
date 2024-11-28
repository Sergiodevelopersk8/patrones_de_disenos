using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Log
    {

        //readonly es de escritura
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";


        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        //constructor privado para que no se modifique  
        private Log()
        {

        }

        //escritura
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }


    }
}
