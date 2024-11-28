using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapterejemplo
{
    public class CommunicationSystem
    {

        public void StartConversation(ICommunication communicator, string question, string answer)
        {
            Console.WriteLine(communicator.Ask(question));
            Console.WriteLine(communicator.Replay(answer));




        }





    }
}
