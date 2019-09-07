// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XIMStringConversionText
    {
        [NativeTypeName("unsigned short")]
        public ushort length;

        [NativeTypeName("XIMStringConversionFeedback *")]
        public UIntPtr* feedback;

        public int encoding_is_wchar;

        [NativeTypeName("union (anonymous union at /usr/include/X11/Xlib.h:1295:5)")]
        public _string__AnonymousRecord @string;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _string__AnonymousRecord
        {
            [FieldOffset(0)]
            [NativeTypeName("char *")]
            public sbyte* mbs;

            [FieldOffset(0)]
            [NativeTypeName("wchar_t *")]
            public int* wcs;
        }
    }
}