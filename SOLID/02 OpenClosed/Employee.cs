namespace SOLID._02_OpenClosed
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.EmployeeType = type;
        }

        public decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name, string type) : base(id, name, type) { }

        public new decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}