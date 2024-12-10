using Dapper;
using Domain;
using Infastructure.Interfaces;
using Infastructure.DataContext;

namespace Infastructure.Services;

public class ClassService:IClassService
{
    private readonly DataContext.ConTaxt connection;

    public ClassService()
    {
        connection = new ConTaxt();
    }
    
    public bool CreateClass(Class clas)
    {
        var sql = @"insert into class(class_name,subject_id,teacher_id,classroom_id,section,created_at,updated_at)
                    values(@class_name,@subject_id,@teacher_id,@classroom_id,@section,@created_at,@updated_at);";
        int res = connection.Connection().Execute(sql, clas);
        return res != 0;
    }

    public List<Class> GetClasses()
    {
        var sql = "select * from class;";
        var res = connection.Connection().Query<Class>(sql).ToList();
        return res;
    }

    public bool UpdateClass(Class clas)
    {
        var sql = @"update class
                    set class_name=@class_name,
                        subject_id=@subject_id,
                        teacher_id=@teacher_id,
                        classroom_id=@classroom_id,
                        section=@section,
                        created_at=@created_at,
                        updated_at=@updated_at
                        where class_id=@class_id;";
        int res = connection.Connection().Execute(sql, clas);
        return res != 0;
    }

    public bool DeleteClass(int id)
    {
        var sql = "delete from class where class_id = @Id;";
        int res = connection.Connection().Execute(sql, new { Id = id });
        return res != 0;
    }
}