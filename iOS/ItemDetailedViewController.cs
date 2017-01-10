using System;
using CoreGraphics;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using SQLite;
using UIKit;
using Foundation;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Bhasvic10th.iOS
{
	
    public partial class ItemDetailedViewController: UIViewController
    {


		UIScrollView scrollView;
		//public string name { get;  set; }
	//	public string date { get; set; }
	//	public string content { get; set; }
	//	public string url { get; set; }
		public NewsItem NewsItem { get; set;}
		public ItemDetailedViewController (IntPtr handle) : base (handle)
        {
			
        }


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			scrollView = new UIScrollView();



			var titleLabel = new UILabel(new CGRect(10, 20, View.Bounds.Width, 30));
			titleLabel.Text = "BHASVIC";
			titleLabel.Font = UIFont.BoldSystemFontOfSize(25); 
			View.AddSubview(titleLabel);

			var nameLabel = new UILabel(new CGRect(10, 75, View.Bounds.Width, 30));
			nameLabel.Text = NewsItem.Name;
			nameLabel.Lines = 0;
			nameLabel.Font = UIFont.BoldSystemFontOfSize(30);
			nameLabel.LineBreakMode = UILineBreakMode.WordWrap;
			scrollView.AddSubview(nameLabel);

			var dateLabel = new UILabel(new CGRect(10, 100, View.Bounds.Width, 30));
			DateTime dt = DateTime.ParseExact(NewsItem.DatePublished, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
			dateLabel.Text = dt.ToShortDateString();
			scrollView.AddSubview(dateLabel);

			var contentLabel = new UILabel(new CGRect(10, 120, View.Bounds.Width, 300));
			string noHTML = Regex.Replace(NewsItem.Content, @"<[^>]+>|&nbsp;", "").Trim();
			string noHTMLNormalised = Regex.Replace(noHTML, @"\s{2,}", " ");
			contentLabel.Text = noHTMLNormalised;
			contentLabel.Lines = 0;
			contentLabel.LineBreakMode = UILineBreakMode.WordWrap;
			scrollView.AddSubview(contentLabel);

			var dateoELabel = new UILabel(new CGRect(10, 80, View.Bounds.Width, 30));
			//DateTime dtt = DateTime.ParseExact(NewsItem.DateOfEvent, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
			dateLabel.Text = NewsItem.DateOfEvent;
			Console.WriteLine(NewsItem.DateOfEvent);

			scrollView.AddSubview(dateoELabel);


			var dateNLabel = new UILabel(new CGRect(10, 130, View.Bounds.Width, 30));
			//DateTime dtt = DateTime.ParseExact(NewsItem.DateOfEvent, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
			dateLabel.Text = NewsItem.NotificationDate;
			Console.WriteLine(NewsItem.NotificationDate);
			scrollView.AddSubview(dateNLabel);


			//var categoryLabel = new UILabel(new CGRect(10, 80, View.Bounds.Width, 30));
			////DateTime dtt = DateTime.ParseExact(NewsItem.DateOfEvent, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
			//dateLabel.Text = NewsItem.Category;
			//scrollView.AddSubview(categoryLabel);


			var urlLabel = new UILabel(new CGRect(10,500 , View.Bounds.Width, 30));
			urlLabel.Text = NewsItem.Url;
			scrollView.AddSubview(urlLabel);

			this.View.AddSubview(scrollView);

		//	NavigationController.SetHasNavigationBar(this, false);
			//this.NavigationController.PopToRootViewController(true);





		}

		public override void ViewDidLayoutSubviews()
		{
			
			scrollView.Frame = new CoreGraphics.CGRect(0, 0, this.View.Bounds.Size.Width, 500);
			scrollView.ContentSize = scrollView.Frame.Size; // This may not be what you actually want, but what you had before was certainly wrong.
		//	scrollView.titleLabel.Frame = new CoreGraphics.CGRect(0, 0, this.View.Bounds.Size.Width, this.View.Bounds.Size.Height);
		}

    }
}