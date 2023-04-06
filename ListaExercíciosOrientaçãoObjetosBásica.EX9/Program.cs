namespace ListaExercíciosOrientaçãoObjetosBásica.EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaFinal = new MediaHarmonica();
            mediaFinal.media1 = 10;
            mediaFinal.media2 = 10;
            mediaFinal.media3 = 10;
            mediaFinal.media4 = 10;

            Console.WriteLine(mediaFinal.MediaTotal());
        }
    }
}