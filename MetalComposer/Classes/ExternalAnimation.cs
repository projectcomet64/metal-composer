using System;
using M64MM.Utils;
using Newtonsoft.Json;


namespace MetalComposer.Classes
{
    public class ExternalAnimation
    {
        public string AnimName { get; set; } = "SM64 Animation";
        public uint FrameCount;
        public uint BoneCount;
        byte[] _indices;
        byte[] _values;
        public byte[] Indices { get { return _indices; } }
        public byte[] Values { get { return _values; } }
        public bool Looping { get; set; }
        public string Author { get; set; } = "Not set";

        [JsonConstructor]
        public ExternalAnimation(string name, uint fcount, uint bcount, byte[] indices, byte[] values, bool loops = true, string author = null)
        {
            AnimName = name;
            FrameCount = fcount;
            BoneCount = bcount;
            _indices = indices;
            _values = values;
            Looping = loops;
            if (author != null)
            {
                Author = author;
            }

            // I hate unaligned writes
            // This deals with them :D
            // Animation data can have a few bytes of padding... make it zeros
            if (_values.Length % 8 != 0)
            {
                byte[] newVal = new byte[_values.Length + (8 - _values.Length % 8)];
                Array.Copy(_values, newVal, _values.Length);
                _values = newVal;
            }
        }

        /// <summary>
        /// Writes this animation to memory
        /// </summary>
        /// <param name="startAt">Address in game memory to write to</param>
        /// <param name="maxSize">Maximum size for the animation to be at</param>
        public void WriteToMem(long startAt = 0x25C00, ulong maxSize = 0x363FF)
        {
            ulong valuesStart = (ulong)_indices.Length + (ulong)startAt;
            ulong length = (ulong)_indices.Length + valuesStart;

            if (length > maxSize) {
                throw new ArgumentOutOfRangeException("Animation data too large for the alloted space for MComposer+");
            }

            Core.WriteBytes(Core.BaseAddress + startAt, _indices, true);
            Core.WriteBytes(Core.BaseAddress + (long)valuesStart, _values, true);

            
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0xA, BitConverter.GetBytes(FrameCount));
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0xC, BitConverter.GetBytes((uint)valuesStart));
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x10, BitConverter.GetBytes((uint)startAt));
        }

    }
}
