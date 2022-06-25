using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKafka.Configuration
{
    public record RetryConfiguration
    {
        public long[]? RetryIntervalSeconds { get; init; }
        public string RetryTopicSuffix { get; init; } = "Retry";
        public string DeadLetterTopicSuffix { get; init; } = "DL";
    }
}
