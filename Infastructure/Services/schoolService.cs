using Dapper;
using Domain;
using Infastructure.Interfaces;
using Infastructure.DataContext;


namespace Infastructure.Services;

public class schoolService:IschoolService
{
    private readonly DataContext.ConTaxt connection;

    public schoolService()
    {
        connection = new ConTaxt();
    }
    public bool Createschool(school school)
    {
        var sql = @"insert into school(school_title,level_count,is_active,created_at,updated_at)
                    values(@school_title,@level_count,@is_active,@created_at,@updated_at);";
        int res = connection.Connection().Execute(sql,school);
        return res != 0;
    }

    public List<school> Getschools()
    {
        var sql = "select * from school;";
        var res = connection.Connection().Query<school>(sql).ToList();
        return res;
    }

    public bool Updateschool(school school)
    {
        var sql = @"update school
                    set school_title=@school_title,
                        level_count=@level_count,
                        is_active=@is_active,
                        created_at=@created_at,
                        updated_at=@updated_at
                        where school_id=@school_id;";
        int res = connection.Connection().Execute(sql, school);
        return res != 0;
    }

    public bool Deleteschool(int id)
    {
        var sql = "delete from school where id=@Id;";
        int res = connection.Connection().Execute(sql, new { Id = id });
        return res != 0;
    }
}