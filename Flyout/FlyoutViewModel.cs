using App.Objects;
using App.Custom;
using App.ViewModels;
using App.Pages;

namespace App.ViewModels {
	public class FlyoutViewModel : BaseViewModel {
		public ObservableCollectionEx<FlyoutPageInfo> Pages { get; set; }

		public FlyoutViewModel() {
			Pages = new ObservableCollectionEx<FlyoutPageInfo>(new[] {
				new FlyoutPageInfo { Title = "Page1", Icon = "", Type = typeof(LoginPage) }
			});
		}
	}
}

