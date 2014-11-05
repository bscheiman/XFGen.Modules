using System;
using Xamarin.Forms;
using System.Threading.Tasks;

[assembly: DependencyAttribute(typeof(App.Android.Implementations.BarcodeReader))]
namespace App.Android.Implementations {
	public class BarcodeReader : Interfaces.IBarcodeReader {
		public async Task<string> ReadBarcodeAsync(string title, string footer) {
			// return result == null ? "" : result.Text;
			return "";
		}
	}
}
