using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WmiFramework.Assistant.Components;
using WmiFramework.Assistant.Components.CodeGenerate;
using WmiFramework.Assistant.Models;

namespace WmiFramework.Assistant.UserInterface
{
    public partial class FormCodeBuilder : Form
    {
        private WmiHelper wmiHelper;
        private UIContext uiContext;

        public FormCodeBuilder(UIContext uiContext)
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            wmiHelper = new WmiHelper();

            this.uiContext = uiContext;

            Visible = true;
        }

        private void FormCodeBuilder_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(obj =>
            {
                foreach (var item in wmiHelper.GetNamespacesSet())
                    Invoke(new Action(() => comboBoxNamespaces.Items.Add(item)));
            });
            folderBrowserDialog.SelectedPath = textBoxSavePath.Text = Path.Combine(Directory.GetCurrentDirectory(), "output");
        }

        private void comboBoxNamespaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(obj =>
            {
                foreach (var item in wmiHelper.GetClassSet(Invoke(new Func<string>(() => comboBoxNamespaces.Text)) as string))
                    Invoke(new Action(() => comboBoxClasses.Items.Add(item)));
            });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxNamespaces.Text) || string.IsNullOrEmpty(comboBoxClasses.Text))
            {
                MessageBox.Show("命名空间与类不能为空", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var classes = wmiHelper.GetClass(comboBoxNamespaces.Text, comboBoxClasses.Text);

            if (classes == null)
            {
                MessageBox.Show("无法识别的命名空间与类", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.Rows.ToEnumerable<DataGridViewRow>().Any(c => c.Tag.Equals(classes)))
            {
                MessageBox.Show("已经存在", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = new DataGridViewRow() { Tag = classes };
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = classes.Namespace });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = classes.Name });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"{comboBoxClasses.Text}Entity" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = comboBoxClasses.Text });
            //row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"{comboBoxClasses.Text}Service" });
            dataGridView.Rows.Add(row);
            row.Cells[2].ReadOnly = row.Cells[3].ReadOnly = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && MessageBox.Show("是否确认删除选中项？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView.SelectedRows)
                    dataGridView.Rows.Remove(item);
            }
        }

        public void SwitchIn(string scope, string path)
        {
            comboBoxNamespaces.Text = scope;
            comboBoxClasses.Text = path;
            buttonAdd.PerformClick();
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("请先请添加要生成的类", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxMessage.Text = string.Empty;
            var fileSet = new List<string>();

            try
            {
                if (Directory.Exists(textBoxSavePath.Text))
                    Directory.Delete(textBoxSavePath.Text, true);
                var entitesPath = Path.Combine(textBoxSavePath.Text, "Entites");
                var servicesPath = Path.Combine(textBoxSavePath.Text, "Services");
                Directory.CreateDirectory(textBoxSavePath.Text);
                Directory.CreateDirectory(entitesPath);
                Directory.CreateDirectory(servicesPath);

                var entityBuilder = new EntityBuilder(entitesPath, textBoxCodeNamespaces.Text);
                var serviceBuilder = new ServiceBuilder(servicesPath, textBoxCodeNamespaces.Text, checkBoxBuildMethod.Checked);
                var wmiRepositoryBuilder = new WmiRepositoryBuilder(textBoxSavePath.Text, textBoxCodeNamespaces.Text);
                var codeCompiler = new CodeCompiler(textBoxSavePath.Text, textBoxCodeNamespaces.Text);

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    var entityName = (string)row.Cells[2].Value;
                    var serviceName = (string)row.Cells[3].Value;
                    var classes = (Classes)row.Tag;

                    textBoxMessage.Text += $"构建实体：{entityName}" + Environment.NewLine;
                    fileSet.Add(entityBuilder.Generate(classes, entityName));

                    if (checkBoxBuildService.Checked)
                    {
                        textBoxMessage.Text += $"构建服务：{serviceName}" + Environment.NewLine;
                        fileSet.Add(serviceBuilder.Generate(classes, entityName, serviceName));
                    }
                }

                if (checkBoxBuildService.Checked)
                {
                    textBoxMessage.Text += $"构建Wmi仓库：WmiRepository" + Environment.NewLine;
                    fileSet.Add(wmiRepositoryBuilder.Generate(dataGridView.Rows.Cast<DataGridViewRow>().Select(c => c.Cells[3].Value as string).ToArray()));
                }

                if (checkBoxBuildDll.Checked)
                {
                    textBoxMessage.Text += $"编译" + Environment.NewLine;
                    if (string.IsNullOrEmpty(textBoxProjectName.Text))
                        textBoxMessage.Text += codeCompiler.Build(fileSet.ToArray(), textBoxCodeNamespaces.Text) + Environment.NewLine;
                    else
                        textBoxMessage.Text += codeCompiler.Build(fileSet.ToArray(), textBoxProjectName.Text) + Environment.NewLine;
                }

                MessageBox.Show("构建成功", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("Explorer.exe", textBoxSavePath.Text);
            }
            catch (Exception ex)
            {
                textBoxMessage.Text += $"操作失败：{ex.Message}" + Environment.NewLine;
            }

            textBoxMessage.Focus();//获取焦点
            textBoxMessage.Select(textBoxMessage.TextLength, 0);//光标定位到文本最后
            textBoxMessage.ScrollToCaret();//滚动到光标处
        }

        private void checkBoxBuildService_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBuildMethod.Enabled = checkBoxBuildMethod.Checked = checkBoxBuildService.Checked;
        }

        private void buttonSavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
