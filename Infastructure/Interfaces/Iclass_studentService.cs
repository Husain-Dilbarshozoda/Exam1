using Domain;

namespace Infastructure.Interfaces;

public interface Iclass_studentService
{
    public bool Createclass_student(class_student classStudent);
    public List<class_student> Getclass_students();
    public bool Updateclass_student(class_student classStudent);
    public bool Deleteclass_student(int id);
}