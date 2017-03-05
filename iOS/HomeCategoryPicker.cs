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
			base.ViewDidLoad();
			TableView.Source = new HomeCatPTableSource();

			if (TableView.IndexPathForSelectedRow != null)
			{
				ChosenCategories.ChosenCategory = ChosenCategories.categories[TableView.IndexPathForSelectedRow.Row];
			}


		}
    }
}