namespace OOP_Task8.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
          
        }
        public void ShowInfo() 
        {
            Console.WriteLine(Id+" "+Name+" "+Salary);
        }
        public override string ToString()
        {
            return $"Id:{Id}+ Name:{Name}+ Salary:{Salary}".ToString();
        }
    }
}
