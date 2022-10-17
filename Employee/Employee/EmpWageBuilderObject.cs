public class EmpWageBuilderObject
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private string companyname;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    public EmpWageBuilderObject(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.companyname = companyname;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void computeEmpWage()
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
        totalEmpWage = totalEmpHrs * this.empRatePerHour;
    }
    public string toString()
    {
        return "Total Employee Wage for Company " + this.companyname + " is: " + this.totalEmpWage;
    }
}
