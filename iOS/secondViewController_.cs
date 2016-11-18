using Foundation;
using System;
using CoreGraphics;
using UIKit;

namespace Bhasvic10th.iOS
{
    public partial class secondViewController: UIViewController
    {
        public secondViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var button = new UIButton
			{
				Frame = new CGRect(0, 50, View.Bounds.Width, 30),
				BackgroundColor = UIColor.Purple
			};
			button.SetTitle("hello", UIControlState.Normal);
			View.Add(button);
			button.TouchUpInside += (sender, e) =>
			{

			}
			;

		}
    }
}