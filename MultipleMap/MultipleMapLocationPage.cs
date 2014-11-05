using App.ViewModels;
using Xamarin.Forms.Maps;
using Xamarin.Forms;

namespace App.Pages {
	public class MultipleMapLocationPage : BasePage<MultipleMapLocationViewModel> {
		protected override void ConfigureUI() {
			BackingModel.Title = "Map";
		}

		protected override void PostUpdate() {
			base.PostUpdate();

			var locations = BackingModel.Locations;
			var map = new Map(MapSpan.FromCenterAndRadius(new Position(locations[0].Latitude, locations[0].Longitude), Distance.FromMeters(100))) {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			foreach (var loc in locations) {
				map.Pins.Add(new Pin {
					Label = loc.Label,
					Type = PinType.Place,
					Position = new Position(loc.Latitude, loc.Longitude)
				});
			}

			Content = ScrollWrap(map);
		}
	}
}

