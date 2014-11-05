using System;
using System.ComponentModel;
using System.Net.Mail;

namespace App.ViewModels {
	public class SettingsViewModel : BaseViewModel {
		[Description("string")]
		public string ExampleString { get; set; }

		[Description("bool")]
		public bool ExampleBool { get; set; }

		[Description("int")]
		public int ExampleInt { get; set; }

		[Description("float")]
		public float ExampleFloat { get; set; }

		[Description("double")]
		public double ExampleDouble { get; set; }

		[Description("uri")]
		public Uri ExampleUri { get; set; }

		[Description("email")]
		public MailAddress ExampleMail { get; set; }

	}
}

