using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosOrientaçãoObjetosBásica.EX4
{
    internal class CombustivelPorKm
    {
        public double kmInicial;
        public double kmFinal;
        public double combustivel;

        public double Consumo()
                {
                return (kmFinal - kmInicial) / combustivel;
                }

    }
}
