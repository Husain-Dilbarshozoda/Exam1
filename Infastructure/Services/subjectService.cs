using Dapper;
using Domain;
using Infastructure.Interfaces;
using Infastructure.DataContext;


namespace Infastructure.Services;

public class subjectService:IsubjectService
{
    private readonly DataContext.ConTaxt connection;

    public subjectService()
    {
        connection = new ConTaxt();
    }

    public bool Createsubject(subject subject)
    {
        var sql = @"insert into subject(title,school_id,stage,term,carry_mark,created_at,updated_at)
                    values(@title,@school_id,@stage,@term,@carry_mark,@created_at,@updated_at)";
        int res = connection.Connection().Execute(sql, subject);
        return res != 0;
    }

    public List<subject> Getsubjects()
    {
        var sql = "select * from subject;";
        var res = connection.Connection().Query<subject>(sql).ToList();
        return res;
    }

    public bool Updatesubject(subject subject)
    {
        var sql = @"update subject
                    set title=@title,
                        school_id=@school_id,
                        stage=@stage,
                        term=@term,
                        carry_mark=@carry_mark,
                        created_at=@created_at,
                        updated_at=@updated_at
                        where subject_id=@subject_id;";
        int res = connection.Connection().Execute(sql, subject);
        return res != 0;
    }

    public bool Deletesubject(int id)
    {
        var sql = "delete from subject where subject_id=@ID;";
        int res = connection.Connection().Execute(sql,new {ID=id});
        return res != 0;
    }
}