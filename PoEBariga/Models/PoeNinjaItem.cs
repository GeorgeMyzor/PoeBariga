using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PoEBariga.Models
{
	public class PoeNinjaItem
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "chaosValue")]
		public double AverageChaosValue { get; set; }
	}
}
