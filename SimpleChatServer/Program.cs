using Microsoft.EntityFrameworkCore;
using SimpleChatServer.Repositories;
using SimpleChatServer.Services;

namespace SimpleChatServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<Context>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IRepositories, UserRepository>();
            builder.Services.AddScoped<IRepositories, ChatRepository>();

            builder.Services.AddScoped<IServices, UserService>();
            builder.Services.AddScoped<IServices, ChatService>();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}