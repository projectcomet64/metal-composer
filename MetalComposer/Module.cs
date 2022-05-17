using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public string SafeName => "METAL Composer";

        public string Description => "Advanced SM64 Animation trainer and external animation loader";

        public Image AddonIcon => Resources.composer_512;

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
            if (form == null || form.IsDisposed) {
                form = new ComposerForm();

                InitSettings();
                try {
                    InitComposer();
                }
                catch (Exception e) {
                    MessageBox.Show($"METAL Composer failed to load external animations. Please check your folder or ask for help. \n{e}");
                }
            }

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

        public void Update() {
            if (form == null || !form.IsHandleCreated) return;
            form?.Invoke(new MethodInvoker(delegate ()
            {
                if (Core.CurrentLevelID > 3 && form != null && (form.IsDisposed == false || form.Disposing))
                {
                    Core.ValidateAnimDataAddress();
                    if (Core.ValidateAnimDataAddress())
                    {
                        form.UpdateCoreAddressText(0);
                        if (OverrideAnimation)
                        {
                            SetAnimOverride(false);
                            if (PlaybackStatus != PlaybackState.PAUSED)
                            AnimationTimer += (short)Speed;
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
