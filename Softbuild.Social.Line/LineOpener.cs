//
//  LineOpener.cs
//
//  Created by Kenji Wada on 2013/03/26.
//  Original Project Created by griffin_stewie on 2013/02/01.
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.

using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Softbuild.Social
{
    public class LineOpener
    {
        private LineOpener()
        {
        }

        private static readonly string LineAppStoreUrl = "https://itunes.apple.com/jp/app/line/id443904275?mt=8";
        private static readonly string LineUrlScheme = "line://";
        private static readonly string LineUrlMessagePath = "msg";

        /// <summary>
        /// Determines if can open line.
        /// </summary>
        /// <returns><c>true</c> if can open line; otherwise, <c>false</c>.</returns>
        public static bool CanOpenLine()
        {
            var shareApp = UIApplication.SharedApplication;
            return shareApp.CanOpenUrl(new NSUrl(LineUrlScheme));
        }

        /// <summary>
        /// Opens the app store.
        /// </summary>
        /// <returns><c>true</c>, if app store was opened, <c>false</c> otherwise.</returns>
        public static bool OpenAppStore() 
        {
            var shareApp = UIApplication.SharedApplication;
            return shareApp.OpenUrl(new NSUrl(LineAppStoreUrl));
        }

        /// <summary>
        /// Opens the line.
        /// </summary>
        /// <returns><c>true</c>, if line was opened, <c>false</c> otherwise.</returns>
        /// <param name="text">Text.</param>
        public static bool OpenLine(string text)
        {
            if (!CanOpenLine())
                return false;

            var encoded = Uri.EscapeDataString(text);
            var url = CreateNSUrl(LineUrlContentTypes.Text, encoded);

            var shareApp = UIApplication.SharedApplication;
            return shareApp.OpenUrl(url);
        }

        /// <summary>
        /// Opens the line.
        /// </summary>
        /// <returns><c>true</c>, if line was opened, <c>false</c> otherwise.</returns>
        /// <param name="image">Image.</param>
        public static bool OpenLine(UIImage image)
        {
            if (!CanOpenLine())
                return false;

            var pasteboard = UIPasteboard.GetUnique();
            pasteboard.SetData(image.AsPNG(), "public.png");

            var pasteboardName = pasteboard.Name;
            var encoded = Uri.EscapeDataString(pasteboardName);
            var url = CreateNSUrl(LineUrlContentTypes.Image, encoded);

            var shareApp = UIApplication.SharedApplication;
            return shareApp.OpenUrl(url);
         }

        /// <summary>
        /// Creates the NSUrl.
        /// </summary>
        /// <returns>The NS URL.</returns>
        /// <param name="type">Type.</param>
        /// <param name="contentKey">Content key.</param>
        private static NSUrl CreateNSUrl(LineUrlContentTypes type, string contentKey)
        {
            var path = string.Format("{0}{1}/{2}/{3}",
                LineUrlScheme, LineUrlMessagePath,
                type.ToStringContentType(), contentKey);
            return new NSUrl(path);
        }
    }
}

