using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;
using System.Linq;
using UIKit;
using System.Text;
using System.IO;
namespace Bhasvic10th.iOS
{
	public static class LocalBhasvicDB
	{
		public static string logTag { get; set; }
		public static string DBLocation { get; set; }
		public static string documentsPath { get; set; }
		public static string libraryPath { get; set; }
		public static List<NewsItem> itemList;
		public static List<NewsItem> categorisedItemList;
		public static SQLite.SQLiteConnection db;

		static LocalBhasvicDB()
		{

			logTag = "LocalBhasvicDB";
			documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			libraryPath = Path.Combine(documentsPath, "../Library/");
			DBLocation = Path.Combine(libraryPath, "MyDatabase.db3");
			db = new SQLite.SQLiteConnection(DBLocation);
			Console.WriteLine(db);
			Console.WriteLine(DBLocation);



		}

		static public void createNewsItemTable()
		{
			db.CreateTable<NewsItem>();
			//return true;
		}

		static public void createSettingsItemTable()
		{
		///	db.CreateTable<>();
			//return true;
		}
	}
}