// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xListFontsReply" /> struct.</summary>
    public static unsafe partial class xListFontsReplyTests
    {
        /// <summary>Validates that the <see cref="xListFontsReply" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xListFontsReply>(), Is.EqualTo(sizeof(xListFontsReply)));
        }

        /// <summary>Validates that the <see cref="xListFontsReply" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xListFontsReply).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xListFontsReply" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xListFontsReply), Is.EqualTo(32));
        }
    }
}
