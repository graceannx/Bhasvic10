// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Bhasvic10th.iOS
{
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CategoryButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel categoryLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CategoryButton != null) {
                CategoryButton.Dispose ();
                CategoryButton = null;
            }

            if (categoryLabel != null) {
                categoryLabel.Dispose ();
                categoryLabel = null;
            }
        }
    }
}