namespace ListaExercíciosOrientaçãoObjetosBásica.EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Esfera valorEsfera = new Esfera();
            valorEsfera.raio = 10;

            Console.WriteLine(valorEsfera.VolumeDaEsfera());


        }
    }
}