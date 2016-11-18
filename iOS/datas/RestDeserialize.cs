using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Bhasvic10th.iOS
{
	public class JsonDeserialize
	{
		public async <List<RootObject>> RefreshDataAsync()
		HttpClient client = new HttpClient();
		Uri uri = new Uri("https://www.bhasvic.ac.uk/umbraco/api/BHANewsPostservice/getPosts?start=2016-10-11&end=2016-11-11&student=true&public=true");
		string obstring = await client.GetStringAsync(uri);
		List<RootObject> bulletinOb = JsonConvert.DeserializeObject<List<RootObject>>(obstring);
		return bulletinOb;

	}
}
