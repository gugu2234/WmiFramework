using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmiFramework.Assistant.UserInterface
{
    public class UIContext
    {
        private FormMain formMain;

        internal UIContext(FormMain formMain)
        {
            this.formMain = formMain;
        }

        /// <summary>
        /// 显示加载中
        /// </summary>
        public void ShowLoading()
        {

        }

        /// <summary>
        /// 隐藏加载中
        /// </summary>
        public void HideLoading()
        {

        }

        /// <summary>
        /// 切换主窗口
        /// </summary>
        /// <param name="name">窗口名</param>
        /// <param name="pars">参数</param>
        public void SwitchForm(string name, params object[] pars)
        {
            formMain.SwitchForm(name, pars);
        }
    }
}
