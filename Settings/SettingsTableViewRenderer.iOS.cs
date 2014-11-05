using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;
using Xamarin.Forms;
using App.iOS.Renderers;
using App.Custom;

[assembly: ExportRenderer(typeof(SettingsTableView), typeof(SettingsTableViewRenderer))]
namespace App.iOS.Renderers {
	public class SettingsTableViewRenderer : TableViewRenderer {
		protected override void OnElementChanged(ElementChangedEventArgs<TableView> e) {
			base.OnElementChanged(e);

			Control.AllowsSelection = false;
			Control.SeparatorStyle = UITableViewCellSeparatorStyle.None;
		}
	}
}

