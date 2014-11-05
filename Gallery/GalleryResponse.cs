using System.Collections.Generic;
using Newtonsoft.Json;

namespace App.Json {
	public class GalleryResponse : BaseJsonObject {
		[JsonProperty("images")]
		public IList<string> Images { get; set; }
	}
}

