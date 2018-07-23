using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace PoEBariga
{
	public static class ItemsProvider
	{
		public static JObject GetPoeNinjaInfo(string url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			WebResponse response = request.GetResponse();

			using (Stream responseStream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

				JObject jsonObject = JObject.Parse(reader.ReadToEnd());

				return jsonObject;
			}
		}
	}
}
