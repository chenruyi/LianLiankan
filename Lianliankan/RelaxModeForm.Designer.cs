namespace Lianliankan
{
    partial class RelaxModeForm
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
            this.BtnProp = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProp
            // 
            this.BtnProp.Location = new System.Drawing.Point(646, 284);
            this.BtnProp.Name = "BtnProp";
            this.BtnProp.Size = new System.Drawing.Size(90, 35);
            this.BtnProp.TabIndex = 6;
            this.BtnProp.Text = "道具";
            this.BtnProp.UseVisualStyleBackColor = true;
            // 
            // BtnPoint
            // 
            this.BtnPoint.Location = new System.Drawing.Point(646, 353);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(90, 35);
            this.BtnPoint.TabIndex = 7;
            this.BtnPoint.Text = "积分";
            this.BtnPoint.UseVisualStyleBackColor = true;
            // 
            // RelaxModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnProp);
            this.Name = "RelaxModeForm";
            this.Text = "RelaxModeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RelaxModeForm_FormClosed);
            this.Controls.SetChildIndex(this.BtnProp, 0);
            this.Controls.SetChildIndex(this.BtnPoint, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProp;
        private System.Windows.Forms.Button BtnPoint;
    }
}