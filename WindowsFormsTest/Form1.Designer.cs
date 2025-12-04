namespace WindowsFormsTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBox1 = new Cyotek.Windows.Forms.ImageBox();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(148, 94);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(436, 334);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.Text = "imageBox1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

    #endregion

    private Cyotek.Windows.Forms.ImageBox imageBox;
    private Cyotek.Windows.Forms.ImageBox imageBox1;
  }
}

