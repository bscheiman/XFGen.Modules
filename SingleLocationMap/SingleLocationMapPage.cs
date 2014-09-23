using Xamarin.Forms.Maps;
using Xamarin.Forms;

namespace App.Pages {
	public class SingleLocationMapPage : BasePage {
		public SingleLocationMapPage() {
			Title = "Map";

			Content = ScrollWrap(new Map(MapSpan.FromCenterAndRadius(new Position($LAT$, $LNG$), Distance.FromMeters(100))) {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			});
		}
	}
}

