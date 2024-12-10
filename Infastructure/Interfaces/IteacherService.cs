using Domain;

namespace Infastructure.Interfaces;

public interface IteacherService
{
    public bool Createteacher(teacher teacher);
    public List<teacher> Getteachers();
    public bool Updateteacher(teacher teacher);
    public bool Deleteteacher(int id);
}