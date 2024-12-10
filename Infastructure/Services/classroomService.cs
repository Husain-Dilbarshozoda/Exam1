using Dapper;
using Domain;
using Infastructure.Interfaces;
using Infastructure.DataContext;


namespace Infastructure.Services;

public class classroomService:IclassroomService
{
    private readonly DataContext.ConTaxt connection;

    public classroomService()
    {
        connection = new ConTaxt();
    }
    
    public bool Createclassroom(classroom classroom)
    {
        var sql = @"insert into classroom(capacity,room_type,description,created_at,updated_at)
                    values(@capacity,@room_type,@description,@created_at,@updated_at);";
        int res = connection.Connection().Execute(sql,classroom);
        return res != 0;
    }

    public List<classroom> Getclassrooms()
    {
        var sql = "select * from classroom;";
        var res = connection.Connection().Query<classroom>(sql).ToList();
        return res;
    }

    public bool Updateclassroom(classroom classroom)
    {
        var sql = @"update classroom
                    set capacity=@capacity,
                        room_type=@room_type,
                        description=@description,
                        created_at=@created_at,
                        updated_at=@updated_at
                        where classroom_id=@classroom_id;";
        int res = connection.Connection().Execute(sql, classroom);
        return res != 0;
    }

    public bool Deleteclassroom(int id)
    {
        var sql = "delete from classroom where classroom_id = @Id;";
        int res = connection.Connection().Execute(sql ,new { Id = id });
        return res!=0;
    }
}