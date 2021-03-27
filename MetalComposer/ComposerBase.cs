using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using M64MM.Utils;
using MetalComposer.Classes;
using Newtonsoft.Json;

namespace MetalComposer
{
    static class ComposerBase
    {
        public static string[] LoopStateNames =
        {
        "None",
        "Forward",
        "Ping-pong",
        "Chainer Bound"
        };

        public static LoopState LoopStatus = LoopState.FORWARD;
        private static PlaybackState _playback = PlaybackState.PLAYING;
        public static bool OverrideAnimation;
        public static bool SpasmAnimation;
        public static bool CustomLoop;
        public static List<ExternalAnimation> ExternalAnimations = new List<ExternalAnimation>();
        private static SettingsGroup _msettings;
        private static string _animationsPath;
        public static string AnimationsPath { get { return _animationsPath; } }
        public static Random RNG = new Random();

        // Chainer variables
        // Consider moving these to their own class for organization's sake

        public static List<ExternalAnimation> ExternalAnimationChain = new List<ExternalAnimation>();
        public static int ExternalAnimationChainIndex { get; set; }
        static bool _animationChainPlaying;
        public static bool AnimationChainPlaying
        {
            get { return _animationChainPlaying; }
            set
            {
                _animationChainPlaying = value;
                OnAnimationChainPlaybackChange(value);
            }
        }

        public static bool AnimationChainLoop { get; set; }

        public delegate void AnimationChainIndexChange();

        public static event AnimationChainIndexChange OnAnimationChainIndexChange;


        public delegate void AnimationChainPlaybackChange(bool playing);

        public static event AnimationChainPlaybackChange OnAnimationChainPlaybackChange;

        // Playblack and Loop variables

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
                            if (CustomLoop)
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
                        case LoopState.CHAINER:
                            // Management of Chain inside Frame Count
                            // TODO: Make this cleaner, its own class, don't just write the whole implementation here
                            if (AnimationChainPlaying)
                            {
                                if (ExternalAnimationChainIndex == ExternalAnimationChain.Count - 1)
                                {
                                    if (AnimationChainLoop)
                                    {
                                        ExternalAnimationChainIndex = 0;
                                        OnAnimationChainIndexChange.Invoke();
                                        ExternalAnimationChain[ExternalAnimationChainIndex].WriteToMem();
                                        Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes((ushort)value - LoopEnd), 4));
                                    }
                                    else
                                    {
                                        AnimationChainPlaying = false;
                                        PlaybackStatus = PlaybackState.PAUSED;
                                        Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd), 4));
                                    }
                                }
                                else
                                {
                                    ExternalAnimationChainIndex++;
                                    OnAnimationChainIndexChange.Invoke();
                                    ExternalAnimationChain[ExternalAnimationChainIndex].WriteToMem();
                                    Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes((ushort)value - LoopEnd), 4));
                                }
                            }
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
                        case LoopState.CHAINER:
                            // Management of Chain inside Frame Count
                            if (AnimationChainPlaying)
                            {
                                if (ExternalAnimationChainIndex == 0)
                                {
                                    if (AnimationChainLoop)
                                    {
                                        ExternalAnimationChainIndex = ExternalAnimationChain.Count - 1;
                                        OnAnimationChainIndexChange.Invoke();
                                        ExternalAnimationChain[ExternalAnimationChainIndex].WriteToMem();
                                        Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd + Speed), 4));
                                    }
                                    else
                                    {
                                        AnimationChainPlaying = false;
                                        PlaybackStatus = PlaybackState.PAUSED;
                                        Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                                    }

                                }
                                else
                                {
                                    ExternalAnimationChainIndex--;
                                    OnAnimationChainIndexChange.Invoke();
                                    ExternalAnimationChain[ExternalAnimationChainIndex].WriteToMem();
                                    if (Speed < 0)
                                    {
                                        Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopEnd + Speed), 4));
                                    }
                                    else if (Speed > 0)
                                    {
                                        Core.WriteBytes(Core.BaseAddress + Core.CoreEntityAddress + 0x42, Core.SwapEndian(BitConverter.GetBytes(LoopStart), 4));
                                    }
                                }
                            }
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
                if (!CustomLoop)
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
            if (CustomLoop)
            {
                LoopStart = start;
                LoopEnd = end;
            }
        }

        public static void RepopulateAnimationList()
        {
            ExternalAnimations.Clear();
            string[] files = Directory.GetFiles(AnimationsPath, "*.json");
            foreach (string f in files)
            {
                string jsonContent = File.ReadAllText(f);
                ExternalAnimation ea = JsonConvert.DeserializeObject<ExternalAnimation>(jsonContent, new JsonSerializerSettings
                {
                    Converters = { new ExternalAnimationConverter() },
                    MissingMemberHandling = MissingMemberHandling.Ignore
                });
                if (ea != null)
                {
                    ExternalAnimations.Add(ea);
                }
            }
        }

        public static void InitSettings()
        {
            _msettings = SettingsManager.GetSettingsGroup("mcomposer", false);
            if (_msettings == null)
            {
                _msettings = SettingsManager.GetSettingsGroup("mcomposer", true);
                // Default folder for animations: M64MM folder/Animations
                _msettings.SetSettingValue("animationsPath", Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Animations");
                Core.SaveSettings();
            }
            _animationsPath = _msettings.GetSettingValue<string>("animationsPath");
        }

        public static void InitComposer()
        {
            if (!Directory.Exists(AnimationsPath))
            {
                Directory.CreateDirectory(AnimationsPath);
            }
            RepopulateAnimationList();
        }
    }
}
