using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WmiFramework.Assistant.Components;
using WmiFramework.Assistant.Models;

namespace WmiFramework.Assistant.UserInterface
{
    public partial class FormExplorer : Form
    {
        private WmiHelper wmiHelper;
        private UIContext uiContext;

        public FormExplorer(UIContext uiContext)
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            wmiHelper = new WmiHelper();

            this.uiContext = uiContext;

            Visible = true;
        }

        private void FormExplorer_Load(object sender, EventArgs e)
        {
            uiContext.ShowLoading();
            ThreadPool.QueueUserWorkItem(obj =>
            {
                foreach (var item in wmiHelper.GetNamespacesSet())
                {
                    Invoke(new Action(() => { listBoxNamespaces.Items.Add(item); }));
                }
                uiContext.HideLoading();
            });
        }

        private void listBoxNamespaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiContext.ShowLoading();
            listBoxClasses.Items.Clear();
            ThreadPool.QueueUserWorkItem(obj =>
            {
                string scope = Invoke(new Func<object>(() => listBoxNamespaces.SelectedItem)) as string;
                foreach (var item in wmiHelper.GetClassSet(scope))
                {
                    Invoke(new Action(() => { listBoxClasses.Items.Add(item); }));
                }
                uiContext.HideLoading();
            });
        }

        private void listBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewProperties.Items.Clear();

            //textBoxNamespaces.Text = listBoxNamespaces.SelectedItem as string;
            //textBoxClasses.Text = listBoxClasses.SelectedItem as string;
            var wmiClasses = wmiHelper.GetClass(listBoxNamespaces.SelectedItem as string, listBoxClasses.SelectedItem as string);
            textBoxNamespaces.Text = wmiClasses.Namespace;
            textBoxClasses.Text = wmiClasses.Name;
            textBoxDescription.Text = wmiClasses.Description.Replace("\n", "\r\n");

            listViewProperties.Items.AddRange(wmiClasses.Properties.Select(c => new ListViewItem(new string[] { "属性", c.Name, c.Description }) { Tag = c }).ToArray());
            listViewProperties.Items.AddRange(wmiClasses.Methods.Select(c => new ListViewItem(new string[] { "方法", c.Name, c.Description }) { Tag = c }).ToArray());
        }

        private void listViewProperties_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(listViewProperties);
        }

        private void listViewProperties_MouseMove(object sender, MouseEventArgs e)
        {
            var item = listViewProperties.GetItemAt(e.X, e.Y);
            if (item == null)
                return;
            var sb = new StringBuilder();
            if (item.Tag is Property property)
            {
                sb.AppendFormat("属性名：{0}\r\n", property.Name);
                sb.AppendFormat("描述：{0}", property.Description);
            }
            else if (item.Tag is Method method)
            {
                sb.AppendFormat("方法名：{0}\r\n", method.Name);
                sb.AppendFormat("描述：{0}", method.Description);
            }
            else
                return;
            toolTip.Show(sb.ToString(), listViewProperties, e.X, e.Y + 20);
        }

        private void listViewProperties_DoubleClick(object sender, EventArgs e)
        {
            var item = listViewProperties.SelectedItems.Count > 0 ? listViewProperties.SelectedItems[0] : null;
            if (item.Tag is Property property)
            {
                using (var form = new FormProperty(property))
                    form.ShowDialog();
            }
            else if (item.Tag is Method method)
            {
                using (var form = new FormMethod(method))
                    form.ShowDialog();
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listBoxNamespaces.Text) || string.IsNullOrEmpty(listBoxClasses.Text))
            {
                MessageBox.Show("请先选择类", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            uiContext.SwitchForm(typeof(FormQuery).Name, listBoxNamespaces.Text, $"select * from {listBoxClasses.Text}");
        }

        private void buttonCodeBuilder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listBoxNamespaces.Text) || string.IsNullOrEmpty(listBoxClasses.Text))
            {
                MessageBox.Show("请先选择类", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            uiContext.SwitchForm(typeof(FormCodeBuilder).Name, listBoxNamespaces.Text, listBoxClasses.Text);
        }
    }
}
