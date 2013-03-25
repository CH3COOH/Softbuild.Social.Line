// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SendLineSample
{
	[Register ("SendLineSampleViewController")]
	partial class SendLineSampleViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnSendImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnSendText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnSendImage != null) {
				btnSendImage.Dispose ();
				btnSendImage = null;
			}

			if (btnSendText != null) {
				btnSendText.Dispose ();
				btnSendText = null;
			}
		}
	}
}
