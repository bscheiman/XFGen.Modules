using Xamarin.Forms;
using System.Threading.Tasks;
using App.Json;
using bscheiman.Common.Extensions;
using App.Custom;

namespace App.ViewModels {
	public class LoginViewModel : BaseViewModel {
		public string Username { get; set; }
		public string Password { get; set; }
		public string Logo { get; set; }

		public Command Login {
			get {
				return new Command(async () => await DoLogin());
			}
		}

		protected async Task DoLogin() {
			LoginResponse result;

			using (new LoadingWrapper(this, "Logging in..."))
				result = await JsonHelper.Post<LoginResponse>("$LOGINURL$", post: new { username = Username, password = Password.ToSHA1() });

			if (result.Valid) {
				// TODO: Add logic here
			}

			await Navigation.PopModalAsync();
		}
	}
}
