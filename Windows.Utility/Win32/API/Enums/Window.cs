using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windows.Utility.Win32.API.Enums
{
    /// <summary>
    /// 窗口状态
    /// </summary>
   public enum WindowStatus:int
    {
        /// <summary>
        /// 最小化一个窗口，即使拥有该窗口的线程没有响应。仅当最小化来自其他线程的窗口时，才应使用此标志。
        /// </summary>
        SW_FORCEMINIMIZE = 11,
        /// <summary>
        /// 隐藏该窗口并激活另一个窗口
        /// </summary>
        SW_HIDE = 0,
        /// <summary>
        /// 最大化指定的窗口
        /// </summary>
        SW_MAXIMIZE = 3,
        /// <summary>
        /// 最小化指定的窗口并按Z顺序激活下一个顶级窗口
        /// </summary>
        SW_MINIMIZE = 6,
        /// <summary>
        /// 激活并显示窗口。如果窗口最小化或最大化，则系统会将其还原到其原始大小和位置。恢复最小化窗口时，应用程序应指定此标志
        /// </summary>
        SW_RESTORE = 9,
        /// <summary>
        /// 激活窗口并以其当前大小和位置显示它
        /// </summary>
        SW_SHOW = 5,
        /// <summary>
        /// 根据启动应用程序的程序传递给CreateProcess函数的STARTUPINFO结构中指定的SW_值设置显示状态
        /// </summary>
        SW_SHOWDEFAULT = 10,
        /// <summary>
        /// 激活窗口并将其显示为最大化窗口
        /// </summary>
        SW_SHOWMAXIMIZED = 3,
        /// <summary>
        /// 激活窗口并将其显示为最小化窗口
        /// </summary>
        SW_SHOWMINIMIZED = 2,
        /// <summary>
        /// 将窗口显示为最小化窗口。该值类似于SW_SHOWMINIMIZED，除了未激活窗口
        /// </summary>
        SW_SHOWMINNOACTIVE = 7,
        /// <summary>
        /// 以当前大小和位置显示窗口。该值与SW_SHOW相似，除了不激活窗口
        /// </summary>
        SW_SHOWNA = 8,
        /// <summary>
        /// 显示窗口的最新大小和位置。该值类似于SW_SHOWNORMAL，除了未激活窗口
        /// </summary>
        SW_SHOWNOACTIVATE = 4,
        /// <summary>
        /// 激活并显示一个窗口。如果窗口最小化或最大化，则系统会将其还原到其原始大小和位置。首次显示窗口时，应用程序应指定此标志
        /// </summary>
        SW_SHOWNORMAL = 1
    }
}
