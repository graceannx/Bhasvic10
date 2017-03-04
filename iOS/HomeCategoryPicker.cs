using Foundation;
using System;
using UIKit;

namespace Bhasvic10th.iOS
{
    public partial class HomeCategoryPicker : UITableViewController
    {
		

        public HomeCategoryPicker (IntPtr handle) : base (handle)
        {
			
        }
		public override void ViewDidLoad()
		{
			TableView.Source = new HomeCatPTableSource();
			base.ViewDidLoad();
		}
    }
}