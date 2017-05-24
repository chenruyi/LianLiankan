namespace Lianliankan
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnBasicMode = new System.Windows.Forms.Button();
            this.BtnRelaxMode = new System.Windows.Forms.Button();
            this.BtnBlockMode = new System.Windows.Forms.Button();
            this.BtnRanking = new System.Windows.Forms.Button();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBasicMode
            // 
            this.BtnBasicMode.Location = new System.Drawing.Point(28, 223);
            this.BtnBasicMode.Name = "BtnBasicMode";
            this.BtnBasicMode.Size = new System.Drawing.Size(98, 53);
            this.BtnBasicMode.TabIndex = 0;
            this.BtnBasicMode.Text = "基本模式";
            this.BtnBasicMode.UseVisualStyleBackColor = true;
            this.BtnBasicMode.Click += new System.EventHandler(this.BtnBasicMode_Click);
            // 
            // BtnRelaxMode
            // 
            this.BtnRelaxMode.Location = new System.Drawing.Point(28, 329);
            this.BtnRelaxMode.Name = "BtnRelaxMode";
            this.BtnRelaxMode.Size = new System.Drawing.Size(98, 53);
            this.BtnRelaxMode.TabIndex = 1;
            this.BtnRelaxMode.Text = "休闲模式";
            this.BtnRelaxMode.UseVisualStyleBackColor = true;
            this.BtnRelaxMode.Click += new System.EventHandler(this.BtnRelaxMode_Click);
            // 
            // BtnBlockMode
            // 
            this.BtnBlockMode.Location = new System.Drawing.Point(28, 441);
            this.BtnBlockMode.Name = "BtnBlockMode";
            this.BtnBlockMode.Size = new System.Drawing.Size(98, 53);
            this.BtnBlockMode.TabIndex = 2;
            this.BtnBlockMode.Text = "关卡模式";
            this.BtnBlockMode.UseVisualStyleBackColor = true;
            this.BtnBlockMode.Click += new System.EventHandler(this.BtnBlockMode_Click);
            // 
            // BtnRanking
            // 
            this.BtnRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRanking.Location = new System.Drawing.Point(583, 517);
            this.BtnRanking.Name = "BtnRanking";
            this.BtnRanking.Size = new System.Drawing.Size(60, 33);
            this.BtnRanking.TabIndex = 3;
            this.BtnRanking.Text = "排行榜";
            this.BtnRanking.UseVisualStyleBackColor = true;
            this.BtnRanking.Click += new System.EventHandler(this.BtnRanking_Click);
            // 
            // BtnSetting
            // 
            this.BtnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetting.Location = new System.Drawing.Point(649, 517);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(67, 33);
            this.BtnSetting.TabIndex = 4;
            this.BtnSetting.Text = "设置";
            this.BtnSetting.UseVisualStyleBackColor = true;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.Location = new System.Drawing.Point(722, 517);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(56, 33);
            this.BtnHelp.TabIndex = 5;
            this.BtnHelp.Text = "帮助";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::Lianliankan.Resource1.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BtnRelaxMode);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.BtnRanking);
            this.Controls.Add(this.BtnBlockMode);
            this.Controls.Add(this.BtnBasicMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Main";
            this.Text = "欢乐连连看";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBasicMode;
        private System.Windows.Forms.Button BtnRelaxMode;
        private System.Windows.Forms.Button BtnBlockMode;
        private System.Windows.Forms.Button BtnRanking;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnHelp;
    }
}