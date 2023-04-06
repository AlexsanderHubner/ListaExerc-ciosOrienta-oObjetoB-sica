namespace ListaExercíciosOrientaçãoObjetosBásica.EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalárioBaseTotaldeVendas totalSalario = new SalárioBaseTotaldeVendas();

            totalSalario.salarioBase = 1000;
            totalSalario.vendas = 500;
            totalSalario.comissao = 0.5;

            Console.WriteLine(totalSalario.SubTotal());


        }
    }
}