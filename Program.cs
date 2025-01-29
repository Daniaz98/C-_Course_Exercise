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

        for (int i = 1; i <= contracts; i++)
        {
            Console.WriteLine($"Enter #{i} contract: ");
            Console.Write("Date (MM/YYYY)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): ");
            var duration = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            HourContract contract = new HourContract(date, valuePerHour, duration);
            
            worker.AddContract(contract);
        }

        Console.WriteLine("Enter month and year to calculate the income (MM/YYYY): ");
        var monthAndYear = Console.ReadLine();

        var month = int.Parse(monthAndYear.Substring(0, 2));
        var year = int.Parse(monthAndYear.Substring(3));
        

        Console.WriteLine($"Name: {worker.Name}");
        Console.WriteLine($"Department: {worker.Department.Name}");
        Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        
        
    }
}