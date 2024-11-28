using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapterejemplo
{
    public interface ICommunication
    {

        string Ask(string question);
        string Replay(string answer);



    }
}
