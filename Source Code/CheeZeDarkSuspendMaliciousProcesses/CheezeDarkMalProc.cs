using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CheeZeDarkSuspendMaliciousProcesses
{
    public class CheezeDarkMalProc
    {
        [DllImport("ntdll.dll", PreserveSig = false)]
        public static extern void NtSuspendProcess(IntPtr processHandle);
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);

        public IntPtr anti_cheatengine;
        public IntPtr anti_virtualbox;
        public bool SuspendCheatEngine()
        {
            Process[] x = Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2.exe");
            foreach(Process cheatengine in x)
            {
                anti_cheatengine = cheatengine.Handle;
                NtSuspendProcess(anti_cheatengine);
                return true;
            }
            return false;
        }
        public void SuspendVirtualBox()
        {
            Process[] vbox = Process.GetProcessesByName("virtualbox.exe");
            foreach(Process vboox in vbox)
            {
                anti_virtualbox = vboox.Handle;
                NtSuspendProcess(anti_virtualbox);
            }
        }
        public void KillMaliciousProcess(string proc_name)
        {
            Process[] xxx = Process.GetProcessesByName(proc_name);
            foreach(Process man in xxx)
            {
                man.Kill();
            }
        }
        public bool CallBSOD()
        {
            RtlSetProcessIsCritical(1, 0, 0);
            Process.GetCurrentProcess().Kill();
            return true;
        }
        public static byte[] GetByteFile(string file)
        {
            byte[] byt = File.ReadAllBytes(file);
            return byt;
        }
    }
}
