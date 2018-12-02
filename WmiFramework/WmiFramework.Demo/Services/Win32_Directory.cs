using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_Directory 类用于表示 Win32 计算机系统上的目录项。目录是一种文件类型，用于通过逻辑方式对“包含”在其中的数据文件进行分组并为分组文件提供路径信息。
    /// 例如: C:\TEMP。
    /// </summary>
    public class Win32_Directory : WMIService<Entites.Win32_DirectoryEntity>
    {
        public Win32_Directory(ConnectionOptions options, string address) : base(options, address) { }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint TakeOwnerShip()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("TakeOwnerShip");
                var output = classObj.InvokeMethod("TakeOwnerShip", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint TakeOwnerShip(Entites.Win32_DirectoryEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("TakeOwnerShip");
            var output = classObj.InvokeMethod("TakeOwnerShip", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Option"></param>
        /// <param name="SecurityDescriptor"></param>
        /// <returns></returns>
        public uint ChangeSecurityPermissions(uint Option, object SecurityDescriptor)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("ChangeSecurityPermissions");
                inParams["Option"] = NetValueToWmi(CimType.UInt32, Option);
                inParams["SecurityDescriptor"] = NetValueToWmi(CimType.Object, SecurityDescriptor);
                var output = classObj.InvokeMethod("ChangeSecurityPermissions", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Option"></param>
        /// <param name="SecurityDescriptor"></param>
        /// <returns></returns>
        public uint ChangeSecurityPermissions(Entites.Win32_DirectoryEntity entity, uint Option, object SecurityDescriptor)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("ChangeSecurityPermissions");
            inParams["Option"] = NetValueToWmi(CimType.UInt32, Option);
            inParams["SecurityDescriptor"] = NetValueToWmi(CimType.Object, SecurityDescriptor);
            var output = classObj.InvokeMethod("ChangeSecurityPermissions", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public uint Copy(string FileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Copy");
                inParams["FileName"] = NetValueToWmi(CimType.String, FileName);
                var output = classObj.InvokeMethod("Copy", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public uint Copy(Entites.Win32_DirectoryEntity entity, string FileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Copy");
            inParams["FileName"] = NetValueToWmi(CimType.String, FileName);
            var output = classObj.InvokeMethod("Copy", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public uint Rename(string FileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Rename");
                inParams["FileName"] = NetValueToWmi(CimType.String, FileName);
                var output = classObj.InvokeMethod("Rename", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public uint Rename(Entites.Win32_DirectoryEntity entity, string FileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Rename");
            inParams["FileName"] = NetValueToWmi(CimType.String, FileName);
            var output = classObj.InvokeMethod("Rename", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint Delete()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Delete");
                var output = classObj.InvokeMethod("Delete", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint Delete(Entites.Win32_DirectoryEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Delete");
            var output = classObj.InvokeMethod("Delete", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint Compress()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Compress");
                var output = classObj.InvokeMethod("Compress", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint Compress(Entites.Win32_DirectoryEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Compress");
            var output = classObj.InvokeMethod("Compress", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint Uncompress()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Uncompress");
                var output = classObj.InvokeMethod("Uncompress", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public uint Uncompress(Entites.Win32_DirectoryEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Uncompress");
            var output = classObj.InvokeMethod("Uncompress", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void TakeOwnerShipEx(bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("TakeOwnerShipEx");
                inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
                inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
                var output = classObj.InvokeMethod("TakeOwnerShipEx", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                StopFileName = (string)output["StopFileName"];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void TakeOwnerShipEx(Entites.Win32_DirectoryEntity entity, bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("TakeOwnerShipEx");
            inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
            inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
            var output = classObj.InvokeMethod("TakeOwnerShipEx", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            StopFileName = (string)output["StopFileName"];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Option"></param>
        /// <param name="Recursive"></param>
        /// <param name="SecurityDescriptor"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void ChangeSecurityPermissionsEx(uint Option, bool Recursive, object SecurityDescriptor, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("ChangeSecurityPermissionsEx");
                inParams["Option"] = NetValueToWmi(CimType.UInt32, Option);
                inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
                inParams["SecurityDescriptor"] = NetValueToWmi(CimType.Object, SecurityDescriptor);
                inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
                var output = classObj.InvokeMethod("ChangeSecurityPermissionsEx", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                StopFileName = (string)output["StopFileName"];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Option"></param>
        /// <param name="Recursive"></param>
        /// <param name="SecurityDescriptor"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void ChangeSecurityPermissionsEx(Entites.Win32_DirectoryEntity entity, uint Option, bool Recursive, object SecurityDescriptor, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("ChangeSecurityPermissionsEx");
            inParams["Option"] = NetValueToWmi(CimType.UInt32, Option);
            inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
            inParams["SecurityDescriptor"] = NetValueToWmi(CimType.Object, SecurityDescriptor);
            inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
            var output = classObj.InvokeMethod("ChangeSecurityPermissionsEx", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            StopFileName = (string)output["StopFileName"];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void CopyEx(string FileName, bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("CopyEx");
                inParams["FileName"] = NetValueToWmi(CimType.String, FileName);
                inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
                inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
                var output = classObj.InvokeMethod("CopyEx", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                StopFileName = (string)output["StopFileName"];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void CopyEx(Entites.Win32_DirectoryEntity entity, string FileName, bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("CopyEx");
            inParams["FileName"] = NetValueToWmi(CimType.String, FileName);
            inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
            inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
            var output = classObj.InvokeMethod("CopyEx", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            StopFileName = (string)output["StopFileName"];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void DeleteEx(string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("DeleteEx");
                inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
                var output = classObj.InvokeMethod("DeleteEx", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                StopFileName = (string)output["StopFileName"];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void DeleteEx(Entites.Win32_DirectoryEntity entity, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("DeleteEx");
            inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
            var output = classObj.InvokeMethod("DeleteEx", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            StopFileName = (string)output["StopFileName"];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void CompressEx(bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("CompressEx");
                inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
                inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
                var output = classObj.InvokeMethod("CompressEx", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                StopFileName = (string)output["StopFileName"];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void CompressEx(Entites.Win32_DirectoryEntity entity, bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("CompressEx");
            inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
            inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
            var output = classObj.InvokeMethod("CompressEx", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            StopFileName = (string)output["StopFileName"];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void UncompressEx(bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("UncompressEx");
                inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
                inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
                var output = classObj.InvokeMethod("UncompressEx", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                StopFileName = (string)output["StopFileName"];
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Recursive"></param>
        /// <param name="StartFileName"></param>
        /// <param name="ReturnValue"></param>
        /// <param name="StopFileName"></param>
        public void UncompressEx(Entites.Win32_DirectoryEntity entity, bool Recursive, string StartFileName, out uint ReturnValue, out string StopFileName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("UncompressEx");
            inParams["Recursive"] = NetValueToWmi(CimType.Boolean, Recursive);
            inParams["StartFileName"] = NetValueToWmi(CimType.String, StartFileName);
            var output = classObj.InvokeMethod("UncompressEx", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            StopFileName = (string)output["StopFileName"];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Permissions"></param>
        /// <returns></returns>
        public bool GetEffectivePermission(uint Permissions)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetEffectivePermission");
                inParams["Permissions"] = NetValueToWmi(CimType.UInt32, Permissions);
                var output = classObj.InvokeMethod("GetEffectivePermission", inParams, null);
                return (bool)WmiValueToNet(CimType.Boolean, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Permissions"></param>
        /// <returns></returns>
        public bool GetEffectivePermission(Entites.Win32_DirectoryEntity entity, uint Permissions)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetEffectivePermission");
            inParams["Permissions"] = NetValueToWmi(CimType.UInt32, Permissions);
            var output = classObj.InvokeMethod("GetEffectivePermission", inParams, null);
            return (bool)WmiValueToNet(CimType.Boolean, output["ReturnValue"]);
        }
    }
}
