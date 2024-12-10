using Domain;

namespace Infastructure.Interfaces;

public interface IstudentService
{
    public bool Createstudent(student student);
    public List<student> Getstudents();
    public bool Updatestudent(student student);
    public bool Deletestudent(int id);
}