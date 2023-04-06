namespace ListaExercíciosOrientaçãoObjetosBásica.EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeLatadeOleo lataOleo = new VolumeLatadeOleo();

            lataOleo.raio = 10;
            lataOleo.altura = 10;

            Console.WriteLine(lataOleo.Volume());
        }
    }
}