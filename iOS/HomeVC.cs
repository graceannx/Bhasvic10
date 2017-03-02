using Foundation;
using System;
using UIKit;

namespace Bhasvic10th.iOS
{
    public partial class HomeVC : UITableViewController
    {
		
        public HomeVC (IntPtr handle) : base (handle)
        {
			

			
			
        }
		public override async void ViewWillAppear(bool animated)
		{
			


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
    }
}