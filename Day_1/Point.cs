using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    internal  struct Point
    {
        public int X;
        public int Y;

        //Method overriding
        public override string ToString()
        {
            return "X="+X +" , Y="+Y;
        }
    }
}
