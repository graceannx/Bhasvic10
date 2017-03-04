using Foundation;
using System;
using UIKit;

namespace Bhasvic10th.iOS
{
	public partial class HomeVC : UITableViewController
	{

		public HomeVC(IntPtr handle) : base(handle)
		{




		}
		public override async void ViewWillAppear(bool animated)
		{

			TableView.Source = new HomeTableSource(LocalBhasvicDB.getItemList());


			base.ViewWillAppear(animated);

		}
		public override async void ViewDidLoad()
		{



			base.ViewDidLoad();

			NewsItemGrabber _newsItemGrabber;
			_newsItemGrabber = new NewsItemGrabber();
			LocalBhasvicDB.createNewsItemTable();
			var jsonString = await _newsItemGrabber.getNews();
			Console.WriteLine(jsonString);
			LocalBhasvicDB.updateDBWithJSON(jsonString);
			Console.WriteLine(LocalBhasvicDB.getItemList());

			TableView.Source = new EventsTableSource(LocalBhasvicDB.getItemList());
		}
		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "HomeEventsSegue")
			{ // set in Storyboard
				var navctlr = segue.DestinationViewController as HomeItemDetailedVCs;
				if (navctlr != null)
				{
					var source = TableView.Source as EventsTableSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					navctlr.SetTask(this, item);

				}
			}
		}
	}

}
