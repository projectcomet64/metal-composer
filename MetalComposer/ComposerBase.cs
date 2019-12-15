using System;
using M64MM.Utils;
namespace MetalComposer
{

    static class ComposerBase
    {
        public static string[] LoopStateNames =
        {
        "None",
        "Forward",
        "Ping-pong"
        };

        public static LoopState LoopStatus = LoopState.FORWARD;
        private static PlaybackState _playback = PlaybackState.PAUSED;
        public static bool OverrideAnimation;
        public static bool customLoop;

        public static PlaybackState PlaybackStatus
        {
            get { return _playback; }
            set
            {
                if (_playback != value)
                {
                    PlaybackChanged(_playback, value);
                    _playback = value;
                }
                else
                {
                    PlaybackChanged(_playback, PlaybackState.PAUSED);
                    _playback = PlaybackState.PAUSED;
                }
                
            }
        }

        public delegate void PlaybackChange(PlaybackState oldState, PlaybackState newState);

        public static event PlaybackChange PlaybackChanged;

        public static ushort LoopStart = 0;
        public static ushort LoopEnd = MaxFrames;
        public static int Speed = 1;

        public static long CoreAddress
        {
            get
            {
                return BitConverter.ToUInt32(
                  Core.ReadBytes(Core.BaseAddress + 0x33B1F8, 4), 0) - 0x80000000;
            }
            private set { }
        }

        public static long ADataAddress
        {
            get
            {
                return BitConverter.ToUInt32(
    Core.ReadBytes(Core.BaseAddress + CoreAddress + 0x3C, 4), 0) - 0x80000000;
            }
            private set { }
        }

        public static short AnimationTimer
        {
            get
            {
                return (short)BitConverter.ToUInt16(
                    Core.ReadBytes(Core.BaseAddress + CoreAddress + 0x42, sizeof(ushort)), 0);
            }
            set
            {
                if (value > LoopEnd)
                {
                    switch (LoopStatus)
                    {
                        case LoopState.NONE:
                            PlaybackStatus = PlaybackState.PAUSED;
                            Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                            break;
                        case LoopState.FORWARD:
                            Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(((ushort)value - LoopEnd + LoopStart)), 4));
                            break;
                        case LoopState.PINGPONG:
                            PlaybackStatus = PlaybackState.REWIND;
                            Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                            break;
                    }
                }
                else if (value < LoopStart)
                {
                    switch (LoopStatus)
                    {
                        case LoopState.NONE:
                            PlaybackStatus = PlaybackState.PAUSED;
                            Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                            break;
                        case LoopState.FORWARD:
                            if (PlaybackStatus == PlaybackState.REWIND)
                            {
                                Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                            }
                            else if (PlaybackStatus == PlaybackState.PLAYING)
                            {
                                Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                            }
                            break;
                        case LoopState.PINGPONG:
                            PlaybackStatus = PlaybackState.PLAYING;
                            Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                            break;
                    }
                }
                else
                {
                    Core.WriteBytes(Core.BaseAddress + CoreAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes((ushort)value), 4));
                }
            }
        }

        public static ushort MaxFrames
        {
            get
            {
                return BitConverter.ToUInt16(
    Core.ReadBytes(Core.BaseAddress + ADataAddress + 0xA, sizeof(ushort)), 0);
            }
            private set { }
        }

        public static void SetAnimOverride(bool restore)
        {
            if (!restore)
            {
                Core.WriteBytes(Core.BaseAddress + ADataAddress + 0x02, BitConverter.GetBytes((ushort)0x04));
            }
            else
            {
                Core.WriteBytes(Core.BaseAddress + ADataAddress + 0x02, BitConverter.GetBytes((ushort)0x00));
            }
            
        }

        public static void NormalizeWingCapHeight(bool restore)
        {
            if (!restore)
            {
                Core.WriteBytes(Core.BaseAddress + ADataAddress + 0x0A, BitConverter.GetBytes((ushort)0x00));
            }
            else
            {
                Core.WriteBytes(Core.BaseAddress + ADataAddress + 0x0A, BitConverter.GetBytes((ushort)0x01));
            }

        }

        public static void SetLoops(ushort start, ushort end)
        {
            if (customLoop)
            {
                LoopStart = start;
                LoopEnd = end;
            }
            else
            {
                LoopStart = 0;
                LoopEnd = MaxFrames;
            }
        }

    }
}
