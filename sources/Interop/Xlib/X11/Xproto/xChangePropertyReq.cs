// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib;

public unsafe partial struct xChangePropertyReq
{
    [NativeTypeName("CARD8")]
    public byte reqType;

    [NativeTypeName("CARD8")]
    public byte mode;

    [NativeTypeName("CARD16")]
    public ushort length;

    [NativeTypeName("CARD32")]
    public uint window;

    [NativeTypeName("CARD32")]
    public uint property;

    [NativeTypeName("CARD32")]
    public uint type;

    [NativeTypeName("CARD8")]
    public byte format;

    [NativeTypeName("BYTE[3]")]
    public fixed byte pad[3];

    [NativeTypeName("CARD32")]
    public uint nUnits;
}
