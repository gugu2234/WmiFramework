using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// StdRegProv 类包含用于与系统注册表交互的方法。可以将这些方法用于: 
    /// 验证用户的访问权限 
    /// 创建、枚举和删除注册表项 
    /// 创建、枚举和删除命名值 
    /// 读取、写入和删除数据值 
    /// </summary>
    public class StdRegProv : WMIService<Entites.StdRegProvEntity>
    {
        public StdRegProv(ConnectionOptions options, string address) : base(options, address) { }
        /// <summary>
        /// CreateKey 方法在指定的树中创建一个子项。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">包含要创建的项。CreateKey 方法创建路径中已指定但不存在的所有子项。例如，如果 MyKey 和 MySubKey 未存在于以下路径中，则 CreateKey 将创建这两项: 
        /// HKEY_LOCAL_MACHINE\SOFTWARE\MyKey\MySubKey </param>
        /// <returns></returns>
        public uint CreateKey(uint hDefKey, string sSubKeyName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("CreateKey");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                var output = classObj.InvokeMethod("CreateKey", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// CreateKey 方法在指定的树中创建一个子项。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">包含要创建的项。CreateKey 方法创建路径中已指定但不存在的所有子项。例如，如果 MyKey 和 MySubKey 未存在于以下路径中，则 CreateKey 将创建这两项: 
        /// HKEY_LOCAL_MACHINE\SOFTWARE\MyKey\MySubKey </param>
        /// <returns></returns>
        public uint CreateKey(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("CreateKey");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            var output = classObj.InvokeMethod("CreateKey", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// DeleteKey 方法删除指定树中的一个子项。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">包含要删除的项。</param>
        /// <returns></returns>
        public uint DeleteKey(uint hDefKey, string sSubKeyName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("DeleteKey");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                var output = classObj.InvokeMethod("DeleteKey", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// DeleteKey 方法删除指定树中的一个子项。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">包含要删除的项。</param>
        /// <returns></returns>
        public uint DeleteKey(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("DeleteKey");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            var output = classObj.InvokeMethod("DeleteKey", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// EnumKey 方法枚举给定路径的子项。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要枚举的子项的路径。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sNames">包含子项字符串数组。</param>
        public void EnumKey(uint hDefKey, string sSubKeyName, out uint ReturnValue, out string[] sNames)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("EnumKey");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                var output = classObj.InvokeMethod("EnumKey", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                sNames = (string[])output["sNames"];
            }
        }
        /// <summary>
        /// EnumKey 方法枚举给定路径的子项。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要枚举的子项的路径。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sNames">包含子项字符串数组。</param>
        public void EnumKey(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, out uint ReturnValue, out string[] sNames)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("EnumKey");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            var output = classObj.InvokeMethod("EnumKey", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            sNames = (string[])output["sNames"];
        }
        /// <summary>
        /// EnumValues 方法枚举给定子项的命名值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要枚举的命名值的路径。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sNames">包含命名值字符串数组。该数组的元素直接对应于 iTypes 的元素。</param>
        /// <param name="Types">包含数据值类型(整数)的数组。可使用这些类型来确定调用哪个 Get 方法。例如，如果数据值类型是 REG_SZ，则调用 GetStringValue 来检索命名值的数据值。此数组中的元素直接对应于 sNames 的元素。Winnt.h 中定义了以下数据值类型: 
        /// REG_SZ (1) 
        /// REG_EXPAND_SZ (2) 
        /// REG_BINARY (3) 
        /// REG_DWORD (4) 
        /// REG_MULTI_SZ (7) 
        /// </param>
        public void EnumValues(uint hDefKey, string sSubKeyName, out uint ReturnValue, out string[] sNames, out int[] Types)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("EnumValues");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                var output = classObj.InvokeMethod("EnumValues", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                sNames = (string[])output["sNames"];
                Types = (int[])output["Types"];
            }
        }
        /// <summary>
        /// EnumValues 方法枚举给定子项的命名值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要枚举的命名值的路径。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sNames">包含命名值字符串数组。该数组的元素直接对应于 iTypes 的元素。</param>
        /// <param name="Types">包含数据值类型(整数)的数组。可使用这些类型来确定调用哪个 Get 方法。例如，如果数据值类型是 REG_SZ，则调用 GetStringValue 来检索命名值的数据值。此数组中的元素直接对应于 sNames 的元素。Winnt.h 中定义了以下数据值类型: 
        /// REG_SZ (1) 
        /// REG_EXPAND_SZ (2) 
        /// REG_BINARY (3) 
        /// REG_DWORD (4) 
        /// REG_MULTI_SZ (7) 
        /// </param>
        public void EnumValues(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, out uint ReturnValue, out string[] sNames, out int[] Types)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("EnumValues");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            var output = classObj.InvokeMethod("EnumValues", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            sNames = (string[])output["sNames"];
            Types = (int[])output["Types"];
        }
        /// <summary>
        /// DeleteValue 方法删除指定子项中的命名值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要删除的命名值的项。</param>
        /// <param name="sValueName">指定要从子项中删除的命名值。指定空字符串可删除默认命名值(默认命名值不会删除，其值将设置为“未设置值”)</param>
        /// <returns></returns>
        public uint DeleteValue(uint hDefKey, string sSubKeyName, string sValueName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("DeleteValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("DeleteValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// DeleteValue 方法删除指定子项中的命名值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要删除的命名值的项。</param>
        /// <param name="sValueName">指定要从子项中删除的命名值。指定空字符串可删除默认命名值(默认命名值不会删除，其值将设置为“未设置值”)</param>
        /// <returns></returns>
        public uint DeleteValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("DeleteValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("DeleteValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// SetDWORDValue 方法为数据类型为 REG_BINARY 的命名值设置数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <param name="uValue">指定双字数据值。</param>
        /// <returns></returns>
        public uint SetDWORDValue(uint hDefKey, string sSubKeyName, string sValueName, uint uValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetDWORDValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                inParams["uValue"] = NetValueToWmi(CimType.UInt32, uValue);
                var output = classObj.InvokeMethod("SetDWORDValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetDWORDValue 方法为数据类型为 REG_BINARY 的命名值设置数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <param name="uValue">指定双字数据值。</param>
        /// <returns></returns>
        public uint SetDWORDValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, uint uValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetDWORDValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            inParams["uValue"] = NetValueToWmi(CimType.UInt32, uValue);
            var output = classObj.InvokeMethod("SetDWORDValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// SetQWORDValue 方法为数据类型为 REG_QWORD 的命名值设置数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <param name="uValue">指定四字数据值。</param>
        /// <returns></returns>
        public uint SetQWORDValue(uint hDefKey, string sSubKeyName, string sValueName, ulong uValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetQWORDValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                inParams["uValue"] = NetValueToWmi(CimType.UInt64, uValue);
                var output = classObj.InvokeMethod("SetQWORDValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetQWORDValue 方法为数据类型为 REG_QWORD 的命名值设置数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <param name="uValue">指定四字数据值。</param>
        /// <returns></returns>
        public uint SetQWORDValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, ulong uValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetQWORDValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            inParams["uValue"] = NetValueToWmi(CimType.UInt64, uValue);
            var output = classObj.InvokeMethod("SetQWORDValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetDWORDValue 方法为数据类型为 REG_DWORD 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="uValue">包含命名值的 DWORD 数据值。</param>
        public void GetDWORDValue(uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out uint uValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetDWORDValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("GetDWORDValue", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                uValue = (uint)output["uValue"];
            }
        }
        /// <summary>
        /// GetDWORDValue 方法为数据类型为 REG_DWORD 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="uValue">包含命名值的 DWORD 数据值。</param>
        public void GetDWORDValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out uint uValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetDWORDValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("GetDWORDValue", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            uValue = (uint)output["uValue"];
        }
        /// <summary>
        /// GetQWORDValue 方法为数据类型为 REG_QWORD 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="uValue">包含命名值的 DWORD 数据值。</param>
        public void GetQWORDValue(uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out ulong uValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetQWORDValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("GetQWORDValue", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                uValue = (ulong)output["uValue"];
            }
        }
        /// <summary>
        /// GetQWORDValue 方法为数据类型为 REG_QWORD 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="uValue">包含命名值的 DWORD 数据值。</param>
        public void GetQWORDValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out ulong uValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetQWORDValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("GetQWORDValue", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            uValue = (ulong)output["uValue"];
        }
        /// <summary>
        /// SetStringValue 方法为数据类型为 REG_MULTI_SZ 的命名值设置数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValue">指定字符串数据值。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <returns></returns>
        public uint SetStringValue(uint hDefKey, string sSubKeyName, string sValue, string sValueName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetStringValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValue"] = NetValueToWmi(CimType.String, sValue);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("SetStringValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetStringValue 方法为数据类型为 REG_MULTI_SZ 的命名值设置数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValue">指定字符串数据值。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <returns></returns>
        public uint SetStringValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValue, string sValueName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetStringValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValue"] = NetValueToWmi(CimType.String, sValue);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("SetStringValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetStringValue 方法为数据类型为 REG_SZ 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sValue">包含命名值的字符串数据值。</param>
        public void GetStringValue(uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out string sValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetStringValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("GetStringValue", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                sValue = (string)output["sValue"];
            }
        }
        /// <summary>
        /// GetStringValue 方法为数据类型为 REG_SZ 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sValue">包含命名值的字符串数据值。</param>
        public void GetStringValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out string sValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetStringValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("GetStringValue", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            sValue = (string)output["sValue"];
        }
        /// <summary>
        /// SetMultiStringValue 方法为数据类型为 REG_MULTI_SZ 的命名值设置数据值。如果成功，SetMultiStringValue 方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValue">指定字符串数据值数组。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <returns></returns>
        public uint SetMultiStringValue(uint hDefKey, string sSubKeyName, string[] sValue, string sValueName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetMultiStringValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValue"] = NetValueToWmi(CimType.String, sValue);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("SetMultiStringValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetMultiStringValue 方法为数据类型为 REG_MULTI_SZ 的命名值设置数据值。如果成功，SetMultiStringValue 方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValue">指定字符串数据值数组。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <returns></returns>
        public uint SetMultiStringValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string[] sValue, string sValueName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetMultiStringValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValue"] = NetValueToWmi(CimType.String, sValue);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("SetMultiStringValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetMultiStringValue 方法为数据类型为 REG_MULTI_SZ 的命名值返回数据值。如果成功，GetMultiStringValue 方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sValue">包含一个由命名值的字符串数据值组成的数组。</param>
        public void GetMultiStringValue(uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out string[] sValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetMultiStringValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("GetMultiStringValue", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                sValue = (string[])output["sValue"];
            }
        }
        /// <summary>
        /// GetMultiStringValue 方法为数据类型为 REG_MULTI_SZ 的命名值返回数据值。如果成功，GetMultiStringValue 方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sValue">包含一个由命名值的字符串数据值组成的数组。</param>
        public void GetMultiStringValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out string[] sValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetMultiStringValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("GetMultiStringValue", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            sValue = (string[])output["sValue"];
        }
        /// <summary>
        /// SetExpandedStringValue 方法为数据类型为 REG_EXPAND_SZ 的命名值设置数据值。如果成功，SetExpandedStringValue 方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValue">指定已扩展的字符串数据值。若要使字符串在你调用 GetExpandedStringValue 时能够扩展，字符串中指定的环境变量必须存在。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <returns></returns>
        public uint SetExpandedStringValue(uint hDefKey, string sSubKeyName, string sValue, string sValueName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetExpandedStringValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValue"] = NetValueToWmi(CimType.String, sValue);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("SetExpandedStringValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetExpandedStringValue 方法为数据类型为 REG_EXPAND_SZ 的命名值设置数据值。如果成功，SetExpandedStringValue 方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValue">指定已扩展的字符串数据值。若要使字符串在你调用 GetExpandedStringValue 时能够扩展，字符串中指定的环境变量必须存在。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <returns></returns>
        public uint SetExpandedStringValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValue, string sValueName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetExpandedStringValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValue"] = NetValueToWmi(CimType.String, sValue);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("SetExpandedStringValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetExpandedStringValue 方法为数据类型为 REG_EXPAND_SZ 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sValue">包含命名值的已扩展字符串数据值。仅当环境变量(例如，%Path%)已定义时，字符串才会扩展。</param>
        public void GetExpandedStringValue(uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out string sValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetExpandedStringValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("GetExpandedStringValue", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                sValue = (string)output["sValue"];
            }
        }
        /// <summary>
        /// GetExpandedStringValue 方法为数据类型为 REG_EXPAND_SZ 的命名值返回数据值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="sValue">包含命名值的已扩展字符串数据值。仅当环境变量(例如，%Path%)已定义时，字符串才会扩展。</param>
        public void GetExpandedStringValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out string sValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetExpandedStringValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("GetExpandedStringValue", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            sValue = (string)output["sValue"];
        }
        /// <summary>
        /// SetBinaryValue 方法为数据类型为 REG_BINARY 的命名值设置数据值。如果成功，SetBinaryValue 方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <param name="uValue">指定二进制数据值数组。</param>
        /// <returns></returns>
        public uint SetBinaryValue(uint hDefKey, string sSubKeyName, string sValueName, byte[] uValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetBinaryValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                inParams["uValue"] = NetValueToWmi(CimType.UInt8, uValue);
                var output = classObj.InvokeMethod("SetBinaryValue", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetBinaryValue 方法为数据类型为 REG_BINARY 的命名值设置数据值。如果成功，SetBinaryValue 方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含要设置的命名值的项。</param>
        /// <param name="sValueName">指定要设置数据值的命名值。可以指定现有命名值(更新)或新的命名值(创建)。指定空字符串可为默认命名值设置数据值。</param>
        /// <param name="uValue">指定二进制数据值数组。</param>
        /// <returns></returns>
        public uint SetBinaryValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, byte[] uValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetBinaryValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            inParams["uValue"] = NetValueToWmi(CimType.UInt8, uValue);
            var output = classObj.InvokeMethod("SetBinaryValue", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetBinaryValue 方法为数据类型为 REG_BINARY 的命名值返回数据值。如果成功，GetBinaryValue 方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="uValue">包含二进制字节数组。</param>
        public void GetBinaryValue(uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out byte[] uValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetBinaryValue");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
                var output = classObj.InvokeMethod("GetBinaryValue", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                uValue = (byte[])output["uValue"];
            }
        }
        /// <summary>
        /// GetBinaryValue 方法为数据类型为 REG_BINARY 的命名值返回数据值。如果成功，GetBinaryValue 方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">指定包含命名值的路径。</param>
        /// <param name="sValueName">指定要检索其数据值的命名值。指定空字符串可获取默认命名值。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="uValue">包含二进制字节数组。</param>
        public void GetBinaryValue(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, string sValueName, out uint ReturnValue, out byte[] uValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetBinaryValue");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["sValueName"] = NetValueToWmi(CimType.String, sValueName);
            var output = classObj.InvokeMethod("GetBinaryValue", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            uValue = (byte[])output["uValue"];
        }
        /// <summary>
        /// CheckAccess 方法验证用户是否拥有指定的权限。如果成功，该方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">包含要验证的项。</param>
        /// <param name="uRequired">用于指定要验证的访问权限的可选参数。你可以将这些值加在一起以验证多个访问权限。默认值为 3。Winnt.h 中定义了以下访问权限值: 
        /// KEY_QUERY_VALUE (0X0001) 
        /// KEY_SET_VALUE (0X0002) 
        /// KEY_CREATE_SUB_KEY (0X0004) 
        /// KEY_ENUMERATE_SUB_KEYS (0X0008) 
        /// KEY_NOTIFY (0X0010) 
        /// KEY_CREATE_LINK (0X0020) 
        /// DELETE (0x00010000) 
        /// READ_CONTROL (0x00020000) 
        /// WRITE_DAC (0X00040000) 
        /// WRITE_OWNER (0X00080000) </param>
        /// <param name="bGranted">如果用户拥有指定的访问权限，则此参数为 True。否则，此参数为 False。</param>
        /// <param name="ReturnValue"></param>
        public void CheckAccess(uint hDefKey, string sSubKeyName, uint uRequired, out bool bGranted, out uint ReturnValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("CheckAccess");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                inParams["uRequired"] = NetValueToWmi(CimType.UInt32, uRequired);
                var output = classObj.InvokeMethod("CheckAccess", inParams, null);
                bGranted = (bool)output["bGranted"];
                ReturnValue = (uint)output["ReturnValue"];
            }
        }
        /// <summary>
        /// CheckAccess 方法验证用户是否拥有指定的权限。如果成功，该方法将返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的可选参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// HKEY_DYN_DATA (0x80000006) 
        /// 请注意，HKEY_DYN_DATA 是只对 Windows 95 和 Windows 98 计算机有效的树。</param>
        /// <param name="sSubKeyName">包含要验证的项。</param>
        /// <param name="uRequired">用于指定要验证的访问权限的可选参数。你可以将这些值加在一起以验证多个访问权限。默认值为 3。Winnt.h 中定义了以下访问权限值: 
        /// KEY_QUERY_VALUE (0X0001) 
        /// KEY_SET_VALUE (0X0002) 
        /// KEY_CREATE_SUB_KEY (0X0004) 
        /// KEY_ENUMERATE_SUB_KEYS (0X0008) 
        /// KEY_NOTIFY (0X0010) 
        /// KEY_CREATE_LINK (0X0020) 
        /// DELETE (0x00010000) 
        /// READ_CONTROL (0x00020000) 
        /// WRITE_DAC (0X00040000) 
        /// WRITE_OWNER (0X00080000) </param>
        /// <param name="bGranted">如果用户拥有指定的访问权限，则此参数为 True。否则，此参数为 False。</param>
        /// <param name="ReturnValue"></param>
        public void CheckAccess(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, uint uRequired, out bool bGranted, out uint ReturnValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("CheckAccess");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            inParams["uRequired"] = NetValueToWmi(CimType.UInt32, uRequired);
            var output = classObj.InvokeMethod("CheckAccess", inParams, null);
            bGranted = (bool)output["bGranted"];
            ReturnValue = (uint)output["ReturnValue"];
        }
        /// <summary>
        /// SetSecurityDescriptor 方法使用提供的 __SecurityDescriptor 更新指定项的安全描述符。如果成功，此方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="Descriptor">包含要对项名称设置的安全描述符。</param>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// </param>
        /// <param name="sSubKeyName">包含要设置安全描述符的项名称。</param>
        /// <returns></returns>
        public uint SetSecurityDescriptor(object Descriptor, uint hDefKey, string sSubKeyName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetSecurityDescriptor");
                inParams["Descriptor"] = NetValueToWmi(CimType.Object, Descriptor);
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                var output = classObj.InvokeMethod("SetSecurityDescriptor", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetSecurityDescriptor 方法使用提供的 __SecurityDescriptor 更新指定项的安全描述符。如果成功，此方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="Descriptor">包含要对项名称设置的安全描述符。</param>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// </param>
        /// <param name="sSubKeyName">包含要设置安全描述符的项名称。</param>
        /// <returns></returns>
        public uint SetSecurityDescriptor(Entites.StdRegProvEntity entity, object Descriptor, uint hDefKey, string sSubKeyName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetSecurityDescriptor");
            inParams["Descriptor"] = NetValueToWmi(CimType.Object, Descriptor);
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            var output = classObj.InvokeMethod("SetSecurityDescriptor", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetSecurityDescriptor 方法在 __SecurityDescriptor 中返回指定项的安全描述符。如果成功，此方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// </param>
        /// <param name="sSubKeyName">包含要获取其安全描述符的项名称。</param>
        /// <param name="Descriptor">从项名称返回安全描述符。</param>
        /// <param name="ReturnValue"></param>
        public void GetSecurityDescriptor(uint hDefKey, string sSubKeyName, out object Descriptor, out uint ReturnValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetSecurityDescriptor");
                inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
                inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
                var output = classObj.InvokeMethod("GetSecurityDescriptor", inParams, null);
                Descriptor = (object)output["Descriptor"];
                ReturnValue = (uint)output["ReturnValue"];
            }
        }
        /// <summary>
        /// GetSecurityDescriptor 方法在 __SecurityDescriptor 中返回指定项的安全描述符。如果成功，此方法返回一个 uint32 类型的值 0；如果出现任何其他错误，则返回其他某个值。
        /// </summary>
        /// <param name="hDefKey">用于指定包含 sSubKeyName 路径的树的参数。默认值为 HKEY_LOCAL_MACHINE (0x80000002)。Winreg.h 中定义了以下树: 
        /// HKEY_CLASSES_ROOT (0x80000000) 
        /// HKEY_CURRENT_USER (0x80000001) 
        /// HKEY_LOCAL_MACHINE (0x80000002) 
        /// HKEY_USERS (0x80000003) 
        /// HKEY_CURRENT_CONFIG (0x80000005) 
        /// </param>
        /// <param name="sSubKeyName">包含要获取其安全描述符的项名称。</param>
        /// <param name="Descriptor">从项名称返回安全描述符。</param>
        /// <param name="ReturnValue"></param>
        public void GetSecurityDescriptor(Entites.StdRegProvEntity entity, uint hDefKey, string sSubKeyName, out object Descriptor, out uint ReturnValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetSecurityDescriptor");
            inParams["hDefKey"] = NetValueToWmi(CimType.UInt32, hDefKey);
            inParams["sSubKeyName"] = NetValueToWmi(CimType.String, sSubKeyName);
            var output = classObj.InvokeMethod("GetSecurityDescriptor", inParams, null);
            Descriptor = (object)output["Descriptor"];
            ReturnValue = (uint)output["ReturnValue"];
        }
    }
}
