using Domain;

namespace Infastructure.Interfaces;

public interface Istudnet_parentService
{
    public bool Createstudnet_parent(studnet_parent studnet_parent);
    public List<studnet_parent> Getstudnet_parents();
    public bool Updatestudnet_parent(studnet_parent studnet_parent);
    public bool Deletestudnet_parent(int id);
}