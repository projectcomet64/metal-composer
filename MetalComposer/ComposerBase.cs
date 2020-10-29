﻿using System;
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
        private static PlaybackState _playback = PlaybackState.PLAYING;
        public static bool OverrideAnimation;
        public static bool SpasmAnimation;
        public static bool customLoop;
        public static Random RNG = new Random();

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

        public static short AnimationTimer
        {
            get
            {
                return Core.AnimationTimer;
            }
            set
            {
                if (!Core.ValidateAnimDataAddress())
                    return;

                if (value > LoopEnd)
                {
                    switch (LoopStatus)
                    {
                        case LoopState.NONE:
                            PlaybackStatus = PlaybackState.PAUSED;
                            Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                            break;
                        case LoopState.FORWARD:
                            if (customLoop)
                            {
                                Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes((LoopStart)), 4));
                            }
                            else
                            {
                                Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(((ushort)value - LoopEnd)), 4));
                            }
                            break;
                        case LoopState.PINGPONG:
                            Speed *= -1;
                            Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                            break;
                    }
                }
                else if (value < LoopStart)
                {
                    switch (LoopStatus)
                    {
                        case LoopState.NONE:
                            PlaybackStatus = PlaybackState.PAUSED;
                            Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                            break;
                        case LoopState.FORWARD:
                            if (Speed < 0)
                            {
                                Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                            }
                            else if (Speed > 0)
                            {
                                Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                            }
                            break;
                        case LoopState.PINGPONG:
                            Speed *= -1;
                            Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                            break;
                    }
                }
                else
                {
                    Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes((ushort)value), 4));
                }
            }
        }

        public static ushort MaxFrames
        {
            get
            {
                ushort _maxFrames = BitConverter.ToUInt16(
    Core.ReadBytes(Core.BaseAddress + Core.AnimDataAddress + 0xA, sizeof(ushort)), 0);
                if (!customLoop)
                {
                    LoopStart = 0;
                    LoopEnd = _maxFrames;
                }
                return _maxFrames;
            }
        }

        public static void SetAnimOverride(bool restore)
        {
            if (!Core.ValidateAnimDataAddress())
                return;

            if (!restore)
            {
                Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x02, BitConverter.GetBytes((ushort)0x04));
            }
            else
            {
                Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x02, BitConverter.GetBytes((ushort)0x00));
            }

        }

        public static void SetAnimSpasm()
        {
            if (!Core.ValidateAnimDataAddress())
                return;

            byte[] AnimMetaBytes = Core.ReadBytes(Core.BaseAddress + Core.AnimDataAddress + 0xC, 4);
            //AnimMetaBytes = Core.SwapEndian(AnimMetaBytes, 4);
            AnimMetaBytes[0] = (byte)(0x40 + (RNG.Next(10) * 2));
            AnimMetaBytes[1] = 0;
            Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x10, AnimMetaBytes);
        }

        public static void NormalizeWingCapHeight(bool restore)
        {
            if (!Core.ValidateAnimDataAddress())
                return;

            if (!restore)
            {
                Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x0A, BitConverter.GetBytes((ushort)0x00));
            }
            else
            {
                Core.WriteBytes(Core.BaseAddress + Core.AnimDataAddress + 0x0A, BitConverter.GetBytes((ushort)0x01));
            }

        }

        public static void SetLoops(ushort start, ushort end)
        {
            if (customLoop)
            {
                LoopStart = start;
                LoopEnd = end;
            }
        }
    }
}
