namespace MetalComposer
{
    partial class ChainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChainerForm));
            this.lbChainList = new System.Windows.Forms.ListBox();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.gbChain = new System.Windows.Forms.GroupBox();
            this.btnSetLink = new System.Windows.Forms.Button();
            this.cbLoopChain = new System.Windows.Forms.CheckBox();
            this.btnMvDown = new System.Windows.Forms.Button();
            this.btnMvUp = new System.Windows.Forms.Button();
            this.nudChainlink = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayChain = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbLoadedAnimations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbChain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChainlink)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChainList
            // 
            this.lbChainList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbChainList.FormattingEnabled = true;
            this.lbChainList.ItemHeight = 16;
            this.lbChainList.Location = new System.Drawing.Point(281, 38);
            this.lbChainList.Name = "lbChainList";
            this.lbChainList.Size = new System.Drawing.Size(255, 244);
            this.lbChainList.TabIndex = 0;
            this.lbChainList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbChainList_DrawItem);
            this.lbChainList.SelectedIndexChanged += new System.EventHandler(this.lbChainList_SelectedIndexChanged);
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.Location = new System.Drawing.Point(281, 295);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(181, 25);
            this.btnAddSelected.TabIndex = 1;
            this.btnAddSelected.Text = "Add Selected Animations to Chain";
            this.btnAddSelected.UseVisualStyleBackColor = true;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // gbChain
            // 
            this.gbChain.Controls.Add(this.btnSetLink);
            this.gbChain.Controls.Add(this.cbLoopChain);
            this.gbChain.Controls.Add(this.btnMvDown);
            this.gbChain.Controls.Add(this.btnMvUp);
            this.gbChain.Controls.Add(this.nudChainlink);
            this.gbChain.Controls.Add(this.label1);
            this.gbChain.Controls.Add(this.btnPlayChain);
            this.gbChain.Location = new System.Drawing.Point(281, 327);
            this.gbChain.Name = "gbChain";
            this.gbChain.Size = new System.Drawing.Size(255, 97);
            this.gbChain.TabIndex = 2;
            this.gbChain.TabStop = false;
            this.gbChain.Text = "Chain";
            // 
            // btnSetLink
            // 
            this.btnSetLink.Location = new System.Drawing.Point(58, 68);
            this.btnSetLink.Name = "btnSetLink";
            this.btnSetLink.Size = new System.Drawing.Size(37, 20);
            this.btnSetLink.TabIndex = 6;
            this.btnSetLink.Text = "Set";
            this.btnSetLink.UseVisualStyleBackColor = true;
            this.btnSetLink.Click += new System.EventHandler(this.btnSetLink_Click);
            // 
            // cbLoopChain
            // 
            this.cbLoopChain.AutoSize = true;
            this.cbLoopChain.Location = new System.Drawing.Point(101, 23);
            this.cbLoopChain.Name = "cbLoopChain";
            this.cbLoopChain.Size = new System.Drawing.Size(80, 17);
            this.cbLoopChain.TabIndex = 5;
            this.cbLoopChain.Text = "Loop Chain";
            this.cbLoopChain.UseVisualStyleBackColor = true;
            this.cbLoopChain.CheckedChanged += new System.EventHandler(this.cbLoopChain_CheckedChanged);
            // 
            // btnMvDown
            // 
            this.btnMvDown.Enabled = false;
            this.btnMvDown.Location = new System.Drawing.Point(101, 68);
            this.btnMvDown.Name = "btnMvDown";
            this.btnMvDown.Size = new System.Drawing.Size(148, 23);
            this.btnMvDown.TabIndex = 4;
            this.btnMvDown.Text = "Move Selected Down";
            this.btnMvDown.UseVisualStyleBackColor = true;
            this.btnMvDown.Click += new System.EventHandler(this.btnMvDown_Click);
            // 
            // btnMvUp
            // 
            this.btnMvUp.Enabled = false;
            this.btnMvUp.Location = new System.Drawing.Point(101, 42);
            this.btnMvUp.Name = "btnMvUp";
            this.btnMvUp.Size = new System.Drawing.Size(148, 23);
            this.btnMvUp.TabIndex = 3;
            this.btnMvUp.Text = "Move Selected Up";
            this.btnMvUp.UseVisualStyleBackColor = true;
            this.btnMvUp.Click += new System.EventHandler(this.btnMvUp_Click);
            // 
            // nudChainlink
            // 
            this.nudChainlink.Location = new System.Drawing.Point(9, 68);
            this.nudChainlink.Name = "nudChainlink";
            this.nudChainlink.Size = new System.Drawing.Size(43, 20);
            this.nudChainlink.TabIndex = 2;
            this.nudChainlink.Scroll += new System.Windows.Forms.ScrollEventHandler(this.nudChainlink_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current chainlink:";
            // 
            // btnPlayChain
            // 
            this.btnPlayChain.Enabled = false;
            this.btnPlayChain.Location = new System.Drawing.Point(6, 19);
            this.btnPlayChain.Name = "btnPlayChain";
            this.btnPlayChain.Size = new System.Drawing.Size(89, 23);
            this.btnPlayChain.TabIndex = 0;
            this.btnPlayChain.Text = "Start Chain";
            this.btnPlayChain.UseVisualStyleBackColor = true;
            this.btnPlayChain.Click += new System.EventHandler(this.btnPlayChain_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(468, 296);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 25);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbLoadedAnimations
            // 
            this.lbLoadedAnimations.FormattingEnabled = true;
            this.lbLoadedAnimations.Location = new System.Drawing.Point(12, 38);
            this.lbLoadedAnimations.Name = "lbLoadedAnimations";
            this.lbLoadedAnimations.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLoadedAnimations.Size = new System.Drawing.Size(255, 368);
            this.lbLoadedAnimations.Sorted = true;
            this.lbLoadedAnimations.TabIndex = 0;
            this.lbLoadedAnimations.DoubleClick += new System.EventHandler(this.lbLoadedAnimations_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Chain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Custom animations";
            // 
            // ChainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddSelected);
            this.Controls.Add(this.gbChain);
            this.Controls.Add(this.lbLoadedAnimations);
            this.Controls.Add(this.lbChainList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChainerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chainer";
            this.gbChain.ResumeLayout(false);
            this.gbChain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChainlink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChainList;
        private System.Windows.Forms.Button btnAddSelected;
        private System.Windows.Forms.GroupBox gbChain;
        private System.Windows.Forms.Button btnMvDown;
        private System.Windows.Forms.Button btnMvUp;
        private System.Windows.Forms.NumericUpDown nudChainlink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayChain;
        private System.Windows.Forms.CheckBox cbLoopChain;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSetLink;
        private System.Windows.Forms.ListBox lbLoadedAnimations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}