// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public partial struct xSetClipRectanglesReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        public byte ordering;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint gc;

        [NativeTypeName("INT16")]
        public short xOrigin;

        [NativeTypeName("INT16")]
        public short yOrigin;
    }
}
