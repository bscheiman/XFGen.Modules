using System;
using System.Runtime.Serialization;

namespace App.Json {
	[DataContract]
	public class LoginResponse : BaseJsonObject {
		[DataMember(Name = "valid")]
		public bool Valid { get; set; }
	}
}

