using Microsoft.EntityFrameworkCore;
using SimpleChatServer.Models;

namespace SimpleChatServer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) => Database.EnsureCreated();

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
