﻿namespace DeveloperStore.Business.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid SellerId { get; set; } 
        public DateTime CreatedAt { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}