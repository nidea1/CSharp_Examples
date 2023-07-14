using System;
using ToDo.Entities.Abstract;

namespace ToDo.Entities.Concrete
{
    public class TeamMember : BaseEntity<string>
    {
        public override required string Id { get; set; }

        public required string Name { get; set; }
    }
}
