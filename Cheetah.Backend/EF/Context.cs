using Cheetah.Backend.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Cheetah.Backend.Entity;

public class Context
{
    private IConfiguration _configuration;
    private string _connectionString;

    public Context(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("SQLServer");
    }

    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);

    //public DbSet<ContactForm> ContactForms { get; set; }
    //public DbSet<Subject> Subjects { get; set; }
}

