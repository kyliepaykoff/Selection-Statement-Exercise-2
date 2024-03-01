namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject)
            {
                case "english"
                    : Console.WriteLine($"I love English, it's my favorite!");
                    break;
                case "science"
                    : Console.WriteLine($"Science is cool, I liked anatomy class.");
                    break;
                case "history"
                    : Console.WriteLine($"History is super interesting, my favorite was World Civ class.");
                    break;
                case "math"
                    : Console.WriteLine($"Math was never my strong suit.");
                        break;
                case "art"
                    : Console.WriteLine($"Art is so fun.");
                        break;
                default:
                    Console.WriteLine($"Sorry, I am unfamiliar with that one.");
                    break;
            }

        }
    }
}
