using System.Data.Common;
using System.Dynamic;

public class Employee
{
    private string id;
    /*public string getId()
    {
        return id;
    }
    public void setId(string ids)
    {
        id = ids;
    }*/
    /*public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Coef { get; set; }*/

    private string name;
    private int age;
    private float coef;
    private Department department;

    public string Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public float Coef { get => coef; set => coef = value; }
    public Employee(){
        id = "Unknown";
        name = "Unknown";
        age = 0;
        coef = 0.0f;
    }
    public Employee(string id1, string name1, int age1, float coef1){
        id = id1;
        name = name1;
        age = age1;
        coef = coef1;
    }
    public Employee(Employee employee)
    {
        id = employee.id;
        name = employee.name;
        age = employee.age;
        coef = employee.coef;
        //department = employee.department;//chỉ tạo alias
        department = new Department(employee.department); // Assuming Department has a copy constructor
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {id}, {name}, {age}, {coef}");
    }
}