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
    [Register ("EventsItemDetailedVC")]
    partial class EventsItemDetailedVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EventDateTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView EventDetail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EventTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton safariButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EventDateTextField != null) {
                EventDateTextField.Dispose ();
                EventDateTextField = null;
            }

            if (EventDetail != null) {
                EventDetail.Dispose ();
                EventDetail = null;
            }

            if (EventTextField != null) {
                EventTextField.Dispose ();
                EventTextField = null;
            }

            if (safariButton != null) {
                safariButton.Dispose ();
                safariButton = null;
            }
        }
    }
}