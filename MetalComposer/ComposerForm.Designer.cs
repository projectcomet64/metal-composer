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
            this.lbStatus = new System.Windows.Forms.Label();
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
            this.btnLoadExternal = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPlusAnimations = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnims = new System.Windows.Forms.ComboBox();
            this.btnOpenAnimFolder = new System.Windows.Forms.Button();
            this.btnReloadFiles = new System.Windows.Forms.Button();
            this.btnLoadSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.cbLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            this.gbPlayback.SuspendLayout();
            this.msMain.SuspendLayout();
            this.gbPlusAnimations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(6, 16);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(168, 43);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Playback status:";
            // 
            // cbOverride
            // 
            this.cbOverride.Location = new System.Drawing.Point(6, 55);
            this.cbOverride.Name = "cbOverride";
            this.cbOverride.Size = new System.Drawing.Size(155, 32);
            this.cbOverride.TabIndex = 1;
            this.cbOverride.Text = "Override Game Animation";
            this.cbOverride.UseVisualStyleBackColor = true;
            this.cbOverride.CheckedChanged += new System.EventHandler(this.cbOverride_CheckedChanged);
            // 
            // tbCurrentFrame
            // 
            this.tbCurrentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentFrame.Location = new System.Drawing.Point(7, 45);
            this.tbCurrentFrame.Maximum = 32;
            this.tbCurrentFrame.Name = "tbCurrentFrame";
            this.tbCurrentFrame.Size = new System.Drawing.Size(447, 45);
            this.tbCurrentFrame.TabIndex = 2;
            this.tbCurrentFrame.Scroll += new System.EventHandler(this.tbCurrentFrame_Scroll);
            // 
            // lbCurrentFrame
            // 
            this.lbCurrentFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCurrentFrame.Location = new System.Drawing.Point(15, 29);
            this.lbCurrentFrame.Name = "lbCurrentFrame";
            this.lbCurrentFrame.Size = new System.Drawing.Size(428, 13);
            this.lbCurrentFrame.TabIndex = 3;
            this.lbCurrentFrame.Text = "0";
            this.lbCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFrameBack
            // 
            this.btnFrameBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrameBack.BackgroundImage")));
            this.btnFrameBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFrameBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameBack.Location = new System.Drawing.Point(149, 96);
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
            this.btnFrameStart.Location = new System.Drawing.Point(111, 96);
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
            this.btnFrameNext.Location = new System.Drawing.Point(263, 96);
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
            this.btnFrameLast.Location = new System.Drawing.Point(301, 96);
            this.btnFrameLast.Name = "btnFrameLast";
            this.btnFrameLast.Size = new System.Drawing.Size(32, 32);
            this.btnFrameLast.TabIndex = 7;
            this.btnFrameLast.UseVisualStyleBackColor = true;
            this.btnFrameLast.Click += new System.EventHandler(this.btnFrameLast_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::MetalComposer.Properties.Resources.PAUSE;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(187, 96);
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
            this.btnRwd.Location = new System.Drawing.Point(225, 96);
            this.btnRwd.Name = "btnRwd";
            this.btnRwd.Size = new System.Drawing.Size(32, 32);
            this.btnRwd.TabIndex = 6;
            this.btnRwd.UseVisualStyleBackColor = true;
            this.btnRwd.Click += new System.EventHandler(this.btnRwd_Click);
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(12, 154);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(41, 13);
            this.lbSpeed.TabIndex = 10;
            this.lbSpeed.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(91, 140);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(357, 45);
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // lbSpeedVal
            // 
            this.lbSpeedVal.AutoSize = true;
            this.lbSpeedVal.Location = new System.Drawing.Point(59, 154);
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
            this.cbLoopMode.Location = new System.Drawing.Point(90, 21);
            this.cbLoopMode.Name = "cbLoopMode";
            this.cbLoopMode.Size = new System.Drawing.Size(177, 21);
            this.cbLoopMode.TabIndex = 13;
            this.cbLoopMode.SelectedIndexChanged += new System.EventHandler(this.cbLoopMode_SelectedIndexChanged);
            // 
            // lbFStart
            // 
            this.lbFStart.AutoSize = true;
            this.lbFStart.Location = new System.Drawing.Point(133, 50);
            this.lbFStart.Name = "lbFStart";
            this.lbFStart.Size = new System.Drawing.Size(56, 13);
            this.lbFStart.TabIndex = 14;
            this.lbFStart.Text = "Loop Start";
            // 
            // lbFEnd
            // 
            this.lbFEnd.AutoSize = true;
            this.lbFEnd.Location = new System.Drawing.Point(133, 76);
            this.lbFEnd.Name = "lbFEnd";
            this.lbFEnd.Size = new System.Drawing.Size(53, 13);
            this.lbFEnd.TabIndex = 15;
            this.lbFEnd.Text = "Loop End";
            // 
            // nudStart
            // 
            this.nudStart.Enabled = false;
            this.nudStart.Location = new System.Drawing.Point(195, 48);
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(72, 20);
            this.nudStart.TabIndex = 16;
            this.nudStart.ValueChanged += new System.EventHandler(this.nudStart_ValueChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lbStatus);
            this.gbInfo.Controls.Add(this.cbOverride);
            this.gbInfo.Location = new System.Drawing.Point(12, 37);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(180, 100);
            this.gbInfo.TabIndex = 17;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // cbLoop
            // 
            this.cbLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoop.Controls.Add(this.cbCustomLoop);
            this.cbLoop.Controls.Add(this.lbLoopMode);
            this.cbLoop.Controls.Add(this.nudEnd);
            this.cbLoop.Controls.Add(this.lbFStart);
            this.cbLoop.Controls.Add(this.lbFEnd);
            this.cbLoop.Controls.Add(this.nudStart);
            this.cbLoop.Controls.Add(this.cbLoopMode);
            this.cbLoop.Location = new System.Drawing.Point(204, 37);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(273, 100);
            this.cbLoop.TabIndex = 18;
            this.cbLoop.TabStop = false;
            this.cbLoop.Text = "Loop Controls";
            // 
            // cbCustomLoop
            // 
            this.cbCustomLoop.Location = new System.Drawing.Point(26, 54);
            this.cbCustomLoop.Name = "cbCustomLoop";
            this.cbCustomLoop.Size = new System.Drawing.Size(97, 35);
            this.cbCustomLoop.TabIndex = 13;
            this.cbCustomLoop.Text = "Custom Loop";
            this.cbCustomLoop.UseVisualStyleBackColor = true;
            this.cbCustomLoop.CheckedChanged += new System.EventHandler(this.cbCustomLoop_CheckedChanged);
            // 
            // lbLoopMode
            // 
            this.lbLoopMode.AutoSize = true;
            this.lbLoopMode.Location = new System.Drawing.Point(23, 24);
            this.lbLoopMode.Name = "lbLoopMode";
            this.lbLoopMode.Size = new System.Drawing.Size(61, 13);
            this.lbLoopMode.TabIndex = 18;
            this.lbLoopMode.Text = "Loop Mode";
            // 
            // nudEnd
            // 
            this.nudEnd.Enabled = false;
            this.nudEnd.Location = new System.Drawing.Point(195, 74);
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(72, 20);
            this.nudEnd.TabIndex = 17;
            this.nudEnd.ValueChanged += new System.EventHandler(this.nudEnd_ValueChanged);
            // 
            // gbPlayback
            // 
            this.gbPlayback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbPlayback.Location = new System.Drawing.Point(12, 143);
            this.gbPlayback.Name = "gbPlayback";
            this.gbPlayback.Size = new System.Drawing.Size(460, 190);
            this.gbPlayback.TabIndex = 19;
            this.gbPlayback.TabStop = false;
            this.gbPlayback.Text = "Playback Controls";
            // 
            // cbSpasm
            // 
            this.cbSpasm.AutoSize = true;
            this.cbSpasm.Location = new System.Drawing.Point(354, 105);
            this.cbSpasm.Name = "cbSpasm";
            this.cbSpasm.Size = new System.Drawing.Size(63, 17);
            this.cbSpasm.TabIndex = 13;
            this.cbSpasm.Text = "SPASM";
            this.cbSpasm.UseVisualStyleBackColor = true;
            this.cbSpasm.CheckedChanged += new System.EventHandler(this.cbSpasm_CheckedChanged);
            // 
            // btnLoadExternal
            // 
            this.btnLoadExternal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadExternal.Location = new System.Drawing.Point(355, 146);
            this.btnLoadExternal.Name = "btnLoadExternal";
            this.btnLoadExternal.Size = new System.Drawing.Size(102, 24);
            this.btnLoadExternal.TabIndex = 14;
            this.btnLoadExternal.Text = "Load from JSON...";
            this.btnLoadExternal.UseVisualStyleBackColor = true;
            this.btnLoadExternal.Click += new System.EventHandler(this.button1_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(484, 24);
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
            // gbPlusAnimations
            // 
            this.gbPlusAnimations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlusAnimations.Controls.Add(this.button1);
            this.gbPlusAnimations.Controls.Add(this.lbAuthor);
            this.gbPlusAnimations.Controls.Add(this.label2);
            this.gbPlusAnimations.Controls.Add(this.cbAnims);
            this.gbPlusAnimations.Controls.Add(this.btnOpenAnimFolder);
            this.gbPlusAnimations.Controls.Add(this.btnReloadFiles);
            this.gbPlusAnimations.Controls.Add(this.btnLoadSelected);
            this.gbPlusAnimations.Controls.Add(this.btnLoadExternal);
            this.gbPlusAnimations.Location = new System.Drawing.Point(12, 339);
            this.gbPlusAnimations.Name = "gbPlusAnimations";
            this.gbPlusAnimations.Size = new System.Drawing.Size(466, 180);
            this.gbPlusAnimations.TabIndex = 21;
            this.gbPlusAnimations.TabStop = false;
            this.gbPlusAnimations.Text = "METAL Composer PLUS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(125, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Open Chainer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbAuthor
            // 
            this.lbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAuthor.AutoEllipsis = true;
            this.lbAuthor.Location = new System.Drawing.Point(9, 44);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(451, 46);
            this.lbAuthor.TabIndex = 17;
            this.lbAuthor.Text = "Select an animation to see animation credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Stored Animations";
            // 
            // cbAnims
            // 
            this.cbAnims.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAnims.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAnims.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnims.FormattingEnabled = true;
            this.cbAnims.Location = new System.Drawing.Point(7, 93);
            this.cbAnims.Name = "cbAnims";
            this.cbAnims.Size = new System.Drawing.Size(451, 21);
            this.cbAnims.Sorted = true;
            this.cbAnims.TabIndex = 15;
            this.cbAnims.SelectedIndexChanged += new System.EventHandler(this.cbAnims_SelectedIndexChanged);
            // 
            // btnOpenAnimFolder
            // 
            this.btnOpenAnimFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAnimFolder.Location = new System.Drawing.Point(234, 17);
            this.btnOpenAnimFolder.Name = "btnOpenAnimFolder";
            this.btnOpenAnimFolder.Size = new System.Drawing.Size(131, 24);
            this.btnOpenAnimFolder.TabIndex = 14;
            this.btnOpenAnimFolder.Text = "Open Animations Folder";
            this.btnOpenAnimFolder.UseVisualStyleBackColor = true;
            this.btnOpenAnimFolder.Click += new System.EventHandler(this.btnOpenAnimFolder_Click);
            // 
            // btnReloadFiles
            // 
            this.btnReloadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadFiles.Location = new System.Drawing.Point(371, 17);
            this.btnReloadFiles.Name = "btnReloadFiles";
            this.btnReloadFiles.Size = new System.Drawing.Size(89, 24);
            this.btnReloadFiles.TabIndex = 14;
            this.btnReloadFiles.Text = "Reload Files";
            this.btnReloadFiles.UseVisualStyleBackColor = true;
            this.btnReloadFiles.Click += new System.EventHandler(this.btnReloadFiles_Click);
            // 
            // btnLoadSelected
            // 
            this.btnLoadSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSelected.Location = new System.Drawing.Point(247, 146);
            this.btnLoadSelected.Name = "btnLoadSelected";
            this.btnLoadSelected.Size = new System.Drawing.Size(102, 24);
            this.btnLoadSelected.TabIndex = 14;
            this.btnLoadSelected.Text = "Load Selected";
            this.btnLoadSelected.UseVisualStyleBackColor = true;
            this.btnLoadSelected.Click += new System.EventHandler(this.btnLoadSelected_Click);
            // 
            // ComposerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 531);
            this.Controls.Add(this.gbPlusAnimations);
            this.Controls.Add(this.gbPlayback);
            this.Controls.Add(this.cbLoop);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 570);
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
            this.gbPlusAnimations.ResumeLayout(false);
            this.gbPlusAnimations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
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
        private System.Windows.Forms.Button btnLoadExternal;
        private System.Windows.Forms.GroupBox gbPlusAnimations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Button btnOpenAnimFolder;
        private System.Windows.Forms.Button btnReloadFiles;
        private System.Windows.Forms.Button btnLoadSelected;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ComboBox cbAnims;
        internal System.Windows.Forms.ComboBox cbLoopMode;
    }
}