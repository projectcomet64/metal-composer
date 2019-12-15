using System;
using System.Windows.Forms;
using static MetalComposer.ComposerBase;

namespace MetalComposer
{
    public partial class ComposerForm : Form
    {
        public ComposerForm()
        {
            InitializeComponent();
            PlaybackChanged += (o, n) => { HandlePlaybackChange(o, n); };
            for (int i = 0; i < Enum.GetNames(typeof(LoopState)).Length; i++)
            {
                cbLoopMode.Items.Add(LoopStateNames[i]);
            }
            cbLoopMode.SelectedIndex = 1;
        }

        public void UpdateMaxFrames(ushort frames)
        {
            if (tbCurrentFrame.Value > frames)
            {
                tbCurrentFrame.Value = frames - 1;
            }
            tbCurrentFrame.Maximum = frames;
        }

        public void UpdateFramesTimer(int timer)
        {
            lbCurrentFrame.Text = timer.ToString();
            tbCurrentFrame.Value = timer;
        }

        public void UpdateCoreAddressText(long address)
        {
            label1.Text = "Core Address is: 0x" + address.ToString("X") + ", A: " + ADataAddress.ToString("X") + "\n Animation timer is: "
                + AnimationTimer + "\nPlayback status: " + PlaybackStatus.ToString();
        }

        public void HandlePlaybackChange(PlaybackState oldState, PlaybackState newState)
        {
            switch (oldState)
            {
                case PlaybackState.PAUSED:
                    switch (newState)
                    {
                        case PlaybackState.PAUSED:
                            btnPlay.Text = "▶";
                            btnRwd.Text = "◀◀";
                            break;
                        case PlaybackState.PLAYING:
                            btnPlay.Text = "❚❚";
                            btnRwd.Text = "◀◀";
                            break;
                        case PlaybackState.REWIND:
                            btnRwd.Text = "❚❚";
                            btnPlay.Text = "▶";
                            break;
                    }
                    break;
                case PlaybackState.PLAYING:
                    switch (newState)
                    {
                        case PlaybackState.PLAYING:
                            PlaybackStatus = PlaybackState.PAUSED;
                            break;
                        case PlaybackState.PAUSED:
                            btnPlay.Text = "▶";
                            btnRwd.Text = "◀◀";
                            break;
                        case PlaybackState.REWIND:
                            btnRwd.Text = "❚❚";
                            btnPlay.Text = "▶";
                            break;
                    }
                    break;
                case PlaybackState.REWIND:
                    switch (newState)
                    {
                        case PlaybackState.REWIND:
                            PlaybackStatus = PlaybackState.PAUSED;
                            break;
                        case PlaybackState.PAUSED:
                            btnPlay.Text = "▶";
                            btnRwd.Text = "◀◀";
                            break;
                        case PlaybackState.PLAYING:
                            btnPlay.Text = "❚❚";
                            btnRwd.Text = "◀◀";
                            break;
                    }
                    break;
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlaybackStatus = PlaybackState.PLAYING;
        }

        private void btnRwd_Click(object sender, EventArgs e)
        {
            PlaybackStatus = PlaybackState.REWIND;
        }

        private void cbLoopMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoopStatus = (LoopState)((ComboBox)sender).SelectedIndex;
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            Speed = tbSpeed.Value;
            lbSpeedVal.Text = Speed + "x";
        }

        private void btnFrameNext_Click(object sender, EventArgs e)
        {
            AnimationTimer++;
        }

        private void btnFrameBack_Click(object sender, EventArgs e)
        {
            AnimationTimer--;
        }

        private void btnFrameStart_Click(object sender, EventArgs e)
        {
            AnimationTimer = 0;
        }

        private void btnFrameLast_Click(object sender, EventArgs e)
        {
            AnimationTimer = (short)tbCurrentFrame.Maximum;
        }

        private void tbCurrentFrame_Scroll(object sender, EventArgs e)
        {
                AnimationTimer = (short)tbCurrentFrame.Value;
        }

        private void cbOverride_CheckedChanged(object sender, EventArgs e)
        {
            OverrideAnimation = ((CheckBox)sender).Checked;
            if (!((CheckBox)sender).Checked)
            {
                SetAnimOverride(true);
            }
        }
    }
}
