using System;
using ToDo.Entities.Abstract;

namespace ToDo.Entities.Concrete
{
    public class Line : BaseEntity<string>
    {

        public override string Id { get; set; }

        public required string Name { get; set; }

        public List<Card>? Cards { get; set; }
    }
}
