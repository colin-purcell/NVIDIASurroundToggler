﻿namespace NVIDIASurroundToggle.Native.Enums
{
    using System;

    [Flags]
    public enum WindowStyles : uint
    {
        Border = 0x00800000,

        Caption = 0x00C00000,

        Child = 0x40000000,

        Childwindow = 0x40000000,

        Clipchildren = 0x02000000,

        Clipsiblings = 0x04000000,

        Disabled = 0x08000000,

        Dlgframe = 0x00400000,

        Group = 0x00020000,

        HScroll = 0x00100000,

        Iconic = 0x20000000,

        Maximize = 0x01000000,

        MaximizeBox = 0x00010000,

        Minimize = 0x20000000,

        MinimizeBox = 0x00020000,

        Overlapped = 0x00000000,

        OverlappedWindow = Overlapped | Caption | SysMenu | ThickFrame | MinimizeBox | MaximizeBox,

        Popup = 0x80000000,

        PopupWindow = Popup | Border | SysMenu,

        SizeBox = 0x00040000,

        SysMenu = 0x00080000,

        TabStop = 0x00010000,

        ThickFrame = 0x00040000,

        Tiled = 0x00000000,

        TiledWindow = Overlapped | Caption | SysMenu | ThickFrame | MinimizeBox | MaximizeBox,

        Visible = 0x10000000,

        VScroll = 0x00200000,

        AcceptFiles = 0x00000010,

        AppWindow = 0x00040000,

        ClientEdge = 0x00000200,

        Composited = 0x02000000,

        ContextHelp = 0x00000400,

        ControlParent = 0x00010000,

        DlgModalFrame = 0x00000001,

        Layered = 0x00080000,

        LayoutRtl = 0x00400000,

        Left = 0x00000000,

        LeftScrollbar = 0x00004000,

        LtrReading = 0x00000000,

        MdiChild = 0x00000040,

        NoActivate = 0x08000000,

        NoInheritLayout = 0x00100000,

        NoParentNotify = 0x00000004,

        NoReDirectionBitmap = 0x00200000,

        PaletteWindow = WindowEdge | ToolWindow | TopMost,

        Right = 0x00001000,

        RightScrollbar = 0x00000000,

        RtlReading = 0x00002000,

        StaticEdge = 0x00020000,

        ToolWindow = 0x00000080,

        TopMost = 0x00000008,

        Transparent = 0x00000020,

        WindowEdge = 0x00000100
    }
}