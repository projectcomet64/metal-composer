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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void UpdateMaxFrames(ushort frames)
        {
            if (tbCurrentFrame.Value > frames)
            {
                tbCurrentFrame.Value = frames - 1;
            }
            else if (tbCurrentFrame.Value < 0)
            {
                tbCurrentFrame.Value = 0;
            }

            if (nudEnd.Value > frames)
            {
                nudEnd.Value = frames;
            }

            if (nudEnd.Value < nudStart.Value)
            {
                nudEnd.Value = nudStart.Value;
            }

            if (nudStart.Value > frames)
            {
                nudStart.Value = 0;
            }

            tbCurrentFrame.Maximum = frames;
            nudEnd.Maximum = frames;
            nudStart.Maximum = nudEnd.Value;
        }

        public void UpdateFramesTimer(int timer)
        {
            lbCurrentFrame.Text = timer.ToString();
            if (timer <= tbCurrentFrame.Maximum)
            {
                tbCurrentFrame.Value = timer;
            }
            else
            {
                tbCurrentFrame.Value = 0;
            }
            
        }

        public void UpdateCoreAddressText(long address)
        {
            label1.Text = "Playback status: " + PlaybackStatus.ToString();
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
                PlaybackStatus = PlaybackState.PLAYING;
            }
        }

        private void cbCustomLoop_CheckedChanged(object sender, EventArgs e)
        {
            customLoop = ((CheckBox)sender).Checked;
            nudEnd.Enabled = ((CheckBox)sender).Checked;
            nudStart.Enabled = ((CheckBox)sender).Checked;
            SetLoops((ushort)nudStart.Value, (ushort)nudEnd.Value);
        }

        private void nudStart_ValueChanged(object sender, EventArgs e)
        {
            SetLoops((ushort)nudStart.Value, (ushort)nudEnd.Value);
        }

        private void nudEnd_ValueChanged(object sender, EventArgs e)
        {
            SetLoops((ushort)nudStart.Value, (ushort)nudEnd.Value);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm abt = new AboutForm();
            abt.ShowDialog(this);
        }
    }
}
