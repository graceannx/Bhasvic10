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
    [Register ("CategoryPickerVC")]
    partial class CategoryPickerVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView categoryPickerView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (categoryPickerView != null) {
                categoryPickerView.Dispose ();
                categoryPickerView = null;
            }
        }
    }
}