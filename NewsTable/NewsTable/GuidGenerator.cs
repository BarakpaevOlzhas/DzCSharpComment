using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsTable
{
    abstract public class GuidGenerator
    {
        public Guid Id { set; get; }

        public GuidGenerator()
        {
            Id = Guid.NewGuid();
        }
    }
}
