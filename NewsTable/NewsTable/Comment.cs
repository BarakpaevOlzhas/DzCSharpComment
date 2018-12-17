using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsTable
{
    public class Comment : GuidGenerator
    {
        public string Text { set; get; }
        public New IdNew { set; get; }
    }
}
