using Npgsql;

namespace Infastructure.DataContext;

public class ConTaxt
{
    private string mainconnection = "Server=localhost;Port=5432;Database=schoolDB;Username=postgres;Password=12345";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(mainconnection);
    }
}