using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosOrientaçãoObjetosBásica.EX5
{
    internal class Esfera
    {
        public double raio;

        public double VolumeDaEsfera()
        {
             return (Math.PI * 4) * (raio * raio * raio) / 3; 
        }
    }
}
