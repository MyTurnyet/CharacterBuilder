namespace CharacterWeb.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public class CharacterWebModels
    {
        [J("characterSheet")] public CharacterSheet CharacterSheet { get; set; }
    }

    public class CharacterSheet
    {
        [J("race")] public string Race { get; set; }
        [J("class")] public string Class { get; set; }
        [J("characterAttributes")] public List<CharacterAttribute> CharacterAttributes { get; set; }
    }

    public class CharacterAttribute
    {
        [J("characterAttribute")] public string AttributeName { get; set; }
        [J("value")] public long Value { get; set; }
    }


    public class DeserializeWebModel
    {
        private readonly string _json;

        public DeserializeWebModel(string json)
        {
            _json = json;
        }

        public CharacterWebModels CharacterModels() => JsonConvert.DeserializeObject<CharacterWebModels>(_json, 
            new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            });
    }
}