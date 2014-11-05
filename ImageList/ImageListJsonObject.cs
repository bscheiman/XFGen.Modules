using Newtonsoft.Json;
using System.Collections.Generic;

namespace App.Json {
	public class ImageListResponse : BaseJsonObject {
		[JsonProperty("results")]
		public IList<ImageListJsonObject> Results { get; set; }
	}

	public class ImageListJsonObject : BaseJsonObject {
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}

