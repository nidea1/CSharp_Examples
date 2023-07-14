using System;
using System.Collections.Generic;

namespace ToDo.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }

        public DateTime CreatedDate { get; private set;}

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
