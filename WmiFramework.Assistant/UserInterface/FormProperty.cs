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
    public partial class FormProperty : Form
    {
        private Property property;

        public FormProperty(Property property)
        {
            this.property = property;

            InitializeComponent();
        }

        private void FormProperty_Load(object sender, EventArgs e)
        {
            Text = $"属性：{property.Name}";
            textBoxName.Text = property.Name;
            textBoxDescription.Text = property.Description.Replace("\n", "\r\n");
            textBoxType.Text = property.Type.ToString();
            checkBoxIsArray.Checked = property.IsArray;
            checkBoxIsArray.Text = property.IsArray ? "是" : "否";
        }
    }
}
