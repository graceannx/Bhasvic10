using System;
using UIKit;
using Foundation;
namespace Bhasvic10th.iOS
{
	public class HomeTableSource : UITableViewSource
	{
		public HomeTableSource()
		{
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			string cellidentifier = "tablecell"; // defines each cell 
			UITableViewCell cell = tableView.DequeueReusableCell(cellidentifier);
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellidentifier);
			}
			cell.TextLabel.Text = "test";
			//categorisedItemList.ElementAt(indexPath.Row).Name
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			throw new NotImplementedException();
		}
	}
}
