namespace Lianliankan
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnReboot = new System.Windows.Forms.Button();
            this.BtnTip = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnBegin = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(45, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 429);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BtnReboot
            // 
            this.BtnReboot.Location = new System.Drawing.Point(646, 226);
            this.BtnReboot.Name = "BtnReboot";
            this.BtnReboot.Size = new System.Drawing.Size(90, 35);
            this.BtnReboot.TabIndex = 3;
            this.BtnReboot.Text = "重排";
            this.BtnReboot.UseVisualStyleBackColor = true;
            this.BtnReboot.Click += new System.EventHandler(this.BtnReboot_Click);
            // 
            // BtnTip
            // 
            this.BtnTip.Location = new System.Drawing.Point(646, 157);
            this.BtnTip.Name = "BtnTip";
            this.BtnTip.Size = new System.Drawing.Size(90, 35);
            this.BtnTip.TabIndex = 2;
            this.BtnTip.Text = "提示";
            this.BtnTip.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(646, 94);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(90, 35);
            this.BtnPause.TabIndex = 1;
            this.BtnPause.Text = "暂停";
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // BtnBegin
            // 
            this.BtnBegin.Location = new System.Drawing.Point(646, 39);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(90, 35);
            this.BtnBegin.TabIndex = 0;
            this.BtnBegin.Text = "开始游戏";
            this.BtnBegin.UseVisualStyleBackColor = true;
            this.BtnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(646, 481);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(90, 35);
            this.BtnHelp.TabIndex = 4;
            this.BtnHelp.Text = "帮助";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnSetting
            // 
            this.BtnSetting.Location = new System.Drawing.Point(646, 431);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(90, 35);
            this.BtnSetting.TabIndex = 5;
            this.BtnSetting.Text = "设置";
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lianliankan.Resource1.gamebackimage;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BtnBegin);
            this.Controls.Add(this.BtnReboot);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.BtnTip);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "欢乐连连看---xx模式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnReboot;
        private System.Windows.Forms.Button BtnTip;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnBegin;
    }
}