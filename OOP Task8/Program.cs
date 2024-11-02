using OOP_Task8.Models;
using System.ComponentModel.Design;

using System.Text.Json;

namespace OOP_Task8
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\Rasim\\source\\repos\\OOP Task8\\Files\Database.json";
            if (!File.Exists(path)) { File.Create(path); }


            Department department = new Department(10,"Department");
            bool result = true;
            while (result)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Get employee by id");
                Console.WriteLine("3. Remove employee");
                Console.WriteLine("0. Quit");
                Console.Write("Select an option: ");

                string input =Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddEmployeetoList(department);
                        SeralizeWithJsonList(department.Employees);
                        break;

                    case "2":
                        Console.WriteLine("Axtarilan id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var foundEmployee = DeSerializeWithJsonList();
                                department.GetEmployeeById(id);

                        break;

                    case "3":
                        Console.WriteLine("Axtarilan id:");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        var removedEmployee = DeSerializeWithJsonList();
                          department.RemoveEmployee(id2);
                        SeralizeWithJsonList(department.Employees);
                        break;

                    case "0":
                         result = false;
                        break;
                        
                }
            }
        }
        public static void SeralizeWithJsonList(List<Employee> employees) 
        {
            using FileStream fileStream = new FileStream(@"C:\Users\Rasim\source\repos\OOP Task8\Files\Database.json",FileMode.Open);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            string result=JsonSerializer.Serialize(employees);
            streamWriter.Write(result);
            Console.WriteLine(result);
        }
        public static List<Employee> DeSerializeWithJsonList() 
        {
         using FileStream fileStream=new FileStream(@"C:\Users\Rasim\source\repos\OOP Task8\Files\Database.json", FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);
            string result=streamReader.ReadToEnd();
            return JsonSerializer.Deserialize<List<Employee>>(result);
        }
        public static void AddEmployeetoList(Department department) 
        {
         Employee employee = new Employee();

            Console.WriteLine("Enter Id:");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            employee.Salary = Convert.ToInt32(Console.ReadLine());
            department.AddEmployee(employee);
         Console.WriteLine("Employee added.");
        }
    }
}
