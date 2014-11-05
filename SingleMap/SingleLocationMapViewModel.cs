using System;

namespace App.ViewModels {
	public class SingleLocationMapViewModel : BaseViewModel {
		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public SingleLocationMapViewModel() {
			Latitude = $LAT$;
			Longitude = $LONG$;
		}
	}
}

