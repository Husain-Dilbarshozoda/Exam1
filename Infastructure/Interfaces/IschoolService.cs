using Domain;

namespace Infastructure.Interfaces;

public interface IschoolService
{
    public bool Createschool(school school);
    public List<school> Getschools();
    public bool Updateschool(school school);
    public bool Deleteschool(int id);
}