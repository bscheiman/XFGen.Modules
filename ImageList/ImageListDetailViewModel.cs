using System;
using App.Custom;
using App.Json;
using System.Threading.Tasks;

namespace App.ViewModels {
	public class ImageListDetailViewModel : BaseViewModel {
		public int ItemId { get; set; }
		public string ImageUrl { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		public override async Task Update() {
			using (new LoadingWrapper(this)) {
				var info = await JsonHelper.Get<ImageListJsonObject>("$IMAGELISTDETAILPAGE$", string.Format("id={0}", ItemId));

				Title = info.Title;
				ImageUrl = info.Image;
				Description = info.Description;
			}
		}
	}
}

