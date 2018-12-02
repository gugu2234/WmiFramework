using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WmiFramework.Assistant.UserInterface
{
    public partial class FormMain : Form
    {
        private UIContext uiContext;

        public FormMain()
        {
            uiContext = new UIContext(this);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tabControl_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls.Count == 0)
            {
                var type = Type.GetType($"WmiFramework.Assistant.UserInterface.{tabControl.SelectedTab.Name}");
                if (type == null)
                    return;
                var form = Activator.CreateInstance(type, uiContext) as Form;
                tabControl.SelectedTab.Controls.Add(form);
            }
        }

        public void SwitchForm(string name, object[] pars)
        {
            tabControl.SelectedTab = tabControl.TabPages[name];
            var form = tabControl.SelectedTab.Controls[0];
            form.GetType().GetMethod("SwitchIn", pars == null ? Type.EmptyTypes : pars.Select(c => c.GetType()).ToArray()).Invoke(form, pars);
        }
    }
}
