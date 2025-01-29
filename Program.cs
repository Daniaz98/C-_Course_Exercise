using System.Globalization;
using EnumExercise.Entities;
using EnumExercise.Entities.Enums;

namespace EnumExercise;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string departamentName = Console.ReadLine();
        
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string workerName = Console.ReadLine();
        
        Console.Write("Level: ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        
        Console.Write("Base wage: ");
        var baseWage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dept = new Department(departamentName);
        Worker worker = new Worker(workerName, level, baseWage, dept);
        
        
        
        Console.Write("How many contracts to this worker?");
        var contracts = int.Parse(Console.ReadLine());

        if (contracts != 0)
        {
            
            Console.WriteLine("Enter #1 contract: ");
            Console.WriteLine("Date: ");
            var contractDate = Console.ReadLine();
            Console.WriteLine("Value per hours: ");
            var valuePerHour = double.Parse(Console.ReadLine());
            Console.WriteLine("Duration (hours): ");
            var duration = Console.ReadLine();
        }
        
        Console.WriteLine("Enter date and month to calculate income (MM/YY): ");
        var date = Console.ReadLine();

        Console.WriteLine($"Name: {workerName}");
        Console.WriteLine($"Department: {departamentName}");
        
    }
}