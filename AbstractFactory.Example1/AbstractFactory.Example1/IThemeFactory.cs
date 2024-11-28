using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1
{
    public interface IThemeFactory
    {
        IButton CreateButton();
        IDropDown CreateDropDrown();
        ITextBox CreateTextBox();
    }
}
