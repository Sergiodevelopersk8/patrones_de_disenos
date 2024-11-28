using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    public interface ITransactionLogger
    {
        void LogTransaction(string message);
    }
}
