using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace MoveASaurasRex
{
	partial class HomeViewController : UIViewController
	{
		public HomeViewController (IntPtr handle) : base (handle)
		{
		}

		[Action("UnwindToHomeViewController:")]
		public void UnwindToHomeViewController(UIStoryboardSegue segue)
		{
			Console.WriteLine ("going back to home");
		}
	}
}
