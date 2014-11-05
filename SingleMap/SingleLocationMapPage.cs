using Xamarin.Forms.Maps;
using Xamarin.Forms;
using App.ViewModels;

namespace App.Pages {
	public class SingleLocationMapPage : BasePage<SingleLocationMapViewModel> {
		protected override void ConfigureUI() {
			BackingModel.Title = "Map";

			Content = ScrollWrap(new Map(MapSpan.FromCenterAndRadius(new Position(BackingModel.Latitude, BackingModel.Longitude), Distance.FromMeters(100))) {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			});
		}
	}
}

