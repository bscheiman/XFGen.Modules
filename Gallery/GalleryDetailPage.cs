using App.ViewModels;
using Xamarin.Forms;

namespace App.Pages {
	public class GalleryDetailPage : BasePage<GalleryDetailViewModel> {
		public GalleryDetailPage(string url) {
			BackingModel.Url = url;
		
			Content = new Image { 
				Source = BackingModel.Url,
				Aspect = Aspect.AspectFill
			};
		}

		protected override void ConfigureUI() {
			BackingModel.Title = "Image";
		}
	}
}

