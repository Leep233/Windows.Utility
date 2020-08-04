using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windows.Utility.Win32.API.Enums
{
    /// <summary>
    /// 
    /// </summary>
   public class Display
    {
        /// <summary>
        /// 检索显示设备的当前设置。
        /// </summary>
        public const int ENUM_CURRENT_SETTINGS = -1;
        /// <summary>
        /// 检索当前存储在注册表中的显示设备设置
        /// </summary>
        public const int ENUM_REGISTRY_SETTINGS = -2;    

     
    }
    /// <summary>
    /// 设置分辨率flags
    /// </summary>
    public enum ChangeDisplaySettingsFlags
    {
        /// <summary>
        /// 当前屏幕的图形模式将动态更改，并且图形模式将在注册表中更新。模式信息存储在USER配置文件中。
        /// </summary>
        CDS_UPDATEREGISTRY = 0x00000001,
        /// <summary>
        /// 系统测试是否可以设置请求的图形模式
        /// </summary>
        CDS_TEST = 0x00000002,
        /// <summary>
        /// 该模式本质上是临时的,如果在另一个桌面之间切换，则此模式将不会重置
        /// </summary>
        CDS_FULLSCREEN = 0x00000004,
        /// <summary>
        /// 这些设置将保存在全局设置区域中，这样它们将影响计算机上的所有用户。
        /// 否则，仅修改用户设置。
        /// 仅当使用CDS_UPDATEREGISTRY标志指定时，此标志才有效
        /// </summary>
        CDS_GLOBAL = 0x00000008,
        /// <summary>
        /// 该设备将成为主要设备
        /// </summary>
        CDS_SET_PRIMARY = 0x00000010,
        /// <summary>
        /// 设置后，lParam参数是指向VIDEOPARAMETERS结构的指针
        /// </summary>
        CDS_VIDEOPARAMETERS = 0x00000020,
        /// <summary>
        /// 将设置更改为不安全的图形模式
        /// </summary>
        CDS_ENABLE_UNSAFE_MODES = 0x00000100,
        /// <summary>
        /// 禁用对不安全图形模式的设置更改
        /// </summary>
        CDS_DISABLE_UNSAFE_MODES = 0x00000200,
        /// <summary>
        /// 即使请求的设置与当前设置相同，也应更改设置
        /// </summary>
        CDS_RESET = 0x40000000,
        CDS_RESET_EX = 0x20000000,
        /// <summary>
        /// 设置将保存在注册表中，但不会生效。仅当使用CDS_UPDATEREGISTRY标志指定时，此标志才有效
        /// </summary>
        CDS_NORESET = 0x10000000
    }
    /// <summary>
    /// 设置分辨率 返回值
    /// </summary>
    public enum ChangeDisplaySettingsReturnCode 
    {
        /// <summary>
        /// 设置更改成功
        /// </summary>
        DISP_CHANGE_SUCCESSFUL =    0,
        /// <summary>
        /// 必须重新启动计算机，图形模式才能正常工作
        /// </summary>
        DISP_CHANGE_RESTART =    1,
        /// <summary>
        /// 显示驱动程序在指定的图形模式下失败
        /// </summary>
        DISP_CHANGE_FAILED =   -1,
        /// <summary>
        /// 不支持图形模式
        /// </summary>
        DISP_CHANGE_BADMODE =   -2,
        /// <summary>
        /// 无法将设置写入注册表
        /// </summary>
        DISP_CHANGE_NOTUPDATED =   -3,
        /// <summary>
        /// 传递了无效的标志集
        /// </summary>
        DISP_CHANGE_BADFLAGS =   -4,
        /// <summary>
        /// 传递了无效的参数。这可以包括无效的标志或标志的组合
        /// </summary>
        DISP_CHANGE_BADPARAM =   -5,
        /// <summary>
        /// 设置更改失败，因为该系统具有DualView功能
        /// </summary>
        DISP_CHANGE_BADDUALVIEW =   -6
    }
    /// <summary>
    /// 显示方向
    /// </summary>
    public enum DisplayOrientation
    {
        /// <summary>
        /// 默认
        /// </summary>
        Default,
        /// <summary>
        /// 90
        /// </summary>
        _90,
        /// <summary>
        /// 180
        /// </summary>
        _180,
        /// <summary>
        /// 270
        /// </summary>
        _270
    }

}
