using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WmiFramework.Demo
{
    public partial class FormMain : Form
    {
        private WmiRepository wmiRepository;

        public FormMain()
        {
            InitializeComponent();
            wmiRepository = new WmiRepository();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count <= 0)
                return;
            if (MessageBox.Show("是否确认结束进程？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var entity = listView.SelectedItems[0].Tag as Entites.Win32_ProcessEntity;
                var res = wmiRepository.Win32_Process.Terminate(entity, 0);
                if (res == 0)
                    MessageBox.Show("操作成功");
                else
                    MessageBox.Show($"操作失败{res}");
                RefreshItems();
            }
        }

        private void RefreshItems()
        {
            listView.Columns.Clear();
            listView.Items.Clear();
            var dataSet = wmiRepository.Win32_Process.ToList();
            if (!dataSet.Any())
                return;
            var properties = dataSet.First().GetType().GetProperties();
            listView.Columns.AddRange(properties.Select(c => new ColumnHeader() { Text = c.Name }).ToArray());
            listView.Items.AddRange(dataSet.Select(c => new ListViewItem(properties.Select(p => p.GetValue(c, null)).Select(v => v == null ? string.Empty : v.ToString()).ToArray()) { Tag = c }).ToArray());
        }
    }
}
