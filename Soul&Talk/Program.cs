namespace Soul_Talk;

class Program
{
    static void Main(string[] args) 
    {
        var foo = new Income(33, Income.TaskType.Online);
        Console.WriteLine(foo);
    }
}
