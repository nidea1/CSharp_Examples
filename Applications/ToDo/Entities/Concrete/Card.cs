using System;
using System.Collections.Generic;
using ToDo.Entities.Abstract;
using ToDo.Enums;

namespace ToDo.Entities.Concrete
{
    public class Card : BaseEntity<int>
    {
        public override int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public required TeamMember AssignedMember{ get; set; }

        public required CardSize CardSize{ get; set; }
    }
}
