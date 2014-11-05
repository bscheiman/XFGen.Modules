using App.Json;
using Xamarin.Forms;
using App.Custom;
using App.Extensions;
using App.ViewModels;

namespace App.Pages {
	public class ImageListPage : BasePage<ImageListViewModel> {
		public ImageList List { get; set; }

		protected override void ConfigureUI() {
			var template = new DataTemplate(typeof(ImageListCell));
			template.BindTo<ImageListJsonObject, string>(ImageCell.ImageSourceProperty, m => m.Image);
			template.BindTo<ImageListJsonObject, string>(TextCell.TextProperty, m => m.Title);
			template.BindTo<ImageListJsonObject, string>(TextCell.DetailProperty, m => m.Description);

			Content = new StackLayout {
				Orientation = StackOrientation.Vertical, 
				Padding = 0,
				Spacing = 0,
				Children = {
					(List = new ImageList {
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.FillAndExpand,
						ItemTemplate = template
					}).BindTo(ItemsView<Cell>.ItemsSourceProperty, _(m => m.Collection))
				}
			};
		}

		protected override void HookEvents() {
			base.HookEvents();

			List.ItemTapped += async (sender, e) => await Navigation.PushAsync(new ImageListDetailPage(List.SelectedItem as ImageListJsonObject));
		}
	}
}

