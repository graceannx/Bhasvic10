using System;
using Foundation;
using UIKit;

namespace Bhasvic10th.iOS
{
	public class HomeCatPTableSource : UITableViewSource
	{
		string[] categories = new string[] { "General, Economics, Business & Acc", "Archaeology, Classical Civs, History", "Art, Photog, Textiles, Graphics", "Biology & Env Studies", "Chemistry", "Computing IT", "Media & Film", "Dance, Drama, Theatre Studies", "English", "ESOL", "Languages", "Geography A Level", "Law, Politics, Philosophy", "Maths", "Music", "Physics", "Sociology, Psych, H & Soc Care", "Sport and PE", "SU Events", "UCAS, University", "Apprenticeship, Work", "Extra-Curricular", "Tutor & Welfare" };
		public HomeCatPTableSource()
		{
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cellidentifier = "S";
			var cell = tableView.DequeueReusableCell(cellidentifier);
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellidentifier);
			}
			cell.TextLabel.Text = categories[indexPath.Row];

			//categorisedItemList.ElementAt(indexPath.Row).Name
			return cell;

		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return categories.Length;

		}
	}
}
