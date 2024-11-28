using AbstractFactory.Example1.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1.Factories
{
    public class WinFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public IDropDown CreateDropDrown()
        {
            return new WinDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox();
        }
    }
}
