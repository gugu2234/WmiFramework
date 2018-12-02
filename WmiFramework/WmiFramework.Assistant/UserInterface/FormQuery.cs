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

namespace WmiFramework.Assistant.UserInterface
{
    public partial class FormQuery : Form
    {
        private WmiHelper wmiHelper;
        private UIContext uiContext;

        public FormQuery(UIContext uiContext)
        {
            InitializeComponent();

            TopLevel = false;
            Dock = DockStyle.Fill;

            wmiHelper = new WmiHelper();

            this.uiContext = uiContext;

            Visible = true;
        }

        private void FormQuery_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(obj =>
            {
                foreach (var item in wmiHelper.GetNamespacesSet())
                    Invoke(new Action(() => comboBoxNamespaces.Items.Add(item)));
            });
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            listViewResult.Columns.Clear();
            listViewResult.Items.Clear();
            ThreadPool.QueueUserWorkItem(obj =>
            {
                try
                {
                    var dataSet = wmiHelper.Query(Invoke(new Func<string>(() => comboBoxNamespaces.Text)) as string, Invoke(new Func<string>(() => textBoxWQL.Text)) as string);
                    if (!dataSet.Any())
                        return;
                    Invoke(new Action(() => listViewResult.Columns.AddRange(dataSet.First().Select(c => new ColumnHeader() { Text = c.Key }).ToArray())));
                    foreach (var item in dataSet)
                        BeginInvoke(new Action(() => listViewResult.Items.Add(new ListViewItem(item.Select(c => c.Value).ToArray()))));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                }
            });
        }

        public void SwitchIn(string scope, string wql)
        {
            var action = new Action(() =>
            {
                comboBoxNamespaces.Text = scope;
                textBoxWQL.Text = wql;
                buttonQuery.PerformClick();
            });
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }
    }
}
