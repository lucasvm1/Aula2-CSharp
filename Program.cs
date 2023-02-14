internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade");
        var idade = Console.ReadLine();

        if ((Convert.ToInt32(idade) >= 12))
        {
            Console.WriteLine("Voce pode jogar");
        }
        else
        {
            Console.WriteLine("Jogue outro jogo!");
        }
    }
}