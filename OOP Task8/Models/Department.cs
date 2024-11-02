using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task8.Models
{public class Department
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }= new List<Employee>();
        public Department(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    public void GetEmployeeById(int id) 
     {
            var employee = Employees.FirstOrDefault(x => x.Id == id);
            employee.ShowInfo();
        }
        public void RemoveEmployee(int id) 
        {
            var result =Employees.Find(x => x.Id == id);
            Employees.Remove(result);
        }

    }
}
