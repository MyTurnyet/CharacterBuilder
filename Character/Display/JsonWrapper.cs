
using System.Text.Json;

namespace Character.Display
{
    public class JsonWrapper : IJsonInterpreter
    {
        public string Serialize(object objectToSerialize)
        {
            return JsonSerializer.Serialize(objectToSerialize);
        }
    }
}
