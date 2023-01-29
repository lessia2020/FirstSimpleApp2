using System;

using AppKit;
using Foundation;

namespace FirstSimpleApp2
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        partial void PushButton(NSButton sender)
        {
			SetText("Button Pushed.");
        }
        partial void ResetButton(NSButton sender)
        {
			SetText("");
			
        }

		private void SetText(string text)
		{
			InfoLabel.StringValue = text;
		}

    }
}
