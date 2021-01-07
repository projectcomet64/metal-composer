using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MetalComposer.Classes
{
    public class ExternalAnimation
    {
        public string Name = "SM64 Animation";
        public uint FrameCount;
        public uint BoneCount;
        byte[] _indices;
        byte[] _values;
        public byte[] Indices { get { return _indices; } }
        public byte[] Values { get { return _values; } }
 
        public ExternalAnimation(string name, uint fcount, uint bcount, byte[] indices, byte[] values)
        {
            Name = name;
            FrameCount = fcount;
            BoneCount = bcount;
            _indices = indices;
            _values = values;
        }

        public void WriteToMem()
        {
            // I hate unaligned writes
            ulong valuesStart = (ulong)(Core.AnimDataAddress + 0x20 + _indices.Length);
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x20, _indices, true);
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x10, BitConverter.GetBytes(Core.AnimDataAddress + 0x20));
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0xA, BitConverter.GetBytes(FrameCount));
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0xC, BitConverter.GetBytes((uint)valuesStart));
            Core.WriteBytes(Core.BaseAddress + (long)valuesStart, _values, true);
        }

    }

    public class ExternalAnimationConverter : JsonConverter<ExternalAnimation>
    {
        bool canRead = false;
        public override ExternalAnimation ReadJson(JsonReader reader, Type objectType, ExternalAnimation existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                JObject anim = JObject.Load(reader);
                byte[] indices, values;
                MessageBox.Show("0xFF".TrimStart("0x".ToCharArray()));
                MessageBox.Show(Convert.ToByte("0xFF".TrimStart("0x".ToCharArray()), 16).ToString());
                indices = anim["indices"].ToObject<string[]>().Select((x) => {
                    byte L = Convert.ToByte(x.Replace("0x", ""), 16);
                    return L;
                    }).ToArray();
                values = anim["values"].ToObject<string[]>().Select(x => Convert.ToByte(x.Replace("0x", ""), 16)).ToArray();
                return new ExternalAnimation(anim["name"].Value<string>(),
                                             anim["length"].Value<uint>(),
                                             anim["nodes"].Value<uint>(),
                                             indices,
                                             values);
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
