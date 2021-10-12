using MetalComposer.Classes;
using MetalComposer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetalComposer.ComposerBase;

namespace MetalComposer
{
    public partial class ChainerForm : Form
    {
        ComposerForm composerForm;
        BindingSource bSource;
        BindingSource extAnimSource;
        public ChainerForm(ComposerForm parentForm)
        {
            InitializeComponent();
            if (parentForm == null)
            {
                Close();
            }
            else
            {
                composerForm = parentForm;
            }
            bSource = new BindingSource
            {
                DataSource = ExternalAnimationChain
            };
            extAnimSource = new BindingSource
            {
                DataSource = ExternalAnimations
            };
            lbLoadedAnimations.DisplayMember = "AnimName";
            lbLoadedAnimations.DataSource = extAnimSource;
            lbChainList.DisplayMember = "AnimName";
            lbChainList.DataSource = bSource;
            nudChainlink.Maximum = 0;
            OnAnimationChainIndexChange += () => UpdateChainlinkIndex();
            OnAnimationChainPlaybackChange += (p) => UpdatePlayChainButtonText(p);
            bSource.ResetBindings(true);
            extAnimSource.ResetBindings(true);
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            if (lbLoadedAnimations.SelectedItems.Count == 0) return;
            ExternalAnimationChain.AddRange(lbLoadedAnimations.SelectedItems.Cast<ExternalAnimation>());
            bSource.ResetBindings(true);
            nudChainlink.Maximum = Math.Max(0, ExternalAnimationChain.Count - 1);
            if (ExternalAnimationChain.Count > 0)
            {
                btnPlayChain.Enabled = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void cbLoopChain_CheckedChanged(object sender, EventArgs e)
        {
            AnimationChainLoop = ((CheckBox)sender).Checked;
        }

        private void UpdatePlayChainButtonText(bool playing)
        {
            if (playing)
            {
                btnPlayChain.Text = "Stop Chain";
            }
            else
            {
                btnPlayChain.Text = "Start Chain";
            }
        }

        private void btnPlayChain_Click(object sender, EventArgs e)
        {
            if (!AnimationChainPlaying)
            {
                // I don't think there's a better way of doing this since the order is
                // constant anyways
                composerForm.cbLoopMode.SelectedIndex = 3;
                if (PlaybackStatus != PlaybackState.PLAYING)
                {
                    PlaybackStatus = PlaybackState.PLAYING;
                }
                ExternalAnimationChain[ExternalAnimationChainIndex].WriteToMem();
                AnimationTimer = (short)LoopStart;
                AnimationChainPlaying = true;
                nudChainlink.Enabled = false;
                btnSetLink.Enabled = false;
            }
            else
            {
                if (PlaybackStatus != PlaybackState.PAUSED)
                {
                    PlaybackStatus = PlaybackState.PAUSED;
                }
                AnimationChainPlaying = false;
                nudChainlink.Enabled = true;
                btnSetLink.Enabled = true;
            }
            UpdatePlayChainButtonText(AnimationChainPlaying);
        }

        private void nudChainlink_Scroll(object sender, ScrollEventArgs e)
        {
            lbChainList.Refresh();
        }

        private void UpdateChainlinkIndex()
        {
            lbChainList.Refresh();
            nudChainlink.Value = ExternalAnimationChainIndex;
            nudChainlink.Maximum = Math.Max(0, ExternalAnimationChain.Count - 1);
        }

        private void lbChainList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;

            e.DrawBackground();
            SolidBrush textColor = new SolidBrush(((Control)sender).ForeColor);
            SolidBrush SelectedColor = new SolidBrush(Color.White);
            if (e.Index == ExternalAnimationChainIndex)
            {
                e.Graphics.DrawImageUnscaledAndClipped(Resources.currentIndex, new Rectangle(0, e.Index * 16, 16, 16));
            }
            e.Graphics.DrawString(((ExternalAnimation)((ListBox)sender).Items[e.Index]).AnimName, DefaultFont, ((ListBox)sender).SelectedIndex == e.Index ? SelectedColor : textColor, new Point(e.Bounds.X + 16, e.Bounds.Y));
        }

        private void lbChainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMvDown.Enabled = btnMvUp.Enabled = true;
            if (lbChainList.SelectedIndex == 0)
            {
                btnMvUp.Enabled = false;
            }
            if (lbChainList.SelectedIndex == ExternalAnimationChain.Count - 1)
            {
                btnMvDown.Enabled = false;
            }
            lbChainList.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbChainList.SelectedItem != null)
            {
                ExternalAnimationChain.RemoveAt(lbChainList.SelectedIndex);
            }
            if (ExternalAnimationChain.Count == 0)
            {
                btnPlayChain.Enabled = false;
            }
            lbChainList_SelectedIndexChanged(null, null);
            bSource.ResetBindings(true);
            lbChainList.Refresh();
        }

        private void btnMvUp_Click(object sender, EventArgs e)
        {
            ExternalAnimationChain.Reverse(lbChainList.SelectedIndex - 1, 2);
            lbChainList.SelectedIndex--;
            bSource.ResetBindings(true);

            lbChainList.Refresh();
        }

        private void btnMvDown_Click(object sender, EventArgs e)
        {
            ExternalAnimationChain.Reverse(lbChainList.SelectedIndex, 2);
            lbChainList.SelectedIndex++;
            bSource.ResetBindings(true);
            lbChainList.Refresh();
        }

        public void UpdateAllLists()
        {
            extAnimSource.ResetBindings(true);
            bSource.ResetBindings(true);
        }

        private void btnSetLink_Click(object sender, EventArgs e)
        {
            ExternalAnimationChainIndex = (int)nudChainlink.Value;
        }
    }
}
