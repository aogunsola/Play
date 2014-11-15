using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace MoveASaurasRex
{
	partial class CreateListViewController : UIViewController
	{
		public CreateListViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			CancelButton.TouchUpInside += (sender, e) => {
				Console.WriteLine ("cancel create list clicked");
			};

			DoneButton.TouchUpInside += (sender, e) => {
				Console.WriteLine ("done create list clicked");
			};

		}
	}
}
