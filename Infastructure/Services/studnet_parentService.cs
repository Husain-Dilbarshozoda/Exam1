using Dapper;
using Domain;
using Infastructure.Interfaces;
using Infastructure.DataContext;

namespace Infastructure.Services;

public class studnet_parentService:Istudnet_parentService
{
    private readonly DataContext.ConTaxt connection;

    public studnet_parentService()
    {
        connection = new ConTaxt();
    }


    public bool Createstudnet_parent(studnet_parent studnet_parent)
    {
        var sql = @"insert into studnet_parent(student_id,parent_id,relationship)
                    values(@student_id,@parent_id,@relationship);";
        int res = connection.Connection().Execute(sql, studnet_parent);
        return res != 0;
    }

    public List<studnet_parent> Getstudnet_parents()
    {
        var sql = "select * from studnet_parent;";
      var res = connection.Connection().Query<studnet_parent>(sql).ToList();
      return res;
    }

    public bool Updatestudnet_parent(studnet_parent studnet_parent)
    {
        var sql = @"update studnet_parent
                    set student_id=@student_id,
                        parent_id=@parent_id,
                        relationship=@relationship
                        where student_parent_id=@student_parent_id;";
        int res = connection.Connection().Execute(sql, studnet_parent);
        return res != 0;    }

    public bool Deletestudnet_parent(int id)
    {
        var sql = "delete from studnet_parent where student_parent_id=@ID;";
        int res = connection.Connection().Execute(sql, new{ID=id});
        return res != 0;
    }
}