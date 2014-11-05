using Xamarin.Forms;
using App.Android.Renderers;
using App.Custom;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SettingsTableView), typeof(SettingsTableViewRenderer))]
namespace App.Android.Renderers {
	public class SettingsTableViewRenderer : TableViewRenderer {
		protected override void OnElementChanged(ElementChangedEventArgs<TableView> e) {
			base.OnElementChanged(e);
		}
	}
}

