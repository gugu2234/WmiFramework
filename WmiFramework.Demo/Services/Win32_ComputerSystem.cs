using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_ComputerSystem 类表示在 Win32 环境中运行的计算机系统。
    /// </summary>
    public class Win32_ComputerSystem : WMIService<Entites.Win32_ComputerSystemEntity>
    {
        public Win32_ComputerSystem(ConnectionOptions options, string address) : base(options, address) { }
        /// <summary>
        /// SetPowerState 方法定义了计算机系统及其运行的操作系统所需的电源状态，并且定义了应当将系统置于此状态的时间。PowerState 参数被指定成某个为 PowerState 属性定义的有效整数值。Time 参数(适用于除了 5“电源重启”以外的其他所有状态更改)表示何时应将电源状态设置为常规日期-时间值或设置为间隔值(其中，间隔的起始时间为收到方法调用的时间)。当 PowerState 参数等于 5“电源重启”时，Time 参数表示系统应当再次开启电源的时间，关闭电源是立即执行的。如果成功，SetPowerState 应返回 0；如果指定的电源状态和时间请求不受支持，则返回 1；如果出现其他错误，则返回另外的值。
        /// </summary>
        /// <param name="PowerState"></param>
        /// <param name="Time"></param>
        /// <returns></returns>
        public uint SetPowerState(ushort PowerState, DateTime Time)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetPowerState");
                inParams["PowerState"] = NetValueToWmi(CimType.UInt16, PowerState);
                inParams["Time"] = NetValueToWmi(CimType.DateTime, Time);
                var output = classObj.InvokeMethod("SetPowerState", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetPowerState 方法定义了计算机系统及其运行的操作系统所需的电源状态，并且定义了应当将系统置于此状态的时间。PowerState 参数被指定成某个为 PowerState 属性定义的有效整数值。Time 参数(适用于除了 5“电源重启”以外的其他所有状态更改)表示何时应将电源状态设置为常规日期-时间值或设置为间隔值(其中，间隔的起始时间为收到方法调用的时间)。当 PowerState 参数等于 5“电源重启”时，Time 参数表示系统应当再次开启电源的时间，关闭电源是立即执行的。如果成功，SetPowerState 应返回 0；如果指定的电源状态和时间请求不受支持，则返回 1；如果出现其他错误，则返回另外的值。
        /// </summary>
        /// <param name="PowerState"></param>
        /// <param name="Time"></param>
        /// <returns></returns>
        public uint SetPowerState(Entites.Win32_ComputerSystemEntity entity, ushort PowerState, DateTime Time)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetPowerState");
            inParams["PowerState"] = NetValueToWmi(CimType.UInt16, PowerState);
            inParams["Time"] = NetValueToWmi(CimType.DateTime, Time);
            var output = classObj.InvokeMethod("SetPowerState", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// Rename 方法用于更改工作组或域中的计算机的名称。在远程工作时，Rename 方法对 Windows XP 家庭版或专业版(仅限工作组)不起作用。应注意，对于域中的任何计算机(域控制器除外，它可以对自己进行身份验证)，均需要进行委派，因为当计算机为接受身份验证而远程访问域控制器时，将需要该计算机的第二个跃点。对于本地访问则没有限制。
        /// 如果指定 Password 和 Username 参数，那么当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，到 winmgmt 的连接必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接传递到 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了密码或用户名，则将返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// 该方法可能返回的值如下: 
        /// 0 - 成功。需要重新引导。
        /// 其他 - 有关上列值以外的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Name">该 Name 参数指定新名称。名称中不能包含控制字符、前导空格或尾随空格，也不能包含以下任何字符:  / \ [ ] : | < > + = ; , ? </param>
        /// <param name="Password">如果 UserName 参数指定了帐户名称，则 Password 参数必须指向连接到域控制器时使用的密码。否则，此参数必须为 NULL。
        /// 当计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了密码或用户名，则将返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// 此参数只用于在 Windows 2000 及更高版本的平台上对域进行重命名。</param>
        /// <param name="UserName">Username 参数是一个指向以空字符结尾的常量字符串的指针，该字符串指定连接到域控制器时要使用的帐户名称。该字符串必须指定域 NetBIOS 名称和用户帐户(例如，"REDMOND\user")，或者指定 Internet 式登录名称(例如，"someone@microsoft.com")形式的用户主体名称(UPN)。如果此参数为 NULL，则使用调用方的上下文。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// 此参数只用于在 Windows 2000 及更高版本的平台上对域进行重命名。</param>
        /// <returns></returns>
        public uint Rename(string Name, string Password, string UserName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Rename");
                inParams["Name"] = NetValueToWmi(CimType.String, Name);
                inParams["Password"] = NetValueToWmi(CimType.String, Password);
                inParams["UserName"] = NetValueToWmi(CimType.String, UserName);
                var output = classObj.InvokeMethod("Rename", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// Rename 方法用于更改工作组或域中的计算机的名称。在远程工作时，Rename 方法对 Windows XP 家庭版或专业版(仅限工作组)不起作用。应注意，对于域中的任何计算机(域控制器除外，它可以对自己进行身份验证)，均需要进行委派，因为当计算机为接受身份验证而远程访问域控制器时，将需要该计算机的第二个跃点。对于本地访问则没有限制。
        /// 如果指定 Password 和 Username 参数，那么当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，到 winmgmt 的连接必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接传递到 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了密码或用户名，则将返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// 该方法可能返回的值如下: 
        /// 0 - 成功。需要重新引导。
        /// 其他 - 有关上列值以外的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Name">该 Name 参数指定新名称。名称中不能包含控制字符、前导空格或尾随空格，也不能包含以下任何字符:  / \ [ ] : | < > + = ; , ? </param>
        /// <param name="Password">如果 UserName 参数指定了帐户名称，则 Password 参数必须指向连接到域控制器时使用的密码。否则，此参数必须为 NULL。
        /// 当计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了密码或用户名，则将返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// 此参数只用于在 Windows 2000 及更高版本的平台上对域进行重命名。</param>
        /// <param name="UserName">Username 参数是一个指向以空字符结尾的常量字符串的指针，该字符串指定连接到域控制器时要使用的帐户名称。该字符串必须指定域 NetBIOS 名称和用户帐户(例如，"REDMOND\user")，或者指定 Internet 式登录名称(例如，"someone@microsoft.com")形式的用户主体名称(UPN)。如果此参数为 NULL，则使用调用方的上下文。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// 此参数只用于在 Windows 2000 及更高版本的平台上对域进行重命名。</param>
        /// <returns></returns>
        public uint Rename(Entites.Win32_ComputerSystemEntity entity, string Name, string Password, string UserName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Rename");
            inParams["Name"] = NetValueToWmi(CimType.String, Name);
            inParams["Password"] = NetValueToWmi(CimType.String, Password);
            inParams["UserName"] = NetValueToWmi(CimType.String, UserName);
            var output = classObj.InvokeMethod("Rename", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// JoinDomainOrWorkgroup 方法用于将计算机系统加入到域或工作组。该方法仅适用于 Windows 2000 及更高版本平台。该方法可能返回的值如下: 
        /// 0 - 成功。
        /// 其他 - 有关上列值以外的整数值，请参阅 Win32 错误代码文档。
        /// 注意: 如果将计算机从域移动到工作组，在运行此方法将其加入工作组之前必须先将计算机从域中删除。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了密码或用户名，则将返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// </summary>
        /// <param name="AccountOU">AccountOU 可以指定指向以空字符结尾的常量字符串的指针，该字符串包含计算机帐户组织单位(OU)的 RFC 1779 格式名称。如果指定此参数，则该字符串必须包含一个完整路径，例如 OU=testOU、DC=domain、DC=Domain、DC=com。否则，此参数必须为 NULL。</param>
        /// <param name="FJoinOptions">FJoinOptions 参数包含一组定义连接选项的位标志。该参数可以使用下列中的一个或多个值: 
        /// 加入域 - 将计算机加入到域。如果未指定此值，则将计算机加入到工作组。0 位 - 加入域 - 如果域不存在，则加入工作组。
        /// 1 位 - 创建帐户 - 在域中创建帐户。
        /// 2 位 - 删除帐户 - 离开域时删除帐户。
        /// 4 位 - Win9X 升级 - 在将操作系统从 Windows 95/98 升级到 Windows NT/Windows 2000 的过程中执行加入操作。
        /// 5 位 - 在已连接域的情况下再加入其他域 - 即使计算机已连接到一个域，仍然允许它再加入到另一个域。
        /// 6 位 - 无安全保护的加入 - 执行无安全保护的加入。
        /// 7 位 - 已通过计算机密码 - 表示计算机(而不是用户)密码已获通过。此选项仅适用于不安全的加入操作。
        /// 8 位 - 延迟 SPN 集 - 指定延迟在计算机对象上写入 SPN 和 DnsHostName 属性，直到完成加入后进行重命名时。
        /// 18 位 - 安装时调用 - 安装期间调用 API。
        /// 
        /// 如果不涉及任何选项，则该方法返回 0。</param>
        /// <param name="Name">该 Name 参数指定要加入的域或工作组。此参数不能为 NULL。</param>
        /// <param name="Password">如果 UserName 参数指定了帐户名称，则 Password 参数必须指向连接到域控制器时要使用的密码。否则，此参数必须为 NULL。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <param name="UserName">Username 参数是一个指向以空字符结尾的常量字符串的指针，该字符串指定连接到域控制器时要使用的帐户名称。该字符串必须指定域 NetBIOS 名称和用户帐户(例如，"REDMOND\user")，或者指定 Internet 式登录名称(例如，"someone@microsoft.com")形式的用户主体名称(UPN)。如果此参数为 NULL，则使用调用方的上下文。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <returns></returns>
        public uint JoinDomainOrWorkgroup(string AccountOU, uint FJoinOptions, string Name, string Password, string UserName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("JoinDomainOrWorkgroup");
                inParams["AccountOU"] = NetValueToWmi(CimType.String, AccountOU);
                inParams["FJoinOptions"] = NetValueToWmi(CimType.UInt32, FJoinOptions);
                inParams["Name"] = NetValueToWmi(CimType.String, Name);
                inParams["Password"] = NetValueToWmi(CimType.String, Password);
                inParams["UserName"] = NetValueToWmi(CimType.String, UserName);
                var output = classObj.InvokeMethod("JoinDomainOrWorkgroup", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// JoinDomainOrWorkgroup 方法用于将计算机系统加入到域或工作组。该方法仅适用于 Windows 2000 及更高版本平台。该方法可能返回的值如下: 
        /// 0 - 成功。
        /// 其他 - 有关上列值以外的整数值，请参阅 Win32 错误代码文档。
        /// 注意: 如果将计算机从域移动到工作组，在运行此方法将其加入工作组之前必须先将计算机从域中删除。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了密码或用户名，则将返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// </summary>
        /// <param name="AccountOU">AccountOU 可以指定指向以空字符结尾的常量字符串的指针，该字符串包含计算机帐户组织单位(OU)的 RFC 1779 格式名称。如果指定此参数，则该字符串必须包含一个完整路径，例如 OU=testOU、DC=domain、DC=Domain、DC=com。否则，此参数必须为 NULL。</param>
        /// <param name="FJoinOptions">FJoinOptions 参数包含一组定义连接选项的位标志。该参数可以使用下列中的一个或多个值: 
        /// 加入域 - 将计算机加入到域。如果未指定此值，则将计算机加入到工作组。0 位 - 加入域 - 如果域不存在，则加入工作组。
        /// 1 位 - 创建帐户 - 在域中创建帐户。
        /// 2 位 - 删除帐户 - 离开域时删除帐户。
        /// 4 位 - Win9X 升级 - 在将操作系统从 Windows 95/98 升级到 Windows NT/Windows 2000 的过程中执行加入操作。
        /// 5 位 - 在已连接域的情况下再加入其他域 - 即使计算机已连接到一个域，仍然允许它再加入到另一个域。
        /// 6 位 - 无安全保护的加入 - 执行无安全保护的加入。
        /// 7 位 - 已通过计算机密码 - 表示计算机(而不是用户)密码已获通过。此选项仅适用于不安全的加入操作。
        /// 8 位 - 延迟 SPN 集 - 指定延迟在计算机对象上写入 SPN 和 DnsHostName 属性，直到完成加入后进行重命名时。
        /// 18 位 - 安装时调用 - 安装期间调用 API。
        /// 
        /// 如果不涉及任何选项，则该方法返回 0。</param>
        /// <param name="Name">该 Name 参数指定要加入的域或工作组。此参数不能为 NULL。</param>
        /// <param name="Password">如果 UserName 参数指定了帐户名称，则 Password 参数必须指向连接到域控制器时要使用的密码。否则，此参数必须为 NULL。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <param name="UserName">Username 参数是一个指向以空字符结尾的常量字符串的指针，该字符串指定连接到域控制器时要使用的帐户名称。该字符串必须指定域 NetBIOS 名称和用户帐户(例如，"REDMOND\user")，或者指定 Internet 式登录名称(例如，"someone@microsoft.com")形式的用户主体名称(UPN)。如果此参数为 NULL，则使用调用方的上下文。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序确定身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <returns></returns>
        public uint JoinDomainOrWorkgroup(Entites.Win32_ComputerSystemEntity entity, string AccountOU, uint FJoinOptions, string Name, string Password, string UserName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("JoinDomainOrWorkgroup");
            inParams["AccountOU"] = NetValueToWmi(CimType.String, AccountOU);
            inParams["FJoinOptions"] = NetValueToWmi(CimType.UInt32, FJoinOptions);
            inParams["Name"] = NetValueToWmi(CimType.String, Name);
            inParams["Password"] = NetValueToWmi(CimType.String, Password);
            inParams["UserName"] = NetValueToWmi(CimType.String, UserName);
            var output = classObj.InvokeMethod("JoinDomainOrWorkgroup", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// UnjoinDomainOrWorkgroup 方法从域或工作组中取消某个计算机系统的加入或从中删除某个计算机系统。此方法仅适用于 Windows 2000 及更高版本的平台。该方法可能返回的值如下: 
        /// 0 - 成功。
        /// 其他 - 有关上列值以外的整数值，请参阅 Win32 错误代码文档。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// </summary>
        /// <param name="FUnjoinOptions">FUnjoinOptions 参数指定取消加入选项。如果此参数是 NETSETUP_ACCT_DELETE，则在取消加入时将禁用帐户。注意: 此选项不会删除帐户。目前未定义其他取消加入选项。
        /// 
        /// 2 位 - 删除帐户 - 离开域时删除帐户。
        /// 如果不涉及任何选项，则该方法返回 0。</param>
        /// <param name="Password">如果 UserName 参数指定了帐户名称，则 Password 参数必须指向连接到域控制器时要使用的密码。否则，此参数必须为 NULL。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <param name="UserName">Username 参数是一个指向以空字符结尾的常量字符串的指针，该字符串指定连接到域控制器时要使用的帐户名称。该字符串必须指定域 NetBIOS 名称和用户帐户(例如，"REDMOND\user")，或者指定 Internet 式登录名称(例如，"someone@microsoft.com")形式的用户主体名称(UPN)。如果此参数为 NULL，则使用调用方的上下文。如果使用空字符串，则传递空密码
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <returns></returns>
        public uint UnjoinDomainOrWorkgroup(uint FUnjoinOptions, string Password, string UserName)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("UnjoinDomainOrWorkgroup");
                inParams["FUnjoinOptions"] = NetValueToWmi(CimType.UInt32, FUnjoinOptions);
                inParams["Password"] = NetValueToWmi(CimType.String, Password);
                inParams["UserName"] = NetValueToWmi(CimType.String, UserName);
                var output = classObj.InvokeMethod("UnjoinDomainOrWorkgroup", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// UnjoinDomainOrWorkgroup 方法从域或工作组中取消某个计算机系统的加入或从中删除某个计算机系统。此方法仅适用于 Windows 2000 及更高版本的平台。该方法可能返回的值如下: 
        /// 0 - 成功。
        /// 其他 - 有关上列值以外的整数值，请参阅 Win32 错误代码文档。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。
        /// </summary>
        /// <param name="FUnjoinOptions">FUnjoinOptions 参数指定取消加入选项。如果此参数是 NETSETUP_ACCT_DELETE，则在取消加入时将禁用帐户。注意: 此选项不会删除帐户。目前未定义其他取消加入选项。
        /// 
        /// 2 位 - 删除帐户 - 离开域时删除帐户。
        /// 如果不涉及任何选项，则该方法返回 0。</param>
        /// <param name="Password">如果 UserName 参数指定了帐户名称，则 Password 参数必须指向连接到域控制器时要使用的密码。否则，此参数必须为 NULL。
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <param name="UserName">Username 参数是一个指向以空字符结尾的常量字符串的指针，该字符串指定连接到域控制器时要使用的帐户名称。该字符串必须指定域 NetBIOS 名称和用户帐户(例如，"REDMOND\user")，或者指定 Internet 式登录名称(例如，"someone@microsoft.com")形式的用户主体名称(UPN)。如果此参数为 NULL，则使用调用方的上下文。如果使用空字符串，则传递空密码
        /// 当域计算机连接到其 IWbemServices ptr 上的 winmgmt(即在获取 IWbemServices 接口的调用中)或 SetProxyBlanket 时，Password 和 Username 必须使用高级身份验证(即不低于 RPC_C_AUTHN_LEVEL_PKT_PRIVACY)。如果对于 winmgmt 而言，它们是本地参数，则不必考虑上述问题，原因在于不仅其身份验证级别与 RPC_C_AUTHN_LEVEL_PKT_PRIVACY 相当，而且其客户端请求从不通过连接到达 winmgmt。
        /// 如果将 Password 和 Username 留空，提供程序并不会在意。
        /// 如果提供程序认为身份验证级别过低，并且指定了 Password 和 Username，则返回 WBEM_E_ENCRYPTED_CONNECTION_REQUIRED。</param>
        /// <returns></returns>
        public uint UnjoinDomainOrWorkgroup(Entites.Win32_ComputerSystemEntity entity, uint FUnjoinOptions, string Password, string UserName)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("UnjoinDomainOrWorkgroup");
            inParams["FUnjoinOptions"] = NetValueToWmi(CimType.UInt32, FUnjoinOptions);
            inParams["Password"] = NetValueToWmi(CimType.String, Password);
            inParams["UserName"] = NetValueToWmi(CimType.String, UserName);
            var output = classObj.InvokeMethod("UnjoinDomainOrWorkgroup", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
    }
}
