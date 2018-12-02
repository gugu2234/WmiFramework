using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using WmiFramework.Assistant.Models;

namespace WmiFramework.Assistant.Components
{
    public class WmiHelper
    {
        private ConnectionOptions options;
        private string address;

        public WmiHelper()
        {

        }

        public WmiHelper(ConnectionOptions options, string address)
        {
            this.options = options;
            this.address = address;
        }

        private ManagementScope GetScope(string path)
        {
            if (path[0] != '\\')
                path = "\\" + path;
            var socps = options == null ? new ManagementScope(path) : new ManagementScope(string.Format(@"\\{0}{1}", address, path), options);
            try { socps.Connect(); }
            catch { }
            //if (!socps.IsConnected)
            //    throw new ManagementException("连接失败");
            return socps;
        }

        /// <summary>
        /// 获取类集合
        /// </summary>
        /// <param name="scope"></param>
        /// <returns></returns>
        public IEnumerable<string> GetClassSet(string scope)
        {
            using (var managementObjectSearcher = new ManagementObjectSearcher(GetScope(scope), new WqlObjectQuery("select * from meta_class"), null))
            {
                ManagementObjectCollection objectCollection = null;
                try { objectCollection = managementObjectSearcher.Get(); }
                catch { yield break; }
                foreach (var item in objectCollection)
                {
                    yield return item["__CLASS"].ToString();
                }
            }
        }

        /// <summary>
        /// 获取类
        /// </summary>
        /// <param name="scope">命名空间</param>
        /// <param name="path">路径(类名)</param>
        /// <returns></returns>
        public Classes GetClass(string scope, string path)
        {
            var options = new ObjectGetOptions(null, TimeSpan.MaxValue, true);
            using (var managementClass = new ManagementClass(GetScope(scope), new ManagementPath(path), options))
            {
                managementClass.Options.UseAmendedQualifiers = true;
                return new Classes(managementClass);
            }
        }

        /// <summary>
        /// 获取命名空间集合
        /// </summary>
        /// <param name="scope">父命名空间</param>
        /// <returns></returns>
        public IEnumerable<string> GetNamespacesSet(string scope = "root")
        {
            using (var managementClass = new ManagementClass(GetScope(scope), new ManagementPath("__namespace"), null))
            {
                ManagementObjectCollection instanceSet;
                try
                {
                    instanceSet = managementClass.GetInstances();
                }
                catch
                {
                    yield break;
                }
                foreach (ManagementObject instance in managementClass.GetInstances())
                {
                    string text = scope + "\\" + instance["Name"].ToString();
                    yield return text;
                    foreach (var item in GetNamespacesSet(text))
                        yield return item;
                }
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="scope">命名空间</param>
        /// <param name="wql">语句</param>
        /// <returns></returns>
        public IEnumerable<Dictionary<string, string>> Query(string scope, string wql)
        {
            using (var searcher = new ManagementObjectSearcher(GetScope(scope), new ObjectQuery(wql)))
            {
                foreach (var item in searcher.Get())
                {
                    yield return item.Properties.ToEnumerable<PropertyData>().ToDictionary(c => c.Name, c => c.GetValueString());
                }
            }
        }
    }
}
