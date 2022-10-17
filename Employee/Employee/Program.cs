
//UC12: List of multiple companies to manage Employee Wage.
//UC13: Daily Wage along with Total Wage
//UC14: Ability to get the Total Wage when queried by company.
class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addCompanyEmpWage("Microsoft", 100, 20, 100);
        empWageBuilder.addCompanyEmpWage("Google", 200, 30, 150);
        empWageBuilder.computeEmpWage();
        Console.WriteLine("Total Wage when queried by the companies is as follows: ");
        Console.WriteLine("Total wage for Microsoft " + empWageBuilder.getTotalWage("Microsoft"));
        Console.WriteLine("Total wage for Google " + empWageBuilder.getTotalWage("Google"));
        Console.ReadLine();
    }  
}