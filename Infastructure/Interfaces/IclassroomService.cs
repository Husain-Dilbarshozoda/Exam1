using Domain;

namespace Infastructure.Interfaces;

public interface IclassroomService
{
    public bool Createclassroom(classroom classroom);
    public List<classroom> Getclassrooms();
    public bool Updateclassroom(classroom classroom);
    public bool Deleteclassroom(int id);
}