using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosOrientaçãoObjetosBásica.EX3
{
    internal class VolumeDoCilindro
    {
        public double raio;
        public double altura;
        
        public double Volume()
        {
        return Math.PI * Math.Pow(raio, 2) * altura;
        }
        

    }
}
