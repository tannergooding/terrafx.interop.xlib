// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct XClientMessageEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public IntPtr display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Atom")]
        public nuint message_type;

        public int format;

        [NativeTypeName("union (anonymous union at /usr/include/X11/Xlib.h:905:2)")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("char [20]")]
            public fixed sbyte b[20];

            [FieldOffset(0)]
            [NativeTypeName("short [10]")]
            public fixed short s[10];

            [FieldOffset(0)]
            [NativeTypeName("long [5]")]
            public _l_e__FixedBuffer l;

            public partial struct _l_e__FixedBuffer
            {
                public nint e0;
                public nint e1;
                public nint e2;
                public nint e3;
                public nint e4;

                public ref nint this[int index]
                {
                    get
                    {
                        return ref AsSpan()[index];
                    }
                }

                public Span<nint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 5);
            }
        }
    }
}
