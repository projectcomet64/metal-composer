using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MetalComposer.Classes
{

    public class ExternalAnimationConverter : JsonConverter<ExternalAnimation>
    {
        bool canRead = false;
        public override ExternalAnimation ReadJson(JsonReader reader, Type objectType, ExternalAnimation existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                JObject anim = JObject.Load(reader);
                byte[] indices, values;
                indices = anim["indices"].ToObject<string[]>().Select((x) => {
                    byte L = Convert.ToByte(x.Replace("0x", ""), 16);
                    return L;
                }).ToArray();
                string author;
                try
                {
                    author = anim["author"].Value<string>();
                }
                catch
                {
                    author = "Author not set";
                }
                values = anim["values"].ToObject<string[]>().Select(x => Convert.ToByte(x.Replace("0x", ""), 16)).ToArray();
                return new ExternalAnimation(anim["name"].Value<string>(),
                                             anim["length"].Value<uint>(),
                                             anim["nodes"].Value<uint>(),
                                             indices,
                                             values,
                                             anim["looping"].Value<bool>(),
                                             author);
            }
            else
            {
                return null;
            }
        }
        public override void WriteJson(JsonWriter writer, ExternalAnimation value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
