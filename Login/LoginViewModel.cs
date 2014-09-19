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

		string username = string.Empty;

		public string Username {
			get { return username; }
			set { SetProperty(ref username, value, () => Username); }
		}

		string password = string.Empty;

		public string Password {
			get { return password; }
			set { SetProperty(ref password, value, () => Password); }
		}

		Command loginCommand;

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
