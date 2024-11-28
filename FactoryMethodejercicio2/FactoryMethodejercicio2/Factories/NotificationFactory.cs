using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodejercicio2.Factories
{
    public abstract class NotificationFactory
    {
        /*con el abstract no se va poder instanciar*/
        public abstract INotification CreateNotification();
    }
}
