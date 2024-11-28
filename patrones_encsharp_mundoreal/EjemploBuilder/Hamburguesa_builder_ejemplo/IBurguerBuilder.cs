using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburguesa_builder_ejemplo
{
    public interface IBurguerBuilder
    {
        void AddBread();
        void AddMeat();
        void AddCheese();
        void AddDressing();
        void AddLettuce();
        void AddTomato();

        Burger GetBurger();
    }
}
