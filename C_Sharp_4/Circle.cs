using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4
{
    class Circle
    {
        double Pi = 3.14;
        double r;


        public double GetSquare()
        {
            return Pi * Math.Pow(r, 2);
        }

        public double GetL()
        {
            return 2 * Pi * r;
        }

        override public string ToString()
        {
            return "\nРадиус:" + this.R + " " +
                 "\nДлина:" + this.GetL() + " " +
                 "\nПлощадь:" + this.GetSquare();
        }



        public double R { get => r; set => r = value >= 0 ? value : 0; }




    }
}
