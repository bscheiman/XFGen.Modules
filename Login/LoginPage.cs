using Xamarin.Forms;
using App.ViewModels;

namespace App.Pages {
	public class LoginPage : BasePage {
		public LoginPage() {
			BindingContext = new LoginViewModel(Navigation);

			Title = "Login";

			Content = new ScrollView { 
				Content = new StackLayout { 
					Padding = 10,
					Children = {
						new Image { 
							Source = "logo.png",
							VerticalOptions = LayoutOptions.CenterAndExpand
						},
						BindElement(new Entry { Placeholder = "Username" }, Entry.TextProperty, LoginViewModel.UsernamePropertyName),
						BindElement(new Entry { Placeholder = "Password", IsPassword = true }, Entry.TextProperty, LoginViewModel.PasswordPropertyName),
						BindElement(new Button { Text = "Sign In", TextColor = Color.Black }, Button.CommandProperty, LoginViewModel.LoginCommandPropertyName)
					}
				}
			};
		}
	}
}
