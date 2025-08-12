public class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        //employee.Id = "E123";
        //employee.id = ""; //Lỗi
        //employee.Name = "John Doe";
        //employee.Age = 30;
        //employee.Coef = 1.5f;

        //Console.WriteLine($"Employee: {employee.Id}, {employee.Name}, {employee.Age}, {employee.Coef}");
        employee.DisplayInfo();
        Employee employee2 = new Employee("E456", "Jane Smith", 28, 1.8f);
        employee2.DisplayInfo();
        Employee employee3 = new Employee(employee2);
        employee3.DisplayInfo();
    }
}