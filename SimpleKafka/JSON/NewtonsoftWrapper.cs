using Newtonsoft.Json;
using SimpleKafka.Deserialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKafka.JSON
{
    internal class NewtonsoftWrapper : IJsonHelper
    {
        public object? Deserialize(string jsonString, Type deserialiseType)
        {
            return JsonConvert.DeserializeObject(jsonString, deserialiseType);
        }

        public T? Deserialize<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
