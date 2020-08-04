using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Windows.Utility.Win32.API.DLLs
{
   public class Kernel32
    {
        [DllImport("Kernel32.dll")]
        public extern static int GetLastError();


        // 取得当前线程编号（线程钩子需要用到）
        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        //使用WINDOWS API函数代替获取当前实例的函数,防止钩子失效
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);
    }
}
