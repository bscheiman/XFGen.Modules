using System.Collections.Generic;
using Newtonsoft.Json;

namespace App.Json {
	public class Location {
		[JsonProperty("latitude")]
		public double Latitude { get; set; }

		[JsonProperty("longitude")]
		public double Longitude { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }
	}

	public class MultipleMapLocationResponse : BaseJsonObject {
		[JsonProperty("locations")]
		public IList<Location> Locations { get; set; }
	}
}

