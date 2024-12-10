using Dapper;
using Domain;
using Infastructure.Interfaces;
using Infastructure.DataContext;

namespace Infastructure.Services;

public class class_studentService:Iclass_studentService
{
    private readonly DataContext.ConTaxt connection;

    public class_studentService()
    {
        connection = new ConTaxt();
    }
    
    public bool Createclass_student(class_student classStudent)
    {
        var sql = @"insert into class_student(class_id,student_id) values(@class_id,@student_id);";
        int res = connection.Connection().Execute(sql, classStudent);
        return res != 0;
    } 

    public List<class_student> Getclass_students()
    {
        var sql = "select * from class_student;";
        var res = connection.Connection().Query<class_student>(sql).ToList();
        return res;
    }

    public bool Updateclass_student(class_student classStudent)
    {
        var sql = "update class_student set class_id=@class_id,student_id=@student_id where class_student_id=@class_student_id;";
        int res = connection.Connection().Execute(sql, classStudent);
        return res != 0;
    }

    public bool Deleteclass_student(int id)
    {
        var sql = "delete from class_student where class_student_id = @Id;";
        int res = connection.Connection().Execute(sql, new { Id = id });
        return res != 0;
    }
}