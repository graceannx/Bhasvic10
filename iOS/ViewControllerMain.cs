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
using CoreAnimation;
using Foundation;

namespace Bhasvic10th.iOS
{
	public partial class ViewControllerMain : UIViewController, IUITableViewDelegate, IUITableViewDataSource 

	{
		UIViewController SecondViewController;
		List<NewsItem> itemList;
		List<NewsItem> categorisedItemList;




		public ViewControllerMain(IntPtr handle) : base(handle)
		{


		}
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			this.NavigationController.SetNavigationBarHidden(true, animated);
		}
		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
			this.NavigationController.SetNavigationBarHidden(false, animated);
		}




		public override async void ViewDidLoad()
		{
			base.ViewDidLoad();




			var selectedtab = "Economics, Business & Acc";

			View.BackgroundColor = UIColor.FromRGB(13, 13, 13);


			//creates BhasvicTitle 
			var titleLabel = new UILabel(new CGRect(10, 20, View.Bounds.Width-10, 30));
			titleLabel.Text = "BHASVIC";
			titleLabel.Font = UIFont.BoldSystemFontOfSize(20);
			titleLabel.TextColor = UIColor.LightTextColor;




			View.AddSubview(titleLabel);

			var picker = new UIPickerView(new CGRect(10, 20, View.Bounds.Width - 20, 150));
			string[] categories = new string[] {"Economics, Business & Acc", "Archaeology, Classical Civs, History","Art, Photog, Textiles, Graphics","Biology & Env Studies","Chemistry","Computing IT","Media & Film","Dance, Drama, Theatre Studies","English","ESOL","Languages","Geography","Law, Politics, Philosophy","Maths","Music","Physics","Sociology, Psych, H & Soc Care","Sport and PE","SU Events","General","UCAS, University","Apprenticeship, Work","Extra-Curricular","Tutor & Welfare"};
			picker.BackgroundColor = UIColor.LightGray;
			picker.Model = new PickerViewModel();
			picker.Hidden = true;




			//	picker.AccessibilityActivate 
			View.AddSubview(picker);
			//var source = new;






			var mainlabel = UIButton.FromType(UIButtonType.RoundedRect);
			mainlabel.SetTitle("HOME", UIControlState.Normal);
			mainlabel.AccessibilityFrame = new CGRect(View.Frame.Right - 75, 20, View.Bounds.Width - 10, 30);
			mainlabel.Font = UIFont.BoldSystemFontOfSize(20);
			mainlabel.SetTitleColor(UIColor.FromRGB(250, 209, 124), UIControlState.Disabled);
			View.AddSubview(mainlabel);


			var button = new UIButton
			{
				Frame = new CGRect(0, 50, View.Bounds.Width, 30),
				BackgroundColor = UIColor.Cyan
				                         

				                          
			};

			button.TouchUpInside += delegate
			{
				if (picker.Hidden == false)
				{
					picker.Hidden = true;
					selectedtab = categories[picker.SelectedRowInComponent(0)];
					Console.WriteLine(selectedtab);
				}
				else {
					picker.Hidden = false;

				}
			};

			View.AddSubview(button);

		






			HttpClient client = new HttpClient();

			string startDate = DateTime.Now.AddDays(-100).ToString("yyyy-MM-dd");
			string endDate = DateTime.Now.ToString("yyyy-MM-dd");
				

			Console.WriteLine(startDate);
			Console.WriteLine(endDate);
			string uriString = "https://www.bhasvic.ac.uk/umbraco/api/BHANewsPostservice/getPosts?start=" + startDate + "&end=" + endDate + "&student=true&public=false";



		
			Uri uri = new Uri(uriString);
			string jsonString = await client.GetStringAsync(uri);
			//var filename = Path.Combine(documents, "account.json");
			//ile.WriteAllText(filename, jsonString);

			//Console.WriteLine(jsonString);
			itemList = JsonConvert.DeserializeObject<List<NewsItem>>(jsonString);
			categorisedItemList = JsonConvert.DeserializeObject<List<NewsItem>>(jsonString);
			categorisedItemList.AddRange(itemList);
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var _pathToDatabase = Path.Combine(documents, "db_sqlite-net.db");




			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine(documentsPath, "../Library/");
			var path = Path.Combine(libraryPath, "MyDatabase.db3");
			Console.WriteLine(path);

			var db = new SQLite.SQLiteConnection(path);

			db.CreateTable<NewsItem>();



				db.RunInTransaction(() =>
				{
					foreach (var item in itemList)
					{
					db.InsertOrReplace(item);
					}

				});
			//todo, create a new table after select period of time and omit old data




			var query = db.Table<NewsItem>().Where(v => v.Category.Equals("General"));

				foreach (var category in query)
					  {
					Console.WriteLine("Category: " + category.Name);
					  }

			//	var query = db.Query<NewsItem>("select * from NewsItem where Category = 'General'");
			//	Console.WriteLine(query.ToString());
				


			                        
			Console.WriteLine(categorisedItemList.ElementAt(0).Category);







			//using (var conn = new SQLite.SQLiteConnection(_pathToDatabase))
			//{
			//	conn.CreateTable<NewsItem>();
			//}


			//button.SetTitle("hello", UIControlState.Normal);
			//View.Add(button);
			//button.TouchUpInside += (sender, e) =>
			//{
			//	SecondViewController controller = this.Storyboard.InstantiateViewController("SecondViewController") as SecondViewController;
			//	controller.name = itemList.First().Name;
			//	this.NavigationController.PushViewController(controller, true);


			//}
			//;

			/*string dbPath = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ormdemo.db3");
			var db = new SQLiteConnection(dbPath);
			db.CreateTable<RootClass>();
			//	db.Insert(bulletinOb);


				var table = db.Table<RootClass>();
				foreach (var s in table)
				{
					Console.WriteLine(s.Name + " " + s.DatePublished);
				}


			//foreach (Array bulletinOb in RootClass) { 
			//}
		//	RootClass p1 = bulletinOb[0];
		//	RootClass p2 = bulletinOb[1];
		//	RootClass p3 = bulletinOb[2];
			RootClass p4 = bulletinOb[3];
			RootClass p5 = bulletinOb[4];
*/

			// Perform any additional setup after loading the view, typically from a nib.

			//	Console.WriteLine(itemList[0].Name);



			//	testItem.LineBreakMode = UILineBreakMode.CharacterWrap;
			//	View.AddSubview(testItem);
			//bulletinText.text = bulletin.Name.bulletin;


			/*int i;
			string[] data = new string[itemList.Count];
			for (i = 0; i < itemList.Count; i++) {
				data[i] = itemList[i].Name;
			}*/



			//	string[] data = new string[] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","b" ,"c" ,"d" ,"e" };
			//create table view

			//var g = UIGraphics.GetCurrentContext();
			//g.SetLineWidth(10);
			//UIColor.Blue.SetFill();
			//UIColor.Red.SetStroke();

			////create geometry
			//var path = new CGPath();

			//path.AddLines(new CGPoint[]{
			//	new CGPoint (0, 50),
			//	new CGPoint (View.Bounds.Width, View.Bounds.Height) });

			//path.CloseSubpath();

			////add geometry to graphics context and draw it
			//g.AddPath(path);
			//g.DrawPath(CGPathDrawingMode.FillStroke);



			UITableView _table;
			_table = new UITableView
			{
				Frame = new CGRect(0, 150, View.Bounds.Width, View.Bounds.Height - 100),
				BackgroundColor =  UIColor.FromRGB(24,24,24)			//	Source = new TableSource(itemList, NavigationController)

			};
			//TableSource source = new TableSource(itemList, NavigationController);
			//source.RowBeenSelected += handleRowBeenSelected;



			for (int i = 1; i <= itemList.Count-1; i++)
			{
				if (itemList.ElementAt(i).Category != selectedtab)
				{
					categorisedItemList.Remove(itemList.ElementAt(i));

				}
			}
			_table.WeakDataSource = this;
			_table.WeakDelegate = this;
			View.AddSubview(_table);







		}



		//	public void handleRowBeenSelected(object sender, EventArgs e) { 

		//SecondViewController controller = this.Storyboard.InstantiateViewController("SecondViewController") as SecondViewController;
		//	this.NavigationController.PushViewController(controller, true);

		//	}
		//






		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}




		public nint RowsInSection(UITableView tableView, nint section)
		{
			//SecondViewController controller = this.Storyboard.InstantiateViewController("SecondViewController") as SecondViewController;
			//this.NavigationController.PushViewController(controller, true);
			return itemList.Count;
		}


	
		 [Export("tableView:didSelectRowAtIndexPath:")]
		public void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			ItemDetailedViewController controller = this.Storyboard.InstantiateViewController("SecondViewController") as ItemDetailedViewController;
	///		controller.name = itemList.ElementAt(indexPath.Row).Name;
	//		controller.date = itemList.ElementAt(indexPath.Row).DatePublished;
	//		controller.content = itemList.ElementAt(indexPath.Row).Content;
	//		controller.url = itemList.ElementAt(indexPath.Row).Url;

			controller.NewsItem = itemList.ElementAt(indexPath.Row);
			this.NavigationController.PushViewController(controller, true);


		}

		public UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{

			string cellidentifier = "tablecell"; // defines each cell 
			UITableViewCell cell = tableView.DequeueReusableCell(cellidentifier); //recycles cell memory 
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellidentifier);
			}

			if (indexPath.Row % 2 == 0)
			{
				cell.BackgroundColor = UIColor.FromRGB(13, 13, 13);

			}
			else {
				cell.BackgroundColor = UIColor.FromRGB(24, 24, 24);
	  
			}
			//produces a cell in a default style
			//cell.ContentView.BackgroundColor = UIColor.DarkGray;
			cell.TextLabel.TextColor = UIColor.LightTextColor;

			cell.TextLabel.Text = categorisedItemList.ElementAt(indexPath.Row).Name;

			return cell;


		}

		//public nint GetComponentCount(UIPickerView pickerView)
		//{
		//	throw new NotImplementedException();
		//}

		//public nint GetRowsInComponent(UIPickerView pickerView, nint component)
		//{
		//	throw new NotImplementedException();
		//}

		//[Export("pickerView:titleForRow:forComponent:")]
		//public string GetTitle(UIPickerView pickerView, nint row, nint component)
		//{
		//	return "Component " + row.ToString();
		//}
		//} 
		


	}


}


