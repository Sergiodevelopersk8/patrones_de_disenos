using AbstractFactory.Example1.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1.Factories
{
    public class LinuxFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public IDropDown CreateDropDrown()
        {
            return new LinuxDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new LinuxTextBox();
        }
    }
}
