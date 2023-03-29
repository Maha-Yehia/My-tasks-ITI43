using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness_logic_tear.Entity
{
    public class BaseEntity
    {
        public State EntityState { get; set; } = State.Unchanged;
    }
}
