using System;
using Xamarin.Forms;
using App.ViewModels;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using App.Extensions;
using System.Net.Mail;
using App.Custom;
using App.Data;
using System.Collections.Generic;

namespace App.Pages {
	public class SettingsPage : BasePage<SettingsViewModel> {
		public TableView Table { get; set; }
		public List<SettingsDbObject> Objects { get; set; }

		protected async override void ConfigureUI() {
			BackingModel.Title = "Settings";
			Objects = new List<SettingsDbObject>(await Database.Get<SettingsDbObject>());

			var section = new TableSection();

			foreach (var property in typeof(SettingsViewModel).GetProperties(BindingFlags.Public | BindingFlags.Instance)) {
				var type = property.PropertyType;
				var descAttribute = property.GetCustomAttributes(true).FirstOrDefault(a => a is DescriptionAttribute);
				var desc = descAttribute == null ? "" : ((DescriptionAttribute) descAttribute).Description;

				if (Objects.All(o => o.Key != property.Name))
					Objects.Add(new SettingsDbObject { Key = property.Name });

				var obj = Objects.First(o => o.Key == property.Name);
				// TODO: Set model properties

				if (type == typeof(string)) {
					section.Add(new EntryCell { 
						Label = desc
					}.BindTo(EntryCell.TextProperty, property.Name));
				} else if (type == typeof(int)) {
					section.Add(new EntryCell { 
						Label = desc,
						Keyboard = Keyboard.Numeric
					}.BindTo(EntryCell.TextProperty, property.Name));
				} else if (type == typeof(float)) {
					section.Add(new EntryCell { 
						Label = desc,
						Keyboard = Keyboard.Numeric
					}.BindTo(EntryCell.TextProperty, property.Name));
				} else if (type == typeof(double)) {
					section.Add(new EntryCell { 
						Label = desc,
						Keyboard = Keyboard.Numeric
					}.BindTo(EntryCell.TextProperty, property.Name));
				} else if (type == typeof(Uri)) {
					section.Add(new EntryCell { 
						Label = desc,
						Keyboard = Keyboard.Url
					}.BindTo(EntryCell.TextProperty, property.Name));
				} else if (type == typeof(MailAddress)) {
					section.Add(new EntryCell { 
						Label = desc,
						Keyboard = Keyboard.Email
					}.BindTo(EntryCell.TextProperty, property.Name));
				} else if (type == typeof(bool)) {
					section.Add(new SwitchCell { 
						Text = desc
					}.BindTo(SwitchCell.OnProperty, property.Name));
				} else if (type == typeof(Uri)) {
					section.Add(new EntryCell { 
						Label = desc
					}.BindTo(EntryCell.TextProperty, property.Name));
				}
			}

			Content = (Table = new SettingsTableView {
				Root = new TableRoot { section },
			});
		}

		protected override async void OnDisappearing() {
			base.OnDisappearing();

			foreach (var o in Objects)
				await Database.Save(o);
		}
	}
}

