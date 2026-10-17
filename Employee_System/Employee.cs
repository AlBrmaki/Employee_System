namespace Employee_System
{
    public abstract class Employee  
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private decimal _salary;
        public decimal Salary { get { return _salary; } }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            _salary = salary;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Employee ID: {Id}, Name: {Name}, Salary: {Salary}");
        }
    }
}
