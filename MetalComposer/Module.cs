using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using M64MM.Additions;
using M64MM.Utils;
using MetalComposer.Properties;
using static MetalComposer.ComposerBase;
namespace MetalComposer
{
    public class Module : IModule
    {

        ComposerForm form;

        public string SafeName => "CoMposer";

        public string Description => "EXPERIMENTAL FEATURE - Modify some aspects of Mario's animation!";

        public Image AddonIcon => Resources.metal_512;

        public void Close(EventArgs e)
        {
            OverrideAnimation = false;
            SetAnimOverride(true);
            if (form != null)
            {
                form.Close();
            }
        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> retList = new List<ToolCommand>();
            ToolCommand showForm = new ToolCommand("Open METAL Composer");
            showForm.Summoned += (a, b) => ShowForm();
            retList.Add(showForm);
            return retList;
        }

        public void Initialize()
        {
        }

        public void OnBaseAddressFound()
        {

        }

        public void OnBaseAddressZero()
        {

        }

        public void ShowForm()
        {
            if (form == null || form.IsDisposed) form = new ComposerForm();

            if (!form.Visible)
                form.Show();

            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        public void Reset()
        {

        }

        public void Update()
        {
            form?.Invoke(new MethodInvoker(delegate ()
            {
                if (Core.CurrentLevelID > 3 && form != null && (form.IsDisposed == false || form.Disposing))
                {
                    ValidateAnimDataAddr();
                    if (ValidAnimData)
                    {
                        form.UpdateCoreAddressText(0);
                        if (OverrideAnimation)
                        {
                            SetAnimOverride(false);
                            switch (PlaybackStatus)
                            {
                                case PlaybackState.PLAYING:
                                    AnimationTimer += (short)Speed;
                                    break;
                                case PlaybackState.REWIND:
                                    AnimationTimer -= (short)Speed;
                                    break;
                            }

                        }
                        if (SpasmAnimation)
                        {
                            SetAnimSpasm();
                            AnimationTimer = (short)RNG.Next(0, MaxFrames);
                        }
                        form.UpdateMaxFrames(MaxFrames);
                        form.UpdateFramesTimer(AnimationTimer);
                    }
                    else
                    {
                        form.UpdateFramesTimer(0, true);
                    }
                }
            }));
        }

        public void OnCoreEntAddressChange(uint addr)
        {

        }
    }
}
