using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Data
{
    public partial class Comment : BaseEntity
    {
       
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActice { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
