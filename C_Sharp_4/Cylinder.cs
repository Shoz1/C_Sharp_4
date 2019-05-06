using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4
{
    class Cylinder
    {
        double Pi = 3.14;
        double r;
        double h;

        public double GetVolume()
        {
            return Pi * Math.Pow(r, 2) * h;
        }

        public double GetSquare()
        {
            return 2 * Pi * r * h;
        }

        new public string ToString()
        {
            return "\nРадиус:" + this.R + " " +
                 "\nВысота:" + this.H + " " +
                 "\nОбъем:" + this.GetVolume() + " " +
                 "\nПлощадь:" + this.GetSquare();
        }

        public double H { get => h; set => h = value >= 0 ? value : 0; }
        public double R { get => r; set => r = value >= 0 ? value : 0; }
    }

}
