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
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.lbLoopMode = new System.Windows.Forms.Label();
            this.gbPlayback = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.cbLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            this.gbPlayback.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current animation:";
            // 
            // cbOverride
            // 
            this.cbOverride.AutoSize = true;
            this.cbOverride.Location = new System.Drawing.Point(6, 71);
            this.cbOverride.Name = "cbOverride";
            this.cbOverride.Size = new System.Drawing.Size(146, 17);
            this.cbOverride.TabIndex = 1;
            this.cbOverride.Text = "Override Game Animation";
            this.cbOverride.UseVisualStyleBackColor = true;
            this.cbOverride.CheckedChanged += new System.EventHandler(this.cbOverride_CheckedChanged);
            // 
            // tbCurrentFrame
            // 
            this.tbCurrentFrame.Location = new System.Drawing.Point(6, 19);
            this.tbCurrentFrame.Maximum = 32;
            this.tbCurrentFrame.Name = "tbCurrentFrame";
            this.tbCurrentFrame.Size = new System.Drawing.Size(339, 45);
            this.tbCurrentFrame.TabIndex = 2;
            this.tbCurrentFrame.Scroll += new System.EventHandler(this.tbCurrentFrame_Scroll);
            // 
            // lbCurrentFrame
            // 
            this.lbCurrentFrame.AutoSize = true;
            this.lbCurrentFrame.Location = new System.Drawing.Point(170, 75);
            this.lbCurrentFrame.Name = "lbCurrentFrame";
            this.lbCurrentFrame.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentFrame.TabIndex = 3;
            this.lbCurrentFrame.Text = "0";
            this.lbCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFrameBack
            // 
            this.btnFrameBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameBack.Location = new System.Drawing.Point(52, 70);
            this.btnFrameBack.Name = "btnFrameBack";
            this.btnFrameBack.Size = new System.Drawing.Size(39, 23);
            this.btnFrameBack.TabIndex = 4;
            this.btnFrameBack.Text = "◀ 1";
            this.btnFrameBack.UseVisualStyleBackColor = true;
            this.btnFrameBack.Click += new System.EventHandler(this.btnFrameBack_Click);
            // 
            // btnFrameStart
            // 
            this.btnFrameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameStart.Location = new System.Drawing.Point(6, 70);
            this.btnFrameStart.Name = "btnFrameStart";
            this.btnFrameStart.Size = new System.Drawing.Size(40, 23);
            this.btnFrameStart.TabIndex = 5;
            this.btnFrameStart.Text = "|◀";
            this.btnFrameStart.UseVisualStyleBackColor = true;
            this.btnFrameStart.Click += new System.EventHandler(this.btnFrameStart_Click);
            // 
            // btnFrameNext
            // 
            this.btnFrameNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameNext.Location = new System.Drawing.Point(261, 70);
            this.btnFrameNext.Name = "btnFrameNext";
            this.btnFrameNext.Size = new System.Drawing.Size(39, 23);
            this.btnFrameNext.TabIndex = 6;
            this.btnFrameNext.Text = "1 ▶";
            this.btnFrameNext.UseVisualStyleBackColor = true;
            this.btnFrameNext.Click += new System.EventHandler(this.btnFrameNext_Click);
            // 
            // btnFrameLast
            // 
            this.btnFrameLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameLast.Location = new System.Drawing.Point(306, 70);
            this.btnFrameLast.Name = "btnFrameLast";
            this.btnFrameLast.Size = new System.Drawing.Size(39, 23);
            this.btnFrameLast.TabIndex = 7;
            this.btnFrameLast.Text = "▶|";
            this.btnFrameLast.UseVisualStyleBackColor = true;
            this.btnFrameLast.Click += new System.EventHandler(this.btnFrameLast_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(216, 70);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(39, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "❚❚";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRwd
            // 
            this.btnRwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRwd.Location = new System.Drawing.Point(97, 70);
            this.btnRwd.Name = "btnRwd";
            this.btnRwd.Size = new System.Drawing.Size(39, 23);
            this.btnRwd.TabIndex = 6;
            this.btnRwd.Text = "◀◀";
            this.btnRwd.UseVisualStyleBackColor = true;
            this.btnRwd.Click += new System.EventHandler(this.btnRwd_Click);
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(5, 107);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(41, 13);
            this.lbSpeed.TabIndex = 10;
            this.lbSpeed.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(52, 103);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(248, 45);
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // lbSpeedVal
            // 
            this.lbSpeedVal.AutoSize = true;
            this.lbSpeedVal.Location = new System.Drawing.Point(306, 107);
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
            this.cbLoopMode.Location = new System.Drawing.Point(71, 20);
            this.cbLoopMode.Name = "cbLoopMode";
            this.cbLoopMode.Size = new System.Drawing.Size(72, 21);
            this.cbLoopMode.TabIndex = 13;
            this.cbLoopMode.SelectedIndexChanged += new System.EventHandler(this.cbLoopMode_SelectedIndexChanged);
            // 
            // lbFStart
            // 
            this.lbFStart.AutoSize = true;
            this.lbFStart.Location = new System.Drawing.Point(9, 49);
            this.lbFStart.Name = "lbFStart";
            this.lbFStart.Size = new System.Drawing.Size(56, 13);
            this.lbFStart.TabIndex = 14;
            this.lbFStart.Text = "Loop Start";
            // 
            // lbFEnd
            // 
            this.lbFEnd.AutoSize = true;
            this.lbFEnd.Location = new System.Drawing.Point(9, 75);
            this.lbFEnd.Name = "lbFEnd";
            this.lbFEnd.Size = new System.Drawing.Size(53, 13);
            this.lbFEnd.TabIndex = 15;
            this.lbFEnd.Text = "Loop End";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(71, 47);
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(72, 20);
            this.nudStart.TabIndex = 16;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.cbOverride);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(200, 100);
            this.gbInfo.TabIndex = 17;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // cbLoop
            // 
            this.cbLoop.Controls.Add(this.lbLoopMode);
            this.cbLoop.Controls.Add(this.nudEnd);
            this.cbLoop.Controls.Add(this.lbFStart);
            this.cbLoop.Controls.Add(this.lbFEnd);
            this.cbLoop.Controls.Add(this.nudStart);
            this.cbLoop.Controls.Add(this.cbLoopMode);
            this.cbLoop.Location = new System.Drawing.Point(218, 12);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(154, 100);
            this.cbLoop.TabIndex = 18;
            this.cbLoop.TabStop = false;
            this.cbLoop.Text = "Loop Controls";
            // 
            // nudEnd
            // 
            this.nudEnd.Location = new System.Drawing.Point(71, 73);
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(72, 20);
            this.nudEnd.TabIndex = 17;
            // 
            // lbLoopMode
            // 
            this.lbLoopMode.AutoSize = true;
            this.lbLoopMode.Location = new System.Drawing.Point(9, 23);
            this.lbLoopMode.Name = "lbLoopMode";
            this.lbLoopMode.Size = new System.Drawing.Size(61, 13);
            this.lbLoopMode.TabIndex = 18;
            this.lbLoopMode.Text = "Loop Mode";
            // 
            // gbPlayback
            // 
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
            this.gbPlayback.Location = new System.Drawing.Point(12, 118);
            this.gbPlayback.Name = "gbPlayback";
            this.gbPlayback.Size = new System.Drawing.Size(360, 146);
            this.gbPlayback.TabIndex = 19;
            this.gbPlayback.TabStop = false;
            this.gbPlayback.Text = "Playback Controls";
            // 
            // ComposerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 273);
            this.Controls.Add(this.gbPlayback);
            this.Controls.Add(this.cbLoop);
            this.Controls.Add(this.gbInfo);
            this.Name = "ComposerForm";
            this.Text = "METAL Composer";
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.cbLoop.ResumeLayout(false);
            this.cbLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            this.gbPlayback.ResumeLayout(false);
            this.gbPlayback.PerformLayout();
            this.ResumeLayout(false);

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
    }
}