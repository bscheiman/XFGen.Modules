using Xamarin.Forms;
using System.Threading.Tasks;
using ZXing.Mobile;
using System.Collections.Generic;
using ZXing;

[assembly: DependencyAttribute(typeof(App.iOS.Implementations.BarcodeReader))]
namespace App.iOS.Implementations {
	public class BarcodeReader : Interfaces.IBarcodeReader {
		public async Task<string> ReadBarcodeAsync(string title, string footer) {
			var scanner = new MobileBarcodeScanner {
				TopText = title,
				BottomText = footer
			};
			var result = await scanner.Scan(new MobileBarcodeScanningOptions {
				PossibleFormats = new List<BarcodeFormat> { 
					BarcodeFormat.QR_CODE
				}
			}, true);

			return result == null ? "" : result.Text;
		}
	}
}

