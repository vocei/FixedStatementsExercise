namespace SelectionStatementsExercise2
{
    public class Program
    {
        // Switch Case Assignment
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower()) 
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate Math..(I really do)");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("Science is kinda cool..");
                    break;
                case "PE":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("Thats a good subject for your physical health!");
                    break;
                case "history":
                    Console.WriteLine("History is important so you don't repeat the bad things..");
                    break;
                case "english":
                    Console.WriteLine("English is hard but also boring if its your primary language");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;
                     
                    
            }
        }
    }
}