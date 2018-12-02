using System;
using System.Management;
using WMIAccess;
using WmiOperate.Services;
namespace WmiOperate
{
    public class WmiRepository
    {
        private ConnectionOptions options;
        private string address;
        public WmiRepository() { }
        public WmiRepository(ConnectionOptions options, string address) : this()
        {
            this.options = options;
            this.address = address;
        }
        private Win32_Process mWin32_Process;
        public Win32_Process Win32_Process
        {
            get
            {
                if(mWin32_Process == null)
                    mWin32_Process = new Win32_Process(options, address);
                return mWin32_Process;
            }
        }
        private StdRegProv mStdRegProv;
        public StdRegProv StdRegProv
        {
            get
            {
                if(mStdRegProv == null)
                    mStdRegProv = new StdRegProv(options, address);
                return mStdRegProv;
            }
        }
    }
}
