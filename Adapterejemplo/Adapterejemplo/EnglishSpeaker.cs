using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapterejemplo
{
    public class EnglishSpeaker : ICommunication
    {
        public string Ask(string question)
        {
            return "Question in English: " + question;
        }

        public string Replay(string answer)
        {
            return "Answer in English : " + answer;
        }
    }
}
