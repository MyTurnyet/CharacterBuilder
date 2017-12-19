namespace CharacterWeb.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class CharacterWebModels
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

    public partial class CharacterWebModels
    {
        public static CharacterWebModels FromJson(string json) => JsonConvert.DeserializeObject<CharacterWebModels>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CharacterWebModels self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}