using Foundation;
using System;
using UIKit;
using SafariServices;

namespace Bhasvic10th.iOS
{
	public partial class EventsItemDetailedVCs : UITableViewController
	{
		public EventsItemDetailedVCs(IntPtr handle) : base(handle)
		{
		}

		NewsItem currentNewsItem { get; set; }
		public EventsVC Delegate { get; set; } // will be used to Save, Delete later
		NSUrl url = new NSUrl("https://www.bhasvic.ac.uk");

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			//safariButton.TouchUpInside += (sender, e) =>
			//{

			//	var sfViewController = new SFSafariViewController(url);

			//	PresentViewController(sfViewController, true, null);
			//};
			//EventTextField.Text = currentNewsItem.Name;
		    //EventDateTextField.Text = currentNewsItem.DateOfEvent;
			//EventDetail.Text = currentNewsItem.Summary;
		}

		// this will be called before the view is displayed

		public void SetTask(EventsVC d, NewsItem newsItem)
		//public void SetTask(NewsItem newsItem)
		{
			Delegate = d;
			currentNewsItem = newsItem;
		}
	};
}