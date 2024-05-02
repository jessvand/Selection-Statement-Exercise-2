namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What's your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
               case "math":
                    Console.WriteLine("I'm also TERRIBLE at math!");
                    break;
               case "english":
                    Console.WriteLine("I really love reading and have a passion for etymology");
                    break;
                case "chemistry":
                    Console.WriteLine("I only understand it now as an adult...because, DANGER!");
                        break;
                case "taylor swift":
                    Console.WriteLine("Its wild that there are uni courses on Taylor Swift");
                    break;
                case "weightlifting":
                    Console.WriteLine("this is the absolute BEST class of them all!");
                    break;


              
                       
            }                
        }
    }
}