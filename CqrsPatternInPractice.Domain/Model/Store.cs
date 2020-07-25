using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPatternInPractice.Domain.Model
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Item> Item { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
