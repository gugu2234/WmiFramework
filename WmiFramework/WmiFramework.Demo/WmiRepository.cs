using System;
using System.Management;
using WmiFramework;
using WmiFramework.Demo.Services;
namespace WmiFramework.Demo
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
        private Win32_Battery mWin32_Battery;
        public Win32_Battery Win32_Battery
        {
            get
            {
                if(mWin32_Battery == null)
                    mWin32_Battery = new Win32_Battery(options, address);
                return mWin32_Battery;
            }
        }
        private Win32_BIOS mWin32_BIOS;
        public Win32_BIOS Win32_BIOS
        {
            get
            {
                if(mWin32_BIOS == null)
                    mWin32_BIOS = new Win32_BIOS(options, address);
                return mWin32_BIOS;
            }
        }
        private Win32_ComputerSystem mWin32_ComputerSystem;
        public Win32_ComputerSystem Win32_ComputerSystem
        {
            get
            {
                if(mWin32_ComputerSystem == null)
                    mWin32_ComputerSystem = new Win32_ComputerSystem(options, address);
                return mWin32_ComputerSystem;
            }
        }
        private Win32_Directory mWin32_Directory;
        public Win32_Directory Win32_Directory
        {
            get
            {
                if(mWin32_Directory == null)
                    mWin32_Directory = new Win32_Directory(options, address);
                return mWin32_Directory;
            }
        }
        private Win32_DiskDrive mWin32_DiskDrive;
        public Win32_DiskDrive Win32_DiskDrive
        {
            get
            {
                if(mWin32_DiskDrive == null)
                    mWin32_DiskDrive = new Win32_DiskDrive(options, address);
                return mWin32_DiskDrive;
            }
        }
        private Win32_Fan mWin32_Fan;
        public Win32_Fan Win32_Fan
        {
            get
            {
                if(mWin32_Fan == null)
                    mWin32_Fan = new Win32_Fan(options, address);
                return mWin32_Fan;
            }
        }
        private Win32_LogicalDisk mWin32_LogicalDisk;
        public Win32_LogicalDisk Win32_LogicalDisk
        {
            get
            {
                if(mWin32_LogicalDisk == null)
                    mWin32_LogicalDisk = new Win32_LogicalDisk(options, address);
                return mWin32_LogicalDisk;
            }
        }
        private Win32_MemoryDevice mWin32_MemoryDevice;
        public Win32_MemoryDevice Win32_MemoryDevice
        {
            get
            {
                if(mWin32_MemoryDevice == null)
                    mWin32_MemoryDevice = new Win32_MemoryDevice(options, address);
                return mWin32_MemoryDevice;
            }
        }
        private Win32_OperatingSystem mWin32_OperatingSystem;
        public Win32_OperatingSystem Win32_OperatingSystem
        {
            get
            {
                if(mWin32_OperatingSystem == null)
                    mWin32_OperatingSystem = new Win32_OperatingSystem(options, address);
                return mWin32_OperatingSystem;
            }
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
        private Win32_Processor mWin32_Processor;
        public Win32_Processor Win32_Processor
        {
            get
            {
                if(mWin32_Processor == null)
                    mWin32_Processor = new Win32_Processor(options, address);
                return mWin32_Processor;
            }
        }
        private Win32_SerialPort mWin32_SerialPort;
        public Win32_SerialPort Win32_SerialPort
        {
            get
            {
                if(mWin32_SerialPort == null)
                    mWin32_SerialPort = new Win32_SerialPort(options, address);
                return mWin32_SerialPort;
            }
        }
        private Win32_UserDesktop mWin32_UserDesktop;
        public Win32_UserDesktop Win32_UserDesktop
        {
            get
            {
                if(mWin32_UserDesktop == null)
                    mWin32_UserDesktop = new Win32_UserDesktop(options, address);
                return mWin32_UserDesktop;
            }
        }
    }
}
