using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPatternInPractice.Domain.Model
{
    public class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
