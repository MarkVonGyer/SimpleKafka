using Confluent.Kafka;

namespace SimpleKafka.Configuration;
public record KafkaConfiguration
{
    private readonly string? _bootstrapServers;
    private readonly OffsetResetValues _offsetResetValues = OffsetResetValues.Latest;
    public bool EnableAutoCommit { get; init; } = true;
    public bool EnableAutoOffsetStore { get; init; } = true;
    public long? MaxMessageBytes { get; init; }
    public string? BootstrapServers { get
        {
            if (string.IsNullOrEmpty(_bootstrapServers))
                throw new NullReferenceException(nameof(_bootstrapServers));
            else
                return _bootstrapServers;
        }
        init
        {
            _bootstrapServers = value;
        }
    }
    public bool SSLEnabled { get; init; } = true;

    public OffsetResetValues OffsetResetValue { init
        {
            _offsetResetValues = value;
        }
    }

    public AutoOffsetReset OffsetResetValueConfluent
    {
        get{
            return (AutoOffsetReset)_offsetResetValues;
        }
    }

    public bool ManualStoreOffset { get; set; } = true;
}
