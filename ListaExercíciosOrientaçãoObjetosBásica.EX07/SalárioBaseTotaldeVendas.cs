using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosOrientaçãoObjetosBásica.EX07
{
    internal class SalárioBaseTotaldeVendas
    {
        public double salarioBase;
        public double vendas;
        public double comissao;

        public double SubTotal()

        {
            return (comissao * vendas) + salarioBase;
        }
    }
}
