﻿namespace Reddit.Models
{
    public class Community
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public virtual User Creator { get; set; }
        public int CreatorId { get; set; }

        public virtual List<User> Subscribers { get; set; } = new();
        public virtual List<Post> Posts { get; set; } = new();
    }
}