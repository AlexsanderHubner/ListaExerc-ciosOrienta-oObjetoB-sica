using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosOrientaçãoObjetosBásica.EX9
{
    internal class MediaHarmonica
    {
        public double media1; 
        public double media2; 
        public double media3;
        public double media4;
        public double MediaTotal() 
        { 
            return 4 / ((1 / media1) + (1 / media2) + (1 / media3) + (1 / media4)); 
        }
    }
}
