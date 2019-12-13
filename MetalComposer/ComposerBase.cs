using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M64MM.Utils;
namespace MetalComposer
{

    static class ComposerBase
    {
        static long coreAddress;
        public static long CoreAddress { get { return coreAddress; } set { coreAddress = value - 0x80000000; } }

        public static void UpdateCoreAddress()
        {
            
            CoreAddress = BitConverter.ToInt64(
                Core.SwapEndian(Core.ReadBytes(Core.BaseAddress + 0x33B1F0, 4), 4), 0);
        }

    }
}
