using App.ViewModels;
using Xamarin.Forms;
using App.Extensions;

namespace App.Pages {
	public class WebPage : BasePage<WebViewModel> {
		protected override void ConfigureUI() {
			BackingModel.Title = "Web";
			BackingModel.Url = "$WEBVIEWURL$";

			Content = new WebView().BindTo(WebView.SourceProperty, _(m => m.Url));
		}
	}
}

