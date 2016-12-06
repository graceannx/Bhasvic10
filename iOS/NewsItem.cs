using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bhasvic10th.iOS
{

	public class NewsItem
		{
			public string Name { get; set; }
			public string Content { get; set; }
			public string DatePublished { get; set; }
			public string Summary { get; set; }
			public string ImageUrl { get; set; }
			public string Url { get; set; }
			public int FileUploadId { get; set; }
			public string Category { get; set;}
			public string NotificationDate { get; set; }
			public string DateOfEvent { get; set; } 
		}


	
	
	
}


