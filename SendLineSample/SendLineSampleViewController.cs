using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Softbuild.Social;

namespace SendLineSample
{
    public partial class SendLineSampleViewController : UIViewController
    {
        public SendLineSampleViewController() : base ("SendLineSampleViewController", null)
        {
        }
		
        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }
		
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            btnSendImage.TouchUpInside += ClickSendImageButton;
            btnSendText.TouchUpInside += ClickSendText;
        }

        void ClickSendText (object sender, EventArgs e)
        {
            if (LineOpener.CanOpenLine())
            {
                LineOpener.OpenLine("test for you");
            }
            else
            {
                LineOpener.OpenAppStore();
            }
        }

        void ClickSendImageButton(object sender, EventArgs e)
        {
            var image = new UIImage("sample.png");
            if (image == null)
            {
                return;
            }

            if (LineOpener.CanOpenLine())
            {
                LineOpener.OpenLine(image);
            }
            else
            {
                LineOpener.OpenAppStore();
            }
        } 
    }
}

