namespace WmiFramework.Assistant.UserInterface
{
    partial class FormCodeBuilder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNamespaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.comboBoxNamespaces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.groupBoxProjectInfo = new System.Windows.Forms.GroupBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.textBoxSolutionName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxBuildProject = new System.Windows.Forms.CheckBox();
            this.checkBoxBuildDll = new System.Windows.Forms.CheckBox();
            this.buttonSavePath = new System.Windows.Forms.Button();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxBuildMethod = new System.Windows.Forms.CheckBox();
            this.checkBoxBuildService = new System.Windows.Forms.CheckBox();
            this.checkBoxBuildEntity = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCodeNamespaces = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxProjectInfo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMessage);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBuild);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxProjectInfo);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNamespaces,
            this.ColumnClasses,
            this.ColumnEntityName,
            this.ColumnServiceName});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(470, 368);
            this.dataGridView.TabIndex = 2;
            // 
            // ColumnNamespaces
            // 
            this.ColumnNamespaces.HeaderText = "命名空间";
            this.ColumnNamespaces.Name = "ColumnNamespaces";
            // 
            // ColumnClasses
            // 
            this.ColumnClasses.HeaderText = "类";
            this.ColumnClasses.Name = "ColumnClasses";
            // 
            // ColumnEntityName
            // 
            this.ColumnEntityName.HeaderText = "实体名";
            this.ColumnEntityName.Name = "ColumnEntityName";
            // 
            // ColumnServiceName
            // 
            this.ColumnServiceName.HeaderText = "服务名";
            this.ColumnServiceName.Name = "ColumnServiceName";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxClasses);
            this.groupBox1.Controls.Add(this.comboBoxNamespaces);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加/删除";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(389, 44);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "新增";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(389, 18);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "删除所选";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类名";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(71, 46);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(312, 20);
            this.comboBoxClasses.TabIndex = 3;
            // 
            // comboBoxNamespaces
            // 
            this.comboBoxNamespaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNamespaces.FormattingEnabled = true;
            this.comboBoxNamespaces.Location = new System.Drawing.Point(71, 20);
            this.comboBoxNamespaces.Name = "comboBoxNamespaces";
            this.comboBoxNamespaces.Size = new System.Drawing.Size(312, 20);
            this.comboBoxNamespaces.TabIndex = 2;
            this.comboBoxNamespaces.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamespaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "命名空间";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(0, 315);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(326, 135);
            this.textBoxMessage.TabIndex = 5;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuild.Location = new System.Drawing.Point(126, 286);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(75, 23);
            this.buttonBuild.TabIndex = 4;
            this.buttonBuild.Text = "立即构建";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // groupBoxProjectInfo
            // 
            this.groupBoxProjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProjectInfo.Controls.Add(this.textBoxProjectName);
            this.groupBoxProjectInfo.Controls.Add(this.textBoxSolutionName);
            this.groupBoxProjectInfo.Controls.Add(this.label6);
            this.groupBoxProjectInfo.Controls.Add(this.label5);
            this.groupBoxProjectInfo.Location = new System.Drawing.Point(0, 198);
            this.groupBoxProjectInfo.Name = "groupBoxProjectInfo";
            this.groupBoxProjectInfo.Size = new System.Drawing.Size(323, 82);
            this.groupBoxProjectInfo.TabIndex = 3;
            this.groupBoxProjectInfo.TabStop = false;
            this.groupBoxProjectInfo.Text = "项目信息";
            this.groupBoxProjectInfo.Visible = false;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectName.Location = new System.Drawing.Point(89, 47);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(228, 21);
            this.textBoxProjectName.TabIndex = 3;
            // 
            // textBoxSolutionName
            // 
            this.textBoxSolutionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSolutionName.Location = new System.Drawing.Point(89, 20);
            this.textBoxSolutionName.Name = "textBoxSolutionName";
            this.textBoxSolutionName.Size = new System.Drawing.Size(228, 21);
            this.textBoxSolutionName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "项目名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "解决方案名称";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkBoxBuildProject);
            this.groupBox4.Controls.Add(this.checkBoxBuildDll);
            this.groupBox4.Controls.Add(this.buttonSavePath);
            this.groupBox4.Controls.Add(this.textBoxSavePath);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(0, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输出参数";
            // 
            // checkBoxBuildProject
            // 
            this.checkBoxBuildProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBuildProject.AutoSize = true;
            this.checkBoxBuildProject.Location = new System.Drawing.Point(185, 47);
            this.checkBoxBuildProject.Name = "checkBoxBuildProject";
            this.checkBoxBuildProject.Size = new System.Drawing.Size(96, 16);
            this.checkBoxBuildProject.TabIndex = 4;
            this.checkBoxBuildProject.Text = "输出项目文件";
            this.checkBoxBuildProject.UseVisualStyleBackColor = true;
            this.checkBoxBuildProject.Visible = false;
            // 
            // checkBoxBuildDll
            // 
            this.checkBoxBuildDll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBuildDll.AutoSize = true;
            this.checkBoxBuildDll.Location = new System.Drawing.Point(42, 47);
            this.checkBoxBuildDll.Name = "checkBoxBuildDll";
            this.checkBoxBuildDll.Size = new System.Drawing.Size(102, 16);
            this.checkBoxBuildDll.TabIndex = 3;
            this.checkBoxBuildDll.Text = "编译输出(DLL)";
            this.checkBoxBuildDll.UseVisualStyleBackColor = true;
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePath.Location = new System.Drawing.Point(295, 18);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(19, 23);
            this.buttonSavePath.TabIndex = 2;
            this.buttonSavePath.UseVisualStyleBackColor = true;
            this.buttonSavePath.Click += new System.EventHandler(this.buttonSavePath_Click);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSavePath.Location = new System.Drawing.Point(65, 20);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(224, 21);
            this.textBoxSavePath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "输出路径";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBoxBuildMethod);
            this.groupBox3.Controls.Add(this.checkBoxBuildService);
            this.groupBox3.Controls.Add(this.checkBoxBuildEntity);
            this.groupBox3.Location = new System.Drawing.Point(0, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "构建参数";
            // 
            // checkBoxBuildMethod
            // 
            this.checkBoxBuildMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBuildMethod.AutoSize = true;
            this.checkBoxBuildMethod.Checked = true;
            this.checkBoxBuildMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBuildMethod.Location = new System.Drawing.Point(224, 22);
            this.checkBoxBuildMethod.Name = "checkBoxBuildMethod";
            this.checkBoxBuildMethod.Size = new System.Drawing.Size(72, 16);
            this.checkBoxBuildMethod.TabIndex = 2;
            this.checkBoxBuildMethod.Text = "构建方法";
            this.checkBoxBuildMethod.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuildService
            // 
            this.checkBoxBuildService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBuildService.AutoSize = true;
            this.checkBoxBuildService.Checked = true;
            this.checkBoxBuildService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBuildService.Location = new System.Drawing.Point(125, 22);
            this.checkBoxBuildService.Name = "checkBoxBuildService";
            this.checkBoxBuildService.Size = new System.Drawing.Size(72, 16);
            this.checkBoxBuildService.TabIndex = 1;
            this.checkBoxBuildService.Text = "构建服务";
            this.checkBoxBuildService.UseVisualStyleBackColor = true;
            this.checkBoxBuildService.CheckedChanged += new System.EventHandler(this.checkBoxBuildService_CheckedChanged);
            // 
            // checkBoxBuildEntity
            // 
            this.checkBoxBuildEntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBuildEntity.AutoSize = true;
            this.checkBoxBuildEntity.Checked = true;
            this.checkBoxBuildEntity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBuildEntity.Enabled = false;
            this.checkBoxBuildEntity.Location = new System.Drawing.Point(26, 22);
            this.checkBoxBuildEntity.Name = "checkBoxBuildEntity";
            this.checkBoxBuildEntity.Size = new System.Drawing.Size(72, 16);
            this.checkBoxBuildEntity.TabIndex = 0;
            this.checkBoxBuildEntity.Text = "构建实体";
            this.checkBoxBuildEntity.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxCodeNamespaces);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "C#参数";
            // 
            // textBoxCodeNamespaces
            // 
            this.textBoxCodeNamespaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCodeNamespaces.Location = new System.Drawing.Point(65, 20);
            this.textBoxCodeNamespaces.Name = "textBoxCodeNamespaces";
            this.textBoxCodeNamespaces.Size = new System.Drawing.Size(252, 21);
            this.textBoxCodeNamespaces.TabIndex = 1;
            this.textBoxCodeNamespaces.Text = "WmiAccess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "命名空间";
            // 
            // FormCodeBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCodeBuilder";
            this.Text = "FormCodeBuilder";
            this.Load += new System.EventHandler(this.FormCodeBuilder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProjectInfo.ResumeLayout(false);
            this.groupBoxProjectInfo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamespaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServiceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.ComboBox comboBoxNamespaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCodeNamespaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxBuildMethod;
        private System.Windows.Forms.CheckBox checkBoxBuildService;
        private System.Windows.Forms.CheckBox checkBoxBuildEntity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSavePath;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxBuildDll;
        private System.Windows.Forms.GroupBox groupBoxProjectInfo;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxSolutionName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxBuildProject;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}