using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1.ConcreteClasses
{
    public class LinuxTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux textbox");
        }
    }
}
