using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPatternInPractice.Domain.Model
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}
