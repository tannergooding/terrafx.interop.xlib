// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XKeymapEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public IntPtr display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("char [32]")]
        public fixed sbyte key_vector[32];
    }
}
