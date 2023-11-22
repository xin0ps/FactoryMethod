using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diagrams.Creational_Pattern
{
    public class WebDialog
    {
        public virtual  IButton createButton()
        {
            Console.WriteLine("HtmlButton created");
            return new HtmlButton();
        }

    }
}
