using Xamarin.Forms;
using App.ViewModels;
using App.Extensions;

namespace App.Pages {
	public class LoginPage : BasePage<LoginViewModel> {
		protected override void ConfigureUI() {
			BackingModel.Title = "Login";

			Content = new ScrollView { 
				Content = new StackLayout { 
					Padding = 10,
					Children = {
						new Image { 
							VerticalOptions = LayoutOptions.CenterAndExpand
						}.BindTo(Image.SourceProperty, _(m => m.Logo)),
						new Entry { Placeholder = "Username" }.BindTo(Entry.TextProperty, _(m => m.Username)),
						new Entry { Placeholder = "Password", IsPassword = true }.BindTo(Entry.TextProperty, _(m => m.Password)),
						new Button { Text = "Sign In", TextColor = Color.Black }.BindTo(Button.CommandProperty, _(m => m.Login))
					}
				}
			};
		}
	}
}
