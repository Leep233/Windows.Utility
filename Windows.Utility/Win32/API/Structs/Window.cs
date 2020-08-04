using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Windows.Utility.Win32.API.Structs
{
    public delegate int WindowProc(int code, IntPtr wParam, IntPtr lParam);

    /// <summary>
    /// 键盘结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class KeyboardHookStruct
    {
        /// <summary>
        /// 定一个虚拟键码。该代码必须有一个价值的范围1至254
        /// </summary>
        public int vkCode;  //
        /// <summary>
        /// 指定的硬件扫描码的关键
        /// </summary>
        public int scanCode; // 
        /// <summary>
        /// 键标志
        /// </summary>
        public int flags;  // 
        /// <summary>
        /// 指定的时间戳记的这个讯息
        /// </summary>
        public int time; // 
        /// <summary>
        /// 指定额外信息相关的信息
        /// </summary>
        public int dwExtraInfo; // 
    }

    /// <summary>
    /// 输入通知
    /// </summary>
    public enum InputNotificationEnum : uint 
    {
        /// <summary>
        /// 发送到激活的窗口和禁用的窗口。如果窗口使用相同的输入队列，则消息将同步发送，首先发送到停用的顶层窗口的窗口过程，然后发送到激活的顶层窗口的窗口过程。如果窗口使用不同的输入队列，则消息将异步发送，因此将立即激活窗口
        /// </summary>
        WM_ACTIVATE =                 0x0006,
        /// <summary>
        /// 通知窗口用户已生成应用程序命令事件，例如，通过使用鼠标单击应用程序命令按钮或在键盘上键入应用程序命令键
        /// </summary>
        WM_APPCOMMAND =               0x0319,
        /// <summary>
        /// 当TranslateMessage函数翻译WM_KEYDOWN消息时，将其发布到具有键盘焦点的窗口中。该WM_CHAR消息包含被按下的键的字符代码
        /// </summary>
        WM_CHAR =               0x0102,
        /// <summary>
        /// 通过TranslateMessage函数翻译WM_KEYUP消息时，将焦点发布到带有键盘焦点的窗口中。WM_DEADCHAR指定由死键生成的字符代码。死键是生成诸如变音符（双点）之类的字符的键，该字符与另一个字符组合以形成复合字符。例如，通过键入变音符的死键，然后键入O键来生成变音符-字符（）
        /// </summary>
        WM_DEADCHAR =           0x0103,

        /// <summary>
        /// 用户按下RegisterHotKey函数注册的热键时发布。消息位于与注册热键的线程关联的消息队列的顶部
        /// <para>wParam  -2 按下了“快照桌面”热键</para>
        /// <para>wParam  -1 按下了“快照窗口”热键</para>
        /// </summary>
        WM_HOTKEY =         0x0312,
        /// <summary>
        /// 当按下非系统键时，以键盘焦点将其发布到窗口中。非系统键是当未按下ALT键时按下的键
        /// </summary>
        WM_KEYDOWN =               0x0100,
        /// <summary>
        /// 释放非系统键时，以键盘焦点将其发布到窗口中。非系统关键是当ALT键被按下一个键没有按下，或者当按下一个窗口有键盘焦点键盘键
        /// </summary>
        WM_KEYUP =           0x0101,
        /// <summary>
        /// 在失去键盘焦点之前立即发送到窗口
        /// </summary>
        WM_KILLFOCUS =          0x0008,
        /// <summary>
        /// 获得键盘焦点后发送到窗口
        /// </summary>
        M_SETFOCUS =             0x0007,
        /// <summary>
        /// 当TranslateMessage函数转换WM_SYSKEYDOWN消息时，发送到具有键盘焦点的窗口。WM_SYSDEADCHAR指定系统死键（即在按住ALT键的同时按下的死键）的字符代码
        /// </summary>
        WM_SYSDEADCHAR =         0x0107,
        /// <summary>
        /// 当用户按下F10键（激活菜单栏）或按住ALT键，然后按下另一个键时，将其发布到具有键盘焦点的窗口中。当当前没有窗口具有键盘焦点时，也会发生这种情况。在这种情况下，WM_SYSKEYDOWN消息将发送到活动窗口。接收消息的窗口可以通过检查lParam参数中的上下文代码来区分这两个上下文
        /// </summary>
        WM_SYSKEYDOWN =          0x0104,
        /// <summary>
        /// 当用户释放在按住ALT键的同时释放的键时，将其发布到具有键盘焦点的窗口中。当当前没有窗口具有键盘焦点时，也会发生这种情况。在这种情况下，WM_SYSKEYUP消息将发送到活动窗口。接收消息的窗口可以通过检查lParam参数中的上下文代码来区分这两个上下文。        窗口通过其WindowProc函数接收此消息
        /// </summary>
        WM_SYSKEYUP =               0x0105,
        /// <summary>
        /// 该WM_UNICHAR消息可以由一个应用程序用于发布输入到其他窗口。此消息包含所按下键的字符代码。（通过发送wParam设置为UNICODE_NOCHAR的消息来测试目标应用程序是否可以处理WM_UNICHAR消息。）
        /// </summary>
        WM_UNICHAR =             0x0109,
    }

    /// <summary>
    /// 安装的挂钩过程的类型
    /// </summary>
    public enum HookEnum {
        /// <summary>
        /// 在系统将消息发送到目标窗口过程之前，安装用于监视消息的挂钩过程。有关更多信息，请参见CallWndProc挂接过程
        /// </summary>
        WH_CALLWNDPROC = 4,
        /// <summary>
        /// 安装挂钩过程，以监视目标窗口过程处理完的消息。有关更多信息，请参见CallWndRetProc挂接过程
        /// </summary>
        WH_CALLWNDPROCRET = 12,
        /// <summary>
        /// 安装一个挂钩程序，该程序接收对CBT应用程序有用的通知。有关更多信息，请参见CBTProc挂钩过程
        /// </summary>
        WH_CBT = 5,
        /// <summary>
        /// 安装一个挂钩程序，对于调试其他挂钩程序很有用。有关更多信息，请参见DebugProc挂钩过程
        /// </summary>
        WH_DEBUG = 9,
        /// <summary>
        /// 安装一个挂钩程序，当应用程序的前台线程即将变为空闲时将调用该挂钩程序。该挂钩对于在空闲时间执行低优先级任务很有用。有关更多信息，请参见ForegroundIdleProc挂钩过程
        /// </summary>
        WH_FOREGROUNDIDLE = 11,
        /// <summary>
        /// 安装挂钩过程，以监视发布到消息队列的消息。有关更多信息，请参见GetMsgProc挂钩过程
        /// </summary>
        WH_GETMESSAGE = 3,
        /// <summary>
        /// 安装一个挂钩程序，该程序发布以前由WH_JOURNALRECORD挂钩程序记录的消息。有关更多信息，请参见JournalPlaybackProc挂钩过程
        /// </summary>
        WH_JOURNALPLAYBACK = 1,
        /// <summary>
        /// 安装一个挂钩过程，该过程记录发布到系统消息队列中的输入消息。该钩子对于记录宏很有用。有关更多信息，请参见JournalRecordProc挂钩过程
        /// </summary>
        WH_JOURNALRECORD = 0,
        /// <summary>
        /// 安装挂钩过程，以监视击键消息。有关更多信息，请参见KeyboardProc挂钩过程
        /// </summary>
        WH_KEYBOARD = 2,
        /// <summary>
        /// 安装钩子程序，以监视低级键盘输入事件。有关更多信息，请参见LowLevelKeyboardProc挂钩过程
        /// </summary>
        WH_KEYBOARD_LL = 13,
        /// <summary>
        /// 安装监视鼠标消息的挂钩过程。有关更多信息，请参见MouseProc挂钩过程
        /// </summary>
        WH_MOUSE = 7,
        /// <summary>
        /// 安装钩子过程，以监视低级鼠标输入事件。有关更多信息，请参见LowLevelMouseProc挂钩过程
        /// </summary>
        WH_MOUSE_LL = 14,
        /// <summary>
        /// 安装挂钩过程，以监视对话框，消息框，菜单或滚动条中由于输入事件而生成的消息。有关更多信息，请参见MessageProc挂钩过程
        /// </summary>
        WH_MSGFILTER = -1,
        /// <summary>
        /// 安装一个挂钩程序，该程序接收对外壳程序有用的通知。有关更多信息，请参见ShellProc挂钩过程
        /// </summary>
        WH_SHELL = 10,
        /// <summary>
        /// 安装挂钩过程，以监视对话框，消息框，菜单或滚动条中由于输入事件而生成的消息。挂钩过程会在与调用线程相同的桌面中监视所有应用程序的这些消息。有关更多信息，请参见SysMsgProc挂接过程
        /// </summary>
        WH_SYSMSGFILTER = 6,
    }

}
