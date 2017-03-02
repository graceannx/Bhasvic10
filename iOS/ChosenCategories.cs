using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;
namespace Bhasvic10th.iOS
{
	public class ChosenCategories
	{
		[PrimaryKey]
		string Category { get; set; }
	}
}
