namespace ListaExercíciosOrientaçãoObjetosBásica.EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mediaFinal = new MediaPonderada();
            mediaFinal.nota1 = 10;
            mediaFinal.peso1 = 0.40;
            mediaFinal.nota2 = 10;
            mediaFinal.peso2 = 0.60;

            Console.WriteLine(mediaFinal.Media());
        }
    }
}