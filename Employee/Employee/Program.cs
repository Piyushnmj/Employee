class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilderObject Microsoft = new EmpWageBuilderObject("Microsoft", 100, 20, 100);
        EmpWageBuilderObject Google = new EmpWageBuilderObject("Google", 200, 30, 150);
        Microsoft.computeEmpWage();
        Console.WriteLine(Microsoft.toString());
        Google.computeEmpWage();
        Console.WriteLine(Google.toString());
        Console.ReadLine();
    }
}