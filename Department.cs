public class Department
{
    private string departmentId;
    private string departmentName;
    public Department(string id, string name)
    {
        departmentId = id;
        departmentName = name;
    }
    public Department(Department department)
    {
        departmentId = department.departmentId;
        departmentName = department.departmentName;
    }
}