namespace EntityFrameworkh2.Models;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Id_Group { get; set; }

}
