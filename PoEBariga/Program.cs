using System;
using System.Collections.Generic;
using PoEBariga.Models;


namespace PoEBariga
{
	class Program
	{
		static void Main(string[] args)
		{
			//TODO from console
			string currentLeague = "Incursion";

			var stats = ItemsProvider.GetPoeNinjaInfo(PoeNinjaUrls.StatsUrl);
			var nextChangeId = ItemsParser.GetProperty(stats, PoeNinjaItems.NextChangeId);

			var jsonArmours = ItemsProvider.GetPoeNinjaInfo(string.Format(PoeNinjaUrls.UniqueArmourUrl, currentLeague, DateTime.Now.ToString("yyyy-MM-dd")));
			var armours = ItemsParser.GetObjectFormProperty<List<PoeNinjaItem>>(jsonArmours, PoeNinjaItems.Lines);

			Console.Read();
		}
	}
}

