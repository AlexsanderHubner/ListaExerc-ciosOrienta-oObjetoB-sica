namespace ListaExercíciosOrientaçãoObjetosBásica.EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CelsiusParaFahrenheit calcularCelsius = new CelsiusParaFahrenheit();

            calcularCelsius.celsius = 32;

            Console.WriteLine(calcularCelsius.Calcularfahrenheit());
        }
    }
}