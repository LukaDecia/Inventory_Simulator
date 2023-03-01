using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio316.Services
{
    static class Generador
    {
        public static double GenerarExponencial(double lambda, double rnd)
        {
            return (-1 / lambda) * Math.Log(1 - rnd);
        }
    }
}
