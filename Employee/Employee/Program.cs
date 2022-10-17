class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
        empWageBuilder.addCompanyEmpWage("Microsoft", 100, 20, 100);
        empWageBuilder.addCompanyEmpWage("Google", 200, 30, 150);
        empWageBuilder.computeEmpWage();
        Console.ReadLine();
    }
}