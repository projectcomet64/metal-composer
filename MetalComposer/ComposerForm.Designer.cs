namespace MetalComposer
{
    partial class ComposerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbOverride = new System.Windows.Forms.CheckBox();
            this.tbCurrentFrame = new System.Windows.Forms.TrackBar();
            this.lbCurrentFrame = new System.Windows.Forms.Label();
            this.btnFrameBack = new System.Windows.Forms.Button();
            this.btnFrameStart = new System.Windows.Forms.Button();
            this.btnFrameNext = new System.Windows.Forms.Button();
            this.btnFrameLast = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRwd = new System.Windows.Forms.Button();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lbSpeedVal = new System.Windows.Forms.Label();
            this.cbLoopMode = new System.Windows.Forms.ComboBox();
            this.lbFStart = new System.Windows.Forms.Label();
            this.lbFEnd = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbLoop = new System.Windows.Forms.GroupBox();
            this.cbCustomLoop = new System.Windows.Forms.CheckBox();
            this.lbLoopMode = new System.Windows.Forms.Label();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.gbPlayback = new System.Windows.Forms.GroupBox();
            this.cbSpasm = new System.Windows.Forms.CheckBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.cbLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            this.gbPlayback.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playback status:";
            // 
            // cbOverride
            // 
            this.cbOverride.Location = new System.Drawing.Point(6, 55);
            this.cbOverride.Name = "cbOverride";
            this.cbOverride.Size = new System.Drawing.Size(99, 32);
            this.cbOverride.TabIndex = 1;
            this.cbOverride.Text = "Override Game Animation";
            this.cbOverride.UseVisualStyleBackColor = true;
            this.cbOverride.CheckedChanged += new System.EventHandler(this.cbOverride_CheckedChanged);
            // 
            // tbCurrentFrame
            // 
            this.tbCurrentFrame.Location = new System.Drawing.Point(7, 45);
            this.tbCurrentFrame.Maximum = 32;
            this.tbCurrentFrame.Name = "tbCurrentFrame";
            this.tbCurrentFrame.Size = new System.Drawing.Size(339, 45);
            this.tbCurrentFrame.TabIndex = 2;
            this.tbCurrentFrame.Scroll += new System.EventHandler(this.tbCurrentFrame_Scroll);
            // 
            // lbCurrentFrame
            // 
            this.lbCurrentFrame.AutoSize = true;
            this.lbCurrentFrame.Location = new System.Drawing.Point(167, 29);
            this.lbCurrentFrame.Name = "lbCurrentFrame";
            this.lbCurrentFrame.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentFrame.TabIndex = 3;
            this.lbCurrentFrame.Text = "0";
            this.lbCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFrameBack
            // 
            this.btnFrameBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrameBack.BackgroundImage")));
            this.btnFrameBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFrameBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameBack.Location = new System.Drawing.Point(53, 96);
            this.btnFrameBack.Name = "btnFrameBack";
            this.btnFrameBack.Size = new System.Drawing.Size(32, 32);
            this.btnFrameBack.TabIndex = 4;
            this.btnFrameBack.UseVisualStyleBackColor = true;
            this.btnFrameBack.Click += new System.EventHandler(this.btnFrameBack_Click);
            // 
            // btnFrameStart
            // 
            this.btnFrameStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrameStart.BackgroundImage")));
            this.btnFrameStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFrameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameStart.Location = new System.Drawing.Point(15, 96);
            this.btnFrameStart.Name = "btnFrameStart";
            this.btnFrameStart.Size = new System.Drawing.Size(32, 32);
            this.btnFrameStart.TabIndex = 5;
            this.btnFrameStart.UseVisualStyleBackColor = true;
            this.btnFrameStart.Click += new System.EventHandler(this.btnFrameStart_Click);
            // 
            // btnFrameNext
            // 
            this.btnFrameNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrameNext.BackgroundImage")));
            this.btnFrameNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFrameNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameNext.Location = new System.Drawing.Point(167, 96);
            this.btnFrameNext.Name = "btnFrameNext";
            this.btnFrameNext.Size = new System.Drawing.Size(32, 32);
            this.btnFrameNext.TabIndex = 6;
            this.btnFrameNext.UseVisualStyleBackColor = true;
            this.btnFrameNext.Click += new System.EventHandler(this.btnFrameNext_Click);
            // 
            // btnFrameLast
            // 
            this.btnFrameLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrameLast.BackgroundImage")));
            this.btnFrameLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFrameLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameLast.Location = new System.Drawing.Point(205, 96);
            this.btnFrameLast.Name = "btnFrameLast";
            this.btnFrameLast.Size = new System.Drawing.Size(32, 32);
            this.btnFrameLast.TabIndex = 7;
            this.btnFrameLast.UseVisualStyleBackColor = true;
            this.btnFrameLast.Click += new System.EventHandler(this.btnFrameLast_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(91, 96);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRwd
            // 
            this.btnRwd.BackgroundImage = global::MetalComposer.Properties.Resources.SWAP;
            this.btnRwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRwd.Location = new System.Drawing.Point(129, 96);
            this.btnRwd.Name = "btnRwd";
            this.btnRwd.Size = new System.Drawing.Size(32, 32);
            this.btnRwd.TabIndex = 6;
            this.btnRwd.UseVisualStyleBackColor = true;
            this.btnRwd.Click += new System.EventHandler(this.btnRwd_Click);
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(6, 144);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(41, 13);
            this.lbSpeed.TabIndex = 10;
            this.lbSpeed.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(53, 140);
            this.tbSpeed.Minimum = -10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(268, 45);
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // lbSpeedVal
            // 
            this.lbSpeedVal.AutoSize = true;
            this.lbSpeedVal.Location = new System.Drawing.Point(327, 144);
            this.lbSpeedVal.Name = "lbSpeedVal";
            this.lbSpeedVal.Size = new System.Drawing.Size(18, 13);
            this.lbSpeedVal.TabIndex = 12;
            this.lbSpeedVal.Text = "1x";
            this.lbSpeedVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLoopMode
            // 
            this.cbLoopMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoopMode.FormattingEnabled = true;
            this.cbLoopMode.Location = new System.Drawing.Point(84, 19);
            this.cbLoopMode.Name = "cbLoopMode";
            this.cbLoopMode.Size = new System.Drawing.Size(146, 21);
            this.cbLoopMode.TabIndex = 13;
            this.cbLoopMode.SelectedIndexChanged += new System.EventHandler(this.cbLoopMode_SelectedIndexChanged);
            // 
            // lbFStart
            // 
            this.lbFStart.AutoSize = true;
            this.lbFStart.Location = new System.Drawing.Point(96, 48);
            this.lbFStart.Name = "lbFStart";
            this.lbFStart.Size = new System.Drawing.Size(56, 13);
            this.lbFStart.TabIndex = 14;
            this.lbFStart.Text = "Loop Start";
            // 
            // lbFEnd
            // 
            this.lbFEnd.AutoSize = true;
            this.lbFEnd.Location = new System.Drawing.Point(96, 74);
            this.lbFEnd.Name = "lbFEnd";
            this.lbFEnd.Size = new System.Drawing.Size(53, 13);
            this.lbFEnd.TabIndex = 15;
            this.lbFEnd.Text = "Loop End";
            // 
            // nudStart
            // 
            this.nudStart.Enabled = false;
            this.nudStart.Location = new System.Drawing.Point(158, 46);
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(72, 20);
            this.nudStart.TabIndex = 16;
            this.nudStart.ValueChanged += new System.EventHandler(this.nudStart_ValueChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.cbOverride);
            this.gbInfo.Location = new System.Drawing.Point(12, 27);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(109, 100);
            this.gbInfo.TabIndex = 17;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // cbLoop
            // 
            this.cbLoop.Controls.Add(this.cbCustomLoop);
            this.cbLoop.Controls.Add(this.lbLoopMode);
            this.cbLoop.Controls.Add(this.nudEnd);
            this.cbLoop.Controls.Add(this.lbFStart);
            this.cbLoop.Controls.Add(this.lbFEnd);
            this.cbLoop.Controls.Add(this.nudStart);
            this.cbLoop.Controls.Add(this.cbLoopMode);
            this.cbLoop.Location = new System.Drawing.Point(127, 27);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(239, 100);
            this.cbLoop.TabIndex = 18;
            this.cbLoop.TabStop = false;
            this.cbLoop.Text = "Loop Controls";
            // 
            // cbCustomLoop
            // 
            this.cbCustomLoop.Location = new System.Drawing.Point(22, 50);
            this.cbCustomLoop.Name = "cbCustomLoop";
            this.cbCustomLoop.Size = new System.Drawing.Size(68, 35);
            this.cbCustomLoop.TabIndex = 13;
            this.cbCustomLoop.Text = "Custom Loop";
            this.cbCustomLoop.UseVisualStyleBackColor = true;
            this.cbCustomLoop.CheckedChanged += new System.EventHandler(this.cbCustomLoop_CheckedChanged);
            // 
            // lbLoopMode
            // 
            this.lbLoopMode.AutoSize = true;
            this.lbLoopMode.Location = new System.Drawing.Point(17, 22);
            this.lbLoopMode.Name = "lbLoopMode";
            this.lbLoopMode.Size = new System.Drawing.Size(61, 13);
            this.lbLoopMode.TabIndex = 18;
            this.lbLoopMode.Text = "Loop Mode";
            // 
            // nudEnd
            // 
            this.nudEnd.Enabled = false;
            this.nudEnd.Location = new System.Drawing.Point(158, 72);
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(72, 20);
            this.nudEnd.TabIndex = 17;
            this.nudEnd.ValueChanged += new System.EventHandler(this.nudEnd_ValueChanged);
            // 
            // gbPlayback
            // 
            this.gbPlayback.Controls.Add(this.cbSpasm);
            this.gbPlayback.Controls.Add(this.tbCurrentFrame);
            this.gbPlayback.Controls.Add(this.lbCurrentFrame);
            this.gbPlayback.Controls.Add(this.btnFrameBack);
            this.gbPlayback.Controls.Add(this.lbSpeedVal);
            this.gbPlayback.Controls.Add(this.btnPlay);
            this.gbPlayback.Controls.Add(this.tbSpeed);
            this.gbPlayback.Controls.Add(this.btnFrameStart);
            this.gbPlayback.Controls.Add(this.lbSpeed);
            this.gbPlayback.Controls.Add(this.btnFrameNext);
            this.gbPlayback.Controls.Add(this.btnFrameLast);
            this.gbPlayback.Controls.Add(this.btnRwd);
            this.gbPlayback.Location = new System.Drawing.Point(12, 133);
            this.gbPlayback.Name = "gbPlayback";
            this.gbPlayback.Size = new System.Drawing.Size(354, 190);
            this.gbPlayback.TabIndex = 19;
            this.gbPlayback.TabStop = false;
            this.gbPlayback.Text = "Playback Controls";
            // 
            // cbSpasm
            // 
            this.cbSpasm.AutoSize = true;
            this.cbSpasm.Location = new System.Drawing.Point(258, 105);
            this.cbSpasm.Name = "cbSpasm";
            this.cbSpasm.Size = new System.Drawing.Size(63, 17);
            this.cbSpasm.TabIndex = 13;
            this.cbSpasm.Text = "SPASM";
            this.cbSpasm.UseVisualStyleBackColor = true;
            this.cbSpasm.CheckedChanged += new System.EventHandler(this.cbSpasm_CheckedChanged);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(378, 24);
            this.msMain.TabIndex = 20;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // ComposerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 335);
            this.Controls.Add(this.gbPlayback);
            this.Controls.Add(this.cbLoop);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "ComposerForm";
            this.Text = "METAL Composer";
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.cbLoop.ResumeLayout(false);
            this.cbLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            this.gbPlayback.ResumeLayout(false);
            this.gbPlayback.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox cbOverride;
        public System.Windows.Forms.TrackBar tbCurrentFrame;
        private System.Windows.Forms.Label lbCurrentFrame;
        private System.Windows.Forms.Button btnFrameBack;
        private System.Windows.Forms.Button btnFrameStart;
        private System.Windows.Forms.Button btnFrameNext;
        private System.Windows.Forms.Button btnFrameLast;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRwd;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lbSpeedVal;
        private System.Windows.Forms.ComboBox cbLoopMode;
        private System.Windows.Forms.Label lbFStart;
        private System.Windows.Forms.Label lbFEnd;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox cbLoop;
        private System.Windows.Forms.Label lbLoopMode;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.GroupBox gbPlayback;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.CheckBox cbCustomLoop;
        private System.Windows.Forms.CheckBox cbSpasm;
    }
}