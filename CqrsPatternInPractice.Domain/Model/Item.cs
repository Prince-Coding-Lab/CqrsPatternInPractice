using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPatternInPractice.Domain.Model
{
    public class Item : BaseEntity
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Store Store { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
