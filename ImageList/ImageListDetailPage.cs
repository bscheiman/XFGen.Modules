using App.Json;
using Xamarin.Forms;
using App.ViewModels;
using App.Extensions;

namespace App.Pages {
	public class ImageListDetailPage : BasePage<ImageListDetailViewModel> {
		public ImageListDetailPage(ImageListJsonObject item) {
			BackingModel.ItemId = item.Id;
		}

		protected override void ConfigureUI() {
			Content = new StackLayout {
				Orientation = StackOrientation.Vertical,
				Padding = 0,
				Spacing = 0,
				Children = {
					new Image {
						// TODO: Customize
					}.BindTo(Image.SourceProperty, _(m => m.ImageUrl)),
					new Label {
						TextColor = Color.Red,
						Text = "asd"
						// TODO: Customize
					}.BindTo(Label.TextProperty, _(m => m.Title)),
					new Label {
						// TODO: Customize
					}.BindTo(Label.TextProperty, _(m => m.Description)),
				},
			};
		}
	}
}

