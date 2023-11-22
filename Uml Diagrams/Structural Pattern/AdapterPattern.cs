using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_Diagrams.Structural_Pattern
{
    public class RoundHole
    {
        private int radius { get; set; }


        public RoundHole(int radius)
        {
            this.radius = radius;
        }

        public bool fits(RoundPeg peg)
        {
            return true;
        }
    }


    public class RoundPeg
    {
      
        private int radius { get; set; }

        public RoundPeg(int radius)
        {
            this.radius = radius;
        }
            


    }


    public class SquarePegAdapter
    {
     

        private SquarePeg peg { get; set; }

        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }

        public int getRadius()
        {
            return peg.getWidth() * Math.Sqrt(2) /2;
        }

    }


    public class SquarePeg
    {
  

        private int width { get; set; }

        public SquarePeg(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return width;
        }
    }
}
