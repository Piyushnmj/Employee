class Program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    public static int computeEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
        }
        int totalEmpWage = totalEmpHrs * empRatePerHour;
        Console.WriteLine("Total Emp Wage for company " + companyname + " is: " + totalEmpWage);
        return totalEmpWage;
    }
    static void Main(string[] args)
    {
        computeEmpWage("Microsoft", 100, 20, 100);
        computeEmpWage("Google", 200, 30, 150);
        Console.ReadLine();
    }
}