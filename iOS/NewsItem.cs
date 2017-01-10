﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;

namespace Bhasvic10th.iOS
{

	public class NewsItem
		{
			
			public int ID { get; set; }
			public string Name { get; set; }
			public string Content { get; set; }
			public string DatePublished { get; set; }
			public string Summary { get; set; }
			public string ImageUrl { get; set; }
			[PrimaryKey]
			public string Url { get; set; }
			public int FileUploadId { get; set; }
			public string Category { get; set;}
			public string NotificationDate { get; set; }
			public string DateOfEvent { get; set; } 
		}


	
	
	
}


