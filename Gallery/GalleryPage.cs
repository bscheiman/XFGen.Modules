using App.ViewModels;
using Xamarin.Forms;
using System;

namespace App.Pages {
	public class GalleryPage : BasePage<GalleryViewModel> {
		protected override void ConfigureUI() {
			BackingModel.Title = "Gallery";
		}

		protected override void PostUpdate() {
			base.PostUpdate();

			var layout = new RelativeLayout();
			var firstBox = GetImage(BackingModel.Images[0]);

			const double padding = 10;

			layout.Children.Add(firstBox, () => new Rectangle(((layout.Width + padding) % 60) / 2, padding, 50, 50));

			var last = firstBox;

			for (int i = 1; i < BackingModel.Images.Length; i++) {
				var relativeTo = last;

				var box = GetImage(BackingModel.Images[i]);
				Func<View, bool> pastBounds = view => relativeTo.Bounds.Right + padding + view.Width > layout.Width;

				layout.Children.Add(box, () => new Rectangle(pastBounds(relativeTo) ? firstBox.X : relativeTo.Bounds.Right + padding,
					pastBounds(relativeTo) ? relativeTo.Bounds.Bottom : relativeTo.Y, relativeTo.Width, relativeTo.Height));

				last = box;
			}

			Content = new ScrollView { 
				Content = layout, 
				Padding = 0, 
				HorizontalOptions = LayoutOptions.FillAndExpand, 
				VerticalOptions = LayoutOptions.FillAndExpand,
				Orientation = ScrollOrientation.Vertical
			};
		}

		ContentView GetImage(string uri) {
			var view = new ContentView {
				Content = new Image { Source = uri }
			};

			view.GestureRecognizers.Add(new TapGestureRecognizer {
				Command = new Command(async () => await Navigation.PushAsync(new GalleryDetailPage(uri)))
			});

			return view;
		}
	}
}

