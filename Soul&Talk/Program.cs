namespace Soul_Talk;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Opgave type og deres tilhørende timeløn:");
        foreach (var task in Enum.GetValues(typeof(Income.TaskType)))
        {
            Console.WriteLine($"{task} = {(int)task}");
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Registreret indkomst:");
        foreach (var income in Income.GetAllIncomes())
        {
            Console.WriteLine(income);
        }
        Console.WriteLine("----------------------------------------");


    }
}

