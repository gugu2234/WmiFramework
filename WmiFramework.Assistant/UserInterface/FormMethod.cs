using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WmiFramework.Assistant.Models;

namespace WmiFramework.Assistant.UserInterface
{
    public partial class FormMethod : Form
    {
        private Method method;

        public FormMethod(Method method)
        {
            this.method = method;

            InitializeComponent();
        }

        private void FormMethod_Load(object sender, EventArgs e)
        {
            Text = $"方法：{method.Name}";
            textBoxName.Text = method.Name;
            textBoxDescription.Text = method.Description.Replace("\n", "\r\n");
            if (method.InParameters != null)
                listViewProperties.Items.AddRange(method.InParameters.Select(c => new ListViewItem(new string[] { "输入 In", c.Name, c.Description }) { Tag = c }).ToArray());
            if (method.OutParameters != null)
                listViewProperties.Items.AddRange(method.OutParameters.Select(c => new ListViewItem(new string[] { "输出 Out", c.Name, c.Description }) { Tag = c }).ToArray());
        }

        private void listViewProperties_DoubleClick(object sender, EventArgs e)
        {
            var item = listViewProperties.SelectedItems.Count > 0 ? listViewProperties.SelectedItems[0] : null;
            if (item.Tag is Property property)
            {
                using (var form = new FormProperty(property))
                    form.ShowDialog();
            }
        }
    }
}
