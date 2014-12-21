using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IdentitySample.Models
{
    public class Messages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public Guid SenderId { get; set; }
        public DateTime Date { get; set; }

        public int ConversationId { get; set; }
        public virtual Conversations Conversation { get; set; }

        
    }
    public class Conversations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConversationId { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipentId { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        
        
        public virtual ICollection<Messages> Messages { get; set; }
    }
}