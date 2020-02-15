// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace System.Windows.Forms
{
    /// <summary>
    /// Provides data for the <see cref="FileDialog.FileOk"/> event.
    /// </summary>
    public sealed class FileDialogCancelEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDialogCancelEventArgs"/> class.
        /// </summary>
        public FileDialogCancelEventArgs(IWin32Window dialogWindow)
        {
            DialogWindow = dialogWindow ?? throw new ArgumentNullException(nameof(dialogWindow));
        }

        /// <summary>
        /// If the application prevents the dialog from closing, it should display a UI to indicate a cause. Use this as
        /// the owner window.
        /// </summary>
        public IWin32Window DialogWindow { get; }
    }
}
