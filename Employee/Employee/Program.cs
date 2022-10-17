class Program
{
    //static void Main(string[] args)
    //{
    //    EmpWageBuilder empWageBuilder = new EmpWageBuilder();
    //    empWageBuilder.addCompanyEmpWage("Microsoft", 100, 20, 100);
    //    empWageBuilder.addCompanyEmpWage("Google", 200, 30, 150);
    //    empWageBuilder.computeEmpWage();
    //    Console.ReadLine();
    //}

    static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        Console.WriteLine("Press X to enter details of Company");
        var input = "X";
        while ( input == "X" )
        {
            var obj = ReadEmpDetails();
            empWageBuilder.addCompanyEmpWage(obj.companyname, obj.empRatePerHour, obj.numOfWorkingDays, obj.maxHoursPerMonth);
            Console.WriteLine("Press X to enter details of Company");
            input = Console.ReadLine();
        }
        empWageBuilder.computeEmpWage();
    }

    public string  ReadEmpDetails()
    {
        Console.WriteLine("Enter Company Name");
        string companyname = Console.ReadLine();

        Console.WriteLine("Enter Employee Rate Per Hour");
        int empRatePerHour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number of Working Days");
        int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Max Hours Per Month");
        int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());

        return new EmpWageBuilder()
        {
            companyname = companyname,
            empRatePerHour = empRatePerHour,
            numOfWorkingDays = numOfWorkingDays,
            maxHoursPerMonth = maxHoursPerMonth
        };
    }
}