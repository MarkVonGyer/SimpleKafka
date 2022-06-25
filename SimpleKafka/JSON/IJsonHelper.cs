using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKafka.Deserialisation
{
    internal interface IJsonHelper
    {
        object? Deserialize(string jsonString, Type deserialiseType);
        T? Deserialize<T>(string jsonString);
    }
}
