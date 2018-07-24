using System;

namespace SOLID._03_Liskov_substitution
{
    public interface IBonusable
    {
        decimal CalculateBonus(decimal salary);
    }

    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.ID = id; this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }

    public class PermanentEmployee : Employee, IBonusable
    {
        public PermanentEmployee(int id, string name) : base(id, name) { }

        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee, IBonusable
    {
  
        public TemporaryEmployee(int id, string name) : base(id, name) { }

        public decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name) : base(id, name) { }

     }
}
