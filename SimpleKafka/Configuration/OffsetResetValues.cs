using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKafka.Configuration
{
    public enum OffsetResetValues
    {
        Latest,
        Earliest,
        Error
    }
}
