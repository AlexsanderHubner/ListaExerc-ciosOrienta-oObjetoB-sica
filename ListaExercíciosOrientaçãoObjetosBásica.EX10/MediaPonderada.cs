﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosOrientaçãoObjetosBásica.EX10
{
    internal class MediaPonderada
    {
        public double nota1;
        public double peso1;
        public double nota2;
        public double peso2;

        public double Media()
        {
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
    }
}
