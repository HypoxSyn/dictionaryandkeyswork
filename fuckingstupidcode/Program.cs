using System;


Employee[] employ =
{

    new Employee("CEO", "Gwyn", 95, 200f),
    new Employee("CTO", "Tim", 22, 100f)
};

Dictionary<string, Employee> empl = new();

Employee[] _ = {
    new Employee("CEO", "GWEN", 24, 40000f),
    new Employee("CTO", "TIM", 30, 20000f)
};

Dictionary<string, Employee> employeesDirectory = new();

foreach (Employee emp in _)
{
    employeesDirectory.Add(emp.Title, emp);
}

string KeyToUpdate = "HR";

if (employeesDirectory.ContainsKey(KeyToUpdate))
{
    employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka",23, 200000f);
    Console.WriteLine($"Employee with role: {KeyToUpdate} have been updated.");
}
else
{
    Console.WriteLine("FAIL");
}

for(int i = 0; i < employeesDirectory.Count; i++)
{
    KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
}


class Employee
{
    //properties of class
    public string Title { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Salary { get; set; }


    public Employee(string title, string name, int age, float salary) //constructor
    {
        this.Title = title;
        this.Name = name;
        this.Age = age;
        this.Salary = salary;

    }

    public Employee() //default constructor
    {
        this.Title = "Dr";
        this.Name = "Default";
        this.Age = 0;
        this.Salary = 0f;
    }

}


