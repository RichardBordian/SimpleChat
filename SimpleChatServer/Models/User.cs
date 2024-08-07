﻿namespace SimpleChatServer.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Chat> Chats { get; set; }
        public List<Message> Messages { get; set; }
    }
}
