using System;
using ToDo.Entities.Abstract;

namespace ToDo.Entities.Concrete
{
    public class Board : BaseEntity<int>
    {
        public override int Id { get; set; }

        public List<Line> Lines { get; set; } = new List<Line>();
    }
}
