namespace ListaExercíciosOrientaçãoObjetosBásica.EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeDoCilindro valorCilindro = new VolumeDoCilindro();

            valorCilindro.altura = 11;
            valorCilindro.raio = 1;

            Console.WriteLine(valorCilindro.Volume());
        }
    }
}