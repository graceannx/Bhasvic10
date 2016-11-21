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

namespace Bhasvic10th.iOS
{
	
    public partial class SecondViewController: UIViewController
    {


		UIScrollView scrollView;
		public string name { get;  set; }
		public string date { get; set; }
		public string content { get; set; }
		public string url { get; set; }

		public SecondViewController (IntPtr handle) : base (handle)
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

			var nameLabel = new UILabel(new CGRect(10, 50, View.Bounds.Width, 30));
			nameLabel.Text = name;
			nameLabel.Lines = 0;
			nameLabel.LineBreakMode = UILineBreakMode.WordWrap;
			scrollView.AddSubview(nameLabel);

			var dateLabel = new UILabel(new CGRect(10, 100, View.Bounds.Width, 30));
			dateLabel.Text = date;
			scrollView.AddSubview(dateLabel);

			var contentLabel = new UILabel(new CGRect(10, 150, View.Bounds.Width, View.Bounds.Height));
			string noHTML = Regex.Replace(content, @"<[^>]+>|&nbsp;", "").Trim();
			string noHTMLNormalised = Regex.Replace(noHTML, @"\s{2,}", " ");
			contentLabel.Text = noHTMLNormalised;
			contentLabel.Lines = 0;
			contentLabel.LineBreakMode = UILineBreakMode.WordWrap;
			scrollView.AddSubview(contentLabel);

			var urlLabel = new UILabel(new CGRect(10,500 , View.Bounds.Width, 30));
			urlLabel.Text = url;
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