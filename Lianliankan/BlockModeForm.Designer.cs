namespace Lianliankan
{
    partial class BlockModeForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnProp = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnProp
            // 
            this.BtnProp.Location = new System.Drawing.Point(643, 285);
            this.BtnProp.Name = "BtnProp";
            this.BtnProp.Size = new System.Drawing.Size(90, 35);
            this.BtnProp.TabIndex = 6;
            this.BtnProp.Text = "道具";
            this.BtnProp.UseVisualStyleBackColor = true;
            // 
            // BtnPoint
            // 
            this.BtnPoint.Location = new System.Drawing.Point(643, 358);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(90, 35);
            this.BtnPoint.TabIndex = 7;
            this.BtnPoint.Text = "积分";
            this.BtnPoint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // BlockModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnProp);
            this.Name = "BlockModeForm";
            this.Text = "欢乐连连看---关卡模式（简单）";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BlockModeForm_FormClosed);
            this.Controls.SetChildIndex(this.BtnProp, 0);
            this.Controls.SetChildIndex(this.BtnPoint, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProp;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}