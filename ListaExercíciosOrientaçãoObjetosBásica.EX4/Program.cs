namespace ListaExercíciosOrientaçãoObjetosBásica.EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CombustivelPorKm totalConsumo = new CombustivelPorKm();
            totalConsumo.kmFinal = 500;
            totalConsumo.kmInicial = 100;
            totalConsumo.combustivel = 25;

            Console.WriteLine(totalConsumo.Consumo());

        }
    }
}