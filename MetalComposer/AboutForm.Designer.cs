namespace MetalComposer
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbThanks = new System.Windows.Forms.Label();
            this.llSM64Decomp = new System.Windows.Forms.LinkLabel();
            this.lbReckoning = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::MetalComposer.Properties.Resources.composer_512;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(64, 64);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(82, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(226, 37);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "METAL Composer";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(86, 63);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(45, 13);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "Version:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(12, 79);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(172, 13);
            this.lbAuthor.TabIndex = 3;
            this.lbAuthor.Text = "by GlitchyPSI, for M64MM3 Classic";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(86, 49);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(167, 13);
            this.lbDesc.TabIndex = 4;
            this.lbDesc.Text = "Advanced SM64 animation trainer";
            // 
            // lbThanks
            // 
            this.lbThanks.AutoSize = true;
            this.lbThanks.Location = new System.Drawing.Point(11, 121);
            this.lbThanks.Name = "lbThanks";
            this.lbThanks.Size = new System.Drawing.Size(296, 13);
            this.lbThanks.TabIndex = 5;
            this.lbThanks.Text = "Special thanks to James Pelster, AloXado320, SuperG64 and";
            // 
            // llSM64Decomp
            // 
            this.llSM64Decomp.AutoSize = true;
            this.llSM64Decomp.Location = new System.Drawing.Point(12, 134);
            this.llSM64Decomp.Name = "llSM64Decomp";
            this.llSM64Decomp.Size = new System.Drawing.Size(252, 13);
            this.llSM64Decomp.TabIndex = 6;
            this.llSM64Decomp.TabStop = true;
            this.llSM64Decomp.Text = "the bunch of clever folks behind the SM64 decomp.";
            this.llSM64Decomp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSM64Decomp_LinkClicked);
            // 
            // lbReckoning
            // 
            this.lbReckoning.AutoSize = true;
            this.lbReckoning.Location = new System.Drawing.Point(12, 195);
            this.lbReckoning.Name = "lbReckoning";
            this.lbReckoning.Size = new System.Drawing.Size(116, 13);
            this.lbReckoning.TabIndex = 7;
            this.lbReckoning.Text = "Zero Fungi, all Tanooki";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(319, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 225);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbReckoning);
            this.Controls.Add(this.llSM64Decomp);
            this.Controls.Add(this.lbThanks);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About METAL Composer...";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbThanks;
        private System.Windows.Forms.LinkLabel llSM64Decomp;
        private System.Windows.Forms.Label lbReckoning;
        private System.Windows.Forms.Button btnOK;
    }
}