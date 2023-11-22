using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diagrams.Creational_Pattern
{

    public class Dialog:IButton
    {
        public void render()
        {
            Console.WriteLine("Render Dialog ");
        }

        public virtual IButton createButton()
        {
            Console.WriteLine("Dialog");
            return null;
        }
    }
}
