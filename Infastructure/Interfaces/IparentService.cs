using Domain;

namespace Infastructure.Interfaces;

public interface IparentService
{
    public bool Createparent(parent parent);
    public List<parent> Getparents();
    public bool Updateparent(parent parent);
    public bool Deleteparent(int id);
}