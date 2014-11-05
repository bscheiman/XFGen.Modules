using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using App.Custom;
using App.iOS.Renderers;

[assembly: ExportRenderer(typeof(ImageListCell), typeof(ImageListCellRenderer))]

namespace App.iOS.Renderers {
	public class ImageListCellRenderer : ImageCellRenderer {
	}
}
