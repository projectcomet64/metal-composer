using MetalComposer.Classes;
using MetalComposer.Properties;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static MetalComposer.ComposerBase;

namespace MetalComposer
{
    public partial class ComposerForm : Form
    {
        BindingSource bSource;
        ChainerForm chainerForm;
        public ComposerForm()
        {
            InitializeComponent();
            PlaybackChanged += (o, n) => { HandlePlaybackChange(o, n); };
            for (int i = 0; i < Enum.GetNames(typeof(LoopState)).Length; i++)
            {
                cbLoopMode.Items.Add(LoopStateNames[i]);
            }
            bSource = new BindingSource
            {
                DataSource = ExternalAnimations
            };
            cbAnims.DisplayMember = "AnimName";
            cbAnims.DataSource = bSource;
            cbLoopMode.SelectedIndex = 1;
            bSource.Sort = "AnimName";
            UpdateEnabledStatus();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void UpdateMaxFrames(ushort frames)
        {
            if (tbCurrentFrame.Value > frames)
            {
                tbCurrentFrame.Value = frames;
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

        public void UpdateFramesTimer(int timer, bool wait = false)
        {
            if (wait)
            {
                lbCurrentFrame.Text = "Wait...";
                return;
            }
            lbCurrentFrame.Text = timer.ToString();
            if (timer < 0)
            {
                tbCurrentFrame.Value = 0;
            }
            else if (timer <= tbCurrentFrame.Maximum)
            {
                tbCurrentFrame.Value = timer;
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
                            btnPlay.BackgroundImage = Resources.PLAY;
                            btnRwd.BackgroundImage = Resources.RWD;
                            break;
                        case PlaybackState.PLAYING:
                            btnPlay.BackgroundImage = Resources.PAUSE;
                            btnRwd.BackgroundImage = Resources.SWAP;
                            break;
                        case PlaybackState.REWIND:
                            btnRwd.BackgroundImage = Resources.SWAP;
                            btnPlay.BackgroundImage = Resources.PAUSE;
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
                            btnPlay.BackgroundImage = Resources.PLAY;
                            btnRwd.BackgroundImage = Resources.RWD;
                            break;
                        case PlaybackState.REWIND:
                            btnRwd.BackgroundImage = Resources.SWAP;
                            btnPlay.BackgroundImage = Resources.PLAY;
                            break;
                    }
                    break;
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (tbSpeed.Value == 0)
            {
                tbSpeed.Value = 1;
            }
            if (tbSpeed.Value < 0)
            {
                tbSpeed.Value *= -1;
            }
            PlaybackStatus = PlaybackState.PLAYING;

        }

        private void btnRwd_Click(object sender, EventArgs e)
        {
            if (PlaybackStatus == PlaybackState.PAUSED)
            {
                PlaybackStatus = PlaybackState.PLAYING;
                tbSpeed.Value = -1;
            }
            else
            {
                tbSpeed.Value *= -1;
            }
        }

        private void cbLoopMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoopStatus = (LoopState)((ComboBox)sender).SelectedIndex;
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
            UpdateEnabledStatus();
        }

        void UpdateEnabledStatus()
        {
            gbPlayback.Enabled = gbPlusAnimations.Enabled = cbOverride.Checked;
            if (!cbOverride.Checked && PlaybackStatus == PlaybackState.PAUSED)
            {
                SetAnimOverride(true);
                PlaybackStatus = PlaybackState.PLAYING;
            }
        }

        private void cbCustomLoop_CheckedChanged(object sender, EventArgs e)
        {
            CustomLoop = ((CheckBox)sender).Checked;
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

        private void cbSpasm_CheckedChanged(object sender, EventArgs e)
        {
            SpasmAnimation = ((CheckBox)sender).Checked;
            tbCurrentFrame.Enabled = !((CheckBox)sender).Checked;
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            //FIXME: Find a way to make this cleaner...

            if (PlaybackStatus == PlaybackState.PAUSED)
            {
                if (((TrackBar)sender).Value != 0)
                {
                    PlaybackStatus = PlaybackState.PLAYING;
                }
            }
            else
            {
                if (((TrackBar)sender).Value == 0)
                {
                    PlaybackStatus = PlaybackState.PAUSED;
                }
                else if (((TrackBar)sender).Value != 0 && PlaybackStatus != PlaybackState.PLAYING)
                {
                    PlaybackStatus = PlaybackState.PLAYING;
                }
            }

            Speed = tbSpeed.Value;
            lbSpeedVal.Text = Speed + "x";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "METAL Composer JSON file (*.json)|*.json";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string jsoncontents = File.ReadAllText(ofd.FileName);
                ExternalAnimation ea = JsonConvert.DeserializeObject<ExternalAnimation>(jsoncontents, new JsonSerializerSettings
                {
                    Converters = { new ExternalAnimationConverter() },
                    MissingMemberHandling = MissingMemberHandling.Ignore
                });
                if (!ea.Looping)
                {
                    // Hardcoded. Right now I don't mind
                    cbLoopMode.SelectedIndex = 0;
                }

                ea.WriteToMem();
            }
        }

        private void btnReloadFiles_Click(object sender, EventArgs e)
        {
            RepopulateAnimationList();
            bSource.ResetBindings(true);
            UpdateCombobox();
        }

        private void UpdateCombobox()
        {
            if (cbAnims.Items.Count > 0)
            {
                cbAnims.Enabled = btnLoadSelected.Enabled = true;
            }
            else
            {
                cbAnims.Enabled = btnLoadSelected.Enabled = false;
            }
            cbAnims.Refresh();
        }

        private void cbAnims_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAuthor.Text = ((ExternalAnimation)cbAnims.SelectedItem).Author;
        }

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {
            if (cbAnims.SelectedItem == null)
                return;

            if (!((ExternalAnimation)cbAnims.SelectedItem).Looping)
            {
                // Hardcoded. Right now I don't mind
                cbLoopMode.SelectedIndex = 0;
            }
            ((ExternalAnimation)cbAnims.SelectedItem).WriteToMem();
        }

        private void btnOpenAnimFolder_Click(object sender, EventArgs e)
        {
            Process.Start(AnimationsPath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chainerForm == null)
            {
                chainerForm = new ChainerForm(this);
            }
            chainerForm.UpdateAllLists();
            chainerForm.Show();
        }
    }
}
