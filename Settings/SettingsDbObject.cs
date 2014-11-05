using System;

namespace App.Data {
	public class SettingsDbObject : BaseDbObject {
		public string Key { get; set; }
		public string Value { get; set; }
	}
}

