using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburguesa_builder_ejemplo
{
       
    
    public class BurguerDirector
    {
        private IBurguerBuilder _burguerBuilder;

    

        public void MakeBurger(IBurguerBuilder burguerBuilder)
        {
            burguerBuilder.AddBread();
            burguerBuilder.AddMeat();
            burguerBuilder.AddCheese();
            burguerBuilder.AddDressing();
            burguerBuilder.AddLettuce();
            burguerBuilder.AddTomato();
        }


     


    }
}
