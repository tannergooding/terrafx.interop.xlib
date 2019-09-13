// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XReparentEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public UIntPtr display;

        [NativeTypeName("Window")]
        public UIntPtr @event;

        [NativeTypeName("Window")]
        public UIntPtr window;

        [NativeTypeName("Window")]
        public UIntPtr parent;

        public int x;

        public int y;

        public int override_redirect;
    }
}
