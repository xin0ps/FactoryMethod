using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diagrams.Creational_Pattern
{
    public class WindowsDialog:Dialog
    {
        public override IButton createButton()
        {
            Console.WriteLine("WindowsButton created");
            return new WindowButton();
        }

    }
}
