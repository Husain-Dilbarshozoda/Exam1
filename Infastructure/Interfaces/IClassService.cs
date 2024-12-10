using Domain;

namespace Infastructure.Interfaces;

public interface IClassService
{
    public bool CreateClass(Class clas);
    public List<Class> GetClasses();
    public bool UpdateClass(Class clas);
    public bool DeleteClass(int id);
}