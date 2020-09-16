// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PutImageReq" /> struct.</summary>
    public static unsafe class PutImageReqTests
    {
        /// <summary>Validates that the <see cref="PutImageReq" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PutImageReq>(), Is.EqualTo(sizeof(PutImageReq)));
        }

        /// <summary>Validates that the <see cref="PutImageReq" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PutImageReq).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PutImageReq" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PutImageReq), Is.EqualTo(24));
        }
    }
}
