using Todo.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddDbContext<AppDbContext>();        
        
        var app = builder.Build();

        app.MapControllers();
       

        app.Run();
    }
}