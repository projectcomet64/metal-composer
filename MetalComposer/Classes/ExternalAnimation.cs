using System;
using M64MM.Utils;


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

        public void WriteToMem()
        {
            
            ulong valuesStart = (ulong)(Core.AnimDataAddress + 0x20 + _indices.Length);
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x20, _indices, true);
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x10, BitConverter.GetBytes(Core.AnimDataAddress + 0x20));
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0xA, BitConverter.GetBytes(FrameCount));
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0xC, BitConverter.GetBytes((uint)valuesStart));
            Core.WriteBytes(Core.BaseAddress + (long)valuesStart, _values, true);
        }

    }
}
