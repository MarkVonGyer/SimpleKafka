using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKafka.Configuration
{
    public record TopicCreationConfiguration
    {
        public short? ReplicationCount { get; init; }
        public short? PartitionCount { get; init; }

        public bool ALlowAutoCreateTopics { get; init; } = false;
    }
}
