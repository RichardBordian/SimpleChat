namespace SimpleChatServer.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public User Admin { get; set; }
        public int AdminId { get; set; }
        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
