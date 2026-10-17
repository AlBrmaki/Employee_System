namespace Employee_System
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        public FullTimeEmployee(int id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is full-time employee.");
        }

        public decimal CalculateSalary()
        {
            return Salary;
        }
    }
}
