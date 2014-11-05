using Xamarin.Forms;
using App.ViewModels;

namespace App.Pages {

	public class FlyoutMainPage : BasePage<BaseViewModel> {
		protected override void ConfigureUI() {
			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Home Page",
						HorizontalOptions = LayoutOptions.Center
					}
				}
			};
		}
	}
	
}
