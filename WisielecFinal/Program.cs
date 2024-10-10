
using System.Linq;
using WisielecFinal;

internal class Program
{
    private static void Main(string[] args)
    {
        RandomWord randomWord = new RandomWord();
        string findWord = randomWord.GetRandomWord();
        //Console.WriteLine(findWord);

        char[] guessedWord = new string('_', findWord.Length).ToCharArray();
        //Console.WriteLine(guessedWord);

        int error = 0;

        while (true)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(guessedWord);
            Error.DrawHangman(error);

            Console.WriteLine("Podaj litere:");
            string input = Console.ReadLine();
            char znakAll = char.Parse(input);
            char znak = char.ToUpper(znakAll);

            char[] abc = findWord.ToCharArray();
            List<int> index = new List<int>();

            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (abc[i] == znak)
                {
                    index.Add(i);
                }
            }
            if (index.Count > 0)
            {
                foreach (int ind in index)
                {
                    guessedWord[ind] = znak;
                }
            }
            else
            {
                Console.SetCursorPosition(0, 11);
                Console.WriteLine($"Znak '{znak}' nie został znaleziony.");
                error = error + 1;
            }
            if (error == 6)
            {
                Console.Clear();
                Console.WriteLine($"Przegrałeś! Szukane słowo to {findWord}");
                break;
            }
            bool takieSame = guessedWord.SequenceEqual(abc);
            if (takieSame == true)
            {
                Console.Clear();
                Console.WriteLine("Gratulacje! Zgadłeś słowo.");
                break;
            }
            //Console.WriteLine(guessedWord);
            //Console.WriteLine(error);
            
        }
        Console.WriteLine();
        Console.WriteLine("Naciśnij ENTER by zamknąć program...");
        Console.ReadLine();
    }
}