using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using App.Custom;
using App.iOS.Renderers;

[assembly: ExportRenderer(typeof(ImageList), typeof(ImageListRenderer))]

namespace App.iOS.Renderers {
	public class ImageListRenderer : ListViewRenderer {
	}
}

