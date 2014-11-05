using Xamarin.Forms;
using App.Custom;
using App.Android.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ImageListCell), typeof(ImageListCellRenderer))]

namespace App.Android.Renderers {
	public class ImageListCellRenderer : ImageCellRenderer {
	}
}

