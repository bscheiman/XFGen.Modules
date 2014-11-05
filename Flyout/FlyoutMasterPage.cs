using Xamarin.Forms;
using App.ViewModels;

namespace App.Pages {
	public class FlyoutMasterPage : BasePage<FlyoutViewModel> {
		public FlyoutPage Master { get; set; }

		public FlyoutMasterPage(FlyoutPage masterPage) {
			Master = masterPage;
			Title = "MENU";
			StyleId = "flyoutMenu";
		}

		protected override void ConfigureUI() {
			var stack = new StackLayout {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Red
			};

			Content = ScrollWrap(stack);
		}
	}
	
}
