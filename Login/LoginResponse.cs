using Newtonsoft.Json;

namespace App.Json {
	public class LoginResponse : BaseJsonObject {
		[JsonProperty("valid")]
		public bool Valid { get; set; }
	}
}

