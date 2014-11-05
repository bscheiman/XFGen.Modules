using System.Threading.Tasks;
using App.Json;
using App.Custom;
using System.Linq;

namespace App.ViewModels {
	public class GalleryViewModel : BaseViewModel<string> {
		public string[] Images { get; set; }

		public override async Task Update() {
			GalleryResponse result;

			using (new LoadingWrapper(this))
				result = await JsonHelper.Get<GalleryResponse>("$GALLERYURL$");

			Images = result.Images.Distinct().ToArray();
		}
	}
}

