using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diagrams.Creational_Pattern
{
    public interface IButton
    {
        public void render()
        {
            Console.WriteLine("render");
        }

        public void onClick()
        {
            Console.WriteLine("Click");
        }
    }
}
