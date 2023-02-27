using Microsoft.EntityFrameworkCore;
using TODOS.Pages;



internal class DbLayer
{
    private static void Main(string[] args)
    {
        var db = new DBLayer();

        var info = new Info
        {

            Message = "jsbjvsd"
        };


        var info1 = new Info
        {

            Message = "jsbjvsd"
        };


        db.Add(info);
        db.Add(info1);
        db.SaveChanges();
        var Info = db.Info.ToList();
    }
}

public sealed class DBLayer : DbContext
{
    public DbSet<Info> Info => Set<Info>();

    public DBLayer()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source = info.db");
    }



   
}
