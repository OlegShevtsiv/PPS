using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string CommentedEssenceId { get; set; }
        public string Text { get; set; }
        public Comment() { }
        public Comment(string _id, string _ownerId, string _commentedEssenceId, string _text)
        {
            Id = _id;
            OwnerId = _ownerId;
            CommentedEssenceId = _commentedEssenceId;
            Text = _text;
        }
    }
}
