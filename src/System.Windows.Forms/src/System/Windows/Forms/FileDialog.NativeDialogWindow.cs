// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    public abstract partial class FileDialog
    {
        private sealed class NativeDialogWindow : IWin32Window
        {
            private readonly HandleRef _handle;

            public NativeDialogWindow(HandleRef handle)
            {
                if (handle.Handle == IntPtr.Zero)
                {
                    throw new ArgumentException("A valid window handle is required.", nameof(handle));
                }

                _handle = handle;
            }

            public IntPtr Handle => _handle.Handle;
        }
    }
}
