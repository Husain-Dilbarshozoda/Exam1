using Domain;

namespace Infastructure.Interfaces;

public interface IsubjectService
{
    public bool Createsubject(subject subject);
    public List<subject> Getsubjects();
    public bool Updatesubject(subject subject);
    public bool Deletesubject(int id);
}