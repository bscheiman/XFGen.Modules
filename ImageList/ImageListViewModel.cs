using App.Json;
using App.Custom;
using System.Threading.Tasks;

namespace App.ViewModels {
	public class ImageListViewModel : BaseViewModel<ImageListJsonObject> {
		public async override Task Update() {
			using (new LoadingWrapper(this)) {
				var res = await JsonHelper.Get<ImageListResponse>("$IMAGELISTURL$");

				Collection.ClearAndAddRange(res.Results);
			}
		}
	}
}

