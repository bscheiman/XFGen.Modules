using Xamarin.Forms;

namespace App.Pages {
	public class FlyoutPage : MasterDetailPage {
		public FlyoutPage() {
			Padding = new Thickness(0, Device.OnPlatform(Navigation == null ? 20 : 0, 0, 0), 0, 0);

			Master = new CustomNavPage(new FlyoutMasterPage(this)) { Title = "---", Icon = "slideout.png" };
			Detail = new CustomNavPage(new FlyoutMainPage()) { Title = "MAIN" };
		}
	}
}

