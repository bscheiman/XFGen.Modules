using System.Linq;
using System.Threading.Tasks;
using App.Custom;
using App.Json;

namespace App.ViewModels {
	public class MultipleMapLocationViewModel : BaseViewModel {
		public Location[] Locations { get; set; }

		public override async Task Update() {
			MultipleMapLocationResponse result;

			using (new LoadingWrapper(this))
				result = await JsonHelper.Get<MultipleMapLocationResponse>("$MULTIPLEMAPURL$");

			Locations = result.Locations.ToArray();
		}
	}
}

