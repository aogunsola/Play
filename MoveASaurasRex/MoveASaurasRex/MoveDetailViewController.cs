using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace MoveASaurasRex
{
	partial class MoveDetailViewController : UITableViewController
	{
		public MoveDetailViewController (IntPtr handle) : base (handle)
		{
		}

		Move newEntry = new Move();

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			CancelButton.TouchUpInside += (sender, e) => {
				Console.WriteLine ("cancel clicked");
			};

			DoneButton.TouchUpInside += (sender, e) => {
				newEntry.name = NameText.Text;
				newEntry.date = DateText.Text;
				newEntry.street = StreetText.Text;
				newEntry.city = CityText.Text;
				newEntry.state = StateText.Text;
				newEntry.zip = ZipText.Text;
				newEntry.country = CountryText.Text;

				Console.WriteLine (newEntry.name + " " + newEntry.date + " " + newEntry.street);
			};
			/*
			CancelButton.Clicked += (object sender, EventArgs e) => {
				Console.WriteLine("cancel clicked");
			};

			DoneButton.Clicked += (object sender, EventArgs e) => {
				Console.WriteLine("done clicked");
			};*/
		}

	}
}
