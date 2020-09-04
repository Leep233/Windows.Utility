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
        public static extern int ShowWindow(IntPtr hWnd, WindowStatus nCmdShow);

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
        /// 合成击键。系统可以使用这样的合成按键来生成WM_KEYUP或WM_KEYDOWN消息。键盘驱动程序的中断处理程序将调用keybd_event函数
        /// </summary>
        /// <param name="vKey">虚拟密钥代码。该代码必须是1到254之间的值。有关完整列表，请参阅</param>
        /// <param name="scan">密钥的硬件扫描代码</param>
        /// <param name="flags">控制功能操作的各个方面 0 按下 2释放</param>
        /// <param name="extraInfo">与击键关联的附加值</param>
        [DllImport("user32.dll")]
        public extern static void keybd_event(VirtualKeyCodes vKey, byte scan, int flags, UIntPtr extraInfo);

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

        /// <summary>
        /// 找到窗口句柄
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 设置一个窗口
        /// </summary>
        /// <param name="hWnd">窗口的句柄</param>
        /// <param name="hWndInsertAfter">
        /// 在Z顺序中位于定位的窗口之前的窗口的句柄。此参数必须是窗口句柄或以下值之一：
        /// -2：将窗口放置在所有非最上面的窗口上方（即，所有最上面的窗口的后面）。如果窗口已经是非最上面的窗口，则此标志无效
        /// -1：将窗口置于所有非最上面的窗口上方。即使禁用窗口，窗口也将保持其最高位置
        /// 0：将窗口置于Z顺序的顶部
        /// 1 ：将窗口置于Z顺序的底部。如果hWnd参数标识了最顶部的窗口，则该窗口将失去其最顶部的状态，并放置在所有其他窗口的底部；
        /// 
        /// </param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <param name="uFlags">窗口大小和位置标志。此参数可以是以下值的组合：
        /// 值	含义
        ///        SWP_ASYNCWINDOWPOS
        ///0x4000
        ///如果调用线程和拥有窗口的线程连接到不同的输入队列，则系统会将请求发布到拥有窗口的线程。这样可以防止在其他线程处理请求时调用线程阻塞其执行。
        ///SWP_DEFERERASE
        ///0x2000
        ///防止生成WM_SYNCPAINT消息。
        ///SWP_DRAWFRAME
        ///0x0020
        ///在窗口周围绘制框架（在窗口的类描述中定义）。
        ///SWP_FRAMECHANGED
        ///0x0020
        ///应用使用SetWindowLong函数设置的新框架样式。即使未更改窗口的大小，也向该窗口发送WM_NCCALCSIZE消息。如果未指定此标志，则仅在更改窗口大小时才发送WM_NCCALCSIZE。
        ///SWP_HIDEWINDOW
        ///0x0080
        ///隐藏窗口。
        ///SWP_NOACTIVATE
        ///0x0010
        ///不激活窗口。如果未设置此标志，则激活窗口并将其移至最顶层或非顶层组的顶部（取决于hWndInsertAfter参数的设置）。
        ///SWP_NOCOPYBITS
        ///0x0100
        ///丢弃客户区的全部内容。如果未指定此标志，则在调整窗口大小或位置后，将保存客户区的有效内容并将其复制回客户区。
        ///SWP_NOMOVE
        ///0x0002
        ///保留当前位置（忽略X和Y参数）。
        ///SWP_NOOWNERZORDER
        ///0x0200
        ///不更改所有者窗口在Z顺序中的位置。
        ///SWP_NOREDRAW
        ///0x0008
        ///不重绘更改。如果设置了此标志，则不会进行任何重绘。这适用于工作区，非工作区（包括标题栏和滚动条）以及由于移动窗口而未显示的父窗口的任何部分。设置此标志后，应用程序必须显式使窗口和父窗口中需要重绘的任何部分无效或重绘。
        ///SWP_NOREPOSITION
        ///0x0200
        ///与SWP_NOOWNERZORDER标志相同。
        ///SWP_NOSENDCHANGING
        ///0x0400
        ///阻止窗口接收WM_WINDOWPOSCHANGING消息。
        ///SWP_NOSIZE
        ///0x0001
        ///保留当前大小（忽略cx和cy参数）。
        ///SWP_NOZORDER
        ///0x0004
        ///保留当前的Z顺序（忽略hWndInsertAfter参数）。
        ///SWP_SHOWWINDOW
        ///0x0040 
        /// 显示窗口
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        /// <summary>
        /// 向指定窗口发送消息
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 此函数更改指定窗口的属性。SetWindowLong还将指定偏移量的32位（LONG）值设置到窗口的额外窗口内存中
        /// </summary>
        /// <param name="hwnd">处理窗口，并间接处理窗口所属的类</param>
        /// <param name="index">指定要设置的值的从零开始的偏移量。
        /// 有效值的范围是零到额外的窗口内存的字节数减去4；
        /// 例如，如果您指定12个或更多字节的额外内存，
        /// 则值8将是第三个32位整数的索引。对于Windows Embedded CE
        /// ，字节偏移量必须为4字节的倍数
        /// GWL_EXSTYLE:
        /// 设置新的扩展窗口样式。
        ///GWL_STYLE:
        ///设置新的窗口样式。GWL_WNDPROC:
        ///设置窗口过程的新地址。如果窗口与调用线程不属于同一进程，则不能更改此属性。
        ///GWL_ID:
        ///设置窗口的新标识符。
        ///GWL_USERDATA:
        ///设置与窗口关联的32位值。每个窗口都有一个对应的32位值，供创建该窗口的应用程序使用。Windows CE 2.0和更高版本支持此值，但Windows CE 1.0和1.01不支持
        ///当hWnd参数标识对话框时，以下值也可用。DWL_DLGPROC:
        /// 设置对话框过程的新地址。Windows CE 2.0和更高版本支持此值，但Windows CE 1.0和1.01不支持。
        /// DWL_MSGRESULT:
        /// 设置在对话框过程中处理的消息的返回值。
        /// DWL_USER:
        /// 设置应用程序专用的新的额外信息，例如句柄或指针</param>
        /// <param name="newLong">指定替换值</param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int SetWindowLong(IntPtr hwnd, int index, IntPtr newLong);

        /// <summary>
        /// 此函数检索有关指定窗口的信息。GetWindowLong还将指定偏移量的32位（长）值检索到窗口的额外窗口存储器中。
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

    }
}
