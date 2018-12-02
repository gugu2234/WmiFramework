namespace WmiFramework.Assistant.UserInterface
{
    partial class FormMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.FormExplorer = new System.Windows.Forms.TabPage();
            this.FormQuery = new System.Windows.Forms.TabPage();
            this.FormCodeBuilder = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.FormExplorer);
            this.tabControl.Controls.Add(this.FormQuery);
            this.tabControl.Controls.Add(this.FormCodeBuilder);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // FormExplorer
            // 
            this.FormExplorer.Location = new System.Drawing.Point(4, 22);
            this.FormExplorer.Name = "FormExplorer";
            this.FormExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.FormExplorer.Size = new System.Drawing.Size(792, 424);
            this.FormExplorer.TabIndex = 0;
            this.FormExplorer.Text = "WMI浏览器";
            this.FormExplorer.UseVisualStyleBackColor = true;
            // 
            // FormQuery
            // 
            this.FormQuery.Location = new System.Drawing.Point(4, 22);
            this.FormQuery.Name = "FormQuery";
            this.FormQuery.Padding = new System.Windows.Forms.Padding(3);
            this.FormQuery.Size = new System.Drawing.Size(792, 424);
            this.FormQuery.TabIndex = 1;
            this.FormQuery.Text = "查询";
            this.FormQuery.UseVisualStyleBackColor = true;
            // 
            // FormCodeBuilder
            // 
            this.FormCodeBuilder.Location = new System.Drawing.Point(4, 22);
            this.FormCodeBuilder.Name = "FormCodeBuilder";
            this.FormCodeBuilder.Size = new System.Drawing.Size(792, 424);
            this.FormCodeBuilder.TabIndex = 2;
            this.FormCodeBuilder.Text = "代码生成器";
            this.FormCodeBuilder.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMI助手";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage FormExplorer;
        private System.Windows.Forms.TabPage FormQuery;
        private System.Windows.Forms.TabPage FormCodeBuilder;
    }
}

