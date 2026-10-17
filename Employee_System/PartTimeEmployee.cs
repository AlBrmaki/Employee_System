namespace Employee_System
{
    public class PartTimeEmployee : Employee, IWorkable
    {
        public PartTimeEmployee(int id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is part-time employee.");
        }

        public decimal CalculateSalary()
        {
            return Salary;
        }
    }
}
