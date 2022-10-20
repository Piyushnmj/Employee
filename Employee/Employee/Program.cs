//UC12: List of multiple companies to manage Employee Wage.
//UC13: Daily Wage along with Total Wage
//UC14: Ability to get the Total Wage when queried by company.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Company Name: ");
        string companyname = Console.ReadLine();

        Console.WriteLine("\nEnter Employee Rate Per Hour: ");
        int empRatePerHour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter number of working days: ");
        int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter max hours per month: ");
        int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());

        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addCompanyEmpWage(companyname, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
        empWageBuilder.computeEmpWage();

        Console.WriteLine("\nTotal Wage when queried by the companies is as follows: ");
        Console.WriteLine("\nTotal wage for " + companyname + " is " + empWageBuilder.getTotalWage(companyname));
        Console.ReadLine();
    }
}