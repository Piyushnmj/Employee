public interface IComputeEmpWage
{
    public void addCompanyEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
    public void computeEmpWage();
    public int getTotalWage(string companyname);
}
public class CompanyEmpWage
{
    public string companyname;
    public int empRatePerHour;
    public int numOfWorkingDays;
    public int maxHoursPerMonth;
    public int totalEmpWage;

    public CompanyEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.companyname = companyname;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
        this.totalEmpWage = 0;
    }

    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;
    }

    public string toString()
    {
        return "Total Emp Wage for Company " + this.companyname + " is: " + this.totalEmpWage;
    }
}