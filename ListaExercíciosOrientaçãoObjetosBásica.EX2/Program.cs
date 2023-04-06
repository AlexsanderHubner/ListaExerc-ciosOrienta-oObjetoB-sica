namespace ListaExercíciosOrientaçãoObjetosBásica.EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FahrenheitParaCelsius fahrenheit = new FahrenheitParaCelsius();

            fahrenheit.celsius = 32;

            Console.WriteLine(fahrenheit.CalcularCelsius());
        }
    }
}