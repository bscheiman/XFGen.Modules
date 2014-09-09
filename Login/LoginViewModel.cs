using Xamarin.Forms;
using System.Threading.Tasks;
using App.Json;
using bscheiman.Common.Extensions;

namespace App.ViewModels {
	public class LoginViewModel : BaseViewModel {
		readonly INavigation navigation;

		public LoginViewModel(INavigation navigation) {
			this.navigation = navigation;
		}

		public const string UsernamePropertyName = "Username";
		string username = string.Empty;

		public string Username {
			get { return username; }
			set { SetProperty(ref username, value, UsernamePropertyName); }
		}

		public const string PasswordPropertyName = "Password";
		string password = string.Empty;

		public string Password {
			get { return password; }
			set { SetProperty(ref password, value, PasswordPropertyName); }
		}

		Command loginCommand;
		public const string LoginCommandPropertyName = "LoginCommand";

		public Command LoginCommand {
			get {
				return loginCommand ?? (loginCommand = new Command(async () => await DoLogin()));
			}
		}

		protected async Task DoLogin() {
			var result = await JsonHelper.Post<LoginResponse>("$URL$", post: new { username, password = password.ToSHA1() });

			if (result.Valid) {
				// TODO: Add logic here
			}

			await navigation.PopModalAsync();
		}
	}
}
