// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public partial struct xCreateGlyphCursorReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint cid;

        [NativeTypeName("CARD32")]
        public uint source;

        [NativeTypeName("CARD32")]
        public uint mask;

        [NativeTypeName("CARD16")]
        public ushort sourceChar;

        [NativeTypeName("CARD16")]
        public ushort maskChar;

        [NativeTypeName("CARD16")]
        public ushort foreRed;

        [NativeTypeName("CARD16")]
        public ushort foreGreen;

        [NativeTypeName("CARD16")]
        public ushort foreBlue;

        [NativeTypeName("CARD16")]
        public ushort backRed;

        [NativeTypeName("CARD16")]
        public ushort backGreen;

        [NativeTypeName("CARD16")]
        public ushort backBlue;
    }
}
