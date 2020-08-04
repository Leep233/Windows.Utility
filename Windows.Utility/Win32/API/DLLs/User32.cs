using System;
using System.Runtime.InteropServices;
using Windows.Utility.Win32.API.Enums;
using Windows.Utility.Win32.API.Structs;

namespace Windows.Utility.Win32.API.DLLs
{
    public class User32
    {
        /// <summary>
        /// 使用EnumDisplayDevices函数可以获取有关当前会话中的显示设备的信息。
        /// </summary>
        /// <param name="deviceName">指向设备名称的指针。如果为NULL，则函数根据iDevNum返回有关计算机上显示适配器的信息</param>
        /// <param name="devNum">指定感兴趣的显示设备的索引值操作系统用索引值标识当前会话中的每个显示设备。索引值是从0开始的连续整数。
        /// 例如，如果当前会话具有三个显示设备，则它们由索引值0、1和2指定</param>
        /// <param name="displayinfo">该结构接收有关iDevNum指定的显示设备的信息</param>
        /// <param name="flag">将此标志设置为EDD_GET_DEVICE_INTERFACE_NAME（0x00000001）
        /// ，以检索GUID_DEVINTERFACE_MONITOR的设备接口名称，该名称由操作系统在每个监视器的基础上注册。该值放置在lpDisplayDevice返回的DISPLAY_DEVICE结构的DeviceID成员中。
        /// 生成的设备接口名称可与SetupAPI函数一起使用，并用作GDI监视器设备和SetupAPI监视器设备之间的链接</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int EnumDisplayDevices(string deviceName, int devNum, ref DisplayDevice displayinfo, int flag);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceName"></param>
        /// <param name="modeNum"></param>
        /// <param name="devMode"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettings(string deviceName, int modeNum, ref DevMode devMode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="devMode"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(ref DevMode devMode, int flags);

        /// <summary>
        /// 显示窗口
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nCmdShow"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern int ShowWindow(IntPtr hWnd, WindowStatus nCmdShow );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isShow"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int ShowCursor(bool isShow);

        /// <summary>   
        /// 获取鼠标的坐标   
        /// </summary>   
        /// <param name="">传址参数，坐标point类型</param>   
        /// <returns>获取成功返回真</returns>   
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point pt);

        /// <summary>
        /// 设置鼠标指针位置
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [DllImport("user32.dll")]
        public extern static void SetCursorPos(int x, int y);
        /// <summary>
        /// 鼠标事件
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="data"></param>
        /// <param name="extraInfo"></param>
        [DllImport("user32.dll")]
        public extern static void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);

        /// <summary>
        /// 指定窗口的边界矩形相交的面积最大的显示监视器。
        /// </summary>
        /// <param name="hwnd">感兴趣窗口的句柄</param>
        /// <param name="flags">如果窗口未与任何显示监视器相交，则确定函数的返回值 0:返回NULL 1:返回主显示监视器的句柄 2:返回离窗口最近的显示监视器的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public extern static IntPtr MonitorFromWindow(IntPtr hwnd, int flags);


        //ToAscii职能的转换指定的虚拟键码和键盘状态的相应字符或字符
        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, //[in] 指定虚拟关键代码进行翻译。
                                         int uScanCode, // [in] 指定的硬件扫描码的关键须翻译成英文。高阶位的这个值设定的关键，如果是（不压）
                                         byte[] lpbKeyState, // [in] 指针，以256字节数组，包含当前键盘的状态。每个元素（字节）的数组包含状态的一个关键。如果高阶位的字节是一套，关键是下跌（按下）。在低比特，如果设置表明，关键是对切换。在此功能，只有肘位的CAPS LOCK键是相关的。在切换状态的NUM个锁和滚动锁定键被忽略。
                                         byte[] lpwTransKey, // [out] 指针的缓冲区收到翻译字符或字符。
                                         int fuState); // [in] Specifies whether a menu is active. This parameter must be 1 if a menu is active, or 0 otherwise.

        //获取按键的状态
        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int vKey);


        /// <summary>
        /// 使用此功能，安装了一个钩子
        /// </summary>
        /// <param name="idHook">HookEnum 类型</param>
        /// <param name="lpfn"></param>
        /// <param name="hInstance"></param>
        /// <param name="threadId"></param>
        /// <returns>成功返回钩子句柄</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, WindowProc lpfn, IntPtr hInstance, int threadId);

        /// <summary>
        /// 调用此函数卸载钩子
        /// </summary>
        /// <param name="idHook"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);


        /// <summary>
        /// 使用此功能，通过信息钩子继续下一个钩子
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);


    }
}
