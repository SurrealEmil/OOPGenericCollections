namespace OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates five instences of class "Employee"
            Employee emp1 = new Employee(101, "Lukas", "Male", 30000);
            Employee emp2 = new Employee(102, "Matilda", "Female", 35000);
            Employee emp3 = new Employee(103, "John", "Male", 36000);
            Employee emp4 = new Employee(104, "Sara", "Female", 33000);
            Employee emp5 = new Employee(105, "Tobias", "Male", 39000);

            // Part 1 - Stack

            // Create a stack 
            Stack<Employee> empStack = new Stack<Employee>();

            // Push employees onto the stack
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            // Loop through and print employee info
            foreach (Employee emp in empStack)
            {
                emp.EmployeeInfo();
                Console.WriteLine($"Items left in the Stack = {empStack.Count}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrive Using Pop Metod");

            // Retrieve employees using Pop method
            while (empStack.Count > 0)
            {
                Employee emp = empStack.Pop();
                emp.EmployeeInfo();
                Console.WriteLine($"Items left in the Stack = {empStack.Count}");
            }

            // Push employees back onto the stack
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            Console.WriteLine("----------------------------");

            // Retrieve employees using Peek method
            Console.WriteLine("Retrive Using Peek Metod");

            for (int i = 0; i < 2; i++)
            {
                Employee emp = empStack.Peek();
                emp.EmployeeInfo();
                Console.WriteLine($"Items left in the Stack = {empStack.Count}");

            }

            Console.WriteLine("----------------------------");

            // Check if emp3 is in the stack
            if (empStack.Contains(emp3))
            {
                Console.WriteLine("Employee 3 is in stack");
            }
            else
            {
                Console.WriteLine($"Employee 3 is not in the stack");
            }

            // Part 2 - List
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Part 2 - List\n");

            // Create a list
            List<Employee> empList = new List<Employee>();

            // Add employees to the list
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);

            // Check if emp2 exists in the list
            if (empList.Contains(emp2))
            {
                Console.WriteLine("Employee 2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exist in the list");
            }
            Console.WriteLine();

            // Use the custom delegate with "Find" to find and print the first male employee
            Employee firstMaleEmployee = empList.Find(Employee.IsMale);
            if (firstMaleEmployee != null)
            {
                firstMaleEmployee.EmployeeInfo2();
            }
            else
            {
                Console.WriteLine("No male employee found");
            }

            Console.WriteLine();

            // Use the custom delegate with "FindAll" to find and print all male employees
            List<Employee> maleEmployees = empList.FindAll(Employee.IsMale);
            if (maleEmployees.Count > 0)
            {
                foreach (var maleEmployee in maleEmployees)
                {
                    maleEmployee.EmployeeInfo2();
                }
            }
            else
            {
                Console.WriteLine("No male employees found");
            }
        }
    }
}