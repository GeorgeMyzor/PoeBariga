using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PoEBariga
{
	public static class ItemsParser
	{
		public static string GetProperty(JObject jsonObject, string propertyName)
		{
			string property = jsonObject[propertyName].ToString();

			return property;
		}

		public static T GetObjectFormProperty<T>(JObject jsonObject, string propertyName)
		{
			string property = jsonObject[propertyName].ToString();
			T deserializedObject = JsonConvert.DeserializeObject<T>(property);

			return deserializedObject;
		}
	}
}
